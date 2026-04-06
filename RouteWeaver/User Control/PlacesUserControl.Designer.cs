namespace RouteWeaver.User_Control
{
    partial class PlacesUserControl
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
            this.Add_PictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Raiting_Label = new System.Windows.Forms.Label();
            this.Star_Picture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.TypeAttract_Label = new System.Windows.Forms.Label();
            this.CountryCity_Label = new System.Windows.Forms.Label();
            this.Attract_Label = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Add_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Star_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel1.BorderRadius = 20;
            this.guna2CustomGradientPanel1.BorderThickness = 1;
            this.guna2CustomGradientPanel1.Controls.Add(this.Add_PictureBox);
            this.guna2CustomGradientPanel1.Controls.Add(this.Raiting_Label);
            this.guna2CustomGradientPanel1.Controls.Add(this.Star_Picture);
            this.guna2CustomGradientPanel1.Controls.Add(this.TypeAttract_Label);
            this.guna2CustomGradientPanel1.Controls.Add(this.CountryCity_Label);
            this.guna2CustomGradientPanel1.Controls.Add(this.Attract_Label);
            this.guna2CustomGradientPanel1.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(332, 115);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // Add_PictureBox
            // 
            this.Add_PictureBox.Image = global::RouteWeaver.Properties.Resources.Add;
            this.Add_PictureBox.ImageRotate = 0F;
            this.Add_PictureBox.Location = new System.Drawing.Point(276, 41);
            this.Add_PictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.Add_PictureBox.Name = "Add_PictureBox";
            this.Add_PictureBox.Size = new System.Drawing.Size(33, 32);
            this.Add_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Add_PictureBox.TabIndex = 5;
            this.Add_PictureBox.TabStop = false;
            this.Add_PictureBox.Click += new System.EventHandler(this.Add_PictureBox_Click);
            // 
            // Raiting_Label
            // 
            this.Raiting_Label.AutoSize = true;
            this.Raiting_Label.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Raiting_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(177)))), ((int)(((byte)(255)))));
            this.Raiting_Label.Location = new System.Drawing.Point(38, 85);
            this.Raiting_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Raiting_Label.Name = "Raiting_Label";
            this.Raiting_Label.Size = new System.Drawing.Size(64, 19);
            this.Raiting_Label.TabIndex = 4;
            this.Raiting_Label.Text = "Рейтинг";
            // 
            // Star_Picture
            // 
            this.Star_Picture.Image = global::RouteWeaver.Properties.Resources.Star;
            this.Star_Picture.ImageRotate = 0F;
            this.Star_Picture.Location = new System.Drawing.Point(18, 87);
            this.Star_Picture.Margin = new System.Windows.Forms.Padding(2);
            this.Star_Picture.Name = "Star_Picture";
            this.Star_Picture.Size = new System.Drawing.Size(15, 16);
            this.Star_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Star_Picture.TabIndex = 3;
            this.Star_Picture.TabStop = false;
            // 
            // TypeAttract_Label
            // 
            this.TypeAttract_Label.AutoSize = true;
            this.TypeAttract_Label.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeAttract_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(177)))), ((int)(((byte)(255)))));
            this.TypeAttract_Label.Location = new System.Drawing.Point(15, 63);
            this.TypeAttract_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TypeAttract_Label.Name = "TypeAttract_Label";
            this.TypeAttract_Label.Size = new System.Drawing.Size(210, 19);
            this.TypeAttract_Label.TabIndex = 2;
            this.TypeAttract_Label.Text = "Тип достопримечательности";
            // 
            // CountryCity_Label
            // 
            this.CountryCity_Label.AutoSize = true;
            this.CountryCity_Label.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountryCity_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(177)))), ((int)(((byte)(255)))));
            this.CountryCity_Label.Location = new System.Drawing.Point(15, 38);
            this.CountryCity_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CountryCity_Label.Name = "CountryCity_Label";
            this.CountryCity_Label.Size = new System.Drawing.Size(114, 19);
            this.CountryCity_Label.TabIndex = 1;
            this.CountryCity_Label.Text = "Страна | Город";
            // 
            // Attract_Label
            // 
            this.Attract_Label.AutoSize = true;
            this.Attract_Label.Font = new System.Drawing.Font("Comfortaa", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Attract_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.Attract_Label.Location = new System.Drawing.Point(14, 11);
            this.Attract_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Attract_Label.Name = "Attract_Label";
            this.Attract_Label.Size = new System.Drawing.Size(216, 23);
            this.Attract_Label.TabIndex = 0;
            this.Attract_Label.Text = "Достопримечательность";
            // 
            // PlacesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PlacesUserControl";
            this.Size = new System.Drawing.Size(332, 115);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Add_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Star_Picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label CountryCity_Label;
        private System.Windows.Forms.Label Attract_Label;
        private System.Windows.Forms.Label TypeAttract_Label;
        private Guna.UI2.WinForms.Guna2PictureBox Star_Picture;
        private System.Windows.Forms.Label Raiting_Label;
        private Guna.UI2.WinForms.Guna2PictureBox Add_PictureBox;
    }
}
