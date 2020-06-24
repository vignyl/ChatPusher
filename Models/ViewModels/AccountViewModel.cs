using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ChatPusher.Models.ViewModels
{
    public class LoginViewModel
    {
        [StringLength(254)]
        [Required]
        [Display(Name = "Phone")]
        public string phone { get; set; }

        [StringLength(254)]
        [DataType(DataType.Password)]
        [Display(Name = "Password", Prompt = "Mot de passe")]
        [Required]
        public string password { get; set; }
    }
     
}