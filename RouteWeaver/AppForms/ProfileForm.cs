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
using System.Windows.Forms.DataVisualization.Charting;

namespace RouteWeaver.AppForms
{
    public partial class ProfileForm : Form
    {
        private Users _user;
        public ProfileForm(Users users)
        {
            InitializeComponent();
            _user = users;
        }        

        private void Back_PictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void SetProfile()
        {
            ProfileFIO_TextBox.Text = _user.user_name;
            ProfileEmail_TextBox.Text = _user.email;
            ProfilePassword_TextBox.Text = _user.password;
            ProfileEmail_Label.Text = _user.email;  

        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            SetProfile();

            if (_user.user_id == 9)
            {
                Settings_PictureBox.Visible = true;
            }
            else
            {
                Settings_PictureBox.Visible = false;
            }
        }


    }
}
