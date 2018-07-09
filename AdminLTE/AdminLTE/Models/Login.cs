using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdminLTE.Models
{
    public class Login
    {
         
    [Required(ErrorMessage = "Email Wajib.", AllowEmptyStrings = false)]
            public string Email { get; set; }
            [Required(ErrorMessage = "Password Wajib.", AllowEmptyStrings = false)]
            [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
            public string Password { get; set; }
           // public bool Ingatsaya { get; set; }
      
    }
}
