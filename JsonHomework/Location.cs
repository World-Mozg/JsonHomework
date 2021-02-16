using System;
using System.Collections.Generic;
using System.Text;

namespace JsonHomework
{
    class Location
    {
        public string name { get; set; }
        public string country { get; set; }
        public string region { get; set; }
        public double lat { get; set; }
        public double lon { get; set; }
        public string timeZoneId { get; set; }
        public DateTime localTime { get; set; }
        public int localTimeEpoch { get; set; }
        public double UTCOffset { get; set; }
    }
}
