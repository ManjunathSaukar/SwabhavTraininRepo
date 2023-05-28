using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContactMVCApp1.VM
{
    public class EditContactViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the mobile number.")]
        public string MobileNumber { get; set; }
    }
}