using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System;

namespace Checkmarx.Models
{
    public class XssViewModel
    {
        [Required]
        [Display(Name = "URL Parameter")]
        public string Value { get; set; }
    }
}
