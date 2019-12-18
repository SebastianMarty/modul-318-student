using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SwissTransport
{
    public class Connections
    {
        [JsonProperty("connections")]
        public List<Connection> ConnectionList { get; set; } 
    }

    public class Connection
    {
        [JsonProperty("from")]
        public ConnectionPoint From  { get; set; }

        [JsonProperty("to")]
        public ConnectionPoint To { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }
    }

    public class ConnectionPoint
    {
        [JsonProperty("station")]
        public Station Station { get; set; }

        public string Arrival { get; set; }

        public string ArrivalTimestamp { get; set; }

        public string Departure { get; set; }

        public string DepartureTimestamp { get; set; }

        public int? Delay { get; set; }

        public string Platform { get; set; }

        public string RealtimeAvailability { get; set; }

        //Gibt die Abfahrtszeit als Date-Time zurück.
        public DateTime GetDeparture()
        {
            DateTime.TryParse(Departure, out var dateTime);
            return dateTime;
        }

        //Gibt die Ankunftszeit als Date-Time zurück.
        public DateTime GetArrival()
        {
            DateTime.TryParse(Arrival, out var dateTime);
            return dateTime;
        }
    }
}