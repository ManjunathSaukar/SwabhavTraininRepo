using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoginMVCApp.ViewModel
{
    public class LoginVM
    {
        [Required (ErrorMessage ="User Name is required")]
        [StringLength (9,ErrorMessage ="Maximum length of user name is 9")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string UserPassword { get; set; }

        public string Title { get; set; }

    }
}