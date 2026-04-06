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
using RouteWeaver.User_Control;
using RouteWeaver.AppForms;

namespace RouteWeaver.AppForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void ShowAttarctions()
        {
            flowLayoutPanel.Controls.Clear();

            List<Attraction> attractions = Program.context.Attraction.OrderBy(p => p.Cities.Country.country_name).ToList();

            foreach (var attract in attractions)
            {
                var control = new PlacesUserControl(attract);
                control.OnAddToRoute += AddToMyRoute;
                flowLayoutPanel.Controls.Add(control);

            }

        }
        private void AddToMyRoute(Attraction attraction)
        {
            
            var added = new PlacesUserControl(attraction);

            added.AddButton.Visible = false;

            flowLayoutPanelTrip.Controls.Add(added);
        }


        private void ShowSamples()
        {
            flowLayoutPanel.Controls.Clear();

            List<Routes> routes = Program.context.Routes.OrderBy(p => p.points_amount).ToList();

            foreach (Routes route in routes)
            {
                flowLayoutPanel.Controls.Add(new SampleUserControl(route));
            }
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
        }

        private void HighlightTab(Label active)
        {
            Color activeColor = Color.FromArgb(87, 115, 232);     // #5773E8
            Color inactiveColor = Color.FromArgb(181, 196, 243);  // светлый

            Place_Label.ForeColor = inactiveColor;
            Sample_Label.ForeColor = inactiveColor;
            Created_Label.ForeColor = inactiveColor;

            active.ForeColor = activeColor;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            RegistrationForm registration = new RegistrationForm();
            registration.Owner = this;
            this.Hide(); // ✅ Скрываем MainForm, но не завершаем приложение
            registration.Show();
        }
    }
}
