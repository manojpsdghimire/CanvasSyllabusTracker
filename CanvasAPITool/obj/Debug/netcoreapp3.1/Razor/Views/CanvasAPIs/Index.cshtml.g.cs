#pragma checksum "C:\Users\manoj.ghimire\Desktop\CanvasSyllabusTracker\CanvasAPITool\Views\CanvasAPIs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02a68bade2d40ce831d25409d191ab3b94a9160c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CanvasAPIs_Index), @"mvc.1.0.view", @"/Views/CanvasAPIs/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\manoj.ghimire\Desktop\CanvasSyllabusTracker\CanvasAPITool\Views\_ViewImports.cshtml"
using CanvasAPITool;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\manoj.ghimire\Desktop\CanvasSyllabusTracker\CanvasAPITool\Views\_ViewImports.cshtml"
using CanvasAPITool.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\manoj.ghimire\Desktop\CanvasSyllabusTracker\CanvasAPITool\Views\CanvasAPIs\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\manoj.ghimire\Desktop\CanvasSyllabusTracker\CanvasAPITool\Views\CanvasAPIs\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02a68bade2d40ce831d25409d191ab3b94a9160c", @"/Views/CanvasAPIs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e2ab182c3cf5a39242133deeca7bc0d1036151e", @"/Views/_ViewImports.cshtml")]
    public class Views_CanvasAPIs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<CanvasAPITool.Model.CanvasAPI>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding:0px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\manoj.ghimire\Desktop\CanvasSyllabusTracker\CanvasAPITool\Views\CanvasAPIs\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02a68bade2d40ce831d25409d191ab3b94a9160c4343", async() => {
                WriteLiteral(@"
        <meta charset=""UTF-8"" />
        <meta name=""google"" content=""notranslate"">
        <meta http-equiv=""Content-Language"" content=""en"" />
        <meta http-equiv=""Content-Type"" content=""text/html;charset=utf-8"" />
        <title>USU Syllabus Tracker</title>
        <link rel=""stylesheet"" href=""resources/bootstrap/css/bootstrap.min.css"">
        <link rel=""stylesheet"" href=""resources/bootstrap/css/bootstrap-responsive.min.css"">
        <link rel=""stylesheet"" href=""resources/font-awesome/css/font-awesome.min.css"">
        <link rel=""stylesheet"" href=""resources/css/syllabus.css"">
        <link rel=""stylesheet"" href=""https://code.jquery.com/ui/1.10.4/themes/smoothness/jquery-ui.css"">
        <script type=""text/javascript"" language=""javascript"" src=""//ajax.googleapis.com/ajax/libs/jquery/1.8/jquery.min.js""></script>
        <script src=""https://code.jquery.com/ui/1.10.4/jquery-ui.js""></script>
        <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
        <script src='ht");
                WriteLiteral("tps://kit.fontawesome.com/a076d05399.js\'></script>\r\n        <link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">\r\n");
                WriteLiteral("        <script type=\"text/javascript\" src=\"https://www.gstatic.com/charts/loader.js\"></script>\r\n");
                WriteLiteral(@"        <script type=""text/javascript"">
            google.charts.load('current', { 'packages': ['bar'] });
            google.charts.setOnLoadCallback(drawChart);

            function drawChart() {
                var syllabus_data = google.visualization.arrayToDataTable([
                    ['Course',  'Total Active Courses', 'With Syllabus', 'Without Syllabus'],
                    ['Courses Syllabus Status', ");
#nullable restore
#line 36 "C:\Users\manoj.ghimire\Desktop\CanvasSyllabusTracker\CanvasAPITool\Views\CanvasAPIs\Index.cshtml"
                                           Write(ViewBag.Total);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 36 "C:\Users\manoj.ghimire\Desktop\CanvasSyllabusTracker\CanvasAPITool\Views\CanvasAPIs\Index.cshtml"
                                                           Write(ViewBag.hasSyllabusTotal);

#line default
#line hidden
#nullable disable
                WriteLiteral(",  ");
#nullable restore
#line 36 "C:\Users\manoj.ghimire\Desktop\CanvasSyllabusTracker\CanvasAPITool\Views\CanvasAPIs\Index.cshtml"
                                                                                       Write(ViewBag.noSyllabusTotal);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"]
                ]);

                var syllabus_options = {
                    chart: {
                        title: 'Canvas Courses',
                        subtitle: 'Active Courses with Syllabus Status',

                    },
                    colors: ['#4285F4','#3e8410', '#DB4437']
                };

                var Syllabus_chart = new google.charts.Bar(document.getElementById('syllabus_material'));

                Syllabus_chart.draw(syllabus_data, google.charts.Bar.convertOptions(syllabus_options ));
            }
        </script>

");
                WriteLiteral(@"        <script type=""text/javascript"">
            google.charts.load('current', { 'packages': ['corechart'] });
            google.charts.setOnLoadCallback(drawChart_department);

        function drawChart_department() {

        var department_data = [
            [{ label: 'Department', type: 'string' },
                { label: 'All Active Courses', type: 'number' },
            { label: 'Uses', type: 'number' },
            { label: 'Does not Uses', type: 'number' }

            ]
        ];

            //loop through each department


            department_data.push([""Syllabus"", ");
#nullable restore
#line 73 "C:\Users\manoj.ghimire\Desktop\CanvasSyllabusTracker\CanvasAPITool\Views\CanvasAPIs\Index.cshtml"
                                         Write(ViewBag.Total);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 73 "C:\Users\manoj.ghimire\Desktop\CanvasSyllabusTracker\CanvasAPITool\Views\CanvasAPIs\Index.cshtml"
                                                         Write(ViewBag.hasSyllabusTotal);

#line default
#line hidden
#nullable disable
                WriteLiteral(",");
#nullable restore
#line 73 "C:\Users\manoj.ghimire\Desktop\CanvasSyllabusTracker\CanvasAPITool\Views\CanvasAPIs\Index.cshtml"
                                                                                   Write(ViewBag.noSyllabusTotal);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ]);\r\n            department_data.push([\"Grade Book\", ");
#nullable restore
#line 74 "C:\Users\manoj.ghimire\Desktop\CanvasSyllabusTracker\CanvasAPITool\Views\CanvasAPIs\Index.cshtml"
                                           Write(ViewBag.Total);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 74 "C:\Users\manoj.ghimire\Desktop\CanvasSyllabusTracker\CanvasAPITool\Views\CanvasAPIs\Index.cshtml"
                                                           Write(ViewBag.usesgradeBook);

#line default
#line hidden
#nullable disable
                WriteLiteral(",");
#nullable restore
#line 74 "C:\Users\manoj.ghimire\Desktop\CanvasSyllabusTracker\CanvasAPITool\Views\CanvasAPIs\Index.cshtml"
                                                                                  Write(ViewBag.nousegradebook);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ]);\r\n            department_data.push([\"Attendence\", ");
#nullable restore
#line 75 "C:\Users\manoj.ghimire\Desktop\CanvasSyllabusTracker\CanvasAPITool\Views\CanvasAPIs\Index.cshtml"
                                           Write(ViewBag.Total);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 75 "C:\Users\manoj.ghimire\Desktop\CanvasSyllabusTracker\CanvasAPITool\Views\CanvasAPIs\Index.cshtml"
                                                           Write(ViewBag.usesattendence);

#line default
#line hidden
#nullable disable
                WriteLiteral(",");
#nullable restore
#line 75 "C:\Users\manoj.ghimire\Desktop\CanvasSyllabusTracker\CanvasAPITool\Views\CanvasAPIs\Index.cshtml"
                                                                                   Write(ViewBag.nousesattendence);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" ]);



         var data = google.visualization.arrayToDataTable(department_data);
        var options = {
          chart: {
            title: 'Active Canvas Courses',
            subtitle: 'Course Analysis',
            },
             colors: ['#4285F4','#3e8410', '#DB4437'],
            bars: 'vertical', // Required for Material Bar Charts.
          vAxis: {format: 'decimal'},
        };

        var chart = new google.charts.Bar(document.getElementById('barchart_material'));

        chart.draw(data, google.charts.Bar.convertOptions(options));
            }

        </script>


");
                WriteLiteral(@"        <script type=""text/javascript"">
            google.charts.load('current', { 'packages': ['corechart'] });
            google.charts.setOnLoadCallback(drawChart_department_courses);

        function drawChart_department_courses() {

       var department_data = [
           [{ label: 'Department', type: 'string' },
            { label: 'Total Courses', type: 'number' },
            { label: 'Using GradeBook', type: 'number' },
            { label: 'Not Using Gradebook', type: 'number' },
            { label: 'Has Syllabus', type: 'number' },
            { label: 'Does not have Syllabus', type: 'number' },
            { label: 'Using Attendence', type: 'number' },
            { label: 'Not Using Attendence', type: 'number' }
            ]
        ];

           

            var list = ");
#nullable restore
#line 119 "C:\Users\manoj.ghimire\Desktop\CanvasSyllabusTracker\CanvasAPITool\Views\CanvasAPIs\Index.cshtml"
                  Write(Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(ViewBag.department_course) as String));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n               \r\n\r\n             //dding for all active courses\r\n  //department_data.push([\"All Courses\",parseInt(");
#nullable restore
#line 123 "C:\Users\manoj.ghimire\Desktop\CanvasSyllabusTracker\CanvasAPITool\Views\CanvasAPIs\Index.cshtml"
                                            Write(ViewBag.Total);

#line default
#line hidden
#nullable disable
                WriteLiteral("), ");
#nullable restore
#line 123 "C:\Users\manoj.ghimire\Desktop\CanvasSyllabusTracker\CanvasAPITool\Views\CanvasAPIs\Index.cshtml"
                                                             Write(ViewBag.usesgradeBook);

#line default
#line hidden
#nullable disable
                WriteLiteral(",");
#nullable restore
#line 123 "C:\Users\manoj.ghimire\Desktop\CanvasSyllabusTracker\CanvasAPITool\Views\CanvasAPIs\Index.cshtml"
                                                                                    Write(ViewBag.nousegradebook);

#line default
#line hidden
#nullable disable
                WriteLiteral(",");
#nullable restore
#line 123 "C:\Users\manoj.ghimire\Desktop\CanvasSyllabusTracker\CanvasAPITool\Views\CanvasAPIs\Index.cshtml"
                                                                                                            Write(ViewBag.hasSyllabusTotal);

#line default
#line hidden
#nullable disable
                WriteLiteral(",");
#nullable restore
#line 123 "C:\Users\manoj.ghimire\Desktop\CanvasSyllabusTracker\CanvasAPITool\Views\CanvasAPIs\Index.cshtml"
                                                                                                                                      Write(ViewBag.noSyllabusTotal);

#line default
#line hidden
#nullable disable
                WriteLiteral(",");
#nullable restore
#line 123 "C:\Users\manoj.ghimire\Desktop\CanvasSyllabusTracker\CanvasAPITool\Views\CanvasAPIs\Index.cshtml"
                                                                                                                                                               Write(ViewBag.usesattendence);

#line default
#line hidden
#nullable disable
                WriteLiteral(",");
#nullable restore
#line 123 "C:\Users\manoj.ghimire\Desktop\CanvasSyllabusTracker\CanvasAPITool\Views\CanvasAPIs\Index.cshtml"
                                                                                                                                                                                       Write(ViewBag.nousesattendence);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"]);

            //looping through the ViewBag list
            for (var i = 0; i < list.length; i++) {

                var department = list[i].ItemId;
                var has_syllabus =list[i].hasSyllabus; 
                var no_syllabus =   list[i].noSyllabus;
                var uses_gradebook = list[i].usesgradebook;
                var no_gradebook = list[i].nousesgradebook;
                var uses_attendence = list[i].usesAttendence;
                var no_attendance = list[i].nousesAttendence;
                var _total = list[i].Total;

               department_data.push([department,_total,uses_gradebook, no_gradebook, has_syllabus, no_syllabus, uses_attendence, no_attendance]);
            }
           

         var data = google.visualization.arrayToDataTable(department_data);
        var options = {
            chart: {
              title: 'Active Canvas Courses',
            subtitle: 'Course Analysis per Department',
            },
            legend: {position: 'to");
                WriteLiteral(@"p', maxLines: 3},
            colors: ['#3366CC', '#DC3912','#FF9900', '#109618','#990099', '#0099C6','#DD4477', ],
            bars: 'vertical', // Required for Material Bar Charts.
          vAxis: {format: 'decimal'},
        };

        var chart = new google.charts.Bar(document.getElementById('chart_material'));

        chart.draw(data, google.charts.Bar.convertOptions(options));
            }

        </script>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02a68bade2d40ce831d25409d191ab3b94a9160c18152", async() => {
                WriteLiteral(@"
        <div class=""container-fluid"">
            <div class=""heading"">
                <div class=""alert alert-dismissible alert-primary"">
                    <h1 style=""font-weight: bold; text-align:center"">
                        Canvas Course Syllabus Tracker
                    </h1>
");
                WriteLiteral("                </div>\r\n               \r\n            </div>\r\n        </div>\r\n        <br />\r\n\r\n        <div class=\"container-fluid\">\r\n            <div class=\"row-fluid\">\r\n                <br />\r\n");
#nullable restore
#line 179 "C:\Users\manoj.ghimire\Desktop\CanvasSyllabusTracker\CanvasAPITool\Views\CanvasAPIs\Index.cshtml"
                 using (Html.BeginForm(FormMethod.Post))
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("<div class=\"container-fluid\" style=\"padding-left: 15px; align-self:center;\">\r\n                        <div class=\"row\">\r\n                            <div class=\"col-xs-5th-1 col-sm-3\" style=\"align-content:center;\">\r\n                                ");
#nullable restore
#line 183 "C:\Users\manoj.ghimire\Desktop\CanvasSyllabusTracker\CanvasAPITool\Views\CanvasAPIs\Index.cshtml"
                           Write(Html.DropDownList("Terms", (IEnumerable<SelectListItem>)ViewBag.Terms, "Select Terms", htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n                            <div class=\"col-xs-5th-1 col-sm-3\" style=\"align-content:center;\">\r\n                                ");
#nullable restore
#line 186 "C:\Users\manoj.ghimire\Desktop\CanvasSyllabusTracker\CanvasAPITool\Views\CanvasAPIs\Index.cshtml"
                           Write(Html.DropDownList("syllabus", (IEnumerable<SelectListItem>)ViewBag.Syllabus, "Select Syllabus", htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n                            <div class=\"col-xs-5th-1 col-sm-3\" style=\"align-content:center;\">\r\n                                ");
#nullable restore
#line 189 "C:\Users\manoj.ghimire\Desktop\CanvasSyllabusTracker\CanvasAPITool\Views\CanvasAPIs\Index.cshtml"
                           Write(Html.DropDownList("departments", (IEnumerable<SelectListItem>)ViewBag.Departments, "Select Department", htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </div>

                            <div class=""col-xs-5th-1 col-sm-3"" style=""align-content:center;"">
                                <div class=""col-md-offset-2 col-md-10"">
                                    <input type=""submit"" value=""Search"" class=""btn btn-primary"" />
                                </div>
                            </div>
                        </div>
                    </div>
                    <br />
");
#nullable restore
#line 200 "C:\Users\manoj.ghimire\Desktop\CanvasSyllabusTracker\CanvasAPITool\Views\CanvasAPIs\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                <br />
            </div>
        </div>
        <hr />
        <div class=""scrollable "">
            <div id=""chart_material"" style=""width: 2000px; height: 500px; ""></div>
        </div>
        <hr />
        <br />
        <div class=""alert alert-success"" style=""text-align:center;"">
            <strong style=""text-align:center;"">All Active Canvas Courses List</strong>
        </div>
        <div class=""container-fluid"">
            <div class=""row-fluid"">
                <div class=""container-fluid"" style=""padding-left: 15px;"">
                    <div class=""row"">

");
#nullable restore
#line 218 "C:\Users\manoj.ghimire\Desktop\CanvasSyllabusTracker\CanvasAPITool\Views\CanvasAPIs\Index.cshtml"
                         foreach (var item in Model)
                        {

                        

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"col-sm-4\">\r\n\r\n\r\n");
#nullable restore
#line 225 "C:\Users\manoj.ghimire\Desktop\CanvasSyllabusTracker\CanvasAPITool\Views\CanvasAPIs\Index.cshtml"
                             if (item.UsesGradeBook.ToUpper() == "FALSE")
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <i style=\"font-size:12px;color:darkorange;\" class=\'fa\'>&#xf06a;</i>\r\n");
#nullable restore
#line 228 "C:\Users\manoj.ghimire\Desktop\CanvasSyllabusTracker\CanvasAPITool\Views\CanvasAPIs\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <i style=\"font-size:12px;color:white;visibility: hidden;\" class=\'fa\'>&#xf06a;</i>\r\n");
#nullable restore
#line 232 "C:\Users\manoj.ghimire\Desktop\CanvasSyllabusTracker\CanvasAPITool\Views\CanvasAPIs\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
                WriteLiteral("\r\n");
#nullable restore
#line 237 "C:\Users\manoj.ghimire\Desktop\CanvasSyllabusTracker\CanvasAPITool\Views\CanvasAPIs\Index.cshtml"
                             if (item.UsesAttendence.ToUpper() == "FALSE")
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <i style=\"font-size:12px;color:red;\" class=\'fa\'>&#xf00d;</i>\r\n");
#nullable restore
#line 240 "C:\Users\manoj.ghimire\Desktop\CanvasSyllabusTracker\CanvasAPITool\Views\CanvasAPIs\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <i style=\"font-size:12px;color:white;visibility: hidden;\" class=\'fa\'>&#xf00d;</i>\r\n");
#nullable restore
#line 244 "C:\Users\manoj.ghimire\Desktop\CanvasSyllabusTracker\CanvasAPITool\Views\CanvasAPIs\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n");
                WriteLiteral("\r\n                        <i>\r\n");
#nullable restore
#line 251 "C:\Users\manoj.ghimire\Desktop\CanvasSyllabusTracker\CanvasAPITool\Views\CanvasAPIs\Index.cshtml"
                             if (item.HasSyllabus.ToUpper() == "FALSE")
                {
                    if (@item.Name.Length >= 40)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <span class=\"badge badge-secondary\"> ");
#nullable restore
#line 255 "C:\Users\manoj.ghimire\Desktop\CanvasSyllabusTracker\CanvasAPITool\Views\CanvasAPIs\Index.cshtml"
                                                            Write(item.Name.Substring(0, 40));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n");
#nullable restore
#line 256 "C:\Users\manoj.ghimire\Desktop\CanvasSyllabusTracker\CanvasAPITool\Views\CanvasAPIs\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <span class=\"badge badge-secondary\"> ");
#nullable restore
#line 259 "C:\Users\manoj.ghimire\Desktop\CanvasSyllabusTracker\CanvasAPITool\Views\CanvasAPIs\Index.cshtml"
                                                            Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n");
#nullable restore
#line 260 "C:\Users\manoj.ghimire\Desktop\CanvasSyllabusTracker\CanvasAPITool\Views\CanvasAPIs\Index.cshtml"

                    }

                }
                else

                {
                    if (@item.Name.Length >= 40)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <span class=\"badge badge-light\">\r\n                                ");
#nullable restore
#line 270 "C:\Users\manoj.ghimire\Desktop\CanvasSyllabusTracker\CanvasAPITool\Views\CanvasAPIs\Index.cshtml"
                           Write(Html.ActionLink(item.Name.Substring(0, 40), "getCourseSyllabus", new { id = item.Id }, new { target = "_blank", item.Name }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </span>\r\n");
#nullable restore
#line 272 "C:\Users\manoj.ghimire\Desktop\CanvasSyllabusTracker\CanvasAPITool\Views\CanvasAPIs\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <span class=\"badge badge-light\">\r\n                                ");
#nullable restore
#line 276 "C:\Users\manoj.ghimire\Desktop\CanvasSyllabusTracker\CanvasAPITool\Views\CanvasAPIs\Index.cshtml"
                           Write(Html.ActionLink(item.Name, "getCourseSyllabus", new { id = item.Id }, new { target = "_blank", item.Name }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </span>\r\n");
#nullable restore
#line 278 "C:\Users\manoj.ghimire\Desktop\CanvasSyllabusTracker\CanvasAPITool\Views\CanvasAPIs\Index.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </i>\r\n                        </div>\r\n");
#nullable restore
#line 283 "C:\Users\manoj.ghimire\Desktop\CanvasSyllabusTracker\CanvasAPITool\Views\CanvasAPIs\Index.cshtml"


                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </div>\r\n                </div>\r\n\r\n                <br />\r\n\r\n                Page ");
#nullable restore
#line 291 "C:\Users\manoj.ghimire\Desktop\CanvasSyllabusTracker\CanvasAPITool\Views\CanvasAPIs\Index.cshtml"
                 Write(Model.PageCount < Model.PageNumber ? 0 : Model.PageNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral(" of ");
#nullable restore
#line 291 "C:\Users\manoj.ghimire\Desktop\CanvasSyllabusTracker\CanvasAPITool\Views\CanvasAPIs\Index.cshtml"
                                                                                Write(Model.PageCount);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <ul class=\"pagination\">\r\n                    ");
#nullable restore
#line 293 "C:\Users\manoj.ghimire\Desktop\CanvasSyllabusTracker\CanvasAPITool\Views\CanvasAPIs\Index.cshtml"
               Write(Html.PagedListPager(Model, page => Url.Action("Index",
               new { Terms = ViewBag.Term, syllabus = ViewBag.Syll, departments = ViewBag.Depart, page, pgSize = ViewBag.psize })));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </ul>

                <br />

                <div class=""alert alert-warning alert-dismissible fade show"" role=""alert"">
                    <strong>NOTE:</strong>
                    <ul>
                        <li>
                            <i style=""font-size:12px;color:darkorange;"" class='fa'>&#xf06a;</i>&nbsp; Courses not using Canvas Grade Book.
                        </li>
                        <li>
                            <i style=""font-size:12px;color:red;"" class='fa'>&#xf00d;</i>&nbsp; Courses not using Canvas Attendence.
                        </li>
                        <li>
                            <i class=""badge badge-secondary"">&nbsp;</i>&nbsp; Courses do not have Syllabus.
                        </li>
                    </ul>
                    <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>");
                WriteLiteral("\n            </div>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<br />\r\n\r\n<style>\r\n   \r\n\r\n    div.scrollable {\r\n       \r\n        overflow: auto;\r\n    }\r\n    div.b {\r\n  word-wrap: break-word;\r\n}\r\n\r\n  \r\n</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<CanvasAPITool.Model.CanvasAPI>> Html { get; private set; }
    }
}
#pragma warning restore 1591
