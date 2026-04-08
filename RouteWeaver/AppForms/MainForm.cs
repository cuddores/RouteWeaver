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
using System.Net.Mail;

namespace RouteWeaver.AppForms
{
    public partial class MainForm : Form
    {
        private Users _user;
        public MainForm()
        {
            InitializeComponent();
        }

        public void SetCurrentUser(Users user)
        {
            _user = user;

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
            if (_user != null)
            {
                Nickname_Label.Text = _user.login;   // или user_name, если хочешь ФИО
            }
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
            if (_user == null)
            {
                RegistrationForm registration = new RegistrationForm();
                registration.Owner = this;
                this.Hide(); //Скрываем MainForm, но не завершаем приложение
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
                
                sorting = Program.context.Attraction.OrderBy(p => p.Cities.Country.country_name).ToList();
            }
            else
            {
                sorting = Program.context.Attraction.Where(p => p.name.ToLower().Contains(search.ToLower()))  // 1. Фильтр по имени
               .OrderBy(p => p.Cities.Country.country_name).ToList();             // 2. Сортировка по стране
            }
        }

        private void Nickname_Label_Click(object sender, EventArgs e)
        {
            ProfileForm profile = new ProfileForm(_user);
            profile.Show();
        }
    }
}
