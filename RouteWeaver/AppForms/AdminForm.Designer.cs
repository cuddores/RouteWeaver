namespace RouteWeaver.AppForms
{
    partial class AdminForm
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
            this.components = new System.ComponentModel.Container();
            this.Profile_Panel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.guna2NumericUpDown1 = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.AdminLongtitude_TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.AdminLatitude_TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.AdminCord_Label = new System.Windows.Forms.Label();
            this.AdminRating_Label = new System.Windows.Forms.Label();
            this.AdminType_ComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.attractionTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.routeWeaverDataSet = new RouteWeaver.RouteWeaverDataSet();
            this.AdminType_Label = new System.Windows.Forms.Label();
            this.AdminCity_ComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.citiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AdminCity_Label = new System.Windows.Forms.Label();
            this.AdminCountry_ComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AdminCountry_Label = new System.Windows.Forms.Label();
            this.AdminAttract_TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.AdminName_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.Back_PictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.countryTableAdapter = new RouteWeaver.RouteWeaverDataSetTableAdapters.CountryTableAdapter();
            this.citiesTableAdapter = new RouteWeaver.RouteWeaverDataSetTableAdapters.CitiesTableAdapter();
            this.attractionTypeTableAdapter = new RouteWeaver.RouteWeaverDataSetTableAdapters.AttractionTypeTableAdapter();
            this.Profile_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attractionTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeWeaverDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Profile_Panel
            // 
            this.Profile_Panel.BorderRadius = 20;
            this.Profile_Panel.Controls.Add(this.gMapControl1);
            this.Profile_Panel.Controls.Add(this.guna2NumericUpDown1);
            this.Profile_Panel.Controls.Add(this.label2);
            this.Profile_Panel.Controls.Add(this.AdminLongtitude_TextBox);
            this.Profile_Panel.Controls.Add(this.AdminLatitude_TextBox);
            this.Profile_Panel.Controls.Add(this.AdminCord_Label);
            this.Profile_Panel.Controls.Add(this.AdminRating_Label);
            this.Profile_Panel.Controls.Add(this.AdminType_ComboBox);
            this.Profile_Panel.Controls.Add(this.AdminType_Label);
            this.Profile_Panel.Controls.Add(this.AdminCity_ComboBox);
            this.Profile_Panel.Controls.Add(this.AdminCity_Label);
            this.Profile_Panel.Controls.Add(this.AdminCountry_ComboBox);
            this.Profile_Panel.Controls.Add(this.AdminCountry_Label);
            this.Profile_Panel.Controls.Add(this.AdminAttract_TextBox);
            this.Profile_Panel.Controls.Add(this.AdminName_Label);
            this.Profile_Panel.Controls.Add(this.label1);
            this.Profile_Panel.Controls.Add(this.guna2Separator1);
            this.Profile_Panel.Controls.Add(this.Back_PictureBox);
            this.Profile_Panel.CustomizableEdges.BottomLeft = false;
            this.Profile_Panel.CustomizableEdges.BottomRight = false;
            this.Profile_Panel.Location = new System.Drawing.Point(265, 151);
            this.Profile_Panel.Name = "Profile_Panel";
            this.Profile_Panel.Size = new System.Drawing.Size(1321, 830);
            this.Profile_Panel.TabIndex = 3;
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(639, 187);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(623, 522);
            this.gMapControl1.TabIndex = 32;
            this.gMapControl1.Zoom = 0D;
            // 
            // guna2NumericUpDown1
            // 
            this.guna2NumericUpDown1.BackColor = System.Drawing.Color.Transparent;
            this.guna2NumericUpDown1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.guna2NumericUpDown1.BorderRadius = 8;
            this.guna2NumericUpDown1.BorderThickness = 2;
            this.guna2NumericUpDown1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2NumericUpDown1.DecimalPlaces = 1;
            this.guna2NumericUpDown1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.guna2NumericUpDown1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2NumericUpDown1.Location = new System.Drawing.Point(38, 571);
            this.guna2NumericUpDown1.Name = "guna2NumericUpDown1";
            this.guna2NumericUpDown1.Size = new System.Drawing.Size(100, 36);
            this.guna2NumericUpDown1.TabIndex = 31;
            this.guna2NumericUpDown1.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(160)))), ((int)(((byte)(211)))));
            this.label2.Location = new System.Drawing.Point(149, 574);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 26);
            this.label2.TabIndex = 30;
            this.label2.Text = "От  1.0 до 5.0";
            // 
            // AdminLongtitude_TextBox
            // 
            this.AdminLongtitude_TextBox.BackColor = System.Drawing.Color.White;
            this.AdminLongtitude_TextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.AdminLongtitude_TextBox.BorderRadius = 15;
            this.AdminLongtitude_TextBox.BorderThickness = 2;
            this.AdminLongtitude_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AdminLongtitude_TextBox.DefaultText = "";
            this.AdminLongtitude_TextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AdminLongtitude_TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AdminLongtitude_TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AdminLongtitude_TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AdminLongtitude_TextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.AdminLongtitude_TextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AdminLongtitude_TextBox.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminLongtitude_TextBox.ForeColor = System.Drawing.Color.Black;
            this.AdminLongtitude_TextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AdminLongtitude_TextBox.Location = new System.Drawing.Point(332, 663);
            this.AdminLongtitude_TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AdminLongtitude_TextBox.Name = "AdminLongtitude_TextBox";
            this.AdminLongtitude_TextBox.PlaceholderText = "Долгота(lng)";
            this.AdminLongtitude_TextBox.SelectedText = "";
            this.AdminLongtitude_TextBox.Size = new System.Drawing.Size(272, 46);
            this.AdminLongtitude_TextBox.TabIndex = 29;
            // 
            // AdminLatitude_TextBox
            // 
            this.AdminLatitude_TextBox.BackColor = System.Drawing.Color.White;
            this.AdminLatitude_TextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.AdminLatitude_TextBox.BorderRadius = 15;
            this.AdminLatitude_TextBox.BorderThickness = 2;
            this.AdminLatitude_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AdminLatitude_TextBox.DefaultText = "";
            this.AdminLatitude_TextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AdminLatitude_TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AdminLatitude_TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AdminLatitude_TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AdminLatitude_TextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.AdminLatitude_TextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AdminLatitude_TextBox.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminLatitude_TextBox.ForeColor = System.Drawing.Color.Black;
            this.AdminLatitude_TextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AdminLatitude_TextBox.Location = new System.Drawing.Point(38, 663);
            this.AdminLatitude_TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AdminLatitude_TextBox.Name = "AdminLatitude_TextBox";
            this.AdminLatitude_TextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.AdminLatitude_TextBox.PlaceholderText = "Широта(lat)";
            this.AdminLatitude_TextBox.SelectedText = "";
            this.AdminLatitude_TextBox.Size = new System.Drawing.Size(272, 46);
            this.AdminLatitude_TextBox.TabIndex = 28;
            // 
            // AdminCord_Label
            // 
            this.AdminCord_Label.BackColor = System.Drawing.Color.White;
            this.AdminCord_Label.Font = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminCord_Label.Location = new System.Drawing.Point(35, 628);
            this.AdminCord_Label.Name = "AdminCord_Label";
            this.AdminCord_Label.Size = new System.Drawing.Size(165, 31);
            this.AdminCord_Label.TabIndex = 27;
            this.AdminCord_Label.Text = "Координаты";
            this.AdminCord_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AdminRating_Label
            // 
            this.AdminRating_Label.BackColor = System.Drawing.Color.White;
            this.AdminRating_Label.Font = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminRating_Label.Location = new System.Drawing.Point(35, 536);
            this.AdminRating_Label.Name = "AdminRating_Label";
            this.AdminRating_Label.Size = new System.Drawing.Size(113, 31);
            this.AdminRating_Label.TabIndex = 25;
            this.AdminRating_Label.Text = "Рейтинг";
            this.AdminRating_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AdminType_ComboBox
            // 
            this.AdminType_ComboBox.BackColor = System.Drawing.Color.Transparent;
            this.AdminType_ComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.AdminType_ComboBox.BorderRadius = 10;
            this.AdminType_ComboBox.BorderThickness = 2;
            this.AdminType_ComboBox.DataSource = this.attractionTypeBindingSource;
            this.AdminType_ComboBox.DisplayMember = "type_name";
            this.AdminType_ComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.AdminType_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AdminType_ComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.AdminType_ComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AdminType_ComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AdminType_ComboBox.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminType_ComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.AdminType_ComboBox.ItemHeight = 30;
            this.AdminType_ComboBox.Location = new System.Drawing.Point(38, 480);
            this.AdminType_ComboBox.Name = "AdminType_ComboBox";
            this.AdminType_ComboBox.Size = new System.Drawing.Size(398, 36);
            this.AdminType_ComboBox.TabIndex = 24;
            this.AdminType_ComboBox.ValueMember = "type_id";
            // 
            // attractionTypeBindingSource
            // 
            this.attractionTypeBindingSource.DataMember = "AttractionType";
            this.attractionTypeBindingSource.DataSource = this.routeWeaverDataSet;
            // 
            // routeWeaverDataSet
            // 
            this.routeWeaverDataSet.DataSetName = "RouteWeaverDataSet";
            this.routeWeaverDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AdminType_Label
            // 
            this.AdminType_Label.BackColor = System.Drawing.Color.White;
            this.AdminType_Label.Font = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminType_Label.Location = new System.Drawing.Point(35, 446);
            this.AdminType_Label.Name = "AdminType_Label";
            this.AdminType_Label.Size = new System.Drawing.Size(61, 31);
            this.AdminType_Label.TabIndex = 23;
            this.AdminType_Label.Text = "Тип";
            this.AdminType_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AdminCity_ComboBox
            // 
            this.AdminCity_ComboBox.BackColor = System.Drawing.Color.Transparent;
            this.AdminCity_ComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.AdminCity_ComboBox.BorderRadius = 10;
            this.AdminCity_ComboBox.BorderThickness = 2;
            this.AdminCity_ComboBox.DataSource = this.citiesBindingSource;
            this.AdminCity_ComboBox.DisplayMember = "city_name";
            this.AdminCity_ComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.AdminCity_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AdminCity_ComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.AdminCity_ComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AdminCity_ComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AdminCity_ComboBox.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.AdminCity_ComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.AdminCity_ComboBox.ItemHeight = 30;
            this.AdminCity_ComboBox.Location = new System.Drawing.Point(38, 389);
            this.AdminCity_ComboBox.Name = "AdminCity_ComboBox";
            this.AdminCity_ComboBox.Size = new System.Drawing.Size(398, 36);
            this.AdminCity_ComboBox.TabIndex = 22;
            this.AdminCity_ComboBox.ValueMember = "city_id";
            // 
            // citiesBindingSource
            // 
            this.citiesBindingSource.DataMember = "Cities";
            this.citiesBindingSource.DataSource = this.routeWeaverDataSet;
            // 
            // AdminCity_Label
            // 
            this.AdminCity_Label.BackColor = System.Drawing.Color.White;
            this.AdminCity_Label.Font = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminCity_Label.Location = new System.Drawing.Point(35, 349);
            this.AdminCity_Label.Name = "AdminCity_Label";
            this.AdminCity_Label.Size = new System.Drawing.Size(87, 31);
            this.AdminCity_Label.TabIndex = 21;
            this.AdminCity_Label.Text = "Город";
            this.AdminCity_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AdminCountry_ComboBox
            // 
            this.AdminCountry_ComboBox.BackColor = System.Drawing.Color.Transparent;
            this.AdminCountry_ComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.AdminCountry_ComboBox.BorderRadius = 10;
            this.AdminCountry_ComboBox.BorderThickness = 2;
            this.AdminCountry_ComboBox.DataSource = this.countryBindingSource;
            this.AdminCountry_ComboBox.DisplayMember = "country_name";
            this.AdminCountry_ComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.AdminCountry_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AdminCountry_ComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.AdminCountry_ComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AdminCountry_ComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AdminCountry_ComboBox.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.AdminCountry_ComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.AdminCountry_ComboBox.ItemHeight = 30;
            this.AdminCountry_ComboBox.Location = new System.Drawing.Point(38, 293);
            this.AdminCountry_ComboBox.Name = "AdminCountry_ComboBox";
            this.AdminCountry_ComboBox.Size = new System.Drawing.Size(398, 36);
            this.AdminCountry_ComboBox.TabIndex = 20;
            this.AdminCountry_ComboBox.ValueMember = "country_id";
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataMember = "Country";
            this.countryBindingSource.DataSource = this.routeWeaverDataSet;
            // 
            // AdminCountry_Label
            // 
            this.AdminCountry_Label.BackColor = System.Drawing.Color.White;
            this.AdminCountry_Label.Font = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminCountry_Label.Location = new System.Drawing.Point(35, 253);
            this.AdminCountry_Label.Name = "AdminCountry_Label";
            this.AdminCountry_Label.Size = new System.Drawing.Size(100, 31);
            this.AdminCountry_Label.TabIndex = 19;
            this.AdminCountry_Label.Text = "Страна";
            this.AdminCountry_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AdminAttract_TextBox
            // 
            this.AdminAttract_TextBox.BackColor = System.Drawing.Color.White;
            this.AdminAttract_TextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.AdminAttract_TextBox.BorderRadius = 15;
            this.AdminAttract_TextBox.BorderThickness = 2;
            this.AdminAttract_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AdminAttract_TextBox.DefaultText = "";
            this.AdminAttract_TextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AdminAttract_TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AdminAttract_TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AdminAttract_TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AdminAttract_TextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.AdminAttract_TextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AdminAttract_TextBox.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminAttract_TextBox.ForeColor = System.Drawing.Color.Black;
            this.AdminAttract_TextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AdminAttract_TextBox.Location = new System.Drawing.Point(38, 187);
            this.AdminAttract_TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AdminAttract_TextBox.Name = "AdminAttract_TextBox";
            this.AdminAttract_TextBox.PlaceholderText = "";
            this.AdminAttract_TextBox.SelectedText = "";
            this.AdminAttract_TextBox.Size = new System.Drawing.Size(465, 46);
            this.AdminAttract_TextBox.TabIndex = 10;
            // 
            // AdminName_Label
            // 
            this.AdminName_Label.BackColor = System.Drawing.Color.White;
            this.AdminName_Label.Font = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminName_Label.Location = new System.Drawing.Point(35, 147);
            this.AdminName_Label.Name = "AdminName_Label";
            this.AdminName_Label.Size = new System.Drawing.Size(401, 31);
            this.AdminName_Label.TabIndex = 18;
            this.AdminName_Label.Text = "Название достопримечательности";
            this.AdminName_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Comfortaa", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(527, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 60);
            this.label1.TabIndex = 16;
            this.label1.Text = "Админ панель";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(201)))), ((int)(((byte)(244)))));
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 107);
            this.guna2Separator1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1321, 8);
            this.guna2Separator1.TabIndex = 10;
            // 
            // Back_PictureBox
            // 
            this.Back_PictureBox.BackColor = System.Drawing.Color.White;
            this.Back_PictureBox.Image = global::RouteWeaver.Properties.Resources.Back;
            this.Back_PictureBox.ImageRotate = 0F;
            this.Back_PictureBox.Location = new System.Drawing.Point(22, 23);
            this.Back_PictureBox.Name = "Back_PictureBox";
            this.Back_PictureBox.Size = new System.Drawing.Size(35, 35);
            this.Back_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Back_PictureBox.TabIndex = 1;
            this.Back_PictureBox.TabStop = false;
            this.Back_PictureBox.Click += new System.EventHandler(this.Back_PictureBox_Click);
            // 
            // countryTableAdapter
            // 
            this.countryTableAdapter.ClearBeforeFill = true;
            // 
            // citiesTableAdapter
            // 
            this.citiesTableAdapter.ClearBeforeFill = true;
            // 
            // attractionTypeTableAdapter
            // 
            this.attractionTypeTableAdapter.ClearBeforeFill = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1850, 1033);
            this.Controls.Add(this.Profile_Panel);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.Profile_Panel.ResumeLayout(false);
            this.Profile_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attractionTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeWeaverDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back_PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel Profile_Panel;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2PictureBox Back_PictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AdminName_Label;
        private Guna.UI2.WinForms.Guna2TextBox AdminAttract_TextBox;
        private System.Windows.Forms.Label AdminCountry_Label;
        private System.Windows.Forms.Label AdminCity_Label;
        private Guna.UI2.WinForms.Guna2ComboBox AdminCountry_ComboBox;
        private System.Windows.Forms.Label AdminType_Label;
        private Guna.UI2.WinForms.Guna2ComboBox AdminCity_ComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox AdminType_ComboBox;
        private System.Windows.Forms.Label AdminRating_Label;
        private System.Windows.Forms.Label AdminCord_Label;
        private Guna.UI2.WinForms.Guna2TextBox AdminLongtitude_TextBox;
        private Guna.UI2.WinForms.Guna2TextBox AdminLatitude_TextBox;
        private RouteWeaverDataSet routeWeaverDataSet;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private RouteWeaverDataSetTableAdapters.CountryTableAdapter countryTableAdapter;
        private System.Windows.Forms.BindingSource citiesBindingSource;
        private RouteWeaverDataSetTableAdapters.CitiesTableAdapter citiesTableAdapter;
        private System.Windows.Forms.BindingSource attractionTypeBindingSource;
        private RouteWeaverDataSetTableAdapters.AttractionTypeTableAdapter attractionTypeTableAdapter;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2NumericUpDown guna2NumericUpDown1;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
    }
}