﻿namespace Fahrplan_
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
            this.Stationsname = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel1.Controls.Add(this.txtVonSuchfeld, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.HauptSuchen, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNachSuchfeld, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(342, 26);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // txtVonSuchfeld
            // 
            this.txtVonSuchfeld.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVonSuchfeld.Location = new System.Drawing.Point(42, 3);
            this.txtVonSuchfeld.Margin = new System.Windows.Forms.Padding(2);
            this.txtVonSuchfeld.Name = "txtVonSuchfeld";
            this.txtVonSuchfeld.Size = new System.Drawing.Size(88, 20);
            this.txtVonSuchfeld.TabIndex = 0;
            this.txtVonSuchfeld.Click += new System.EventHandler(this.OnSuchfeld_Click);
            // 
            // HauptSuchen
            // 
            this.HauptSuchen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HauptSuchen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HauptSuchen.Location = new System.Drawing.Point(266, 2);
            this.HauptSuchen.Margin = new System.Windows.Forms.Padding(2);
            this.HauptSuchen.Name = "HauptSuchen";
            this.HauptSuchen.Size = new System.Drawing.Size(74, 22);
            this.HauptSuchen.TabIndex = 2;
            this.HauptSuchen.Text = "Suchen";
            this.HauptSuchen.UseVisualStyleBackColor = true;
            this.HauptSuchen.Click += new System.EventHandler(this.OnSuchen_Click);
            // 
            // txtNachSuchfeld
            // 
            this.txtNachSuchfeld.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNachSuchfeld.Location = new System.Drawing.Point(174, 3);
            this.txtNachSuchfeld.Margin = new System.Windows.Forms.Padding(2);
            this.txtNachSuchfeld.Name = "txtNachSuchfeld";
            this.txtNachSuchfeld.Size = new System.Drawing.Size(88, 20);
            this.txtNachSuchfeld.TabIndex = 1;
            this.txtNachSuchfeld.Click += new System.EventHandler(this.OnSuchfeld_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Von:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nach:";
            // 
            // HauptPanel
            // 
            this.HauptPanel.AutoSize = true;
            this.HauptPanel.Controls.Add(this.HistoryGridView);
            this.HauptPanel.Controls.Add(this.tableLayoutPanel1);
            this.HauptPanel.Location = new System.Drawing.Point(6, 6);
            this.HauptPanel.Margin = new System.Windows.Forms.Padding(2);
            this.HauptPanel.Name = "HauptPanel";
            this.HauptPanel.Size = new System.Drawing.Size(342, 195);
            this.HauptPanel.TabIndex = 2;
            // 
            // HistoryGridView
            // 
            this.HistoryGridView.AllowUserToOrderColumns = true;
            this.HistoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HistoryGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HistoryGridView.Location = new System.Drawing.Point(0, 26);
            this.HistoryGridView.Margin = new System.Windows.Forms.Padding(2);
            this.HistoryGridView.Name = "HistoryGridView";
            this.HistoryGridView.RowHeadersWidth = 82;
            this.HistoryGridView.RowTemplate.Height = 33;
            this.HistoryGridView.Size = new System.Drawing.Size(342, 169);
            this.HistoryGridView.TabIndex = 2;
            // 
            // SuchfeldPanel
            // 
            this.SuchfeldPanel.Controls.Add(this.StationGridView);
            this.SuchfeldPanel.Controls.Add(this.tableLayoutPanel2);
            this.SuchfeldPanel.Enabled = false;
            this.SuchfeldPanel.Location = new System.Drawing.Point(364, 6);
            this.SuchfeldPanel.Margin = new System.Windows.Forms.Padding(2);
            this.SuchfeldPanel.Name = "SuchfeldPanel";
            this.SuchfeldPanel.Size = new System.Drawing.Size(376, 195);
            this.SuchfeldPanel.TabIndex = 3;
            this.SuchfeldPanel.Visible = false;
            // 
            // StationGridView
            // 
            this.StationGridView.AllowUserToOrderColumns = true;
            this.StationGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StationGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Stationsname});
            this.StationGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StationGridView.Location = new System.Drawing.Point(0, 26);
            this.StationGridView.Margin = new System.Windows.Forms.Padding(2);
            this.StationGridView.Name = "StationGridView";
            this.StationGridView.RowHeadersVisible = false;
            this.StationGridView.RowHeadersWidth = 82;
            this.StationGridView.RowTemplate.Height = 33;
            this.StationGridView.Size = new System.Drawing.Size(376, 169);
            this.StationGridView.TabIndex = 1;
            this.StationGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StationGridView_CellContentClick);
            // 
            // Stationsname
            // 
            this.Stationsname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Stationsname.FillWeight = 50F;
            this.Stationsname.HeaderText = "Name";
            this.Stationsname.MinimumWidth = 10;
            this.Stationsname.Name = "Stationsname";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel2.Controls.Add(this.lblSuchfeldVonNach, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.SuchfeldAbbrechen, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtStationSuche, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(376, 26);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblSuchfeldVonNach
            // 
            this.lblSuchfeldVonNach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSuchfeldVonNach.AutoSize = true;
            this.lblSuchfeldVonNach.Location = new System.Drawing.Point(6, 6);
            this.lblSuchfeldVonNach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSuchfeldVonNach.Name = "lblSuchfeldVonNach";
            this.lblSuchfeldVonNach.Size = new System.Drawing.Size(28, 13);
            this.lblSuchfeldVonNach.TabIndex = 0;
            this.lblSuchfeldVonNach.Text = "auto";
            // 
            // SuchfeldAbbrechen
            // 
            this.SuchfeldAbbrechen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SuchfeldAbbrechen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SuchfeldAbbrechen.Location = new System.Drawing.Point(303, 2);
            this.SuchfeldAbbrechen.Margin = new System.Windows.Forms.Padding(2);
            this.SuchfeldAbbrechen.Name = "SuchfeldAbbrechen";
            this.SuchfeldAbbrechen.Size = new System.Drawing.Size(71, 22);
            this.SuchfeldAbbrechen.TabIndex = 3;
            this.SuchfeldAbbrechen.Text = "Abbrechen";
            this.SuchfeldAbbrechen.UseVisualStyleBackColor = true;
            this.SuchfeldAbbrechen.Click += new System.EventHandler(this.OnAbbrechen_Click);
            // 
            // txtStationSuche
            // 
            this.txtStationSuche.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStationSuche.Location = new System.Drawing.Point(42, 3);
            this.txtStationSuche.Margin = new System.Windows.Forms.Padding(2);
            this.txtStationSuche.Name = "txtStationSuche";
            this.txtStationSuche.Size = new System.Drawing.Size(257, 20);
            this.txtStationSuche.TabIndex = 4;
            this.txtStationSuche.TextChanged += new System.EventHandler(this.StationSuche_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 619);
            this.Controls.Add(this.SuchfeldPanel);
            this.Controls.Add(this.HauptPanel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MinimumSize = new System.Drawing.Size(373, 206);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Stationsname;
    }
}
