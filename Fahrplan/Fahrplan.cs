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
            try
            {
                TextBox tb = sender as TextBox;
                var stations = m_Transport.GetStations(tb.Text);

                //Überprüfen, ob Stationen geladen wurden und dann überprüfen, welche Textbox verwendet wird.
                //Alle Vorschläge der gesuchten Station sollen in die zugehörige Listbox geladen werden.
                //Die Listboxen werden bei Auswahl der zugehörigen Textbox eingeblendet.
                //Zuerst werden die Listboxen geleert, damit nur gewünschte Suchergebnisse angezeigt werden.
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
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nUngültige Eingabe", "Error", MessageBoxButtons.OK);
            }
        }

        private void OnSuchen_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            //Überprüfen, welcher Button gedrückt wurde
            if (btn.Name == btn_VerbindungenSuchen.Name)
            {
                //Zuerst wird die Data-Grid-View geleert, damit nur gewünschte Suchergebnisse angezeigt werden.
                ConnectionGridView.Rows.Clear();

                //Die gewünschte Station von den "Von" und "Nach" Suchfeldern werden in lokale Variablen gespeichert und es wird eine neue Liste erstellt mit den gesuchten Verbindungen.
                string nummer = "";
                string VonStation = txtVonSuchfeld.Text;
                string NachStation = txtNachSuchfeld.Text;

                //Die Suche darf nicht leer sein, ansonsten wird der user darüber informiert.
                if (VonStation != "" && NachStation != "")
                {
                    var connection = m_Transport.GetConnections(VonStation, NachStation).ConnectionList;

                    //Jedes element in connention wird durchgegangen und die gewünschten Werte werden der Data-Grid-View hinzugefügt.
                    foreach (var item in connection)
                    {
                        var stationBoard = m_Transport.GetStationBoard(item.To.Station.Name, item.To.Station.Id);

                        //Bus- und Zug-Nummern werden an den String nummer übergeben.
                        nummer = stationBoard.Entries.FirstOrDefault().Number;

                        //Das Date-Time von GetDeparture und GetArrival werden im Format Stunden und Minuten ausgegeben.
                        ConnectionGridView.Rows.Add(item.From.Station.Name,
                                                item.From.GetDeparture().ToString("HH:mm"),
                                                item.To.Station.Name,
                                                item.To.GetArrival().ToString("HH:mm"),
                                                nummer,
                                                item.Duration);
                    }
                }
                else
                {
                    MessageBox.Show("Die Suchfelder dürfen nicht leer sein. Bitte suchen sie nach einer Start- und End-Station", "Fehler", MessageBoxButtons.OK);
                }
            }
            else if (btn.Name == btn_StationenSuchen.Name)
            {
                //Zuerst wird die Data-Grid-View geleert, damit nur gewünschte Suchergebnisse angezeigt werden.
                StationenGridView.Rows.Clear();

                //Die gewünschte Station und eine Liste der passenden Stationen werden in lokalen Variablen gespeichert.
                string StationSuche = txtStationen.Text;
                
                //Die Suche darf nicht leer sein, ansonsten wird der user darüber informiert.
                if (StationSuche != "")
                {
                    var stationBoard = m_Transport.GetStationBoard(StationSuche, "");

                    //Jeder Eintrag in stationBoard.Entries wird durchgegangen und in der Data-Grid-View ausgegeben.
                    foreach (var entry in stationBoard.Entries)
                    {
                        StationenGridView.Rows.Add(stationBoard.Station.Name, entry.Number, entry.Stop.Departure, entry.To);
                    }
                }
                else
                {
                    MessageBox.Show("Das Suchfeld darf nicht leer sein. Bitte suchen sie nach einer Station", "Fehler", MessageBoxButtons.OK);
                }
            }
        }

        private void OnList_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                ListBox lb = sender as ListBox;

                //Zuerst wird überprüft von welcher ListBox der Event aufgerufen wurde.
                //Dann soll die Selektion in der passenden TextBox angezeigt werden und die ListBox wird ausgeblendet.
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

                    //Es wird die passende Station zur Suche herausgesucht.
                    foreach (var station in stations.StationList)
                    {
                        if (station.Name == ort)
                        {
                            //Koordinaten der ausgewählten Station in lokale Variablen Speichern.
                            var YCoordinate = station.Coordinate.YCoordinate;
                            var XCoordinate = station.Coordinate.XCoordinate;

                            //Wenn eine der Koordinaten 0 ist kann der Ort auf der Karte nicht angezeigt werden.
                            if (XCoordinate == 0 || YCoordinate == 0)
                            {
                                MessageBox.Show("Dieser Ort kann leider nicht angezeigt werden, bitte wählen Sie einen anderen aus.", "Fehler", MessageBoxButtons.OK);
                                break;
                            }
                            //Die Werte der 2 Koordinaten Variablen an die URL übergeben und den Ort im Web-Browser-Element anzeigen lassen.
                            var BingMapsUrl = $"http://bing.com/maps/default.aspx?cp={XCoordinate}~{YCoordinate}&lvl=20";
                            KartenBrowser.Navigate(BingMapsUrl);
                        }
                    }
                }
            }
        }
    }
}
