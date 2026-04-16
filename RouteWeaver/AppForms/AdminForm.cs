using RouteWeaver.AppForms;
using RouteWeaver.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RouteWeaver.AppForms
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            AdminLatitude_TextBox.TextChanged += PreviewMap;
            AdminLongtitude_TextBox.TextChanged += PreviewMap;
        }


        private void PreviewMap(object sender, EventArgs e)
        {
            string latText = AdminLatitude_TextBox.Text.Trim();
            string lngText = AdminLongtitude_TextBox.Text.Trim();

            // Если пусто — ничего не делаем
            if (string.IsNullOrWhiteSpace(latText) || string.IsNullOrWhiteSpace(lngText))
                return;

            // Если строка заканчивается точкой — ждём, пока пользователь допишет
            if (latText.EndsWith(".") || lngText.EndsWith("."))
                return;

            // Если строка НЕ число — тоже выходим
            if (!double.TryParse(latText.Replace('.', ','), out double lat))
                return;

            if (!double.TryParse(lngText.Replace('.', ','), out double lng))
                return;

            // Теперь можно ставить маркер
            gMapControl1.Overlays.Clear();
            var overlay = new GMap.NET.WindowsForms.GMapOverlay("preview");

            var marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                new GMap.NET.PointLatLng(lat, lng),
                GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red_dot);

            overlay.Markers.Add(marker);
            gMapControl1.Overlays.Add(overlay);

            gMapControl1.Position = new GMap.NET.PointLatLng(lat, lng);
            gMapControl1.Zoom = 14;
        }



        private void Back_PictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "routeWeaverDataSet.AttractionType". При необходимости она может быть перемещена или удалена.
            this.attractionTypeTableAdapter.Fill(this.routeWeaverDataSet.AttractionType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "routeWeaverDataSet.Cities". При необходимости она может быть перемещена или удалена.
            this.citiesTableAdapter.Fill(this.routeWeaverDataSet.Cities);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "routeWeaverDataSet.Country". При необходимости она может быть перемещена или удалена.
            this.countryTableAdapter.Fill(this.routeWeaverDataSet.Country);

            InitMap();

        }
        private void InitMap()
        {
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;

            gMapControl1.MinZoom = 2;
            gMapControl1.MaxZoom = 18;
            gMapControl1.Zoom = 12;

            // Центр карты — Париж (пример)
            gMapControl1.Position = new GMap.NET.PointLatLng(48.8566, 2.3522);

            gMapControl1.ShowCenter = false;
        }
        private void AddAttract_Btn_Click(object sender, EventArgs e)
        {
            if (!Validate())
                return;

            try
            {
                    // 1. Читаем данные
                string name = AdminAttract_TextBox.Text.Trim();
                int cityId = (int)AdminCity_ComboBox.SelectedValue;
                int typeId = (int)AdminType_ComboBox.SelectedValue;
                double rating = (double)guna2NumericUpDown1.Value;
                string address = AdminAddres_TextBox.Text.Trim();
                int countryId = (int)AdminCountry_ComboBox.SelectedValue;

                // Ищем город в БД и проверяем, что он относится к выбранной стране
                var city = Program.context.Cities.FirstOrDefault(c => c.city_id == cityId);

                if (city == null || city.country_id != countryId)
                {
                    MessageBox.Show("Выбранный город не относится к выбранной стране.",
                        "Ошибка выбора", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Читаем координаты (и заменяем запятую на точку)
                string lat = AdminLatitude_TextBox.Text.Trim().Replace(',', '.');
                string lng = AdminLongtitude_TextBox.Text.Trim().Replace(',', '.');

                // Формируем строку для БД
                string location = $"{lat}/{lng}";

                // 5. Создаём объект (Latitude/Longitude НЕ трогаем!)
                Attraction newAttraction = new Attraction
                {
                    name = name,
                    city_id = cityId,
                    type_id = typeId,
                    attraction_rating = rating,
                    address = address,
                    location = location
                };

                // 6. Сохраняем
                Program.context.Attraction.Add(newAttraction);
                Program.context.SaveChanges();
                this.Close();


                MessageBox.Show("Достопримечательность успешно добавлена!",
                    "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearAdminFields();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var eve in ex.EntityValidationErrors)
                {
                    foreach (var ve in eve.ValidationErrors)
                    {
                        MessageBox.Show($"{ve.PropertyName}: {ve.ErrorMessage}");
                    }
                }
            }
        }

        private void ClearAdminFields()
        {
            AdminAttract_TextBox.Clear();
            AdminLatitude_TextBox.Clear();
            AdminLongtitude_TextBox.Clear();
            guna2NumericUpDown1.Value = 0;
            AdminAddres_TextBox.Clear();
            AdminCountry_ComboBox.SelectedIndex = 0;
            AdminCity_ComboBox.SelectedIndex = 0;
            AdminType_ComboBox.SelectedIndex = 0;
        }
        
        private bool AttractNameValidation()
        {
            string text = AdminAttract_TextBox.Text.Trim();
            string pattern = @"^[a-zA-Zа-яА-Я0-9 ]+$";

            if (Regex.IsMatch(text, pattern))
                return true;

            MessageBox.Show("Название может содержать только буквы и цифры.",
                "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            return false;
        }

        private bool Validation()
        {
            if (AttractNameValidation()) return true;
            else return false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ClearAdminFields();
        }

    }
    
}

