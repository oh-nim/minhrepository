using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SCADAMasan.Areas.SCADAGroup.Models
{
    public class LoginModel
    {
        [Required]
        public string username { get; set; }
        public string password{ get; set; }
        public string fullname { get; set; }
    }
}