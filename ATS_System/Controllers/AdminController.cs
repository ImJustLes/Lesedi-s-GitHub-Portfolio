using ATS_System.Models;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ATS_System.Controllers
{
    public class AdminController : Controller
    {
        //This basically serves as the connection to the real-time database      
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "Zhgb2srnouL9kwyuTmsCfqIo32zT3BKCASCDzRP7",
            BasePath = "https://wertutors-v1-default-rtdb.firebaseio.com",
        };

        //Client object AKA the thing that allows you to create users
        IFirebaseClient client;

        List<Tutor> tutors = new List<Tutor>()
        {
            new Tutor("John", "Doe", "Johannesburg", new List<string> { "Maths", "Science" }, new List<string> { "Grade 8", "Grade 9" }, new List<DateTime> { DateTime.Parse("2024-10-16T14:00:00"), DateTime.Parse("2024-10-17T16:00:00") }, 250.0),
            new Tutor("Jane", "Smith", "Pretoria", new List<string> { "English", "History" }, new List<string> { "Grade 10", "Grade 11" }, new List<DateTime> { DateTime.Parse("2024-10-18T10:00:00"), DateTime.Parse("2024-10-19T12:00:00") }, 300.0),
            new Tutor("Michael", "Johnson", "Cape Town", new List<string> { "Geography", "Economics" }, new List<string> { "Grade 12" }, new List<DateTime> { DateTime.Parse("2024-10-20T14:00:00"), DateTime.Parse("2024-10-21T16:00:00") }, 350.0),
            new Tutor("Emily", "Davis", "Durban", new List<string> { "Maths", "Science", "English" }, new List<string> { "Grade 8", "Grade 9", "Grade 10" }, new List<DateTime> { DateTime.Parse("2024-10-22T10:00:00"), DateTime.Parse("2024-10-23T12:00:00"), DateTime.Parse("2024-10-24T14:00:00") }, 400.0),
            new Tutor("David", "Wilson", "Bloemfontein", new List<string> { "History", "Geography" }, new List<string> { "Grade 11", "Grade 12" }, new List<DateTime> { DateTime.Parse("2024-10-25T14:00:00"), DateTime.Parse("2024-10-26T16:00:00") }, 275.0)
        };

        // GET: AdminController
        [HttpGet]
        public ActionResult Index()
        {
            client = new FireSharp.FirebaseClient(config);

            if (client != null)
            {
                Console.WriteLine("Its connected omg"); 
            }
            return View("Admin_Dashboard");
        }
        public ActionResult ATS_System()
        {
            //FirebaseResponse response = client.Get("applicants");
            //dynamic data = JsonConvert.DeserializeObject<dynamic>(response.Body);

            //foreach (var item in data)
            //{
            //    tutors.Add(JsonConvert.DeserializeObject<Tutor>(((JProperty)item).Value.ToString()));
            //}
            return View(tutors);
        }

        public ActionResult AcceptTutor()
        {

            return View();
        }
        public ActionResult Client_Analytics()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FilterTutors(IFormCollection Collection)
        {
            try
            {
                string subject = Collection["cmbSubject"];
                string location = Collection["cmbLocation"];

                if (!subject.Equals("") && !location.Equals(""))
                {
                    List<Tutor> filteredTutors = tutors.FindAll(t => t.Subjects.Contains(subject) && t.Location.Contains(location));
                    return View("ATS_System", filteredTutors);
                }
                else if (subject.Equals("") && !location.Equals(""))
                {
                    List<Tutor> filteredTutors = tutors.FindAll(t => t.Location.Contains(location));
                    return View("ATS_System", filteredTutors);
                }
                else if (!subject.Equals("") && location.Equals(""))
                {
                    List<Tutor> filteredTutors = tutors.FindAll(t => t.Subjects.Contains(subject));
                    return View("ATS_System", filteredTutors);
                }

                return View("ATS_System", tutors);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex);
                return View("Error");
            }            
        }

        

        // GET: AdminController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdminController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdminController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdminController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
