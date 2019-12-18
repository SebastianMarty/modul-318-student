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
            this.VerbindungenLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblVonSuchfeld = new System.Windows.Forms.Label();
            this.lblNachSuchfeld = new System.Windows.Forms.Label();
            this.btn_VerbindungenSuchen = new System.Windows.Forms.Button();
            this.txtVonSuchfeld = new System.Windows.Forms.TextBox();
            this.txtNachSuchfeld = new System.Windows.Forms.TextBox();
            this.StationenTab = new System.Windows.Forms.TabPage();
            this.StationenList = new System.Windows.Forms.ListBox();
            this.StationenGridView = new System.Windows.Forms.DataGridView();
            this.StationenLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.txtStationen = new System.Windows.Forms.TextBox();
            this.btn_StationenSuchen = new System.Windows.Forms.Button();
            this.lblStationen = new System.Windows.Forms.Label();
            this.KartenTab = new System.Windows.Forms.TabPage();
            this.KartenList = new System.Windows.Forms.ListBox();
            this.KartenBrowser = new System.Windows.Forms.WebBrowser();
            this.KartenSucheLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblKartenStation = new System.Windows.Forms.Label();
            this.txtKartenStation = new System.Windows.Forms.TextBox();
            this.Von = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bus_Zug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Durration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bus_Zug_Station = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abfahrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NachStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label1.Location = new System.Drawing.Point(278, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.VerbindungsTab);
            this.tabControl.Controls.Add(this.StationenTab);
            this.tabControl.Controls.Add(this.KartenTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1724, 965);
            this.tabControl.TabIndex = 5;
            // 
            // VerbindungsTab
            // 
            this.VerbindungsTab.Controls.Add(this.NachSuchfeldList);
            this.VerbindungsTab.Controls.Add(this.VonSuchfeldList);
            this.VerbindungsTab.Controls.Add(this.ConnectionGridView);
            this.VerbindungsTab.Controls.Add(this.VerbindungenLayoutPanel);
            this.VerbindungsTab.Location = new System.Drawing.Point(8, 39);
            this.VerbindungsTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VerbindungsTab.Name = "VerbindungsTab";
            this.VerbindungsTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VerbindungsTab.Size = new System.Drawing.Size(1708, 918);
            this.VerbindungsTab.TabIndex = 0;
            this.VerbindungsTab.Text = "Verbindungen";
            this.VerbindungsTab.UseVisualStyleBackColor = true;
            // 
            // NachSuchfeldList
            // 
            this.NachSuchfeldList.FormattingEnabled = true;
            this.NachSuchfeldList.ItemHeight = 25;
            this.NachSuchfeldList.Location = new System.Drawing.Point(856, 54);
            this.NachSuchfeldList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.NachSuchfeldList.Name = "NachSuchfeldList";
            this.NachSuchfeldList.Size = new System.Drawing.Size(672, 304);
            this.NachSuchfeldList.TabIndex = 3;
            this.NachSuchfeldList.Visible = false;
            this.NachSuchfeldList.SelectedIndexChanged += new System.EventHandler(this.OnList_SelectedIndexChanged);
            // 
            // VonSuchfeldList
            // 
            this.VonSuchfeldList.FormattingEnabled = true;
            this.VonSuchfeldList.ItemHeight = 25;
            this.VonSuchfeldList.Location = new System.Drawing.Point(88, 54);
            this.VonSuchfeldList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.VonSuchfeldList.Name = "VonSuchfeldList";
            this.VonSuchfeldList.Size = new System.Drawing.Size(672, 304);
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
            this.ConnectionGridView.Location = new System.Drawing.Point(4, 54);
            this.ConnectionGridView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ConnectionGridView.Name = "ConnectionGridView";
            this.ConnectionGridView.RowHeadersVisible = false;
            this.ConnectionGridView.RowHeadersWidth = 82;
            this.ConnectionGridView.Size = new System.Drawing.Size(1700, 860);
            this.ConnectionGridView.TabIndex = 1;
            // 
            // VerbindungenLayoutPanel
            // 
            this.VerbindungenLayoutPanel.ColumnCount = 5;
            this.VerbindungenLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.VerbindungenLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.VerbindungenLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.VerbindungenLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.VerbindungenLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.VerbindungenLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.VerbindungenLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.VerbindungenLayoutPanel.Controls.Add(this.lblVonSuchfeld, 0, 0);
            this.VerbindungenLayoutPanel.Controls.Add(this.lblNachSuchfeld, 2, 0);
            this.VerbindungenLayoutPanel.Controls.Add(this.btn_VerbindungenSuchen, 4, 0);
            this.VerbindungenLayoutPanel.Controls.Add(this.txtVonSuchfeld, 1, 0);
            this.VerbindungenLayoutPanel.Controls.Add(this.txtNachSuchfeld, 3, 0);
            this.VerbindungenLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.VerbindungenLayoutPanel.Location = new System.Drawing.Point(4, 4);
            this.VerbindungenLayoutPanel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.VerbindungenLayoutPanel.Name = "VerbindungenLayoutPanel";
            this.VerbindungenLayoutPanel.RowCount = 1;
            this.VerbindungenLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.VerbindungenLayoutPanel.Size = new System.Drawing.Size(1700, 50);
            this.VerbindungenLayoutPanel.TabIndex = 0;
            // 
            // lblVonSuchfeld
            // 
            this.lblVonSuchfeld.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVonSuchfeld.AutoSize = true;
            this.lblVonSuchfeld.Location = new System.Drawing.Point(6, 12);
            this.lblVonSuchfeld.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblVonSuchfeld.Name = "lblVonSuchfeld";
            this.lblVonSuchfeld.Size = new System.Drawing.Size(68, 25);
            this.lblVonSuchfeld.TabIndex = 0;
            this.lblVonSuchfeld.Text = "Von:";
            // 
            // lblNachSuchfeld
            // 
            this.lblNachSuchfeld.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNachSuchfeld.AutoSize = true;
            this.lblNachSuchfeld.Location = new System.Drawing.Point(770, 12);
            this.lblNachSuchfeld.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNachSuchfeld.Name = "lblNachSuchfeld";
            this.lblNachSuchfeld.Size = new System.Drawing.Size(72, 25);
            this.lblNachSuchfeld.TabIndex = 1;
            this.lblNachSuchfeld.Text = "Nach:";
            // 
            // btn_VerbindungenSuchen
            // 
            this.btn_VerbindungenSuchen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_VerbindungenSuchen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_VerbindungenSuchen.Location = new System.Drawing.Point(1536, 4);
            this.btn_VerbindungenSuchen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_VerbindungenSuchen.Name = "btn_VerbindungenSuchen";
            this.btn_VerbindungenSuchen.Size = new System.Drawing.Size(160, 42);
            this.btn_VerbindungenSuchen.TabIndex = 4;
            this.btn_VerbindungenSuchen.Text = "Suchen";
            this.btn_VerbindungenSuchen.UseVisualStyleBackColor = true;
            this.btn_VerbindungenSuchen.Click += new System.EventHandler(this.OnSuchen_Click);
            // 
            // txtVonSuchfeld
            // 
            this.txtVonSuchfeld.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVonSuchfeld.Location = new System.Drawing.Point(84, 9);
            this.txtVonSuchfeld.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVonSuchfeld.Name = "txtVonSuchfeld";
            this.txtVonSuchfeld.Size = new System.Drawing.Size(676, 31);
            this.txtVonSuchfeld.TabIndex = 5;
            this.txtVonSuchfeld.TextChanged += new System.EventHandler(this.OnSuchfeld_TextChanged);
            // 
            // txtNachSuchfeld
            // 
            this.txtNachSuchfeld.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNachSuchfeld.Location = new System.Drawing.Point(852, 9);
            this.txtNachSuchfeld.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNachSuchfeld.Name = "txtNachSuchfeld";
            this.txtNachSuchfeld.Size = new System.Drawing.Size(676, 31);
            this.txtNachSuchfeld.TabIndex = 6;
            this.txtNachSuchfeld.TextChanged += new System.EventHandler(this.OnSuchfeld_TextChanged);
            // 
            // StationenTab
            // 
            this.StationenTab.Controls.Add(this.StationenList);
            this.StationenTab.Controls.Add(this.StationenGridView);
            this.StationenTab.Controls.Add(this.StationenLayoutPanel);
            this.StationenTab.Controls.Add(this.label1);
            this.StationenTab.Location = new System.Drawing.Point(8, 39);
            this.StationenTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StationenTab.Name = "StationenTab";
            this.StationenTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StationenTab.Size = new System.Drawing.Size(1708, 918);
            this.StationenTab.TabIndex = 1;
            this.StationenTab.Text = "Stationen";
            this.StationenTab.UseVisualStyleBackColor = true;
            // 
            // StationenList
            // 
            this.StationenList.FormattingEnabled = true;
            this.StationenList.ItemHeight = 25;
            this.StationenList.Location = new System.Drawing.Point(108, 54);
            this.StationenList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.StationenList.Name = "StationenList";
            this.StationenList.Size = new System.Drawing.Size(672, 304);
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
            this.StationenGridView.Location = new System.Drawing.Point(4, 54);
            this.StationenGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StationenGridView.Name = "StationenGridView";
            this.StationenGridView.RowHeadersVisible = false;
            this.StationenGridView.RowHeadersWidth = 82;
            this.StationenGridView.RowTemplate.Height = 33;
            this.StationenGridView.Size = new System.Drawing.Size(1700, 860);
            this.StationenGridView.TabIndex = 2;
            // 
            // StationenLayoutPanel
            // 
            this.StationenLayoutPanel.ColumnCount = 3;
            this.StationenLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.StationenLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.StationenLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.StationenLayoutPanel.Controls.Add(this.txtStationen, 1, 0);
            this.StationenLayoutPanel.Controls.Add(this.btn_StationenSuchen, 2, 0);
            this.StationenLayoutPanel.Controls.Add(this.lblStationen, 0, 0);
            this.StationenLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.StationenLayoutPanel.Location = new System.Drawing.Point(4, 4);
            this.StationenLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StationenLayoutPanel.Name = "StationenLayoutPanel";
            this.StationenLayoutPanel.RowCount = 1;
            this.StationenLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.StationenLayoutPanel.Size = new System.Drawing.Size(1700, 50);
            this.StationenLayoutPanel.TabIndex = 1;
            // 
            // txtStationen
            // 
            this.txtStationen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStationen.Location = new System.Drawing.Point(104, 9);
            this.txtStationen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStationen.Name = "txtStationen";
            this.txtStationen.Size = new System.Drawing.Size(1428, 31);
            this.txtStationen.TabIndex = 0;
            this.txtStationen.TextChanged += new System.EventHandler(this.OnSuchfeld_TextChanged);
            // 
            // btn_StationenSuchen
            // 
            this.btn_StationenSuchen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_StationenSuchen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_StationenSuchen.Location = new System.Drawing.Point(1540, 4);
            this.btn_StationenSuchen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_StationenSuchen.Name = "btn_StationenSuchen";
            this.btn_StationenSuchen.Size = new System.Drawing.Size(156, 42);
            this.btn_StationenSuchen.TabIndex = 2;
            this.btn_StationenSuchen.Text = "Suchen";
            this.btn_StationenSuchen.UseVisualStyleBackColor = true;
            this.btn_StationenSuchen.Click += new System.EventHandler(this.OnSuchen_Click);
            // 
            // lblStationen
            // 
            this.lblStationen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStationen.AutoSize = true;
            this.lblStationen.Location = new System.Drawing.Point(7, 12);
            this.lblStationen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStationen.Name = "lblStationen";
            this.lblStationen.Size = new System.Drawing.Size(85, 25);
            this.lblStationen.TabIndex = 0;
            this.lblStationen.Text = "Station:";
            // 
            // KartenTab
            // 
            this.KartenTab.Controls.Add(this.KartenList);
            this.KartenTab.Controls.Add(this.KartenBrowser);
            this.KartenTab.Controls.Add(this.KartenSucheLayoutPanel);
            this.KartenTab.Location = new System.Drawing.Point(8, 39);
            this.KartenTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.KartenTab.Name = "KartenTab";
            this.KartenTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.KartenTab.Size = new System.Drawing.Size(1708, 918);
            this.KartenTab.TabIndex = 2;
            this.KartenTab.Text = "Karte";
            this.KartenTab.UseVisualStyleBackColor = true;
            // 
            // KartenList
            // 
            this.KartenList.FormattingEnabled = true;
            this.KartenList.ItemHeight = 25;
            this.KartenList.Location = new System.Drawing.Point(108, 60);
            this.KartenList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.KartenList.Name = "KartenList";
            this.KartenList.Size = new System.Drawing.Size(672, 304);
            this.KartenList.TabIndex = 3;
            this.KartenList.Visible = false;
            this.KartenList.SelectedIndexChanged += new System.EventHandler(this.OnList_SelectedIndexChanged);
            // 
            // KartenBrowser
            // 
            this.KartenBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KartenBrowser.Location = new System.Drawing.Point(4, 58);
            this.KartenBrowser.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.KartenBrowser.MinimumSize = new System.Drawing.Size(40, 38);
            this.KartenBrowser.Name = "KartenBrowser";
            this.KartenBrowser.Size = new System.Drawing.Size(1700, 856);
            this.KartenBrowser.TabIndex = 1;
            // 
            // KartenSucheLayoutPanel
            // 
            this.KartenSucheLayoutPanel.ColumnCount = 2;
            this.KartenSucheLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.KartenSucheLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.KartenSucheLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.KartenSucheLayoutPanel.Controls.Add(this.lblKartenStation, 0, 0);
            this.KartenSucheLayoutPanel.Controls.Add(this.txtKartenStation, 1, 0);
            this.KartenSucheLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.KartenSucheLayoutPanel.Location = new System.Drawing.Point(4, 4);
            this.KartenSucheLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.KartenSucheLayoutPanel.Name = "KartenSucheLayoutPanel";
            this.KartenSucheLayoutPanel.RowCount = 1;
            this.KartenSucheLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.KartenSucheLayoutPanel.Size = new System.Drawing.Size(1700, 54);
            this.KartenSucheLayoutPanel.TabIndex = 0;
            // 
            // lblKartenStation
            // 
            this.lblKartenStation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKartenStation.AutoSize = true;
            this.lblKartenStation.Location = new System.Drawing.Point(4, 14);
            this.lblKartenStation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKartenStation.Name = "lblKartenStation";
            this.lblKartenStation.Size = new System.Drawing.Size(92, 25);
            this.lblKartenStation.TabIndex = 0;
            this.lblKartenStation.Text = "Station:";
            // 
            // txtKartenStation
            // 
            this.txtKartenStation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKartenStation.Location = new System.Drawing.Point(104, 11);
            this.txtKartenStation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKartenStation.Name = "txtKartenStation";
            this.txtKartenStation.Size = new System.Drawing.Size(1592, 31);
            this.txtKartenStation.TabIndex = 1;
            this.txtKartenStation.TextChanged += new System.EventHandler(this.OnSuchfeld_TextChanged);
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
            this.Bus_Zug.HeaderText = "Bus/Zug:";
            this.Bus_Zug.MinimumWidth = 10;
            this.Bus_Zug.Name = "Bus_Zug";
            // 
            // Durration
            // 
            this.Durration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Durration.HeaderText = "Dauer:";
            this.Durration.MinimumWidth = 6;
            this.Durration.Name = "Durration";
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
            this.Bus_Zug_Station.HeaderText = "Bus/Zug:";
            this.Bus_Zug_Station.MinimumWidth = 10;
            this.Bus_Zug_Station.Name = "Bus_Zug_Station";
            // 
            // Abfahrt
            // 
            this.Abfahrt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Abfahrt.HeaderText = "Abfahrt:";
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
            // Fahrplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1724, 965);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(1190, 771);
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
        private System.Windows.Forms.TableLayoutPanel VerbindungenLayoutPanel;
        private System.Windows.Forms.Label lblVonSuchfeld;
        private System.Windows.Forms.Label lblNachSuchfeld;
        private System.Windows.Forms.Button btn_VerbindungenSuchen;
        private System.Windows.Forms.TextBox txtVonSuchfeld;
        private System.Windows.Forms.TextBox txtNachSuchfeld;
        private System.Windows.Forms.DataGridView StationenGridView;
        private System.Windows.Forms.TableLayoutPanel StationenLayoutPanel;
        private System.Windows.Forms.TextBox txtStationen;
        private System.Windows.Forms.Button btn_StationenSuchen;
        private System.Windows.Forms.Label lblStationen;
        private System.Windows.Forms.TableLayoutPanel KartenSucheLayoutPanel;
        private System.Windows.Forms.Label lblKartenStation;
        private System.Windows.Forms.TextBox txtKartenStation;
        private System.Windows.Forms.WebBrowser KartenBrowser;
        private System.Windows.Forms.ListBox VonSuchfeldList;
        private System.Windows.Forms.ListBox NachSuchfeldList;
        private System.Windows.Forms.ListBox StationenList;
        private System.Windows.Forms.ListBox KartenList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Von;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bus_Zug;
        private System.Windows.Forms.DataGridViewTextBoxColumn Durration;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bus_Zug_Station;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrt;
        private System.Windows.Forms.DataGridViewTextBoxColumn NachStation;
    }
}

