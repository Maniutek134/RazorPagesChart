#pragma checksum "/Users/msalasa/Projects/dotnet/RazorPagesChart/Pages/Charts/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bea07b092db0ffbddb91b61872524875cc393c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RazorPagesChart.Pages.Charts.Pages_Charts_Index), @"mvc.1.0.razor-page", @"/Pages/Charts/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Charts/Index.cshtml", typeof(RazorPagesChart.Pages.Charts.Pages_Charts_Index), null)]
namespace RazorPagesChart.Pages.Charts
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/msalasa/Projects/dotnet/RazorPagesChart/Pages/_ViewImports.cshtml"
using RazorPagesChart;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bea07b092db0ffbddb91b61872524875cc393c2", @"/Pages/Charts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"557539f5ba30707e199343baa714fe58d0aaf22b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Charts_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(7, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "/Users/msalasa/Projects/dotnet/RazorPagesChart/Pages/Charts/Index.cshtml"
  
    ViewData["Title"] = "Chart";

#line default
#line hidden
            BeginContext(100, 44, true);
            WriteLiteral("\r\n<h1>Intensity chart</h1>\r\n\r\n<h4>Road id - ");
            EndContext();
            BeginContext(145, 19, false);
#line 11 "/Users/msalasa/Projects/dotnet/RazorPagesChart/Pages/Charts/Index.cshtml"
         Write(Model.RoadSegmentId);

#line default
#line hidden
            EndContext();
            BeginContext(164, 9, true);
            WriteLiteral("</h4>\r\n\r\n");
            EndContext();
            BeginContext(173, 223, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0bea07b092db0ffbddb91b61872524875cc393c24040", async() => {
                BeginContext(179, 19, true);
                WriteLiteral("\r\n    <p>\r\n        ");
                EndContext();
                BeginContext(198, 131, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0bea07b092db0ffbddb91b61872524875cc393c24437", async() => {
                    BeginContext(263, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
                    BeginContext(312, 8, true);
                    WriteLiteral("        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 15 "/Users/msalasa/Projects/dotnet/RazorPagesChart/Pages/Charts/Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.RoadSegmentId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 15 "/Users/msalasa/Projects/dotnet/RazorPagesChart/Pages/Charts/Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.RoadSegmentIds;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(329, 60, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Filter\" />\r\n    </p>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(396, 1080, true);
            WriteLiteral(@"
<hr />

<div class=""row"">
    <div class=""col-md-12"">
        <h4>Temperature</h4>
    </div>
    <div class=""col-md-12"">
        <canvas id=""tempChart""></canvas>
    </div>
</div>
<hr />

<div class=""row"">
    <div class=""col-md-12"">
        <h4>Pressure</h4>
    </div>
    <div class=""col-md-12"">
        <canvas id=""pressureChart""></canvas>
    </div>
</div>
<hr />

<div class=""row"">
    <div class=""col-md-12"">
        <h4>Humidity</h4>
    </div>
    <div class=""col-md-12"">
        <canvas id=""humidityChart""></canvas>
    </div>
</div>

<script src=""https://cdn.jsdelivr.net/npm/chart.js@2.8.0""></script>
<script src=""https://cdn.jsdelivr.net/npm/hammerjs@2.0.8""></script>
<script src=""https://cdn.jsdelivr.net/npm/chartjs-plugin-zoom@0.7.0""></script>
<script type=""text/javascript"">
    var ctx = document.getElementById('tempChart').getContext('2d');
    var chart = new Chart(ctx, {
        // The type of chart we want to create
        type: 'bar',

        // The dat");
            WriteLiteral("a for our dataset\r\n        data: {\r\n            labels: ");
            EndContext();
            BeginContext(1477, 33, false);
#line 63 "/Users/msalasa/Projects/dotnet/RazorPagesChart/Pages/Charts/Index.cshtml"
               Write(Json.Serialize(ViewBag.tempLabel));

#line default
#line hidden
            EndContext();
            BeginContext(1510, 157, true);
            WriteLiteral(",\r\n            datasets: [\r\n            {\r\n                label: \'< 14C\',\r\n                backgroundColor: \'rgba(54, 162, 235, 1)\',\r\n                data: ");
            EndContext();
            BeginContext(1668, 33, false);
#line 68 "/Users/msalasa/Projects/dotnet/RazorPagesChart/Pages/Charts/Index.cshtml"
                 Write(Json.Serialize(ViewBag.tempData4));

#line default
#line hidden
            EndContext();
            BeginContext(1701, 148, true);
            WriteLiteral("\r\n            },\r\n            {\r\n                label: \'14-18C\',\r\n                backgroundColor: \'rgba(255, 205, 86, 1)\',\r\n                data: ");
            EndContext();
            BeginContext(1850, 33, false);
#line 73 "/Users/msalasa/Projects/dotnet/RazorPagesChart/Pages/Charts/Index.cshtml"
                 Write(Json.Serialize(ViewBag.tempData3));

#line default
#line hidden
            EndContext();
            BeginContext(1883, 148, true);
            WriteLiteral("\r\n            },\r\n            {\r\n                label: \'18-24C\',\r\n                backgroundColor: \'rgba(255, 159, 64, 1)\',\r\n                data: ");
            EndContext();
            BeginContext(2032, 33, false);
#line 78 "/Users/msalasa/Projects/dotnet/RazorPagesChart/Pages/Charts/Index.cshtml"
                 Write(Json.Serialize(ViewBag.tempData2));

#line default
#line hidden
            EndContext();
            BeginContext(2065, 146, true);
            WriteLiteral("\r\n            },\r\n            {\r\n                label: \'>24C\',\r\n                backgroundColor: \'rgba(255, 99, 132, 1)\',\r\n                data: ");
            EndContext();
            BeginContext(2212, 33, false);
#line 83 "/Users/msalasa/Projects/dotnet/RazorPagesChart/Pages/Charts/Index.cshtml"
                 Write(Json.Serialize(ViewBag.tempData1));

#line default
#line hidden
            EndContext();
            BeginContext(2245, 1300, true);
            WriteLiteral(@"
            }
            ]
        },

        // Configuration options go here
        options: {
               scales: {
                yAxes: [{
                    ticks: {
                        beginAtZero:true
                    }
                }]
            },
            // Container for pan options
            pan: {
                // Boolean to enable panning
                enabled: true,

                // Panning directions. Remove the appropriate direction to disable
                // Eg. 'y' would only allow panning in the y direction
                mode: 'xy'
            },

            // Container for zoom options
            zoom: {
                // Boolean to enable zooming
                enabled: true,

                // Zooming directions. Remove the appropriate direction to disable
                // Eg. 'y' would only allow zooming in the y direction
                mode: 'xy',
            }
        }

    });
</script>
<script typ");
            WriteLiteral(@"e=""text/javascript"">
    var ctx = document.getElementById('pressureChart').getContext('2d');
    var chart = new Chart(ctx, {
        // The type of chart we want to create
        type: 'bar',

        // The data for our dataset
        data: {
            labels: ");
            EndContext();
            BeginContext(3546, 33, false);
#line 128 "/Users/msalasa/Projects/dotnet/RazorPagesChart/Pages/Charts/Index.cshtml"
               Write(Json.Serialize(ViewBag.presLabel));

#line default
#line hidden
            EndContext();
            BeginContext(3579, 159, true);
            WriteLiteral(",\r\n            datasets: [\r\n            {\r\n                label: \'< 1000\',\r\n                backgroundColor: \'rgba(255, 255, 126, 1)\',\r\n                data: ");
            EndContext();
            BeginContext(3739, 33, false);
#line 133 "/Users/msalasa/Projects/dotnet/RazorPagesChart/Pages/Charts/Index.cshtml"
                 Write(Json.Serialize(ViewBag.presData3));

#line default
#line hidden
            EndContext();
            BeginContext(3772, 148, true);
            WriteLiteral("\r\n            },\r\n            {\r\n                label: \'1000-1015\',\r\n                backgroundColor: \'rgba(46,204,113,1)\',\r\n                data: ");
            EndContext();
            BeginContext(3921, 33, false);
#line 138 "/Users/msalasa/Projects/dotnet/RazorPagesChart/Pages/Charts/Index.cshtml"
                 Write(Json.Serialize(ViewBag.presData2));

#line default
#line hidden
            EndContext();
            BeginContext(3954, 148, true);
            WriteLiteral("\r\n            },\r\n            {\r\n                label: \'> 1015\',\r\n                backgroundColor: \'rgba(255, 99, 132, 1)\',\r\n                data: ");
            EndContext();
            BeginContext(4103, 33, false);
#line 143 "/Users/msalasa/Projects/dotnet/RazorPagesChart/Pages/Charts/Index.cshtml"
                 Write(Json.Serialize(ViewBag.presData1));

#line default
#line hidden
            EndContext();
            BeginContext(4136, 1302, true);
            WriteLiteral(@"
            }
            ]
        },

        // Configuration options go here
        options: {
               scales: {
                yAxes: [{
                    ticks: {
                        beginAtZero:true
                    }
                }]
            },
            // Container for pan options
            pan: {
                // Boolean to enable panning
                enabled: true,

                // Panning directions. Remove the appropriate direction to disable
                // Eg. 'y' would only allow panning in the y direction
                mode: 'xy'
            },

            // Container for zoom options
            zoom: {
                // Boolean to enable zooming
                enabled: true,

                // Zooming directions. Remove the appropriate direction to disable
                // Eg. 'y' would only allow zooming in the y direction
                mode: 'xy',
            }
        }

    });
</script>

<script t");
            WriteLiteral(@"ype=""text/javascript"">
    var ctx = document.getElementById('humidityChart').getContext('2d');
    var chart = new Chart(ctx, {
        // The type of chart we want to create
        type: 'bar',

        // The data for our dataset
        data: {
            labels: ");
            EndContext();
            BeginContext(5439, 33, false);
#line 189 "/Users/msalasa/Projects/dotnet/RazorPagesChart/Pages/Charts/Index.cshtml"
               Write(Json.Serialize(ViewBag.humiLabel));

#line default
#line hidden
            EndContext();
            BeginContext(5472, 157, true);
            WriteLiteral(",\r\n            datasets: [\r\n            {\r\n                label: \'< 50\',\r\n                backgroundColor: \'rgba(197, 239, 247, 1)\',\r\n                data: ");
            EndContext();
            BeginContext(5630, 33, false);
#line 194 "/Users/msalasa/Projects/dotnet/RazorPagesChart/Pages/Charts/Index.cshtml"
                 Write(Json.Serialize(ViewBag.humiData3));

#line default
#line hidden
            EndContext();
            BeginContext(5663, 146, true);
            WriteLiteral("\r\n            },\r\n            {\r\n                label: \'50-80\',\r\n                backgroundColor: \'rgba(0, 181, 204, 1)\',\r\n                data: ");
            EndContext();
            BeginContext(5810, 33, false);
#line 199 "/Users/msalasa/Projects/dotnet/RazorPagesChart/Pages/Charts/Index.cshtml"
                 Write(Json.Serialize(ViewBag.humiData2));

#line default
#line hidden
            EndContext();
            BeginContext(5843, 145, true);
            WriteLiteral("\r\n            },\r\n            {\r\n                label: \'> 80\',\r\n                backgroundColor: \'rgba(31, 58, 147, 1)\',\r\n                data: ");
            EndContext();
            BeginContext(5989, 33, false);
#line 204 "/Users/msalasa/Projects/dotnet/RazorPagesChart/Pages/Charts/Index.cshtml"
                 Write(Json.Serialize(ViewBag.humiData1));

#line default
#line hidden
            EndContext();
            BeginContext(6022, 1013, true);
            WriteLiteral(@"
            }
            ]
        },

        // Configuration options go here
        options: {
               scales: {
                yAxes: [{
                    ticks: {
                        beginAtZero:true
                    }
                }]
            },
            // Container for pan options
            pan: {
                // Boolean to enable panning
                enabled: true,

                // Panning directions. Remove the appropriate direction to disable
                // Eg. 'y' would only allow panning in the y direction
                mode: 'xy'
            },

            // Container for zoom options
            zoom: {
                // Boolean to enable zooming
                enabled: true,

                // Zooming directions. Remove the appropriate direction to disable
                // Eg. 'y' would only allow zooming in the y direction
                mode: 'xy',
            }
        }

    });
</script>
");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RazorPagesChart.Pages.Charts.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesChart.Pages.Charts.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesChart.Pages.Charts.IndexModel>)PageContext?.ViewData;
        public RazorPagesChart.Pages.Charts.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591