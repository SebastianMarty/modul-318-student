namespace Fahrplan_
{
    partial class Fahrplan
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.VerbindungsTab = new System.Windows.Forms.TabPage();
            this.NachSuchfeldList = new System.Windows.Forms.ListBox();
            this.VonSuchfeldList = new System.Windows.Forms.ListBox();
            this.ConnectionGridView = new System.Windows.Forms.DataGridView();
            this.Von = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bus_Zug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Durration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VerbindungenLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_VerbindungenSuchen = new System.Windows.Forms.Button();
            this.txtVonSuchfeld = new System.Windows.Forms.TextBox();
            this.txtNachSuchfeld = new System.Windows.Forms.TextBox();
            this.StationenTab = new System.Windows.Forms.TabPage();
            this.StationenList = new System.Windows.Forms.ListBox();
            this.StationenGridView = new System.Windows.Forms.DataGridView();
            this.StationsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bus_Zug_Station = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abfahrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NachStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationenLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.txtStationen = new System.Windows.Forms.TextBox();
            this.btn_StationenSuchen = new System.Windows.Forms.Button();
            this.lblHauptVon = new System.Windows.Forms.Label();
            this.KartenTab = new System.Windows.Forms.TabPage();
            this.KartenList = new System.Windows.Forms.ListBox();
            this.KartenBrowser = new System.Windows.Forms.WebBrowser();
            this.KartenSucheLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblKartenStation = new System.Windows.Forms.Label();
            this.txtKartenStation = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.VerbindungsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionGridView)).BeginInit();
            this.VerbindungenLayoutPanel.SuspendLayout();
            this.StationenTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StationenGridView)).BeginInit();
            this.StationenLayoutPanel.SuspendLayout();
            this.KartenTab.SuspendLayout();
            this.KartenSucheLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.VerbindungsTab);
            this.tabControl.Controls.Add(this.StationenTab);
            this.tabControl.Controls.Add(this.KartenTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(862, 502);
            this.tabControl.TabIndex = 5;
            // 
            // VerbindungsTab
            // 
            this.VerbindungsTab.Controls.Add(this.NachSuchfeldList);
            this.VerbindungsTab.Controls.Add(this.VonSuchfeldList);
            this.VerbindungsTab.Controls.Add(this.ConnectionGridView);
            this.VerbindungsTab.Controls.Add(this.VerbindungenLayoutPanel);
            this.VerbindungsTab.Location = new System.Drawing.Point(4, 22);
            this.VerbindungsTab.Margin = new System.Windows.Forms.Padding(2);
            this.VerbindungsTab.Name = "VerbindungsTab";
            this.VerbindungsTab.Padding = new System.Windows.Forms.Padding(2);
            this.VerbindungsTab.Size = new System.Drawing.Size(854, 476);
            this.VerbindungsTab.TabIndex = 0;
            this.VerbindungsTab.Text = "Verbindungen";
            this.VerbindungsTab.UseVisualStyleBackColor = true;
            // 
            // NachSuchfeldList
            // 
            this.NachSuchfeldList.FormattingEnabled = true;
            this.NachSuchfeldList.Location = new System.Drawing.Point(428, 28);
            this.NachSuchfeldList.Name = "NachSuchfeldList";
            this.NachSuchfeldList.Size = new System.Drawing.Size(338, 160);
            this.NachSuchfeldList.TabIndex = 3;
            this.NachSuchfeldList.Visible = false;
            this.NachSuchfeldList.SelectedIndexChanged += new System.EventHandler(this.OnList_SelectedIndexChanged);
            // 
            // VonSuchfeldList
            // 
            this.VonSuchfeldList.FormattingEnabled = true;
            this.VonSuchfeldList.Location = new System.Drawing.Point(44, 28);
            this.VonSuchfeldList.Name = "VonSuchfeldList";
            this.VonSuchfeldList.Size = new System.Drawing.Size(338, 160);
            this.VonSuchfeldList.TabIndex = 2;
            this.VonSuchfeldList.Visible = false;
            this.VonSuchfeldList.SelectedIndexChanged += new System.EventHandler(this.OnList_SelectedIndexChanged);
            // 
            // ConnectionGridView
            // 
            this.ConnectionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConnectionGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Von,
            this.Departure,
            this.Nach,
            this.Arrival,
            this.Bus_Zug,
            this.Durration});
            this.ConnectionGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConnectionGridView.Location = new System.Drawing.Point(2, 28);
            this.ConnectionGridView.Name = "ConnectionGridView";
            this.ConnectionGridView.RowHeadersVisible = false;
            this.ConnectionGridView.RowHeadersWidth = 82;
            this.ConnectionGridView.Size = new System.Drawing.Size(850, 446);
            this.ConnectionGridView.TabIndex = 1;
            // 
            // Von
            // 
            this.Von.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Von.HeaderText = "Von:";
            this.Von.MinimumWidth = 6;
            this.Von.Name = "Von";
            // 
            // Departure
            // 
            this.Departure.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Departure.HeaderText = "Abfahrt:";
            this.Departure.MinimumWidth = 6;
            this.Departure.Name = "Departure";
            // 
            // Nach
            // 
            this.Nach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nach.HeaderText = "Nach:";
            this.Nach.MinimumWidth = 6;
            this.Nach.Name = "Nach";
            // 
            // Arrival
            // 
            this.Arrival.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Arrival.HeaderText = "Ankunft:";
            this.Arrival.MinimumWidth = 6;
            this.Arrival.Name = "Arrival";
            // 
            // Bus_Zug
            // 
            this.Bus_Zug.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Bus_Zug.HeaderText = "Bus/Zug";
            this.Bus_Zug.MinimumWidth = 10;
            this.Bus_Zug.Name = "Bus_Zug";
            // 
            // Durration
            // 
            this.Durration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Durration.HeaderText = "Dauer";
            this.Durration.MinimumWidth = 6;
            this.Durration.Name = "Durration";
            // 
            // VerbindungenLayoutPanel
            // 
            this.VerbindungenLayoutPanel.ColumnCount = 5;
            this.VerbindungenLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.VerbindungenLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.VerbindungenLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.VerbindungenLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.VerbindungenLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.VerbindungenLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.VerbindungenLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.VerbindungenLayoutPanel.Controls.Add(this.label4, 0, 0);
            this.VerbindungenLayoutPanel.Controls.Add(this.label5, 2, 0);
            this.VerbindungenLayoutPanel.Controls.Add(this.btn_VerbindungenSuchen, 4, 0);
            this.VerbindungenLayoutPanel.Controls.Add(this.txtVonSuchfeld, 1, 0);
            this.VerbindungenLayoutPanel.Controls.Add(this.txtNachSuchfeld, 3, 0);
            this.VerbindungenLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.VerbindungenLayoutPanel.Location = new System.Drawing.Point(2, 2);
            this.VerbindungenLayoutPanel.Name = "VerbindungenLayoutPanel";
            this.VerbindungenLayoutPanel.RowCount = 1;
            this.VerbindungenLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.VerbindungenLayoutPanel.Size = new System.Drawing.Size(850, 26);
            this.VerbindungenLayoutPanel.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Von:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nach:";
            // 
            // btn_VerbindungenSuchen
            // 
            this.btn_VerbindungenSuchen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_VerbindungenSuchen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_VerbindungenSuchen.Location = new System.Drawing.Point(768, 2);
            this.btn_VerbindungenSuchen.Margin = new System.Windows.Forms.Padding(2);
            this.btn_VerbindungenSuchen.Name = "btn_VerbindungenSuchen";
            this.btn_VerbindungenSuchen.Size = new System.Drawing.Size(80, 22);
            this.btn_VerbindungenSuchen.TabIndex = 4;
            this.btn_VerbindungenSuchen.Text = "Suchen";
            this.btn_VerbindungenSuchen.UseVisualStyleBackColor = true;
            this.btn_VerbindungenSuchen.Click += new System.EventHandler(this.OnSuchen_Click);
            // 
            // txtVonSuchfeld
            // 
            this.txtVonSuchfeld.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVonSuchfeld.Location = new System.Drawing.Point(42, 3);
            this.txtVonSuchfeld.Margin = new System.Windows.Forms.Padding(2);
            this.txtVonSuchfeld.Name = "txtVonSuchfeld";
            this.txtVonSuchfeld.Size = new System.Drawing.Size(338, 20);
            this.txtVonSuchfeld.TabIndex = 5;
            this.txtVonSuchfeld.TextChanged += new System.EventHandler(this.OnSuchfeld_TextChanged);
            // 
            // txtNachSuchfeld
            // 
            this.txtNachSuchfeld.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNachSuchfeld.Location = new System.Drawing.Point(426, 3);
            this.txtNachSuchfeld.Margin = new System.Windows.Forms.Padding(2);
            this.txtNachSuchfeld.Name = "txtNachSuchfeld";
            this.txtNachSuchfeld.Size = new System.Drawing.Size(338, 20);
            this.txtNachSuchfeld.TabIndex = 6;
            this.txtNachSuchfeld.TextChanged += new System.EventHandler(this.OnSuchfeld_TextChanged);
            // 
            // StationenTab
            // 
            this.StationenTab.Controls.Add(this.StationenList);
            this.StationenTab.Controls.Add(this.StationenGridView);
            this.StationenTab.Controls.Add(this.StationenLayoutPanel);
            this.StationenTab.Controls.Add(this.label1);
            this.StationenTab.Location = new System.Drawing.Point(4, 22);
            this.StationenTab.Margin = new System.Windows.Forms.Padding(2);
            this.StationenTab.Name = "StationenTab";
            this.StationenTab.Padding = new System.Windows.Forms.Padding(2);
            this.StationenTab.Size = new System.Drawing.Size(854, 476);
            this.StationenTab.TabIndex = 1;
            this.StationenTab.Text = "Stationen";
            this.StationenTab.UseVisualStyleBackColor = true;
            // 
            // StationenList
            // 
            this.StationenList.FormattingEnabled = true;
            this.StationenList.Location = new System.Drawing.Point(54, 28);
            this.StationenList.Name = "StationenList";
            this.StationenList.Size = new System.Drawing.Size(338, 160);
            this.StationenList.TabIndex = 3;
            this.StationenList.Visible = false;
            this.StationenList.SelectedIndexChanged += new System.EventHandler(this.OnList_SelectedIndexChanged);
            // 
            // StationenGridView
            // 
            this.StationenGridView.AllowUserToOrderColumns = true;
            this.StationenGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StationenGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StationsName,
            this.Bus_Zug_Station,
            this.Abfahrt,
            this.NachStation});
            this.StationenGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StationenGridView.Location = new System.Drawing.Point(2, 28);
            this.StationenGridView.Margin = new System.Windows.Forms.Padding(2);
            this.StationenGridView.Name = "StationenGridView";
            this.StationenGridView.RowHeadersVisible = false;
            this.StationenGridView.RowHeadersWidth = 82;
            this.StationenGridView.RowTemplate.Height = 33;
            this.StationenGridView.Size = new System.Drawing.Size(850, 446);
            this.StationenGridView.TabIndex = 2;
            // 
            // StationsName
            // 
            this.StationsName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StationsName.HeaderText = "Name:";
            this.StationsName.MinimumWidth = 10;
            this.StationsName.Name = "StationsName";
            // 
            // Bus_Zug_Station
            // 
            this.Bus_Zug_Station.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Bus_Zug_Station.HeaderText = "Bus/Zug";
            this.Bus_Zug_Station.MinimumWidth = 10;
            this.Bus_Zug_Station.Name = "Bus_Zug_Station";
            // 
            // Abfahrt
            // 
            this.Abfahrt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Abfahrt.HeaderText = "Abfahrt";
            this.Abfahrt.MinimumWidth = 10;
            this.Abfahrt.Name = "Abfahrt";
            // 
            // NachStation
            // 
            this.NachStation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NachStation.HeaderText = "Nach:";
            this.NachStation.MinimumWidth = 10;
            this.NachStation.Name = "NachStation";
            // 
            // StationenLayoutPanel
            // 
            this.StationenLayoutPanel.ColumnCount = 3;
            this.StationenLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.StationenLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.StationenLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.StationenLayoutPanel.Controls.Add(this.txtStationen, 1, 0);
            this.StationenLayoutPanel.Controls.Add(this.btn_StationenSuchen, 2, 0);
            this.StationenLayoutPanel.Controls.Add(this.lblHauptVon, 0, 0);
            this.StationenLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.StationenLayoutPanel.Location = new System.Drawing.Point(2, 2);
            this.StationenLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.StationenLayoutPanel.Name = "StationenLayoutPanel";
            this.StationenLayoutPanel.RowCount = 1;
            this.StationenLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.StationenLayoutPanel.Size = new System.Drawing.Size(850, 26);
            this.StationenLayoutPanel.TabIndex = 1;
            // 
            // txtStationen
            // 
            this.txtStationen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStationen.Location = new System.Drawing.Point(52, 3);
            this.txtStationen.Margin = new System.Windows.Forms.Padding(2);
            this.txtStationen.Name = "txtStationen";
            this.txtStationen.Size = new System.Drawing.Size(714, 20);
            this.txtStationen.TabIndex = 0;
            this.txtStationen.TextChanged += new System.EventHandler(this.OnSuchfeld_TextChanged);
            // 
            // btn_StationenSuchen
            // 
            this.btn_StationenSuchen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_StationenSuchen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_StationenSuchen.Location = new System.Drawing.Point(770, 2);
            this.btn_StationenSuchen.Margin = new System.Windows.Forms.Padding(2);
            this.btn_StationenSuchen.Name = "btn_StationenSuchen";
            this.btn_StationenSuchen.Size = new System.Drawing.Size(78, 22);
            this.btn_StationenSuchen.TabIndex = 2;
            this.btn_StationenSuchen.Text = "Suchen";
            this.btn_StationenSuchen.UseVisualStyleBackColor = true;
            this.btn_StationenSuchen.Click += new System.EventHandler(this.OnSuchen_Click);
            // 
            // lblHauptVon
            // 
            this.lblHauptVon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHauptVon.AutoSize = true;
            this.lblHauptVon.Location = new System.Drawing.Point(3, 6);
            this.lblHauptVon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHauptVon.Name = "lblHauptVon";
            this.lblHauptVon.Size = new System.Drawing.Size(43, 13);
            this.lblHauptVon.TabIndex = 0;
            this.lblHauptVon.Text = "Station:";
            // 
            // KartenTab
            // 
            this.KartenTab.Controls.Add(this.KartenList);
            this.KartenTab.Controls.Add(this.KartenBrowser);
            this.KartenTab.Controls.Add(this.KartenSucheLayoutPanel);
            this.KartenTab.Location = new System.Drawing.Point(4, 22);
            this.KartenTab.Margin = new System.Windows.Forms.Padding(2);
            this.KartenTab.Name = "KartenTab";
            this.KartenTab.Padding = new System.Windows.Forms.Padding(2);
            this.KartenTab.Size = new System.Drawing.Size(854, 476);
            this.KartenTab.TabIndex = 2;
            this.KartenTab.Text = "Karte";
            this.KartenTab.UseVisualStyleBackColor = true;
            // 
            // KartenList
            // 
            this.KartenList.FormattingEnabled = true;
            this.KartenList.Location = new System.Drawing.Point(54, 31);
            this.KartenList.Name = "KartenList";
            this.KartenList.Size = new System.Drawing.Size(338, 160);
            this.KartenList.TabIndex = 3;
            this.KartenList.Visible = false;
            this.KartenList.SelectedIndexChanged += new System.EventHandler(this.OnList_SelectedIndexChanged);
            // 
            // KartenBrowser
            // 
            this.KartenBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KartenBrowser.Location = new System.Drawing.Point(2, 30);
            this.KartenBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.KartenBrowser.Name = "KartenBrowser";
            this.KartenBrowser.Size = new System.Drawing.Size(850, 444);
            this.KartenBrowser.TabIndex = 1;
            // 
            // KartenSucheLayoutPanel
            // 
            this.KartenSucheLayoutPanel.ColumnCount = 2;
            this.KartenSucheLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.KartenSucheLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.KartenSucheLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.KartenSucheLayoutPanel.Controls.Add(this.lblKartenStation, 0, 0);
            this.KartenSucheLayoutPanel.Controls.Add(this.txtKartenStation, 1, 0);
            this.KartenSucheLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.KartenSucheLayoutPanel.Location = new System.Drawing.Point(2, 2);
            this.KartenSucheLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.KartenSucheLayoutPanel.Name = "KartenSucheLayoutPanel";
            this.KartenSucheLayoutPanel.RowCount = 1;
            this.KartenSucheLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.KartenSucheLayoutPanel.Size = new System.Drawing.Size(850, 28);
            this.KartenSucheLayoutPanel.TabIndex = 0;
            // 
            // lblKartenStation
            // 
            this.lblKartenStation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKartenStation.AutoSize = true;
            this.lblKartenStation.Location = new System.Drawing.Point(2, 7);
            this.lblKartenStation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKartenStation.Name = "lblKartenStation";
            this.lblKartenStation.Size = new System.Drawing.Size(46, 13);
            this.lblKartenStation.TabIndex = 0;
            this.lblKartenStation.Text = "Station:";
            // 
            // txtKartenStation
            // 
            this.txtKartenStation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKartenStation.Location = new System.Drawing.Point(52, 4);
            this.txtKartenStation.Margin = new System.Windows.Forms.Padding(2);
            this.txtKartenStation.Name = "txtKartenStation";
            this.txtKartenStation.Size = new System.Drawing.Size(796, 20);
            this.txtKartenStation.TabIndex = 1;
            this.txtKartenStation.TextChanged += new System.EventHandler(this.OnSuchfeld_TextChanged);
            // 
            // Fahrplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 502);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MinimumSize = new System.Drawing.Size(608, 435);
            this.Name = "Fahrplan";
            this.Text = "Fahrplan";
            this.tabControl.ResumeLayout(false);
            this.VerbindungsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionGridView)).EndInit();
            this.VerbindungenLayoutPanel.ResumeLayout(false);
            this.VerbindungenLayoutPanel.PerformLayout();
            this.StationenTab.ResumeLayout(false);
            this.StationenTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StationenGridView)).EndInit();
            this.StationenLayoutPanel.ResumeLayout(false);
            this.StationenLayoutPanel.PerformLayout();
            this.KartenTab.ResumeLayout(false);
            this.KartenSucheLayoutPanel.ResumeLayout(false);
            this.KartenSucheLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage VerbindungsTab;
        private System.Windows.Forms.TabPage StationenTab;
        private System.Windows.Forms.TabPage KartenTab;
        private System.Windows.Forms.DataGridView ConnectionGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Von;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bus_Zug;
        private System.Windows.Forms.DataGridViewTextBoxColumn Durration;
        private System.Windows.Forms.TableLayoutPanel VerbindungenLayoutPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_VerbindungenSuchen;
        private System.Windows.Forms.TextBox txtVonSuchfeld;
        private System.Windows.Forms.TextBox txtNachSuchfeld;
        private System.Windows.Forms.DataGridView StationenGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bus_Zug_Station;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrt;
        private System.Windows.Forms.DataGridViewTextBoxColumn NachStation;
        private System.Windows.Forms.TableLayoutPanel StationenLayoutPanel;
        private System.Windows.Forms.TextBox txtStationen;
        private System.Windows.Forms.Button btn_StationenSuchen;
        private System.Windows.Forms.Label lblHauptVon;
        private System.Windows.Forms.TableLayoutPanel KartenSucheLayoutPanel;
        private System.Windows.Forms.Label lblKartenStation;
        private System.Windows.Forms.TextBox txtKartenStation;
        private System.Windows.Forms.WebBrowser KartenBrowser;
        private System.Windows.Forms.ListBox VonSuchfeldList;
        private System.Windows.Forms.ListBox NachSuchfeldList;
        private System.Windows.Forms.ListBox StationenList;
        private System.Windows.Forms.ListBox KartenList;
    }
}

