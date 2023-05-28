using BasicMVCApp.Models;
using BasicMVCApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BasicMVCApp.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult GetStudent()
        {
            Student student = new Student
            {
                Id = 1,
                Name = "Manjunath",
                Cgpa = 9
            };
            return View(student);
        }
        public ActionResult GetStudents()
        {
            var s1 = new Student
            {
                Id = 1,
                Name = "Manjunath",
                Cgpa = 9
            };
            var s2 = new Student
            {
                Id = 2,
                Name = "Ravi",
                Cgpa = 8
            };
            var s3 = new Student
            {
                Id = 3,
                Name = "Ekta",
                Cgpa = 8.5
            };
            var students = new List<Student> { s1, s2, s3 };
            return View(students);
        }
        public ActionResult GetStudentCollege()
        {
            var s1 = new Student
            {
                Id = 1,
                Name = "Manjunath",
                Cgpa = 9
            };
            var s2 = new Student
            {
                Id = 2,
                Name = "Ravi",
                Cgpa = 8
            };
            var s3 = new Student
            {
                Id = 3,
                Name = "Ekta",
                Cgpa = 8.5
            };
            var students = new List<Student> { s1, s2, s3 };

            var c1 = new College { Id = 1, Name = "NGIT" };
            var c2 = new College { Id = 3, Name = "KMIT" };
            var colleges = new List<College> { c1, c2 };

            var vm = new GetStudentCollegeVM
            {
                Students = students,
                Colleges = colleges
            };
            return View(vm);
        }
    }
}