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
    public partial class Fahrplan : Form
    {
        private List<string> m_Auswahlmoeglichkeiten = new List<string>();
        private Transport m_Transport = new Transport();

        public Fahrplan()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HauptPanel.Dock = DockStyle.Fill;
            VerbindungPanel.Dock = DockStyle.Fill;
        }

        private void OnSuchfeld_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.AutoCompleteSource = AutoCompleteSource.None;
            tb.AutoCompleteMode = AutoCompleteMode.Suggest;
            var stations = m_Transport.GetStations(tb.Text);

            if (stations.StationList.Count > 0)
            {
                tb.AutoCompleteSource = AutoCompleteSource.CustomSource;

                AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
                foreach(var station in stations.StationList)
                {
                    collection.Add(station.Name);
                }

                tb.AutoCompleteCustomSource = collection;
            }
        }

        private void OnSuchen_Click(object sender, EventArgs e)
        {
            string VonStation = txtVonSuchfeld.Text;
            string NachStation = txtNachSuchfeld.Text;

            var connection = m_Transport.GetConnections(VonStation, NachStation);

            foreach(var item in connection.ConnectionList)
            {
                ConnectionGridView.Rows.Add(item.From.Station.Name,
                                            item.From.GetDeparture(),
                                            item.To.Station.Name,
                                            item.To.GetArrival(),
                                            item.Duration);
            }

            txtVon.Text = VonStation;
            txtNach.Text = NachStation;

            ZuVerbindung();
        }

        private void OnAbbrechen_Click(object sender, EventArgs e)
        {
            ZuHaupt();
        }

        public void ZuHaupt()
        {
            VerbindungPanel.Enabled = false;
            VerbindungPanel.Visible = false;
            HauptPanel.Enabled = true;
            HauptPanel.Visible = true;
        }

        public void ZuVerbindung()
        {
            HauptPanel.Enabled = false;
            HauptPanel.Visible = false;
            VerbindungPanel.Enabled = true;
            VerbindungPanel.Visible = true;
        }

        private void OnFrueher_Click(object sender, EventArgs e)
        {

        }

        private void OnSpaeter_Click(object sender, EventArgs e)
        {

        }
    }
}
