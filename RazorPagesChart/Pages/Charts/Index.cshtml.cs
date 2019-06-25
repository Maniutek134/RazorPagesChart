using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesChart.Model;

namespace RazorPagesChart.Pages.Charts
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesChart.Model.DataBaseGdyniaContext _context;

        public IndexModel(RazorPagesChart.Model.DataBaseGdyniaContext context)
        {
            _context = context;
        }

        //public ActionResult Dashboard()
        //{
        //    var list = _context.Intensity.gelAll();
        //    List<int> repartitions = new List<int>();
        //    var time = list.Select(x => x.time);

        //}

        public IList<AverageIntensity> Intensity { get;set; }
        public SelectList RoadSegmentIds { get; set; }
        [BindProperty(SupportsGet = true)]
        public int RoadSegmentId { get; set; }

        public async Task OnGetAsync()
        {
            // Use LINQ to get list of roadSegmentIds.
            //IQueryable<int> genreQuery = from i in _context.Intensity
            //                                orderby i.RoadSegmentId
            //                                select i.RoadSegmentId;

            //List<int> rsList = await genreQuery.Distinct().ToListAsync();
            //RoadSegmentIds = new SelectList(rsList,rsList.Take(0));
            RoadSegmentIds = new SelectList(new List<int> { 31616, 30790, 32091, 31948, 31617, 31947, 32092, 32093, 32094, 32095 });

            var intensities = from i in _context.AverageIntensity
                              select i;

            intensities = intensities.Where(x => x.RoadSegmentId == RoadSegmentId).OrderBy(x => x.AverageMeasurementTime);
            

            Intensity = await intensities
            .ToListAsync();

            //Intensity = await intensities
            //.Include(i => i.DbTemperature)
            //.ToListAsync();

            initTempData(intensities);



            //ViewData["label"]= new List<String> { "January", "February", "March", "April", "May", "June", "July" };
            //ViewData["data"] = new List<int> { 0, 10, 5, 2, 20, 30, 45 };
        }

        private void initTempData(IQueryable<AverageIntensity> intensities)
        {
            ViewData["tempLabel"] = intensities.Select(x => x.AverageMeasurementTime);
            //ViewData["data"] = intensities.Select(x => x.Intensity);

            List<String> tempList1 = new List<string>();
            List<String> tempList2 = new List<string>();
            List<String> tempList3 = new List<string>();
            List<String> tempList4 = new List<string>();
            List<double> tempDataList1 = new List<double>();
            List<double> tempDataList2 = new List<double>();
            List<double> tempDataList3 = new List<double>();
            List<double> tempDataList4 = new List<double>();
            foreach (AverageIntensity intensity in intensities)
            {
                var temp = intensity.Temperature;

                if (temp >= 22)
                {
                    tempDataList1.Add(intensity.Intensity);
                    tempList1.Add("rgba(255, 99, 132, 1)");
                }
                else
                {
                    tempDataList1.Add(0);
                    tempList1.Add("rgba(255, 255, 255, 0.0)");
                }

                if (temp < 22 && temp >= 18)
                {
                    tempDataList2.Add(intensity.Intensity);
                    tempList2.Add("rgba(255, 159, 64, 1)");
                }
                else
                {
                    tempDataList2.Add(0);
                    tempList2.Add("rgba(255, 255, 255, 0.0)");
                }

                if (temp < 18 && temp >= 14)
                {
                    tempDataList3.Add(intensity.Intensity);
                    tempList3.Add("rgba(255, 205, 86, 1)");
                }
                else
                {
                    tempDataList3.Add(0);
                    tempList3.Add("rgba(255, 255, 255, 0.0)");
                }

                if (temp < 14)
                {
                    tempDataList4.Add(intensity.Intensity);
                    tempList4.Add("rgba(54, 162, 235, 1");
                }
                else
                {
                    tempDataList4.Add(0);
                    tempList4.Add("rgba(255, 255, 255, 0.0)");
                }
            }
            ViewData["tempData1"] = tempDataList1;
            ViewData["tempData2"] = tempDataList2;
            ViewData["tempData3"] = tempDataList3;
            ViewData["tempData4"] = tempDataList4;
            ViewData["temp1"] = tempList1;
            ViewData["temp2"] = tempList2;
            ViewData["temp3"] = tempList3;
            ViewData["temp4"] = tempList4;



            ViewData["presLabel"] = intensities.Select(x => x.AverageMeasurementTime);
            //ViewData["data"] = intensities.Select(x => x.Intensity);

            List<String> pressureList1 = new List<string>();
            List<String> pressureList2 = new List<string>();
            List<String> pressureList3 = new List<string>();
            List<double> pressureDataList1 = new List<double>();
            List<double> pressureDataList2 = new List<double>();
            List<double> pressureDataList3 = new List<double>();
            foreach (AverageIntensity intensity in intensities)
            {
                var temp = intensity.Pressure;

                if (temp >= 1015)
                {
                    pressureDataList1.Add(intensity.Intensity);
                    pressureList1.Add("rgba(255, 99, 132, 1)");
                }
                else
                {
                    pressureDataList1.Add(0);
                    pressureList1.Add("rgba(255, 255, 255, 0.0)");
                }

                if (temp < 1015 && temp >= 1000)
                {
                    pressureDataList2.Add(intensity.Intensity);
                    pressureList2.Add("rgba(6,204,113,1)");
                }
                else
                {
                    pressureDataList2.Add(0);
                    pressureList2.Add("rgba(255, 255, 255, 0.0)");
                }

                if (temp < 1000)
                {
                    pressureDataList3.Add(intensity.Intensity);
                    pressureList3.Add("rgba(255, 205, 86, 1)");
                }
                else
                {
                    pressureDataList3.Add(0);
                    pressureList3.Add("rgba(255, 255, 255, 0.0)");
                }


            }
            ViewData["presData1"] = pressureDataList1;
            ViewData["presData2"] = pressureDataList2;
            ViewData["presData3"] = pressureDataList3;
            ViewData["pres1"] = pressureList1;
            ViewData["pres2"] = pressureList2;
            ViewData["pres3"] = pressureList3;


            ViewData["humiLabel"] = intensities.Select(x => x.AverageMeasurementTime);
            //ViewData["data"] = intensities.Select(x => x.Intensity);

            List<String> humiList1 = new List<string>();
            List<String> humiList2 = new List<string>();
            List<String> humiList3 = new List<string>();
            List<double> humiDataList1 = new List<double>();
            List<double> humiDataList2 = new List<double>();
            List<double> humiDataList3 = new List<double>();
            foreach (AverageIntensity intensity in intensities)
            {
                var temp = intensity.Humidity;

                if (temp >= 80)
                {
                    humiDataList1.Add(intensity.Intensity);
                    humiList1.Add("rgba(255, 99, 132, 1)");
                }
                else
                {
                    humiDataList1.Add(0);
                    humiList1.Add("rgba(255, 255, 255, 0.0)");
                }

                if (temp < 80 && temp >= 50)
                {
                    humiDataList2.Add(intensity.Intensity);
                    humiList2.Add("rgba(6,204,113,1)");
                }
                else
                {
                    humiDataList2.Add(0);
                    humiList2.Add("rgba(255, 255, 255, 0.0)");
                }

                if (temp < 50)
                {
                    humiDataList3.Add(intensity.Intensity);
                    humiList3.Add("rgba(255, 205, 86, 1)");
                }
                else
                {
                    humiDataList3.Add(0);
                    humiList3.Add("rgba(255, 255, 255, 0.0)");
                }


            }
            ViewData["humiData1"] = humiDataList1;
            ViewData["humiData2"] = humiDataList2;
            ViewData["humiData3"] = humiDataList3;
            ViewData["humi1"] = humiList1;
            ViewData["humi2"] = humiList2;
            ViewData["humi3"] = humiList3;
        }
    }
}