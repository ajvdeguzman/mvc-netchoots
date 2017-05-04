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
                new Student() {
                    StudentId = 1,
                    StudentName = "John Lennon",
                    Age = 24,
                    Description = "Vocalist, Rhythm Guitarist, Lucy in the Sky With Diamonds",
                    isNewlyEnrolled = true,
                    StudentGender = "Female",
                    Password = "jlen"
                },

                new Student() {
                    StudentId = 1,
                    StudentName = "Paul McCartney",
                    Age = 26,
                    Description = "Vocalist, Bassist, Got to Get You Into My Life",
                    isNewlyEnrolled = false,
                    StudentGender = "Female",
                    Password = "pmac"
                },

                new Student() {
                    StudentId = 3,
                    StudentName = "George Harrison",
                    Age = 23,
                    Description = "Vocalist, Lead Guitarist, While My Guitar Gently Weeps",
                    isNewlyEnrolled = true,
                    StudentGender = "Male",
                    Password = "ghar"
                },

                new Student() {
                    StudentId = 4,
                    StudentName = "Richard Starkey",
                    Age = 27,
                    Description = "Vocalist, Drummer, Yellow Submarine",
                    isNewlyEnrolled = false,
                    StudentGender = "Male",
                    Password = "rsta"
                }
            };

            return View(studentList);
        }
    }
}