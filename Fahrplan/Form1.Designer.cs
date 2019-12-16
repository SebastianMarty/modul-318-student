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
            this.txtVonSuchfeld = new System.Windows.Forms.TextBox();
            this.HauptSuchen = new System.Windows.Forms.Button();
            this.txtNachSuchfeld = new System.Windows.Forms.TextBox();
            this.lblHauptVon = new System.Windows.Forms.Label();
            this.lblHauptNach = new System.Windows.Forms.Label();
            this.HauptPanel = new System.Windows.Forms.Panel();
            this.HistoryGridView = new System.Windows.Forms.DataGridView();
            this.VerbindungPanel = new System.Windows.Forms.Panel();
            this.ConnectionGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtVon = new System.Windows.Forms.TextBox();
            this.txtNach = new System.Windows.Forms.TextBox();
            this.Von = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Durration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.HauptPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryGridView)).BeginInit();
            this.VerbindungPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionGridView)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel1.Controls.Add(this.txtVonSuchfeld, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.HauptSuchen, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNachSuchfeld, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblHauptVon, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblHauptNach, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(456, 32);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // txtVonSuchfeld
            // 
            this.txtVonSuchfeld.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVonSuchfeld.Location = new System.Drawing.Point(56, 5);
            this.txtVonSuchfeld.Name = "txtVonSuchfeld";
            this.txtVonSuchfeld.Size = new System.Drawing.Size(115, 22);
            this.txtVonSuchfeld.TabIndex = 0;
            this.txtVonSuchfeld.TextChanged += new System.EventHandler(this.OnSuchfeld_TextChanged);
            // 
            // HauptSuchen
            // 
            this.HauptSuchen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HauptSuchen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HauptSuchen.Location = new System.Drawing.Point(351, 3);
            this.HauptSuchen.Name = "HauptSuchen";
            this.HauptSuchen.Size = new System.Drawing.Size(102, 26);
            this.HauptSuchen.TabIndex = 2;
            this.HauptSuchen.Text = "Suchen";
            this.HauptSuchen.UseVisualStyleBackColor = true;
            this.HauptSuchen.Click += new System.EventHandler(this.OnSuchen_Click);
            // 
            // txtNachSuchfeld
            // 
            this.txtNachSuchfeld.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNachSuchfeld.Location = new System.Drawing.Point(230, 5);
            this.txtNachSuchfeld.Name = "txtNachSuchfeld";
            this.txtNachSuchfeld.Size = new System.Drawing.Size(115, 22);
            this.txtNachSuchfeld.TabIndex = 1;
            this.txtNachSuchfeld.TextChanged += new System.EventHandler(this.OnSuchfeld_TextChanged);
            // 
            // lblHauptVon
            // 
            this.lblHauptVon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHauptVon.AutoSize = true;
            this.lblHauptVon.Location = new System.Drawing.Point(8, 7);
            this.lblHauptVon.Name = "lblHauptVon";
            this.lblHauptVon.Size = new System.Drawing.Size(37, 17);
            this.lblHauptVon.TabIndex = 0;
            this.lblHauptVon.Text = "Von:";
            // 
            // lblHauptNach
            // 
            this.lblHauptNach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHauptNach.AutoSize = true;
            this.lblHauptNach.Location = new System.Drawing.Point(178, 7);
            this.lblHauptNach.Name = "lblHauptNach";
            this.lblHauptNach.Size = new System.Drawing.Size(45, 17);
            this.lblHauptNach.TabIndex = 4;
            this.lblHauptNach.Text = "Nach:";
            // 
            // HauptPanel
            // 
            this.HauptPanel.AutoSize = true;
            this.HauptPanel.Controls.Add(this.HistoryGridView);
            this.HauptPanel.Controls.Add(this.tableLayoutPanel1);
            this.HauptPanel.Location = new System.Drawing.Point(8, 8);
            this.HauptPanel.Name = "HauptPanel";
            this.HauptPanel.Size = new System.Drawing.Size(456, 240);
            this.HauptPanel.TabIndex = 2;
            // 
            // HistoryGridView
            // 
            this.HistoryGridView.AllowUserToOrderColumns = true;
            this.HistoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HistoryGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HistoryGridView.Location = new System.Drawing.Point(0, 32);
            this.HistoryGridView.Name = "HistoryGridView";
            this.HistoryGridView.RowHeadersWidth = 82;
            this.HistoryGridView.RowTemplate.Height = 33;
            this.HistoryGridView.Size = new System.Drawing.Size(456, 208);
            this.HistoryGridView.TabIndex = 2;
            // 
            // VerbindungPanel
            // 
            this.VerbindungPanel.Controls.Add(this.ConnectionGridView);
            this.VerbindungPanel.Controls.Add(this.tableLayoutPanel3);
            this.VerbindungPanel.Enabled = false;
            this.VerbindungPanel.Location = new System.Drawing.Point(488, 8);
            this.VerbindungPanel.Margin = new System.Windows.Forms.Padding(4);
            this.VerbindungPanel.Name = "VerbindungPanel";
            this.VerbindungPanel.Size = new System.Drawing.Size(587, 240);
            this.VerbindungPanel.TabIndex = 4;
            this.VerbindungPanel.Visible = false;
            // 
            // ConnectionGridView
            // 
            this.ConnectionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConnectionGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Von,
            this.Departure,
            this.Nach,
            this.Arrival,
            this.Durration});
            this.ConnectionGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConnectionGridView.Location = new System.Drawing.Point(0, 32);
            this.ConnectionGridView.Margin = new System.Windows.Forms.Padding(4);
            this.ConnectionGridView.Name = "ConnectionGridView";
            this.ConnectionGridView.RowHeadersVisible = false;
            this.ConnectionGridView.RowHeadersWidth = 82;
            this.ConnectionGridView.Size = new System.Drawing.Size(587, 208);
            this.ConnectionGridView.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 7;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel3.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button2, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.button3, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtVon, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtNach, 4, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(587, 32);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Von:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nach:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(4, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Früher";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnFrueher_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(374, 4);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 24);
            this.button2.TabIndex = 3;
            this.button2.Text = "Später";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OnSpaeter_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.Location = new System.Drawing.Point(480, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 26);
            this.button3.TabIndex = 4;
            this.button3.Text = "Abbrechen";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtVon
            // 
            this.txtVon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVon.Location = new System.Drawing.Point(163, 5);
            this.txtVon.Name = "txtVon";
            this.txtVon.Size = new System.Drawing.Size(71, 22);
            this.txtVon.TabIndex = 5;
            // 
            // txtNach
            // 
            this.txtNach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNach.Location = new System.Drawing.Point(296, 5);
            this.txtNach.Name = "txtNach";
            this.txtNach.Size = new System.Drawing.Size(71, 22);
            this.txtNach.TabIndex = 6;
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
            // Durration
            // 
            this.Durration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Durration.HeaderText = "Dauer";
            this.Durration.MinimumWidth = 6;
            this.Durration.Name = "Durration";
            // 
            // Fahrplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 603);
            this.Controls.Add(this.VerbindungPanel);
            this.Controls.Add(this.HauptPanel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MinimumSize = new System.Drawing.Size(587, 289);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtVonSuchfeld;
        private System.Windows.Forms.Button HauptSuchen;
        private System.Windows.Forms.TextBox txtNachSuchfeld;
        private System.Windows.Forms.Label lblHauptVon;
        private System.Windows.Forms.Label lblHauptNach;
        private System.Windows.Forms.Panel HauptPanel;
        private System.Windows.Forms.DataGridView HistoryGridView;
        private System.Windows.Forms.Panel VerbindungPanel;
        private System.Windows.Forms.DataGridView ConnectionGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtVon;
        private System.Windows.Forms.TextBox txtNach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Von;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn Durration;
    }
}

