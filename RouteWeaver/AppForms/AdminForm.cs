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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
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
    }
}
