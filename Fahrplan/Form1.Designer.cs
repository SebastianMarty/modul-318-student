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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtStation = new System.Windows.Forms.TextBox();
            this.HauptSuchen = new System.Windows.Forms.Button();
            this.lblHauptVon = new System.Windows.Forms.Label();
            this.HauptPanel = new System.Windows.Forms.Panel();
            this.HistoryGridView = new System.Windows.Forms.DataGridView();
            this.VerbindungPanel = new System.Windows.Forms.Panel();
            this.ConnectionGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtVonSuchfeld = new System.Windows.Forms.TextBox();
            this.txtNachSuchfeld = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.VerbindungsTab = new System.Windows.Forms.TabPage();
            this.StationenTab = new System.Windows.Forms.TabPage();
            this.Von = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bus_Zug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Durration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.HauptPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryGridView)).BeginInit();
            this.VerbindungPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionGridView)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.VerbindungsTab.SuspendLayout();
            this.StationenTab.SuspendLayout();
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tableLayoutPanel1.Controls.Add(this.txtStation, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.HauptSuchen, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblHauptVon, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1549, 50);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // txtStation
            // 
            this.txtStation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStation.Location = new System.Drawing.Point(84, 9);
            this.txtStation.Margin = new System.Windows.Forms.Padding(4);
            this.txtStation.Name = "txtStation";
            this.txtStation.Size = new System.Drawing.Size(604, 31);
            this.txtStation.TabIndex = 0;
            this.txtStation.TextChanged += new System.EventHandler(this.OnSuchfeld_TextChanged);
            // 
            // HauptSuchen
            // 
            this.HauptSuchen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HauptSuchen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HauptSuchen.Location = new System.Drawing.Point(1388, 4);
            this.HauptSuchen.Margin = new System.Windows.Forms.Padding(4);
            this.HauptSuchen.Name = "HauptSuchen";
            this.HauptSuchen.Size = new System.Drawing.Size(157, 42);
            this.HauptSuchen.TabIndex = 2;
            this.HauptSuchen.Text = "Suchen";
            this.HauptSuchen.UseVisualStyleBackColor = true;
            this.HauptSuchen.Click += new System.EventHandler(this.OnSuchen_Click);
            // 
            // lblHauptVon
            // 
            this.lblHauptVon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHauptVon.AutoSize = true;
            this.lblHauptVon.Location = new System.Drawing.Point(12, 12);
            this.lblHauptVon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHauptVon.Name = "lblHauptVon";
            this.lblHauptVon.Size = new System.Drawing.Size(56, 25);
            this.lblHauptVon.TabIndex = 0;
            this.lblHauptVon.Text = "Von:";
            // 
            // HauptPanel
            // 
            this.HauptPanel.AutoSize = true;
            this.HauptPanel.Controls.Add(this.HistoryGridView);
            this.HauptPanel.Controls.Add(this.tableLayoutPanel1);
            this.HauptPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HauptPanel.Location = new System.Drawing.Point(3, 3);
            this.HauptPanel.Margin = new System.Windows.Forms.Padding(4);
            this.HauptPanel.Name = "HauptPanel";
            this.HauptPanel.Size = new System.Drawing.Size(1549, 782);
            this.HauptPanel.TabIndex = 2;
            // 
            // HistoryGridView
            // 
            this.HistoryGridView.AllowUserToOrderColumns = true;
            this.HistoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HistoryGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HistoryGridView.Location = new System.Drawing.Point(0, 50);
            this.HistoryGridView.Margin = new System.Windows.Forms.Padding(4);
            this.HistoryGridView.Name = "HistoryGridView";
            this.HistoryGridView.RowHeadersWidth = 82;
            this.HistoryGridView.RowTemplate.Height = 33;
            this.HistoryGridView.Size = new System.Drawing.Size(1549, 732);
            this.HistoryGridView.TabIndex = 2;
            // 
            // VerbindungPanel
            // 
            this.VerbindungPanel.Controls.Add(this.ConnectionGridView);
            this.VerbindungPanel.Controls.Add(this.tableLayoutPanel3);
            this.VerbindungPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VerbindungPanel.Location = new System.Drawing.Point(3, 3);
            this.VerbindungPanel.Margin = new System.Windows.Forms.Padding(6);
            this.VerbindungPanel.Name = "VerbindungPanel";
            this.VerbindungPanel.Size = new System.Drawing.Size(1549, 782);
            this.VerbindungPanel.TabIndex = 4;
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
            this.ConnectionGridView.Location = new System.Drawing.Point(0, 50);
            this.ConnectionGridView.Margin = new System.Windows.Forms.Padding(6);
            this.ConnectionGridView.Name = "ConnectionGridView";
            this.ConnectionGridView.RowHeadersVisible = false;
            this.ConnectionGridView.RowHeadersWidth = 82;
            this.ConnectionGridView.Size = new System.Drawing.Size(1549, 732);
            this.ConnectionGridView.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.button3, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtVonSuchfeld, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtNachSuchfeld, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1549, 50);
            this.tableLayoutPanel3.TabIndex = 0;
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
            this.label5.Location = new System.Drawing.Point(696, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nach:";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.Location = new System.Drawing.Point(1388, 4);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 42);
            this.button3.TabIndex = 4;
            this.button3.Text = "Suchen";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.OnSuchen_Click);
            // 
            // txtVonSuchfeld
            // 
            this.txtVonSuchfeld.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVonSuchfeld.Location = new System.Drawing.Point(84, 9);
            this.txtVonSuchfeld.Margin = new System.Windows.Forms.Padding(4);
            this.txtVonSuchfeld.Name = "txtVonSuchfeld";
            this.txtVonSuchfeld.Size = new System.Drawing.Size(602, 31);
            this.txtVonSuchfeld.TabIndex = 5;
            this.txtVonSuchfeld.TextChanged += new System.EventHandler(this.OnSuchfeld_TextChanged);
            // 
            // txtNachSuchfeld
            // 
            this.txtNachSuchfeld.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNachSuchfeld.Location = new System.Drawing.Point(778, 9);
            this.txtNachSuchfeld.Margin = new System.Windows.Forms.Padding(4);
            this.txtNachSuchfeld.Name = "txtNachSuchfeld";
            this.txtNachSuchfeld.Size = new System.Drawing.Size(602, 31);
            this.txtNachSuchfeld.TabIndex = 6;
            this.txtNachSuchfeld.TextChanged += new System.EventHandler(this.OnSuchfeld_TextChanged);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.VerbindungsTab);
            this.tabControl.Controls.Add(this.StationenTab);
            this.tabControl.Location = new System.Drawing.Point(29, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1571, 835);
            this.tabControl.TabIndex = 5;
            // 
            // VerbindungsTab
            // 
            this.VerbindungsTab.Controls.Add(this.VerbindungPanel);
            this.VerbindungsTab.Location = new System.Drawing.Point(8, 39);
            this.VerbindungsTab.Name = "VerbindungsTab";
            this.VerbindungsTab.Padding = new System.Windows.Forms.Padding(3);
            this.VerbindungsTab.Size = new System.Drawing.Size(1555, 788);
            this.VerbindungsTab.TabIndex = 0;
            this.VerbindungsTab.Text = "Verbindungen";
            this.VerbindungsTab.UseVisualStyleBackColor = true;
            // 
            // StationenTab
            // 
            this.StationenTab.Controls.Add(this.HauptPanel);
            this.StationenTab.Controls.Add(this.label1);
            this.StationenTab.Location = new System.Drawing.Point(8, 39);
            this.StationenTab.Name = "StationenTab";
            this.StationenTab.Padding = new System.Windows.Forms.Padding(3);
            this.StationenTab.Size = new System.Drawing.Size(1555, 788);
            this.StationenTab.TabIndex = 1;
            this.StationenTab.Text = "Stationen";
            this.StationenTab.UseVisualStyleBackColor = true;
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
            // Fahrplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1673, 902);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(862, 400);
            this.Name = "Fahrplan";
            this.Text = "Fahrplan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.HauptPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HistoryGridView)).EndInit();
            this.VerbindungPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionGridView)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.VerbindungsTab.ResumeLayout(false);
            this.StationenTab.ResumeLayout(false);
            this.StationenTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtStation;
        private System.Windows.Forms.Button HauptSuchen;
        private System.Windows.Forms.Label lblHauptVon;
        private System.Windows.Forms.Panel HauptPanel;
        private System.Windows.Forms.DataGridView HistoryGridView;
        private System.Windows.Forms.Panel VerbindungPanel;
        private System.Windows.Forms.DataGridView ConnectionGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtVonSuchfeld;
        private System.Windows.Forms.TextBox txtNachSuchfeld;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage VerbindungsTab;
        private System.Windows.Forms.TabPage StationenTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Von;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bus_Zug;
        private System.Windows.Forms.DataGridViewTextBoxColumn Durration;
    }
}

