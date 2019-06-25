using System;
using System.Collections.Generic;

namespace RazorPagesChart.Model
{
    public partial class AverageIntensity
    {
        public int RoadSegmentId { get; set; }
        public double Intensity { get; set; }
        public double Temperature { get; set; }
        public double Pressure { get; set; }
        public double Humidity { get; set; }
        public int Visibility { get; set; }
        public double WindSpeed { get; set; }
        public double WindDeg { get; set; }
        public DateTime AverageMeasurementTime { get; set; }
        public int Id { get; set; }
    }
}
