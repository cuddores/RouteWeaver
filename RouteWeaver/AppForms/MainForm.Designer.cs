namespace RouteWeaver.AppForms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.routeWeaverDataSet = new RouteWeaver.RouteWeaverDataSet();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Filter_PictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.PopularPlaces_Label = new System.Windows.Forms.Label();
            this.Sample_Label = new System.Windows.Forms.Label();
            this.Place_Label = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.Search_TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.FilterByRateComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.AppName_Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nickname_Label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.Location_PictureBox = new System.Windows.Forms.FlowLayoutPanel();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.AdminRole_Label = new System.Windows.Forms.Label();
            this.Length_Label = new System.Windows.Forms.Label();
            this.AppIcon_PictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.MainFilterPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.ClearFilterBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.FilterByTypeComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.attractionTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.FilterByCountryComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SortByTypeLabel = new System.Windows.Forms.Label();
            this.attractionTypeTableAdapter = new RouteWeaver.RouteWeaverDataSetTableAdapters.AttractionTypeTableAdapter();
            this.countryTableAdapter = new RouteWeaver.RouteWeaverDataSetTableAdapters.CountryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.routeWeaverDataSet)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Filter_PictureBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppIcon_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.MainFilterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attractionTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // routeWeaverDataSet
            // 
            this.routeWeaverDataSet.DataSetName = "RouteWeaverDataSet";
            this.routeWeaverDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.Filter_PictureBox);
            this.guna2Panel1.Controls.Add(this.flowLayoutPanel);
            this.guna2Panel1.Controls.Add(this.PopularPlaces_Label);
            this.guna2Panel1.Controls.Add(this.Sample_Label);
            this.guna2Panel1.Controls.Add(this.Place_Label);
            this.guna2Panel1.Controls.Add(this.guna2Separator1);
            this.guna2Panel1.Controls.Add(this.Search_TextBox);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 120);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(408, 910);
            this.guna2Panel1.TabIndex = 0;
            // 
            // Filter_PictureBox
            // 
            this.Filter_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.Filter_PictureBox.Image = global::RouteWeaver.Properties.Resources.Filter;
            this.Filter_PictureBox.ImageRotate = 0F;
            this.Filter_PictureBox.Location = new System.Drawing.Point(371, 123);
            this.Filter_PictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.Filter_PictureBox.Name = "Filter_PictureBox";
            this.Filter_PictureBox.Size = new System.Drawing.Size(17, 16);
            this.Filter_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Filter_PictureBox.TabIndex = 11;
            this.Filter_PictureBox.TabStop = false;
            this.Filter_PictureBox.UseTransparentBackground = true;
            this.Filter_PictureBox.Click += new System.EventHandler(this.Filter_PictureBox_Click);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.flowLayoutPanel.Location = new System.Drawing.Point(11, 152);
            this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(392, 758);
            this.flowLayoutPanel.TabIndex = 12;
            // 
            // PopularPlaces_Label
            // 
            this.PopularPlaces_Label.AutoSize = true;
            this.PopularPlaces_Label.BackColor = System.Drawing.Color.Transparent;
            this.PopularPlaces_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PopularPlaces_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.PopularPlaces_Label.Location = new System.Drawing.Point(7, 114);
            this.PopularPlaces_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PopularPlaces_Label.Name = "PopularPlaces_Label";
            this.PopularPlaces_Label.Size = new System.Drawing.Size(157, 18);
            this.PopularPlaces_Label.TabIndex = 10;
            this.PopularPlaces_Label.Text = "Популярные места";
            // 
            // Sample_Label
            // 
            this.Sample_Label.AutoSize = true;
            this.Sample_Label.BackColor = System.Drawing.Color.Transparent;
            this.Sample_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sample_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(196)))), ((int)(((byte)(243)))));
            this.Sample_Label.Location = new System.Drawing.Point(234, 76);
            this.Sample_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Sample_Label.Name = "Sample_Label";
            this.Sample_Label.Size = new System.Drawing.Size(86, 20);
            this.Sample_Label.TabIndex = 7;
            this.Sample_Label.Text = "Шаблоны";
            this.Sample_Label.Click += new System.EventHandler(this.Sample_Label_Click);
            // 
            // Place_Label
            // 
            this.Place_Label.AutoSize = true;
            this.Place_Label.BackColor = System.Drawing.Color.Transparent;
            this.Place_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Place_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(196)))), ((int)(((byte)(243)))));
            this.Place_Label.Location = new System.Drawing.Point(70, 77);
            this.Place_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Place_Label.Name = "Place_Label";
            this.Place_Label.Size = new System.Drawing.Size(62, 20);
            this.Place_Label.TabIndex = 6;
            this.Place_Label.Text = "Места";
            this.Place_Label.Click += new System.EventHandler(this.Place_Label_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(201)))), ((int)(((byte)(244)))));
            this.guna2Separator1.Location = new System.Drawing.Point(1, 103);
            this.guna2Separator1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(407, 8);
            this.guna2Separator1.TabIndex = 9;
            // 
            // Search_TextBox
            // 
            this.Search_TextBox.BackColor = System.Drawing.Color.Transparent;
            this.Search_TextBox.BorderRadius = 12;
            this.Search_TextBox.BorderThickness = 0;
            this.Search_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Search_TextBox.DefaultText = "";
            this.Search_TextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Search_TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Search_TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Search_TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Search_TextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.Search_TextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Search_TextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(160)))), ((int)(((byte)(211)))));
            this.Search_TextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Search_TextBox.IconLeftOffset = new System.Drawing.Point(8, 0);
            this.Search_TextBox.IconLeftSize = new System.Drawing.Size(25, 25);
            this.Search_TextBox.Location = new System.Drawing.Point(13, 8);
            this.Search_TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Search_TextBox.Name = "Search_TextBox";
            this.Search_TextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(196)))), ((int)(((byte)(243)))));
            this.Search_TextBox.PlaceholderText = "Поиск мест...";
            this.Search_TextBox.SelectedText = "";
            this.Search_TextBox.Size = new System.Drawing.Size(509, 65);
            this.Search_TextBox.TabIndex = 3;
            this.Search_TextBox.TextChanged += new System.EventHandler(this.Search_TextBox_TextChanged);
            // 
            // FilterByRateComboBox
            // 
            this.FilterByRateComboBox.BackColor = System.Drawing.Color.Transparent;
            this.FilterByRateComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.FilterByRateComboBox.BorderRadius = 10;
            this.FilterByRateComboBox.BorderThickness = 2;
            this.FilterByRateComboBox.DisplayMember = "country_id";
            this.FilterByRateComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FilterByRateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterByRateComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.FilterByRateComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FilterByRateComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FilterByRateComboBox.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.FilterByRateComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.FilterByRateComboBox.ItemHeight = 30;
            this.FilterByRateComboBox.Items.AddRange(new object[] {
            "По возрастанию",
            "По убыванию"});
            this.FilterByRateComboBox.Location = new System.Drawing.Point(24, 54);
            this.FilterByRateComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.FilterByRateComboBox.Name = "FilterByRateComboBox";
            this.FilterByRateComboBox.Size = new System.Drawing.Size(479, 36);
            this.FilterByRateComboBox.TabIndex = 21;
            this.FilterByRateComboBox.ValueMember = "country_id";
            this.FilterByRateComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterByRateComboBox_SelectedIndexChanged);
            // 
            // AppName_Label
            // 
            this.AppName_Label.AutoSize = true;
            this.AppName_Label.BackColor = System.Drawing.Color.Transparent;
            this.AppName_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AppName_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(75)))), ((int)(((byte)(127)))));
            this.AppName_Label.Location = new System.Drawing.Point(89, 12);
            this.AppName_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AppName_Label.Name = "AppName_Label";
            this.AppName_Label.Size = new System.Drawing.Size(217, 36);
            this.AppName_Label.TabIndex = 4;
            this.AppName_Label.Text = "Route Weaver";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(160)))), ((int)(((byte)(211)))));
            this.label2.Location = new System.Drawing.Point(94, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Планировщик маршрутов";
            // 
            // Nickname_Label
            // 
            this.Nickname_Label.BackColor = System.Drawing.Color.White;
            this.Nickname_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nickname_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.Nickname_Label.Location = new System.Drawing.Point(1693, 82);
            this.Nickname_Label.Name = "Nickname_Label";
            this.Nickname_Label.Size = new System.Drawing.Size(143, 25);
            this.Nickname_Label.TabIndex = 2;
            this.Nickname_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Nickname_Label.Visible = false;
            this.Nickname_Label.Click += new System.EventHandler(this.Nickname_Label_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.56727F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.43273F));
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.gMapControl1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(408, 125);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.472254F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 98.52775F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1442, 908);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderRadius = 20;
            this.guna2Panel3.Controls.Add(this.tableLayoutPanel2);
            this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(251)))));
            this.guna2Panel3.Location = new System.Drawing.Point(1035, 16);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(400, 889);
            this.guna2Panel3.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Location_PictureBox, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.944445F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.05556F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(400, 889);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(75)))), ((int)(((byte)(127)))));
            this.label1.Location = new System.Drawing.Point(2, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Маршрут";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Location_PictureBox
            // 
            this.Location_PictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Location_PictureBox.AutoScroll = true;
            this.Location_PictureBox.Location = new System.Drawing.Point(16, 64);
            this.Location_PictureBox.Name = "Location_PictureBox";
            this.Location_PictureBox.Size = new System.Drawing.Size(368, 816);
            this.Location_PictureBox.TabIndex = 2;
            // 
            // gMapControl1
            // 
            this.gMapControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(14, 16);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 18;
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
            this.gMapControl1.Size = new System.Drawing.Size(1003, 889);
            this.gMapControl1.TabIndex = 1;
            this.gMapControl1.Zoom = 0D;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.White;
            this.guna2CustomGradientPanel1.Controls.Add(this.AdminRole_Label);
            this.guna2CustomGradientPanel1.Controls.Add(this.Length_Label);
            this.guna2CustomGradientPanel1.Controls.Add(this.AppName_Label);
            this.guna2CustomGradientPanel1.Controls.Add(this.Nickname_Label);
            this.guna2CustomGradientPanel1.Controls.Add(this.label2);
            this.guna2CustomGradientPanel1.Controls.Add(this.AppIcon_PictureBox);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1850, 120);
            this.guna2CustomGradientPanel1.TabIndex = 6;
            // 
            // AdminRole_Label
            // 
            this.AdminRole_Label.AutoSize = true;
            this.AdminRole_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminRole_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(160)))), ((int)(((byte)(211)))));
            this.AdminRole_Label.Location = new System.Drawing.Point(95, 82);
            this.AdminRole_Label.Name = "AdminRole_Label";
            this.AdminRole_Label.Size = new System.Drawing.Size(0, 20);
            this.AdminRole_Label.TabIndex = 7;
            // 
            // Length_Label
            // 
            this.Length_Label.AutoSize = true;
            this.Length_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Length_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(75)))), ((int)(((byte)(127)))));
            this.Length_Label.Location = new System.Drawing.Point(795, 43);
            this.Length_Label.Name = "Length_Label";
            this.Length_Label.Size = new System.Drawing.Size(0, 24);
            this.Length_Label.TabIndex = 6;
            // 
            // AppIcon_PictureBox
            // 
            this.AppIcon_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.AppIcon_PictureBox.FillColor = System.Drawing.Color.Transparent;
            this.AppIcon_PictureBox.Image = global::RouteWeaver.Properties.Resources.TripIcon;
            this.AppIcon_PictureBox.ImageRotate = 0F;
            this.AppIcon_PictureBox.Location = new System.Drawing.Point(20, 28);
            this.AppIcon_PictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.AppIcon_PictureBox.Name = "AppIcon_PictureBox";
            this.AppIcon_PictureBox.Size = new System.Drawing.Size(65, 64);
            this.AppIcon_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AppIcon_PictureBox.TabIndex = 0;
            this.AppIcon_PictureBox.TabStop = false;
            this.AppIcon_PictureBox.UseTransparentBackground = true;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guna2PictureBox1.BackColor = System.Drawing.Color.White;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::RouteWeaver.Properties.Resources.Avatarka;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(1734, 22);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(60, 59);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // MainFilterPanel
            // 
            this.MainFilterPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainFilterPanel.BorderRadius = 20;
            this.MainFilterPanel.Controls.Add(this.ClearFilterBtn);
            this.MainFilterPanel.Controls.Add(this.label4);
            this.MainFilterPanel.Controls.Add(this.FilterByTypeComboBox);
            this.MainFilterPanel.Controls.Add(this.label3);
            this.MainFilterPanel.Controls.Add(this.FilterByCountryComboBox);
            this.MainFilterPanel.Controls.Add(this.SortByTypeLabel);
            this.MainFilterPanel.Controls.Add(this.FilterByRateComboBox);
            this.MainFilterPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(251)))));
            this.MainFilterPanel.Location = new System.Drawing.Point(411, 230);
            this.MainFilterPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MainFilterPanel.Name = "MainFilterPanel";
            this.MainFilterPanel.Size = new System.Drawing.Size(533, 378);
            this.MainFilterPanel.TabIndex = 7;
            this.MainFilterPanel.Visible = false;
            // 
            // ClearFilterBtn
            // 
            this.ClearFilterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.ClearFilterBtn.BorderRadius = 12;
            this.ClearFilterBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ClearFilterBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ClearFilterBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ClearFilterBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ClearFilterBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.ClearFilterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearFilterBtn.ForeColor = System.Drawing.Color.White;
            this.ClearFilterBtn.Location = new System.Drawing.Point(24, 314);
            this.ClearFilterBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ClearFilterBtn.Name = "ClearFilterBtn";
            this.ClearFilterBtn.Size = new System.Drawing.Size(480, 46);
            this.ClearFilterBtn.TabIndex = 27;
            this.ClearFilterBtn.Text = "Сбросить фильтр";
            this.ClearFilterBtn.Click += new System.EventHandler(this.ClearFilterBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.label4.Location = new System.Drawing.Point(20, 215);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(366, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "Сортировка по Типу достопримечательности";
            // 
            // FilterByTypeComboBox
            // 
            this.FilterByTypeComboBox.BackColor = System.Drawing.Color.Transparent;
            this.FilterByTypeComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.FilterByTypeComboBox.BorderRadius = 10;
            this.FilterByTypeComboBox.BorderThickness = 2;
            this.FilterByTypeComboBox.DataSource = this.attractionTypeBindingSource;
            this.FilterByTypeComboBox.DisplayMember = "type_name";
            this.FilterByTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FilterByTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterByTypeComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.FilterByTypeComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FilterByTypeComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FilterByTypeComboBox.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.FilterByTypeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.FilterByTypeComboBox.ItemHeight = 30;
            this.FilterByTypeComboBox.Location = new System.Drawing.Point(24, 251);
            this.FilterByTypeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.FilterByTypeComboBox.Name = "FilterByTypeComboBox";
            this.FilterByTypeComboBox.Size = new System.Drawing.Size(479, 36);
            this.FilterByTypeComboBox.TabIndex = 25;
            this.FilterByTypeComboBox.ValueMember = "type_id";
            this.FilterByTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterByTypeComboBox_SelectedIndexChanged);
            // 
            // attractionTypeBindingSource
            // 
            this.attractionTypeBindingSource.DataMember = "AttractionType";
            this.attractionTypeBindingSource.DataSource = this.routeWeaverDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.label3.Location = new System.Drawing.Point(20, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "Сортировка по Странам";
            // 
            // FilterByCountryComboBox
            // 
            this.FilterByCountryComboBox.BackColor = System.Drawing.Color.Transparent;
            this.FilterByCountryComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.FilterByCountryComboBox.BorderRadius = 10;
            this.FilterByCountryComboBox.BorderThickness = 2;
            this.FilterByCountryComboBox.DataSource = this.countryBindingSource;
            this.FilterByCountryComboBox.DisplayMember = "country_name";
            this.FilterByCountryComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FilterByCountryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterByCountryComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.FilterByCountryComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FilterByCountryComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FilterByCountryComboBox.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.FilterByCountryComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.FilterByCountryComboBox.ItemHeight = 30;
            this.FilterByCountryComboBox.Location = new System.Drawing.Point(24, 154);
            this.FilterByCountryComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.FilterByCountryComboBox.Name = "FilterByCountryComboBox";
            this.FilterByCountryComboBox.Size = new System.Drawing.Size(479, 36);
            this.FilterByCountryComboBox.TabIndex = 23;
            this.FilterByCountryComboBox.ValueMember = "country_id";
            this.FilterByCountryComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterByCountryComboBox_SelectedIndexChanged);
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataMember = "Country";
            this.countryBindingSource.DataSource = this.routeWeaverDataSet;
            // 
            // SortByTypeLabel
            // 
            this.SortByTypeLabel.AutoSize = true;
            this.SortByTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.SortByTypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.SortByTypeLabel.Location = new System.Drawing.Point(20, 18);
            this.SortByTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SortByTypeLabel.Name = "SortByTypeLabel";
            this.SortByTypeLabel.Size = new System.Drawing.Size(218, 18);
            this.SortByTypeLabel.TabIndex = 22;
            this.SortByTypeLabel.Text = "Сортировка по Рейтингу ⭐";
            // 
            // attractionTypeTableAdapter
            // 
            this.attractionTypeTableAdapter.ClearBeforeFill = true;
            // 
            // countryTableAdapter
            // 
            this.countryTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1850, 1033);
            this.Controls.Add(this.MainFilterPanel);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.routeWeaverDataSet)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Filter_PictureBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppIcon_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.MainFilterPanel.ResumeLayout(false);
            this.MainFilterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attractionTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox AppIcon_PictureBox;
        private Guna.UI2.WinForms.Guna2TextBox Search_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AppName_Label;
        private System.Windows.Forms.Label Place_Label;
        private System.Windows.Forms.Label Sample_Label;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label PopularPlaces_Label;
        private Guna.UI2.WinForms.Guna2PictureBox Filter_PictureBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel Location_PictureBox;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label Nickname_Label;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Label Length_Label;
        private System.Windows.Forms.Label AdminRole_Label;
        private Guna.UI2.WinForms.Guna2ComboBox FilterByRateComboBox;
        private Guna.UI2.WinForms.Guna2Panel MainFilterPanel;
        private System.Windows.Forms.Label SortByTypeLabel;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox FilterByTypeComboBox;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox FilterByCountryComboBox;
        private Guna.UI2.WinForms.Guna2Button ClearFilterBtn;
        private RouteWeaverDataSet routeWeaverDataSet;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private RouteWeaverDataSetTableAdapters.CountryTableAdapter countryTableAdapter;
        private System.Windows.Forms.BindingSource attractionTypeBindingSource;
        private RouteWeaverDataSetTableAdapters.AttractionTypeTableAdapter attractionTypeTableAdapter;
    }
}