using Guna.UI2.WinForms;
using RouteWeaver.AppForms;
using RouteWeaver.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RouteWeaver.User_Control
{
    public partial class PlacesUserControl : UserControl
    {
        internal Attraction _attraction;

        public event Action<PlacesUserControl> OnDeleteFromRoute;
        public event Action<Attraction> OnPlaceSelected;
        public event Action<PlacesUserControl> OnAddToRoute;
        public Guna2PictureBox DeleteButton => Delete_PictureBox;
        public Guna.UI2.WinForms.Guna2PictureBox AddButton => Add_PictureBox;



        public PlacesUserControl(Attraction attraction)
        {
            InitializeComponent();
            Delete_PictureBox.Visible = false;
            Delete_PictureBox.Click += Delete_PictureBox_Click;
            _attraction = attraction;
            SetAttractCard();
        }

        private void Delete_PictureBox_Click(object sender, EventArgs e)
        {
            OnDeleteFromRoute?.Invoke(this);
        }

        private void SetAttractCard()
        {
            Attract_Label.Text = $"{_attraction.name}";
            CountryCity_Label.Text = $"{_attraction.Cities.Country.country_name} • {_attraction.Cities.city_name}";
            TypeAttract_Label.Text = $"{_attraction.AttractionType.type_name}";
            Raiting_Label.Text = $"{_attraction.attraction_rating}";

        }

        private void Add_PictureBox_Click(object sender, EventArgs e)
        {
            OnPlaceSelected?.Invoke(_attraction);     // карта
            OnAddToRoute?.Invoke(this);               // маршрут
        }
    }
}
