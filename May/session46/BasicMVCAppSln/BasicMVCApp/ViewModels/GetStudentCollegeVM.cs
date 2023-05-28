using BasicMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicMVCApp.ViewModels
{
    public class GetStudentCollegeVM
    {
        public List<Student> Students { get; set; }
        public List<College> Colleges { get; set; }
    }
}