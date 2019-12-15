using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace Fahrplan_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HauptPanel.Dock = DockStyle.Fill;
            SuchfeldPanel.Dock = DockStyle.Fill;
        }

        private void OnSuchen_Click(object sender, EventArgs e)
        {

        }

        private void OnSuchfeld_Click(object sender, EventArgs e)
        {
            ZuSuchfeld();

            TextBox tb = sender as TextBox;

            if (tb.Name == "txtVonSuchfeld")
            {
                lblSuchfeldVonNach.Text = "Von:";
            }
            else if (tb.Name == "txtNachSuchfeld")
            {
                lblSuchfeldVonNach.Text = "Nach:";
            }
        }

        private void OnAbbrechen_Click(object sender, EventArgs e)
        {
            ZuHaupt();
        }

        private void StationSuche_TextChanged(object sender, EventArgs e)
        {
            Transport transport = new Transport();

            StationGridView.Rows.Clear();
            foreach (var station in transport.GetStations(txtStationSuche.Text).StationList)
            {
                StationGridView.Rows.Add(station.Name);
            }
        }

        private void StationGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedStation = StationGridView.CurrentCell.Value;

            if(lblSuchfeldVonNach.Text == "Von:")
            {
                txtVonSuchfeld.Text = selectedStation.ToString();
            }
            else if (lblSuchfeldVonNach.Text == "Nach:")
            {
                txtNachSuchfeld.Text = selectedStation.ToString();
            }

            ZuHaupt();
        }

        public void ZuHaupt()
        {
            SuchfeldPanel.Enabled = false;
            SuchfeldPanel.Visible = false;
            HauptPanel.Enabled = true;
            HauptPanel.Visible = true;
        }

        public void ZuSuchfeld()
        {
            HauptPanel.Enabled = false;
            HauptPanel.Visible = false;
            SuchfeldPanel.Enabled = true;
            SuchfeldPanel.Visible = true;
        }
    }
}
