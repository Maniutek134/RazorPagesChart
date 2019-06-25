using System;
using System.Collections.Generic;

namespace RazorPagesChart.Model
{
    public partial class WeatherCondition
    {
        public WeatherCondition()
        {
            Intensity = new HashSet<Intensity>();
        }

        public int Id { get; set; }
        public float Temperature { get; set; }
        public float Pressure { get; set; }
        public float Humidity { get; set; }
        public int Visibility { get; set; }
        public float WindSpeed { get; set; }
        public float WindDeg { get; set; }
        public DateTime MeasureTime { get; set; }

        public virtual ICollection<Intensity> Intensity { get; set; }
    }
}
