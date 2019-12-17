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
            this.KartenLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.KartenSucheLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblKartenStation = new System.Windows.Forms.Label();
            this.txt_KartenStation = new System.Windows.Forms.TextBox();
            this.btn_KartenSuche = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.VerbindungsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionGridView)).BeginInit();
            this.VerbindungenLayoutPanel.SuspendLayout();
            this.StationenTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StationenGridView)).BeginInit();
            this.StationenLayoutPanel.SuspendLayout();
            this.KartenTab.SuspendLayout();
            this.KartenLayoutPanel.SuspendLayout();
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
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1673, 902);
            this.tabControl.TabIndex = 5;
            // 
            // VerbindungsTab
            // 
            this.VerbindungsTab.Controls.Add(this.ConnectionGridView);
            this.VerbindungsTab.Controls.Add(this.VerbindungenLayoutPanel);
            this.VerbindungsTab.Location = new System.Drawing.Point(8, 39);
            this.VerbindungsTab.Name = "VerbindungsTab";
            this.VerbindungsTab.Padding = new System.Windows.Forms.Padding(3);
            this.VerbindungsTab.Size = new System.Drawing.Size(1657, 855);
            this.VerbindungsTab.TabIndex = 0;
            this.VerbindungsTab.Text = "Verbindungen";
            this.VerbindungsTab.UseVisualStyleBackColor = true;
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
            this.ConnectionGridView.Location = new System.Drawing.Point(3, 53);
            this.ConnectionGridView.Margin = new System.Windows.Forms.Padding(6);
            this.ConnectionGridView.Name = "ConnectionGridView";
            this.ConnectionGridView.RowHeadersVisible = false;
            this.ConnectionGridView.RowHeadersWidth = 82;
            this.ConnectionGridView.Size = new System.Drawing.Size(1651, 799);
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
            this.VerbindungenLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.VerbindungenLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.VerbindungenLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.VerbindungenLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.VerbindungenLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.VerbindungenLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.VerbindungenLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.VerbindungenLayoutPanel.Controls.Add(this.label4, 0, 0);
            this.VerbindungenLayoutPanel.Controls.Add(this.label5, 2, 0);
            this.VerbindungenLayoutPanel.Controls.Add(this.btn_VerbindungenSuchen, 4, 0);
            this.VerbindungenLayoutPanel.Controls.Add(this.txtVonSuchfeld, 1, 0);
            this.VerbindungenLayoutPanel.Controls.Add(this.txtNachSuchfeld, 3, 0);
            this.VerbindungenLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.VerbindungenLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.VerbindungenLayoutPanel.Margin = new System.Windows.Forms.Padding(6);
            this.VerbindungenLayoutPanel.Name = "VerbindungenLayoutPanel";
            this.VerbindungenLayoutPanel.RowCount = 1;
            this.VerbindungenLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.VerbindungenLayoutPanel.Size = new System.Drawing.Size(1651, 50);
            this.VerbindungenLayoutPanel.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Von:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(746, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nach:";
            // 
            // btn_VerbindungenSuchen
            // 
            this.btn_VerbindungenSuchen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_VerbindungenSuchen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_VerbindungenSuchen.Location = new System.Drawing.Point(1488, 4);
            this.btn_VerbindungenSuchen.Margin = new System.Windows.Forms.Padding(4);
            this.btn_VerbindungenSuchen.Name = "btn_VerbindungenSuchen";
            this.btn_VerbindungenSuchen.Size = new System.Drawing.Size(159, 42);
            this.btn_VerbindungenSuchen.TabIndex = 4;
            this.btn_VerbindungenSuchen.Text = "Suchen";
            this.btn_VerbindungenSuchen.UseVisualStyleBackColor = true;
            this.btn_VerbindungenSuchen.Click += new System.EventHandler(this.OnSuchen_Click);
            // 
            // txtVonSuchfeld
            // 
            this.txtVonSuchfeld.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVonSuchfeld.Location = new System.Drawing.Point(84, 9);
            this.txtVonSuchfeld.Margin = new System.Windows.Forms.Padding(4);
            this.txtVonSuchfeld.Name = "txtVonSuchfeld";
            this.txtVonSuchfeld.Size = new System.Drawing.Size(652, 31);
            this.txtVonSuchfeld.TabIndex = 5;
            this.txtVonSuchfeld.TextChanged += new System.EventHandler(this.OnSuchfeld_TextChanged);
            // 
            // txtNachSuchfeld
            // 
            this.txtNachSuchfeld.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNachSuchfeld.Location = new System.Drawing.Point(828, 9);
            this.txtNachSuchfeld.Margin = new System.Windows.Forms.Padding(4);
            this.txtNachSuchfeld.Name = "txtNachSuchfeld";
            this.txtNachSuchfeld.Size = new System.Drawing.Size(652, 31);
            this.txtNachSuchfeld.TabIndex = 6;
            this.txtNachSuchfeld.TextChanged += new System.EventHandler(this.OnSuchfeld_TextChanged);
            // 
            // StationenTab
            // 
            this.StationenTab.Controls.Add(this.StationenGridView);
            this.StationenTab.Controls.Add(this.StationenLayoutPanel);
            this.StationenTab.Controls.Add(this.label1);
            this.StationenTab.Location = new System.Drawing.Point(8, 39);
            this.StationenTab.Name = "StationenTab";
            this.StationenTab.Padding = new System.Windows.Forms.Padding(3);
            this.StationenTab.Size = new System.Drawing.Size(1657, 855);
            this.StationenTab.TabIndex = 1;
            this.StationenTab.Text = "Stationen";
            this.StationenTab.UseVisualStyleBackColor = true;
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
            this.StationenGridView.Location = new System.Drawing.Point(3, 53);
            this.StationenGridView.Margin = new System.Windows.Forms.Padding(4);
            this.StationenGridView.Name = "StationenGridView";
            this.StationenGridView.RowHeadersVisible = false;
            this.StationenGridView.RowHeadersWidth = 82;
            this.StationenGridView.RowTemplate.Height = 33;
            this.StationenGridView.Size = new System.Drawing.Size(1651, 799);
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
            this.StationenLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.StationenLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.StationenLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.StationenLayoutPanel.Controls.Add(this.txtStationen, 1, 0);
            this.StationenLayoutPanel.Controls.Add(this.btn_StationenSuchen, 2, 0);
            this.StationenLayoutPanel.Controls.Add(this.lblHauptVon, 0, 0);
            this.StationenLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.StationenLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.StationenLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.StationenLayoutPanel.Name = "StationenLayoutPanel";
            this.StationenLayoutPanel.RowCount = 1;
            this.StationenLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.StationenLayoutPanel.Size = new System.Drawing.Size(1651, 50);
            this.StationenLayoutPanel.TabIndex = 1;
            // 
            // txtStationen
            // 
            this.txtStationen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStationen.Location = new System.Drawing.Point(104, 9);
            this.txtStationen.Margin = new System.Windows.Forms.Padding(4);
            this.txtStationen.Name = "txtStationen";
            this.txtStationen.Size = new System.Drawing.Size(1378, 31);
            this.txtStationen.TabIndex = 0;
            this.txtStationen.TextChanged += new System.EventHandler(this.OnSuchfeld_TextChanged);
            // 
            // btn_StationenSuchen
            // 
            this.btn_StationenSuchen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_StationenSuchen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_StationenSuchen.Location = new System.Drawing.Point(1490, 4);
            this.btn_StationenSuchen.Margin = new System.Windows.Forms.Padding(4);
            this.btn_StationenSuchen.Name = "btn_StationenSuchen";
            this.btn_StationenSuchen.Size = new System.Drawing.Size(157, 42);
            this.btn_StationenSuchen.TabIndex = 2;
            this.btn_StationenSuchen.Text = "Suchen";
            this.btn_StationenSuchen.UseVisualStyleBackColor = true;
            this.btn_StationenSuchen.Click += new System.EventHandler(this.OnSuchen_Click);
            // 
            // lblHauptVon
            // 
            this.lblHauptVon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHauptVon.AutoSize = true;
            this.lblHauptVon.Location = new System.Drawing.Point(7, 12);
            this.lblHauptVon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHauptVon.Name = "lblHauptVon";
            this.lblHauptVon.Size = new System.Drawing.Size(85, 25);
            this.lblHauptVon.TabIndex = 0;
            this.lblHauptVon.Text = "Station:";
            // 
            // KartenTab
            // 
            this.KartenTab.Controls.Add(this.KartenLayoutPanel);
            this.KartenTab.Location = new System.Drawing.Point(8, 39);
            this.KartenTab.Name = "KartenTab";
            this.KartenTab.Padding = new System.Windows.Forms.Padding(3);
            this.KartenTab.Size = new System.Drawing.Size(1657, 855);
            this.KartenTab.TabIndex = 2;
            this.KartenTab.Text = "Karte";
            this.KartenTab.UseVisualStyleBackColor = true;
            // 
            // KartenLayoutPanel
            // 
            this.KartenLayoutPanel.ColumnCount = 1;
            this.KartenLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.KartenLayoutPanel.Controls.Add(this.KartenSucheLayoutPanel, 0, 0);
            this.KartenLayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.KartenLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.KartenLayoutPanel.Name = "KartenLayoutPanel";
            this.KartenLayoutPanel.RowCount = 2;
            this.KartenLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.KartenLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.KartenLayoutPanel.Size = new System.Drawing.Size(503, 849);
            this.KartenLayoutPanel.TabIndex = 0;
            // 
            // KartenSucheLayoutPanel
            // 
            this.KartenSucheLayoutPanel.ColumnCount = 3;
            this.KartenSucheLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.KartenSucheLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.KartenSucheLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.KartenSucheLayoutPanel.Controls.Add(this.lblKartenStation, 0, 0);
            this.KartenSucheLayoutPanel.Controls.Add(this.txt_KartenStation, 1, 0);
            this.KartenSucheLayoutPanel.Controls.Add(this.btn_KartenSuche, 2, 0);
            this.KartenSucheLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KartenSucheLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.KartenSucheLayoutPanel.Name = "KartenSucheLayoutPanel";
            this.KartenSucheLayoutPanel.RowCount = 1;
            this.KartenSucheLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.KartenSucheLayoutPanel.Size = new System.Drawing.Size(497, 54);
            this.KartenSucheLayoutPanel.TabIndex = 0;
            // 
            // lblKartenStation
            // 
            this.lblKartenStation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKartenStation.AutoSize = true;
            this.lblKartenStation.Location = new System.Drawing.Point(3, 14);
            this.lblKartenStation.Name = "lblKartenStation";
            this.lblKartenStation.Size = new System.Drawing.Size(94, 25);
            this.lblKartenStation.TabIndex = 0;
            this.lblKartenStation.Text = "Station:";
            // 
            // txt_KartenStation
            // 
            this.txt_KartenStation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_KartenStation.Location = new System.Drawing.Point(103, 11);
            this.txt_KartenStation.Name = "txt_KartenStation";
            this.txt_KartenStation.Size = new System.Drawing.Size(231, 31);
            this.txt_KartenStation.TabIndex = 1;
            // 
            // btn_KartenSuche
            // 
            this.btn_KartenSuche.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_KartenSuche.Location = new System.Drawing.Point(340, 3);
            this.btn_KartenSuche.Name = "btn_KartenSuche";
            this.btn_KartenSuche.Size = new System.Drawing.Size(154, 48);
            this.btn_KartenSuche.TabIndex = 2;
            this.btn_KartenSuche.Text = "button1";
            this.btn_KartenSuche.UseVisualStyleBackColor = true;
            // 
            // Fahrplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1673, 902);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "Fahrplan";
            this.Text = "Fahrplan";
            this.Load += new System.EventHandler(this.Form1_Load);
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
            this.KartenLayoutPanel.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel KartenLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel KartenSucheLayoutPanel;
        private System.Windows.Forms.Label lblKartenStation;
        private System.Windows.Forms.TextBox txt_KartenStation;
        private System.Windows.Forms.Button btn_KartenSuche;
    }
}

