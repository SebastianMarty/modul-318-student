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

        private void OnSuchfeld_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            var stations = m_Transport.GetStations(tb.Text);

            if (stations.StationList.Count > 0)
            {
                if (tb.Name == txtVonSuchfeld.Name)
                {
                    VonSuchfeldList.Items.Clear();
                    VonSuchfeldList.Visible = true;
                    foreach (var station in stations.StationList)
                    {
                        VonSuchfeldList.Items.Add(station.Name);
                    }
                }
                else if (tb.Name == txtNachSuchfeld.Name)
                {
                    NachSuchfeldList.Items.Clear();
                    NachSuchfeldList.Visible = true;
                    foreach (var station in stations.StationList)
                    {
                        NachSuchfeldList.Items.Add(station.Name);
                    }
                }
                else if (tb.Name == txtStationen.Name)
                {
                    StationenList.Items.Clear();
                    StationenList.Visible = true;
                    foreach (var station in stations.StationList)
                    {
                        StationenList.Items.Add(station.Name);
                    }
                }
                else if (tb.Name == txtKartenStation.Name)
                {
                    KartenList.Items.Clear();
                    KartenList.Visible = true;
                    foreach (var station in stations.StationList)
                    {
                        KartenList.Items.Add(station.Name);
                    }
                }
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
        }

        private void OnList_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                ListBox lb = sender as ListBox;
                if (lb.Name == VonSuchfeldList.Name)
                {
                    txtVonSuchfeld.Text = lb.SelectedItem.ToString();
                    VonSuchfeldList.Visible = false;
                }
                else if (lb.Name == NachSuchfeldList.Name)
                {
                    txtNachSuchfeld.Text = lb.SelectedItem.ToString();
                    NachSuchfeldList.Visible = false;
                }
                else if (lb.Name == StationenList.Name)
                {
                    txtStationen.Text = lb.SelectedItem.ToString();
                    StationenList.Visible = false;
                }
                else if (lb.Name == KartenList.Name)
                {
                    txtKartenStation.Text = lb.SelectedItem.ToString();
                    KartenList.Visible = false;
                    
                    var ort = txtKartenStation.Text;
                    var stations = m_Transport.GetStations(txtKartenStation.Text);

                    foreach (var station in stations.StationList)
                    {
                        if (station.Name == ort)
                        {
                            var YCoordinate = station.Coordinate.YCoordinate;
                            var XCoordinate = station.Coordinate.XCoordinate;

                            if (XCoordinate == 0 || YCoordinate == 0)
                            {
                                MessageBox.Show("Dieser Ort kann leider nicht angezeigt werden, bitte wählen Sie einen anderen.");
                                break;
                            }
                            var BingMapsUrl = $"http://bing.com/maps/default.aspx?cp={XCoordinate}~{YCoordinate}&lvl=20";
                            KartenBrowser.Navigate(BingMapsUrl);
                        }
                        
                    }
                }
            }
        }
    }
}
