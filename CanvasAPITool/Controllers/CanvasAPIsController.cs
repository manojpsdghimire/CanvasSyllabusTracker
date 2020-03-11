using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using CanvasAPITool.Model;
using System.Net.Http;
using Nancy.Json;
using X.PagedList;
using Newtonsoft.Json;
using System.Net;
using System.IO;
using Aspose.Words;
using SelectPdf;

namespace CanvasAPITool.Controllers
{
    public class CanvasAPIsController : Controller
    {
        private readonly CanvasContext _context;

        CanvasSIS sis = new CanvasSIS();
        public CanvasAPIsController(CanvasContext context)
        {
            _context = context;
        }
       

        // GET: CanvasAPIs
        public IActionResult Index(int Terms, int? page, int syllabus, string departments)
        {

            ViewBag.Term = Terms;
            ViewBag.Syll = syllabus;
            ViewBag.Depart = departments;

           List< CanvasAPI> _CanvasCourses = _context.CanvasAPI.ToList();

            //gets the list of all active classes and returns for a viewbag
            ViewBag.Terms = new SelectList(Task.Run(() => getActiveTerms(sis.base_url, sis.account_id, sis.access_token)).Result, "id", "name");

            //returning the dropdown for the course syllabus view
            ViewBag.Syllabus = new SelectList(SyllabusViewOptions(), "Value", "Text");

            //dropdown for the departments
            ViewBag.Departments = new SelectList(Departments(), "Value", "Text");

            //check for the term 
            if (Terms != 0)
            {
                _CanvasCourses = _CanvasCourses.FindAll(a=>a.EnrollmentTermId == Terms.ToString());
            }

            //data display per department
            ViewBag.department_course  = _CanvasCourses.GroupBy(i => i.Department).Select(i => new {
                ItemId = i.Key,
                Total = i.Select(j => j.Id).Count(),
                hasSyllabus = i.Where(a => a.HasSyllabus.ToUpper() == "TRUE").Select(j => j.Id).Count(), //courses with syllabus
                noSyllabus = i.Where(b => b.HasSyllabus.ToUpper() == "FALSE").Select(j => j.Id).Count(), //courses without syllabus
                usesgradebook = i.Where(c => c.UsesGradeBook.ToUpper() == "TRUE").Select(j => j.Id).Count(), //courses uses gradebook
                nousesgradebook = i.Where(c => c.UsesGradeBook.ToUpper() == "FALSE").Select(j => j.Id).Count(), //courses does not use gradebook
                usesAttendence = i.Where(c => c.UsesAttendence.ToUpper() == "TRUE").Select(j => j.Id).Count(), //courses uses attendence
                nousesAttendence = i.Where(c => c.UsesAttendence.ToUpper() == "FALSE").Select(j => j.Id).Count(), //courses does not use attendence
            }).OrderBy(a => a.ItemId);

            //Graphing the results
            ViewBag.Total = _CanvasCourses.Count();
            //data for syllabus usage
            ViewBag.hasSyllabusTotal = _CanvasCourses.Where(a => a.HasSyllabus.ToUpper() == "TRUE").Count();
            ViewBag.noSyllabusTotal = _CanvasCourses.Where(a => a.HasSyllabus.ToUpper() == "FALSE").Count();


            //data for grade book uses
            ViewBag.usesgradeBook = _CanvasCourses.Where(a => a.UsesGradeBook.ToUpper() == "TRUE").Count();
            ViewBag.nousegradebook = _CanvasCourses.Where(a => a.UsesGradeBook.ToUpper() == "FALSE").Count();


            //data for attendence 
            ViewBag.usesattendence = _CanvasCourses.Where(a => a.UsesAttendence.ToUpper() == "TRUE").Count();
            ViewBag.nousesattendence = _CanvasCourses.Where(a => a.UsesAttendence.ToUpper() == "FALSE").Count();



            //checking if the dropdown is populated 
            if (syllabus != 0)
            {
               _CanvasCourses  = getTermCourse(_CanvasCourses, syllabus);
            }

            //filter the courses based on the department selected
            if(!String.IsNullOrEmpty(departments) && departments != "ALL")
            {
                _CanvasCourses = _CanvasCourses.FindAll(a => a.Department == departments);
            }

            //pagination
            int pageSize = 60;
            int pageNumber = (page ?? 1);
            ViewBag.OnePageOfProducts = _CanvasCourses;

            //list for graphing 
            ViewBag.DepartmentData = _CanvasCourses.ToList();

            return View( _CanvasCourses.OrderBy(a=>a.Name).ToPagedList(pageNumber, pageSize));
        }

       
        //*******************************************************************************************************************************
        //returns the syllabus view options
        public List<SelectListItem> SyllabusViewOptions()
        {
            List<SelectListItem> syllabusView = new List<SelectListItem>();
            syllabusView.Add(new SelectListItem() { Text = "All Courses", Value = "1" });
            syllabusView.Add(new SelectListItem() { Text = "Courses With Syllabus", Value = "2" });
            syllabusView.Add(new SelectListItem() { Text = "Courses Without Syllabus", Value = "3" });

            return syllabusView;
        }

        //*******************************************************************************************************************************
        //returns the list of departments 
        public List<SelectListItem> Departments()
        {
            List<SelectListItem> DepartmentView = new List<SelectListItem>();
            DepartmentView.Add(new SelectListItem() { Text = "All Departments", Value = "ALL" });
            DepartmentView.Add(new SelectListItem() { Text = "Accounting Business Economics & Finance", Value = "ABEF" });
            DepartmentView.Add(new SelectListItem() { Text = "Biology and Environmental Science", Value = "BIOES" });
            DepartmentView.Add(new SelectListItem() { Text = "Chemistry", Value = "CHM" });
            DepartmentView.Add(new SelectListItem() { Text = "Communication and Fine Arts", Value = "COMFA" });
            DepartmentView.Add(new SelectListItem() { Text = "Computer Science", Value = "CSC" });
            DepartmentView.Add(new SelectListItem() { Text = "Education", Value = "EDU" });
            DepartmentView.Add(new SelectListItem() { Text = "English", Value = "ENG" });
            DepartmentView.Add(new SelectListItem() { Text = "Environmental Science", Value = "ENV" });
            DepartmentView.Add(new SelectListItem() { Text = "Foreign Language and Literature", Value = "FLL" });
            DepartmentView.Add(new SelectListItem() { Text = "Global Studies", Value = "GLS" });
            DepartmentView.Add(new SelectListItem() { Text = "Health and Exercies Science", Value = "HES" });
            DepartmentView.Add(new SelectListItem() { Text = "History", Value = "HIS" });
            DepartmentView.Add(new SelectListItem() { Text = "Westminster Honors Program", Value = "HON" });
            DepartmentView.Add(new SelectListItem() { Text = "Humanities", Value = "HU" });
            DepartmentView.Add(new SelectListItem() { Text = "Leadership", Value = "LST" });
            DepartmentView.Add(new SelectListItem() { Text = "Mathematics and Physics", Value = "MATPHY" });
            DepartmentView.Add(new SelectListItem() { Text = "Natural Sciences and Maths", Value = "NM" });
            DepartmentView.Add(new SelectListItem() { Text = "Physical Education", Value = "PED" });
            DepartmentView.Add(new SelectListItem() { Text = "Philoshopy and Religious Studies", Value = "PHLRS" });
            DepartmentView.Add(new SelectListItem() { Text = "Political Science and Security Studies", Value = "POLSS" });
            DepartmentView.Add(new SelectListItem() { Text = "Psychology", Value = "PSY" });
            DepartmentView.Add(new SelectListItem() { Text = "Westminster College MO", Value = "WESTM" });
            DepartmentView.Add(new SelectListItem() { Text = "Women's Gender Studies", Value = "WGS" });
            DepartmentView.Add(new SelectListItem() { Text = "First Year Programming", Value = "WSM" });
            DepartmentView.Add(new SelectListItem() { Text = "Others", Value = "OTHER" });
            return DepartmentView;
        }
       
        //*******************************************************************************************************************************
        // GET: Canvas Courses Syllabus File
        public ActionResult getCourseSyllabus(int id)
        {
            var syllabus = Task.Run(() => getCourseSyllabus(sis.base_url, id, sis.access_token)).Result;
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

    
            WebClient client = new WebClient();
            List<Courses_Documents> item = syllabus.OrderBy(a => a.modified_at).Take(1).ToList();
     
            if(item.Count>0)
            {

                if (!item.First().filename.Contains(".pdf"))
                {
                    return ConvertToPDF(item.First().url, item.First().filename);
                }
                else
                {
                    return GeneratePDF(item.First().url, item.First().filename); ;
                }
            }
            else
            {
                //get the syllabus body
                var syllabus_body =  getSyllabusBody(sis.base_url, id, sis.access_token).Result;
                if(!String.IsNullOrEmpty(syllabus_body.syllabus_body))
                {
                    //ViewBag.name = syllabus_body.name;
                    //ViewBag.Syllabus = syllabus_body.syllabus_body;
                    //return View();

                    return CreatePDF(syllabus_body.syllabus_body, syllabus_body.name);
                }
            }

            return new EmptyResult();
        }


        //*******************************************************************************************************************************
        //returns pdf view
        public ActionResult CreatePDF(string syllabus_body, string name)
        {
            HtmlToPdf converter = new HtmlToPdf();

            PdfDocument doc = converter.ConvertHtmlString(syllabus_body);

            
            converter.Options.PdfPageSize = PdfPageSize.A4;
            converter.Options.PdfPageOrientation = PdfPageOrientation.Portrait;
            converter.Options.MarginLeft = 200;
            converter.Options.MarginRight = 200;
            converter.Options.MarginTop = 300;
            converter.Options.MarginBottom =300;

            byte[] pdfContent = doc.Save();

            if (pdfContent == null)
            {
                return null;
            }
            var Header = new System.Net.Mime.ContentDisposition
            {
                Inline = true,
                FileName = name.ToString()
            };
            Response.Headers.Add("SyllabusContent", Header.ToString());
            return File(pdfContent, System.Net.Mime.MediaTypeNames.Application.Pdf);
        }

        //*******************************************************************************************************************************
        //Get Syllabus Body
        public static async Task<Canvas_Courses> getSyllabusBody(string baseUrl, int course_id, string accessToken)
        {
            string rval = string.Empty;
            string urlCommand = baseUrl + "accounts/1/courses/" + course_id + "?access_token=" + accessToken + "&include[]=syllabus_body";
            using (HttpResponseMessage response = await httpGET(urlCommand))
            {
                rval = await response.Content.ReadAsStringAsync();
                if (!response.IsSuccessStatusCode)
                {
                    throw new HttpRequestException(rval);
                }
            }

            JavaScriptSerializer js = new JavaScriptSerializer();
            Canvas_Courses coursesyllabus = js.Deserialize < Canvas_Courses>(rval);

            return coursesyllabus;
        }
        //*******************************************************************************************************************************
        //returns pdf view
        public ActionResult ConvertToPDF(string url, string filename)
        {

            WebClient client = new WebClient();
            byte[] docBytes = client.DownloadData(url);


            // Load Word Document from this byte array
            Document loadedFromBytes = new Document(new MemoryStream(docBytes));

            // Save Word to PDF byte array
            MemoryStream pdfStream = new MemoryStream();
            loadedFromBytes.Save(pdfStream, SaveFormat.Pdf);

            //returning pdf
            byte[] pdfContent = pdfStream.ToArray();

            if (pdfContent == null)
            {
                return null;
            }
            var Header = new System.Net.Mime.ContentDisposition
            {
                Inline = true,
                FileName = filename
            };
            Response.Headers.Add("Content", Header.ToString());
            return File(pdfContent, System.Net.Mime.MediaTypeNames.Application.Pdf);

        }
       
        //*******************************************************************************************************************************
       // returns pdf view
        public ActionResult GeneratePDF(string url, string filename)
        {

            //read the file from the directory
            WebClient client = new WebClient();
            byte[] pdfContent = client.DownloadData(url);
            if (pdfContent == null)
            {
                return null;
            }
            var contentDispositionHeader = new System.Net.Mime.ContentDisposition
            {
                Inline = true,
                FileName = filename
            };
            Response.Headers.Add("Content-Disposition", contentDispositionHeader.ToString());
            return File(pdfContent, System.Net.Mime.MediaTypeNames.Application.Pdf);
        }

        //*******************************************************************************************************************************
        //Validating the API Calls
        protected static async Task<HttpResponseMessage> httpGET(string urlCommand)
        {
            HttpResponseMessage response = null;

            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                handler.AllowAutoRedirect = false;
                using (HttpClient client = new HttpClient(handler, true))
                {
                    client.BaseAddress = new Uri(urlCommand);
                    client.DefaultRequestHeaders.Accept.Clear();

                    response = await client.GetAsync(urlCommand);
                }
            }
            catch (Exception err)
            {
                throw err;
            }

            return response;
        }
        //*******************************************************************************************************************************
        //GET ACtive Terms
        public static async Task<List<EnrollmentTerm>> getActiveTerms(string baseUrl, string accountid, string accessToken)
        {
            string rval = string.Empty;
            string urlCommand = baseUrl + "accounts/" + accountid + "/terms?access_token=" + accessToken + "&per_page=1000";
            using (HttpResponseMessage response = await httpGET(urlCommand))
            {
                rval = await response.Content.ReadAsStringAsync();
                if (!response.IsSuccessStatusCode)
                {
                    throw new HttpRequestException(rval);
                }
            }

            //going through the list to get only active terms
            JavaScriptSerializer jss = new JavaScriptSerializer();
            Enrollment_Terms terms_enrollment = jss.Deserialize<Enrollment_Terms>(rval);
            List<EnrollmentTerm> Terms_Active = new List<EnrollmentTerm>();
            foreach (var items in terms_enrollment.enrollment_terms)
            {
                if (!Enum.IsDefined(typeof(DefaultTerms.Terms_Default), items.id))
                {
                    if (items.end_at == null || items.end_at >= DateTime.Now)
                    {
                        Terms_Active.Add(items);
                    }
                }
            }
            return Terms_Active;
        }
        //*******************************************************************************************************************************
        //checking to see if the courses are published and available
        public List<CanvasAPI> getTermCourse(List<CanvasAPI> courses,  int Courses_Syllabus)
        {
            switch (Courses_Syllabus)
            {
                case 1:
                    break;
                case 2: //that contain syllabus
                    courses = courses.FindAll(x => x.HasSyllabus.ToUpper() == "TRUE");
                    break;
                case 3:
                    //doesnot contain syllabus
                    courses = courses.FindAll(x => x.HasSyllabus.ToUpper() == "FALSE");
                    break;
                default:
                    break;
            }
            
            return courses;
        }
        //*******************************************************************************************************************************
        //returns all the active terms
        //https://westminster-mo.instructure.com/api/v1/courses/2420/files?access_token=9218~FkwyEMJfOf49K2OS9h6AWXU4WJ4owlsbxvyQrNBr9a8ohkpRQ95Yu3BRlgRc5p5c&per_page=1000
        public static async Task<List<Courses_Documents>> getCourseSyllabus(string baseUrl, int course_id, string accessToken)
        {
            string rval = string.Empty;
            string urlCommand = baseUrl + "courses/" + course_id + "/files?access_token=" + accessToken + "&per_page=1000";
            using (HttpResponseMessage response = await httpGET(urlCommand))
            {
                rval = await response.Content.ReadAsStringAsync();
                if (!response.IsSuccessStatusCode)
                {
                    throw new HttpRequestException(rval);
                }
            }

            //create a new list for the 
            List<Courses_Documents> course_syllabus = JsonConvert.DeserializeObject<List<Courses_Documents>>(rval);

            foreach (var items in course_syllabus.ToPagedList())
            {
                if (!items.filename.ToUpper().Contains("SYLLABUS"))
                {
                    course_syllabus.Remove(items);
                }
            }
            return course_syllabus;
        }

       

    }
}
