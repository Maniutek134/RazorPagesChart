using System;
using System.Collections.Generic;

namespace RazorPagesChart.Model
{
    public partial class Intensity
    {
        public int Id { get; set; }
        public int RoadSegmentId { get; set; }
        public float Intenstiy { get; set; }
        public DateTime MeasureTime { get; set; }
        public int? DbTemperatureid { get; set; }

        public virtual WeatherCondition DbTemperature { get; set; }
    }
}
