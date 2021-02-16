using System;
using System.Collections.Generic;
using System.Text;

namespace JsonHomework
{
    class Current
    {
        public DateTime observationTime { get; set; }
        public int temperature { get; set; }
        public int weatherCode { get; set; }
        public string weatherIcons { get; set; }
        public string weatherDescriptions { get; set; }
        public int windSpeed { get; set; }
        public int windDegree { get; set; }
        public string windDirection { get; set; }
        public int pressure { get; set; }
        public int precip { get; set; }
        public int humidity { get; set; }
        public int cloudCover { get; set; }
        public int feelsLike { get; set; }
        public int UVIndex { get; set; }
        public int visibility { get; set; }
        public bool isDay { get; set; }
       
    }
}
