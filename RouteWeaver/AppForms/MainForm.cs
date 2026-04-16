using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using RouteWeaver.AppForms;
using RouteWeaver.Models;
using RouteWeaver.User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RouteWeaver.AppForms
{
    public partial class MainForm : Form
    {
        private Users _user;
        private string _selectedCity = null;
        

        public MainForm()
        {
            InitializeComponent();
        }

        public void SetCurrentUser(Users user)
        {
            _user = user;

            if (_user.user_id == 9)
            {
                AdminRole_Label.Text = "Админ";
            }
            else
            {
                AdminRole_Label.Text = "Пользватель";
            }
            if (Nickname_Label != null)
            {
                Nickname_Label.Text = $"@{user.login}";
                Nickname_Label.Visible = true;
            }
            else 
                Nickname_Label.Visible = false;
        }

        private void ShowAttarctions()
        {
            flowLayoutPanel.Controls.Clear();

            List<Attraction> attractions = Program.context.Attraction.OrderBy(p => p.Cities.Country.country_name).ToList();

            foreach (var attract in attractions)
            {
                var control = new PlacesUserControl(attract);
                control.OnPlaceSelected += ShowAttractionOnMap;
                control.OnPlaceSelected += UpdateGeoLabel;
                control.OnAddToRoute += AddToMyRoute;
                flowLayoutPanel.Controls.Add(control);
            }

        }
        private void UpdateGeoLabel(Attraction a)
        {
            Geo_Label.Text = a.Cities.city_name;
        }


        private void AddToMyRoute(PlacesUserControl original)
        {
            var attraction = original._attraction;
            Geo_Label.Text = attraction.Cities.city_name;


            if (_selectedCity == null)
                _selectedCity = attraction.Cities.city_name;
            else if (_selectedCity != attraction.Cities.city_name)
            {
                MessageBox.Show("Вы можете добавлять места только из одного города",
                    "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // создаём копию карточки
            var added = new PlacesUserControl(attraction);

            added.AddButton.Visible = false;
            added.Delete_PictureBox.Visible = true;

            // сохраняем ссылку на оригинал
            added.Tag = original;

            added.OnDeleteFromRoute += RemoveFromRoute;

            Location_PictureBox.Controls.Add(added);

            // скрываем плюс у оригинала
            original.AddButton.Visible = false;

            UpdateRouteLine();
            UpdateDistanceLabel();
            UpdateMapRoute();

        }

        private void UpdateRouteLine()
        {
            var points = new List<Attraction>();

            foreach (PlacesUserControl c in Location_PictureBox.Controls)
                points.Add(c._attraction);

            if (points.Count >= 2)
                ShowRouteOnMap(points);
        }


        private void RemoveFromRoute(PlacesUserControl control)
        {
            var original = control.Tag as PlacesUserControl;

            if (original != null)
                original.AddButton.Visible = true;

            Location_PictureBox.Controls.Remove(control);

            if (Location_PictureBox.Controls.Count == 0)
                _selectedCity = null;

            UpdateDistanceLabel();
            UpdateMapRoute();
        }

        private void ShowSamples()
        {
            flowLayoutPanel.Controls.Clear();

            List<Routes> routes = Program.context.Routes.OrderBy(p => p.points_amount).ToList();

            foreach (Routes route in routes)
            {
                var control = new SampleUserControl(route);
                control.OnSampleSelected += LoadRouteFromTemplate;
                flowLayoutPanel.Controls.Add(control);
            }

        }
        private void LoadRouteFromTemplate(Routes route, SampleUserControl selectedSample)
        {
            // 1. Вернуть плюсики у всех шаблонов
            foreach (Control c in flowLayoutPanel.Controls)
            {
                if (c is SampleUserControl sample)
                    sample.Add_PictureBox.Visible = true;
            }

            // 2. Скрыть плюсик у выбранного шаблона
            selectedSample.Add_PictureBox.Visible = false;

            // 3. Загрузить маршрут
            Location_PictureBox.Controls.Clear();
            _selectedCity = null;

            var points = route.RoutePoint
                .OrderBy(p => p.route_point_id)
                .Select(p => p.Attraction);

            foreach (var attraction in points)
            {
                var control = new PlacesUserControl(attraction);

                control.AddButton.Visible = false;
                control.Delete_PictureBox.Visible = true;

                control.OnDeleteFromRoute += RemoveFromRoute;
                _selectedCity = attraction.Cities.city_name;
                Geo_Label.Text = _selectedCity;


                Location_PictureBox.Controls.Add(control);

                if (_selectedCity == null)
                    _selectedCity = attraction.Cities.city_name;
            }
            ShowRouteOnMap(points.ToList());
            UpdateDistanceLabel();
            UpdateMapRoute();
        }

        private void UpdateWalkLabel(double distanceKm)
        {
            // Средняя скорость человека
            double speed = 4.0;

            if (distanceKm <= 0)
            {
                Walk_Label.Text = "0 мин";
                return;
            }

            double hours = distanceKm / speed;
            int minutes = (int)(hours * 60);

            Walk_Label.Text = $"{minutes} мин пешком";
        }
        private void UpdateRideLabel(double distanceKm)
        {
            // Средняя скорость автомобиля в городе
            double speed = 45.0; 

            if (distanceKm <= 0)
            {
                Ride_Label.Text = "0 мин";
                return;
            }

            double hours = distanceKm / speed;
            int minutes = (int)(hours * 60);

            if (minutes < 60)
                Ride_Label.Text = $"{minutes} мин езды";
            else
                Ride_Label.Text = $"{minutes / 60} ч {minutes % 60} мин езды";
        }


        private void Place_Label_Click(object sender, EventArgs e)
        {
            HighlightTab(Place_Label);
            ShowAttarctions();
        }

        private void Sample_Label_Click(object sender, EventArgs e)
        {
            HighlightTab(Sample_Label);
            ShowSamples();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            HighlightTab(Place_Label);
            ShowAttarctions();
            if (_user != null)
            {
                Nickname_Label.Text = _user.login;  
            }
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
        private void ShowAttractionOnMap(Attraction a)
        {
            gMapControl1.Overlays.Clear();

            var overlay = new GMapOverlay("markers");

            var marker = new GMarkerGoogle(
                new PointLatLng(a.Latitude, a.Longitude),
                GMarkerGoogleType.red_dot);

            overlay.Markers.Add(marker);
            gMapControl1.Overlays.Add(overlay);

            gMapControl1.Position = new PointLatLng(a.Latitude, a.Longitude);
            gMapControl1.Zoom = 14;
        }

        private void ShowRouteOnMap(List<Attraction> points)
        {
            gMapControl1.Overlays.Clear();

            var overlay = new GMapOverlay("route");
            var routePoints = new List<PointLatLng>();

            foreach (var p in points)
                routePoints.Add(new PointLatLng(p.Latitude, p.Longitude));

            var route = new GMapRoute(routePoints, "myRoute")
            {
                Stroke = new Pen(Color.FromArgb(87, 115, 232), 4)
            };

            overlay.Routes.Add(route);
            gMapControl1.Overlays.Add(overlay);

            FitMapToRoute(points);
        }
        private void FitMapToRoute(List<Attraction> points)
        {
            double minLat = points.Min(p => p.Latitude); //широта
            double maxLat = points.Max(p => p.Latitude);
            double minLng = points.Min(p => p.Longitude); //долгота
            double maxLng = points.Max(p => p.Longitude);

            var rect = RectLatLng.FromLTRB(maxLng, maxLat, minLng, minLat);
            gMapControl1.SetZoomToFitRect(rect);
        }

        private void HighlightTab(Label active)
        {
            Color activeColor = Color.FromArgb(87, 115, 232);     // #5773E8
            Color inactiveColor = Color.FromArgb(181, 196, 243);  // светлый

            Place_Label.ForeColor = inactiveColor;
            Sample_Label.ForeColor = inactiveColor;

            active.ForeColor = activeColor;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            if (_user == null)
            {
                RegistrationForm registration = new RegistrationForm();
                registration.Owner = this;
                this.Hide(); 
                registration.Show();
            }
            else
            {
                ProfileForm profile = new ProfileForm(_user);
                profile.Show();
            }
        }

        private void Search_TextBox_TextChanged(object sender, EventArgs e)
        {
            string search = Search_TextBox.Text.Trim().ToLower();

            List<Attraction> sorting;

            if (string.IsNullOrEmpty(search))
            {
                sorting = Program.context.Attraction
                    .OrderBy(p => p.Cities.Country.country_name)
                    .ToList();
            }
            else
            {
                sorting = Program.context.Attraction
                    .Where(p => p.name.ToLower().Contains(search))
                    .OrderBy(p => p.Cities.Country.country_name)
                    .ToList();
            }

            flowLayoutPanel.Controls.Clear();

            foreach (var attract in sorting)
            {
                var control = new PlacesUserControl(attract);
                control.OnPlaceSelected += ShowAttractionOnMap;   // карта
                control.OnAddToRoute += AddToMyRoute;             // маршрут
                flowLayoutPanel.Controls.Add(control);
            }
        }

        private void Nickname_Label_Click(object sender, EventArgs e)
        {
            ProfileForm profile = new ProfileForm(_user);
            profile.Show();
        }

        private double CalculateRouteDistance(List<Attraction> points)
        {
            double total = 0;

            for (int i = 0; i < points.Count - 1; i++)
            {
                double lat1 = points[i].Latitude;
                double lon1 = points[i].Longitude;

                double lat2 = points[i + 1].Latitude;
                double lon2 = points[i + 1].Longitude;

                total += HaversineDistance(lat1, lon1, lat2, lon2);
            }

            return total;
        }

        private void UpdateDistanceLabel()
        {
            var points = new List<Attraction>();

            foreach (PlacesUserControl c in Location_PictureBox.Controls)
                points.Add(c._attraction);

            if (points.Count < 2)
            {
                Length_Label.Text = "0 км";
                return;
            }

            double km = CalculateRouteDistance(points);
            Length_Label.Text = $"{km:F2} км";

            UpdateWalkLabel(km);
            UpdateRideLabel(km);
        }

        private double HaversineDistance(double lat1, double lon1, double lat2, double lon2)
        {
            // Радиус Земли в километрах.
            // Используется в формуле гаверсинусов.
            double R = 6371.0;

            // Разница широт и долгот в РАДИАНАХ.
            // (lat2 - lat1) — разница в градусах.
            // * Math.PI / 180 — перевод градусов в радианы.
            double dLat = (lat2 - lat1) * Math.PI / 180.0;
            double dLon = (lon2 - lon1) * Math.PI / 180.0;

            // Переводим исходные широты в радианы,
            // потому что косинус работает с радианами.
            lat1 = lat1 * Math.PI / 180.0;
            lat2 = lat2 * Math.PI / 180.0;

            // Основная часть формулы гаверсинусов.
            // Вычисляет "кривизну" дуги между двумя точками на сфере.
            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                       Math.Sin(dLon / 2) * Math.Sin(dLon / 2) * Math.Cos(lat1) * Math.Cos(lat2);

            // Преобразование гаверсинуса в центральный угол между точками.
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            // Итоговое расстояние: радиус Земли * угол.
            // Возвращаем расстояние в КИЛОМЕТРАХ.
            return R * c;
        }

        private void UpdateMapRoute()
        {
            var points = new List<Attraction>();

            // Собираем все точки из правой панели маршрута
            foreach (PlacesUserControl c in Location_PictureBox.Controls)
                points.Add(c._attraction);

            gMapControl1.Overlays.Clear();

            // Если точек нет — просто очищаем карту
            if (points.Count == 0)
                return;

            // Если одна точка — показываем только маркер
            if (points.Count == 1)
            {
                ShowAttractionOnMap(points[0]);
                return;
            }

            // Рисуем линию маршрута
            ShowRouteOnMap(points);
        }

        private void Export_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Собираем выбранные достопримечательности
                var selected = Location_PictureBox.Controls
                    .OfType<PlacesUserControl>()
                    .Select(c => c._attraction)
                    .ToList();

                if (selected.Count == 0)
                {
                    MessageBox.Show("Вы не выбрали ни одной достопримечательности!");
                    return;
                }

                // 2. Создаём Word
                var wordApp = new Microsoft.Office.Interop.Word.Application();
                var doc = wordApp.Documents.Add();

                // 3. Заголовок
                var paragraph = doc.Content.Paragraphs.Add();
                paragraph.Range.Text = "Выбранные достопримечательности";
                paragraph.Range.Font.Size = 14;
                paragraph.Range.Font.Name = "Comfortaa";
                paragraph.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                paragraph.Range.InsertParagraphAfter();

                // 4. Таблица
                var table = doc.Tables.Add(
                    doc.Bookmarks.get_Item("\\endofdoc").Range,
                    selected.Count + 1,
                    4
                );

                // Границы таблицы
                table.Borders.Enable = 1;

                // Шрифт таблицы
                table.Range.Font.Name = "Comfortaa";
                table.Range.Font.Size = 12;

                // Заголовки
                table.Cell(1, 1).Range.Text = "Название";
                table.Cell(1, 2).Range.Text = "Город";
                table.Cell(1, 3).Range.Text = "Адрес";
                table.Cell(1, 4).Range.Text = "Координаты";

                table.Rows[1].Range.Bold = 1;
                table.Rows[1].Shading.BackgroundPatternColor = Microsoft.Office.Interop.Word.WdColor.wdColorGray20;

                // 5. Заполняем таблицу
                int row = 2;
                foreach (var a in selected)
                {
                    table.Cell(row, 1).Range.Text = a.name;
                    table.Cell(row, 2).Range.Text = a.Cities.city_name;
                    table.Cell(row, 3).Range.Text = a.address;
                    table.Cell(row, 4).Range.Text = a.location;
                    row++;
                }

                // 6. Показываем Word
                wordApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}


//ДОБАВИТЬ ВАЛИДАЦИЮ АДМИНУ
//ДОБАВИТЬ ОБНОВЛЕНИЕ
//ДОБАВИТЬ СОРТИРОВКУ(она есть)
//ДОБАВИТЬ ДИАГРАММЫ МАРШУРА
//ОБНОВИТЬ ПРОФИЛЬ
//ДОБАВИТЬ ОТЗЫВЫ(?)
//ДОБАВИТЬ РЕДАКТИРОАНИЕ ПРОФИЛЯ/СКРЫТЬ ПАРОЛЬ
//ОТОБРАЖЕНИЕ КАРТЫ ПО ВЕРХНЕМУ ГОРОДУ