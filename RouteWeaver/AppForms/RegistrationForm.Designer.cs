using Guna.UI2.WinForms;
using System.Drawing;

namespace RouteWeaver.AppForms
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RegistrAppName_Label = new System.Windows.Forms.Label();
            this.Hello_Label = new System.Windows.Forms.Label();
            this.Login_TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Password_TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Login_Label = new System.Windows.Forms.Label();
            this.Password_Label = new System.Windows.Forms.Label();
            this.Enter_Btn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.RegistrationIcon_PictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.SignUp_Btn = new Guna.UI2.WinForms.Guna2Button();
            this.Registration_Btn = new Guna.UI2.WinForms.Guna2Button();
            this.FIO_Label = new System.Windows.Forms.Label();
            this.FIO_TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegistrationIcon_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RegistrAppName_Label
            // 
            this.RegistrAppName_Label.AutoSize = true;
            this.RegistrAppName_Label.BackColor = System.Drawing.Color.Transparent;
            this.RegistrAppName_Label.Font = new System.Drawing.Font("Comfortaa", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrAppName_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.RegistrAppName_Label.Location = new System.Drawing.Point(856, 132);
            this.RegistrAppName_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RegistrAppName_Label.Name = "RegistrAppName_Label";
            this.RegistrAppName_Label.Size = new System.Drawing.Size(207, 44);
            this.RegistrAppName_Label.TabIndex = 5;
            this.RegistrAppName_Label.Text = "Route Weaver";
            // 
            // Hello_Label
            // 
            this.Hello_Label.AutoSize = true;
            this.Hello_Label.BackColor = System.Drawing.Color.Transparent;
            this.Hello_Label.Font = new System.Drawing.Font("Comfortaa", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Hello_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(150)))), ((int)(((byte)(240)))));
            this.Hello_Label.Location = new System.Drawing.Point(827, 168);
            this.Hello_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Hello_Label.Name = "Hello_Label";
            this.Hello_Label.Size = new System.Drawing.Size(265, 30);
            this.Hello_Label.TabIndex = 6;
            this.Hello_Label.Text = "Рады видеть Вас снова";
            // 
            // Login_TextBox
            // 
            this.Login_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.Login_TextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.Login_TextBox.BorderRadius = 15;
            this.Login_TextBox.BorderThickness = 2;
            this.Login_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Login_TextBox.DefaultText = "";
            this.Login_TextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Login_TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Login_TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Login_TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Login_TextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Login_TextBox.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.Login_TextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Login_TextBox.Location = new System.Drawing.Point(773, 396);
            this.Login_TextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Login_TextBox.Name = "Login_TextBox";
            this.Login_TextBox.PlaceholderText = "";
            this.Login_TextBox.SelectedText = "";
            this.Login_TextBox.Size = new System.Drawing.Size(372, 62);
            this.Login_TextBox.TabIndex = 8;
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.Password_TextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.Password_TextBox.BorderRadius = 15;
            this.Password_TextBox.BorderThickness = 2;
            this.Password_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password_TextBox.DefaultText = "";
            this.Password_TextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Password_TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Password_TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password_TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password_TextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password_TextBox.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.Password_TextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password_TextBox.Location = new System.Drawing.Point(773, 505);
            this.Password_TextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.PlaceholderText = "";
            this.Password_TextBox.SelectedText = "";
            this.Password_TextBox.Size = new System.Drawing.Size(372, 62);
            this.Password_TextBox.TabIndex = 9;
            // 
            // Login_Label
            // 
            this.Login_Label.AutoSize = true;
            this.Login_Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.Login_Label.Font = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.Login_Label.Location = new System.Drawing.Point(773, 364);
            this.Login_Label.Name = "Login_Label";
            this.Login_Label.Size = new System.Drawing.Size(70, 30);
            this.Login_Label.TabIndex = 10;
            this.Login_Label.Text = "Login";
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.Password_Label.Font = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.Password_Label.Location = new System.Drawing.Point(773, 473);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(106, 30);
            this.Password_Label.TabIndex = 11;
            this.Password_Label.Text = "Password";
            // 
            // Enter_Btn
            // 
            this.Enter_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.Enter_Btn.BorderRadius = 12;
            this.Enter_Btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Enter_Btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Enter_Btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Enter_Btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Enter_Btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.Enter_Btn.Font = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Enter_Btn.ForeColor = System.Drawing.Color.White;
            this.Enter_Btn.Location = new System.Drawing.Point(817, 729);
            this.Enter_Btn.Name = "Enter_Btn";
            this.Enter_Btn.Size = new System.Drawing.Size(284, 54);
            this.Enter_Btn.TabIndex = 15;
            this.Enter_Btn.Text = "Войти";
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.Image = global::RouteWeaver.Properties.Resources.Regist_back;
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(773, 262);
            this.guna2PictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(372, 62);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox3.TabIndex = 13;
            this.guna2PictureBox3.TabStop = false;
            this.guna2PictureBox3.UseTransparentBackground = true;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = global::RouteWeaver.Properties.Resources.Registration_back;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(729, 221);
            this.guna2PictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(460, 697);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 7;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // RegistrationIcon_PictureBox
            // 
            this.RegistrationIcon_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.RegistrationIcon_PictureBox.FillColor = System.Drawing.Color.Transparent;
            this.RegistrationIcon_PictureBox.Image = global::RouteWeaver.Properties.Resources.TripIcon;
            this.RegistrationIcon_PictureBox.ImageRotate = 0F;
            this.RegistrationIcon_PictureBox.Location = new System.Drawing.Point(925, 57);
            this.RegistrationIcon_PictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.RegistrationIcon_PictureBox.Name = "RegistrationIcon_PictureBox";
            this.RegistrationIcon_PictureBox.Size = new System.Drawing.Size(68, 72);
            this.RegistrationIcon_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RegistrationIcon_PictureBox.TabIndex = 1;
            this.RegistrationIcon_PictureBox.TabStop = false;
            this.RegistrationIcon_PictureBox.UseTransparentBackground = true;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::RouteWeaver.Properties.Resources.Vector;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(12, 26);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(1781, 980);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // SignUp_Btn
            // 
            this.SignUp_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(223)))), ((int)(((byte)(252)))));
            this.SignUp_Btn.BorderRadius = 15;
            this.SignUp_Btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SignUp_Btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SignUp_Btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SignUp_Btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SignUp_Btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.SignUp_Btn.Font = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignUp_Btn.ForeColor = System.Drawing.Color.White;
            this.SignUp_Btn.Location = new System.Drawing.Point(778, 269);
            this.SignUp_Btn.Name = "SignUp_Btn";
            this.SignUp_Btn.Size = new System.Drawing.Size(176, 48);
            this.SignUp_Btn.TabIndex = 14;
            this.SignUp_Btn.Text = "Вход";
            this.SignUp_Btn.Click += new System.EventHandler(this.SignUp_Btn_Click);
            // 
            // Registration_Btn
            // 
            this.Registration_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(223)))), ((int)(((byte)(252)))));
            this.Registration_Btn.BorderRadius = 15;
            this.Registration_Btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Registration_Btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Registration_Btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Registration_Btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Registration_Btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.Registration_Btn.Font = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Registration_Btn.ForeColor = System.Drawing.Color.White;
            this.Registration_Btn.Location = new System.Drawing.Point(963, 269);
            this.Registration_Btn.Name = "Registration_Btn";
            this.Registration_Btn.Size = new System.Drawing.Size(176, 48);
            this.Registration_Btn.TabIndex = 15;
            this.Registration_Btn.Text = "Регистрация";
            this.Registration_Btn.Click += new System.EventHandler(this.Registration_Btn_Click);
            // 
            // FIO_Label
            // 
            this.FIO_Label.AutoSize = true;
            this.FIO_Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.FIO_Label.Font = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIO_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.FIO_Label.Location = new System.Drawing.Point(773, 582);
            this.FIO_Label.Name = "FIO_Label";
            this.FIO_Label.Size = new System.Drawing.Size(155, 30);
            this.FIO_Label.TabIndex = 17;
            this.FIO_Label.Text = "Имя Фамилия";
            // 
            // FIO_TextBox
            // 
            this.FIO_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.FIO_TextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.FIO_TextBox.BorderRadius = 15;
            this.FIO_TextBox.BorderThickness = 2;
            this.FIO_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FIO_TextBox.DefaultText = "";
            this.FIO_TextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FIO_TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FIO_TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FIO_TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FIO_TextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FIO_TextBox.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIO_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.FIO_TextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FIO_TextBox.Location = new System.Drawing.Point(773, 614);
            this.FIO_TextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.FIO_TextBox.Name = "FIO_TextBox";
            this.FIO_TextBox.PlaceholderText = "";
            this.FIO_TextBox.SelectedText = "";
            this.FIO_TextBox.Size = new System.Drawing.Size(372, 62);
            this.FIO_TextBox.TabIndex = 16;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1850, 1033);
            this.Controls.Add(this.FIO_Label);
            this.Controls.Add(this.FIO_TextBox);
            this.Controls.Add(this.Registration_Btn);
            this.Controls.Add(this.SignUp_Btn);
            this.Controls.Add(this.guna2PictureBox3);
            this.Controls.Add(this.Enter_Btn);
            this.Controls.Add(this.Password_Label);
            this.Controls.Add(this.Login_Label);
            this.Controls.Add(this.RegistrAppName_Label);
            this.Controls.Add(this.Password_TextBox);
            this.Controls.Add(this.Login_TextBox);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.RegistrationIcon_PictureBox);
            this.Controls.Add(this.Hello_Label);
            this.Controls.Add(this.guna2PictureBox1);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistrationForm_FormClosing);
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegistrationIcon_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox RegistrationIcon_PictureBox;
        private System.Windows.Forms.Label RegistrAppName_Label;
        private System.Windows.Forms.Label Hello_Label;
        private Guna2PictureBox guna2PictureBox2;
        private Guna2TextBox Login_TextBox;
        private Guna2TextBox Password_TextBox;
        private System.Windows.Forms.Label Login_Label;
        private System.Windows.Forms.Label Password_Label;
        private Guna2Button Enter_Btn;
        private Guna2PictureBox guna2PictureBox3;
        private Guna2Button SignUp_Btn;
        private Guna2Button Registration_Btn;
        private System.Windows.Forms.Label FIO_Label;
        private Guna2TextBox FIO_TextBox;
    }
}