using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RouteWeaver.AppForms;
using RouteWeaver.Models;

namespace RouteWeaver.User_Control
{
    public partial class SampleUserControl : UserControl
    {
        private Routes _routes;
        public event Action<Routes, SampleUserControl> OnSampleSelected;

        public SampleUserControl(Routes routes)
        {
            InitializeComponent();
            _routes=routes;
            SetSampleCard();
        }
        private void SetSampleCard()
        {
            Route_Label.Text = _routes.route_title;
            PointAmount_Label.Text = $"{_routes.points_amount} места";

   
            var names = _routes.RoutePoint.OrderBy(p => p.route_point_id).Select(p => p.Attraction.name);

            Points_Label.Text = string.Join(" • ", names);
        }

        private void Add_PictureBox_Click(object sender, EventArgs e)
        {
            //Add_PictureBox.Visible = false;  
            OnSampleSelected?.Invoke(_routes, this);

        }
    }
}
