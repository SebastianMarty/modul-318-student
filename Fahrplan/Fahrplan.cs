using SwissTransport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Fahrplan_
{
    public partial class Fahrplan : Form
    {
        private Transport m_Transport = new Transport();

        public Fahrplan()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OnSuchfeld_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            tb.AutoCompleteSource = AutoCompleteSource.None;
            tb.AutoCompleteMode = AutoCompleteMode.Suggest;
            var stations = m_Transport.GetStations(tb.Text);

            if (stations.StationList.Count > 0)
            {
                tb.AutoCompleteSource = AutoCompleteSource.CustomSource;

                AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
                foreach (var station in stations.StationList)
                {
                    collection.Add(station.Name);
                }

                tb.AutoCompleteCustomSource = collection;
            }
        }

        private void OnSuchen_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Name == btn_VerbindungenSuchen.Name)
            {
                ConnectionGridView.Rows.Clear();

                string nummer = "";
                string VonStation = txtVonSuchfeld.Text;
                string NachStation = txtNachSuchfeld.Text;
                var connection = m_Transport.GetConnections(VonStation, NachStation).ConnectionList;

                foreach (var item in connection)
                {
                    var stationBoard = m_Transport.GetStationBoard(item.To.Station.Name, item.To.Station.Id);

                    nummer = stationBoard.Entries.FirstOrDefault().Number;

                    ConnectionGridView.Rows.Add(item.From.Station.Name,
                                            item.From.GetDeparture().ToString("HH:mm"),
                                            item.To.Station.Name,
                                            item.To.GetArrival().ToString("HH:mm"),
                                            nummer,
                                            item.Duration);
                }
            }
            else if (btn.Name == btn_StationenSuchen.Name)
            {
                StationenGridView.Rows.Clear();

                string StationSuche = txtStationen.Text;
                var stationBoard = m_Transport.GetStationBoard(StationSuche, "");

                foreach (var entry in stationBoard.Entries)
                {
                        StationenGridView.Rows.Add(stationBoard.Station.Name, entry.Number, entry.Stop.Departure, entry.To);
                }
            }
            //else if(btn.Name == button1.Name)
            //{
            //    dataGridView1.Rows.Clear();
            //}
        }
    }
}
