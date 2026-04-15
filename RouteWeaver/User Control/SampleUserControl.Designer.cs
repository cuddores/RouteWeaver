namespace RouteWeaver.User_Control
{
    partial class SampleUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.Points_Label = new System.Windows.Forms.Label();
            this.PointAmount_Label = new System.Windows.Forms.Label();
            this.Route_Label = new System.Windows.Forms.Label();
            this.Add_PictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Add_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel1.BorderRadius = 20;
            this.guna2CustomGradientPanel1.BorderThickness = 1;
            this.guna2CustomGradientPanel1.Controls.Add(this.Add_PictureBox);
            this.guna2CustomGradientPanel1.Controls.Add(this.Points_Label);
            this.guna2CustomGradientPanel1.Controls.Add(this.PointAmount_Label);
            this.guna2CustomGradientPanel1.Controls.Add(this.Route_Label);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(365, 115);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // Points_Label
            // 
            this.Points_Label.Font = new System.Drawing.Font("Comfortaa", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Points_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(177)))), ((int)(((byte)(255)))));
            this.Points_Label.Location = new System.Drawing.Point(11, 63);
            this.Points_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Points_Label.Name = "Points_Label";
            this.Points_Label.Size = new System.Drawing.Size(319, 47);
            this.Points_Label.TabIndex = 5;
            this.Points_Label.Text = "Точки";
            // 
            // PointAmount_Label
            // 
            this.PointAmount_Label.AutoSize = true;
            this.PointAmount_Label.Font = new System.Drawing.Font("Comfortaa", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PointAmount_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(177)))), ((int)(((byte)(255)))));
            this.PointAmount_Label.Location = new System.Drawing.Point(11, 37);
            this.PointAmount_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PointAmount_Label.Name = "PointAmount_Label";
            this.PointAmount_Label.Size = new System.Drawing.Size(154, 23);
            this.PointAmount_Label.TabIndex = 4;
            this.PointAmount_Label.Text = "Количество точек";
            // 
            // Route_Label
            // 
            this.Route_Label.AutoSize = true;
            this.Route_Label.Font = new System.Drawing.Font("Comfortaa", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Route_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.Route_Label.Location = new System.Drawing.Point(11, 12);
            this.Route_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Route_Label.Name = "Route_Label";
            this.Route_Label.Size = new System.Drawing.Size(172, 23);
            this.Route_Label.TabIndex = 3;
            this.Route_Label.Text = "Название маршрута";
            // 
            // Add_PictureBox
            // 
            this.Add_PictureBox.Image = global::RouteWeaver.Properties.Resources.Add;
            this.Add_PictureBox.ImageRotate = 0F;
            this.Add_PictureBox.Location = new System.Drawing.Point(313, 29);
            this.Add_PictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.Add_PictureBox.Name = "Add_PictureBox";
            this.Add_PictureBox.Size = new System.Drawing.Size(30, 29);
            this.Add_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Add_PictureBox.TabIndex = 6;
            this.Add_PictureBox.TabStop = false;
            this.Add_PictureBox.Click += new System.EventHandler(this.Add_PictureBox_Click);
            // 
            // SampleUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SampleUserControl";
            this.Size = new System.Drawing.Size(365, 115);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Add_PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label PointAmount_Label;
        private System.Windows.Forms.Label Route_Label;
        private System.Windows.Forms.Label Points_Label;
        public Guna.UI2.WinForms.Guna2PictureBox Add_PictureBox;
    }
}
