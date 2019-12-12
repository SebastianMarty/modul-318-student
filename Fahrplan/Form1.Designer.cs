namespace Fahrplan_
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HauptPanel = new System.Windows.Forms.Panel();
            this.HistoryGridView = new System.Windows.Forms.DataGridView();
            this.SuchfeldPanel = new System.Windows.Forms.Panel();
            this.StationGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSuchfeldVonNach = new System.Windows.Forms.Label();
            this.SuchfeldAbbrechen = new System.Windows.Forms.Button();
            this.txtStationSuche = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.HauptPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryGridView)).BeginInit();
            this.SuchfeldPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StationGridView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 31);
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tableLayoutPanel1.Controls.Add(this.txtVonSuchfeld, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.HauptSuchen, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNachSuchfeld, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(684, 50);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // txtVonSuchfeld
            // 
            this.txtVonSuchfeld.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVonSuchfeld.Location = new System.Drawing.Point(83, 9);
            this.txtVonSuchfeld.Name = "txtVonSuchfeld";
            this.txtVonSuchfeld.Size = new System.Drawing.Size(179, 31);
            this.txtVonSuchfeld.TabIndex = 0;
            this.txtVonSuchfeld.Click += new System.EventHandler(this.OnSuchfeld_Click);
            // 
            // HauptSuchen
            // 
            this.HauptSuchen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HauptSuchen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HauptSuchen.Location = new System.Drawing.Point(533, 3);
            this.HauptSuchen.Name = "HauptSuchen";
            this.HauptSuchen.Size = new System.Drawing.Size(148, 44);
            this.HauptSuchen.TabIndex = 2;
            this.HauptSuchen.Text = "Suchen";
            this.HauptSuchen.UseVisualStyleBackColor = true;
            this.HauptSuchen.Click += new System.EventHandler(this.OnSuchen_Click);
            // 
            // txtNachSuchfeld
            // 
            this.txtNachSuchfeld.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNachSuchfeld.Location = new System.Drawing.Point(348, 9);
            this.txtNachSuchfeld.Name = "txtNachSuchfeld";
            this.txtNachSuchfeld.Size = new System.Drawing.Size(179, 31);
            this.txtNachSuchfeld.TabIndex = 1;
            this.txtNachSuchfeld.Click += new System.EventHandler(this.OnSuchfeld_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Von:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nach:";
            // 
            // HauptPanel
            // 
            this.HauptPanel.AutoSize = true;
            this.HauptPanel.Controls.Add(this.HistoryGridView);
            this.HauptPanel.Controls.Add(this.tableLayoutPanel1);
            this.HauptPanel.Location = new System.Drawing.Point(12, 12);
            this.HauptPanel.Name = "HauptPanel";
            this.HauptPanel.Size = new System.Drawing.Size(684, 375);
            this.HauptPanel.TabIndex = 2;
            // 
            // HistoryGridView
            // 
            this.HistoryGridView.AllowUserToOrderColumns = true;
            this.HistoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HistoryGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HistoryGridView.Location = new System.Drawing.Point(0, 50);
            this.HistoryGridView.Name = "HistoryGridView";
            this.HistoryGridView.RowHeadersWidth = 82;
            this.HistoryGridView.RowTemplate.Height = 33;
            this.HistoryGridView.Size = new System.Drawing.Size(684, 325);
            this.HistoryGridView.TabIndex = 2;
            // 
            // SuchfeldPanel
            // 
            this.SuchfeldPanel.Controls.Add(this.StationGridView);
            this.SuchfeldPanel.Controls.Add(this.tableLayoutPanel2);
            this.SuchfeldPanel.Enabled = false;
            this.SuchfeldPanel.Location = new System.Drawing.Point(727, 12);
            this.SuchfeldPanel.Name = "SuchfeldPanel";
            this.SuchfeldPanel.Size = new System.Drawing.Size(751, 375);
            this.SuchfeldPanel.TabIndex = 3;
            this.SuchfeldPanel.Visible = false;
            // 
            // StationGridView
            // 
            this.StationGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StationGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StationGridView.Location = new System.Drawing.Point(0, 50);
            this.StationGridView.Name = "StationGridView";
            this.StationGridView.RowHeadersWidth = 82;
            this.StationGridView.RowTemplate.Height = 33;
            this.StationGridView.Size = new System.Drawing.Size(751, 325);
            this.StationGridView.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.Controls.Add(this.lblSuchfeldVonNach, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.SuchfeldAbbrechen, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtStationSuche, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(751, 50);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblSuchfeldVonNach
            // 
            this.lblSuchfeldVonNach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSuchfeldVonNach.AutoSize = true;
            this.lblSuchfeldVonNach.Location = new System.Drawing.Point(13, 12);
            this.lblSuchfeldVonNach.Name = "lblSuchfeldVonNach";
            this.lblSuchfeldVonNach.Size = new System.Drawing.Size(54, 25);
            this.lblSuchfeldVonNach.TabIndex = 0;
            this.lblSuchfeldVonNach.Text = "auto";
            // 
            // SuchfeldAbbrechen
            // 
            this.SuchfeldAbbrechen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SuchfeldAbbrechen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SuchfeldAbbrechen.Location = new System.Drawing.Point(604, 3);
            this.SuchfeldAbbrechen.Name = "SuchfeldAbbrechen";
            this.SuchfeldAbbrechen.Size = new System.Drawing.Size(144, 44);
            this.SuchfeldAbbrechen.TabIndex = 3;
            this.SuchfeldAbbrechen.Text = "Abbrechen";
            this.SuchfeldAbbrechen.UseVisualStyleBackColor = true;
            this.SuchfeldAbbrechen.Click += new System.EventHandler(this.OnAbbrechen_Click);
            // 
            // txtStationSuche
            // 
            this.txtStationSuche.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStationSuche.Location = new System.Drawing.Point(83, 9);
            this.txtStationSuche.Name = "txtStationSuche";
            this.txtStationSuche.Size = new System.Drawing.Size(515, 31);
            this.txtStationSuche.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2173, 1190);
            this.Controls.Add(this.SuchfeldPanel);
            this.Controls.Add(this.HauptPanel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(730, 360);
            this.Name = "Form1";
            this.Text = "Fahrplan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.HauptPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HistoryGridView)).EndInit();
            this.SuchfeldPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StationGridView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtVonSuchfeld;
        private System.Windows.Forms.Button HauptSuchen;
        private System.Windows.Forms.TextBox txtNachSuchfeld;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel HauptPanel;
        private System.Windows.Forms.DataGridView HistoryGridView;
        private System.Windows.Forms.Panel SuchfeldPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblSuchfeldVonNach;
        private System.Windows.Forms.TextBox txtStationSuche;
        private System.Windows.Forms.Button SuchfeldAbbrechen;
        private System.Windows.Forms.DataGridView StationGridView;
    }
}

