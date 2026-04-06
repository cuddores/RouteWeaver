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
        private Attraction _attraction;
        public PlacesUserControl(Attraction attraction)
        {
            InitializeComponent();
            _attraction = attraction;
            SetAttractCard();
        }
        public Guna.UI2.WinForms.Guna2PictureBox AddButton => Add_PictureBox;

        private void SetAttractCard()
        {
            Attract_Label.Text = $"{_attraction.name}";
            CountryCity_Label.Text = $"{_attraction.Cities.Country.country_name} • {_attraction.Cities.city_name}";
            TypeAttract_Label.Text = $"{_attraction.AttractionType.type_name}";
            Raiting_Label.Text = $"{_attraction.attraction_rating}";

        }

        public event Action<Attraction> OnAddToRoute;
        private void Add_PictureBox_Click(object sender, EventArgs e)
        {
            OnAddToRoute?.Invoke(_attraction);
            Add_PictureBox.Visible = false;
        }
    }
}
