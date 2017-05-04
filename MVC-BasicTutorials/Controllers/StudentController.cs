using MVC_BasicTutorials.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_BasicTutorials.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            var studentList = new List<Student>
            {
                new Student() { StudentId = 1, StudentName = "John Lennon", Age = 24 },
                new Student() { StudentId = 1, StudentName = "Paul McCartney", Age = 26 },
                new Student() { StudentId = 3, StudentName = "George Harrison", Age = 23 },
                new Student() { StudentId = 4, StudentName = "Richard Starkey", Age = 27 }
            };

            return View(studentList);
        }
    }
}