using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AbhinavMohanASP.NET.Models
{
    public class MessagingModel
    {
        [Display(Name = "Display Name")]
        [Required(ErrorMessage = "You need to enter a username")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Username must be between 5 to 20 characters")]
        public string DisplayName { get; set; }
        
        [DataType(DataType.PostalCode)]
        public string Location { get; set; }
        
        [Required(ErrorMessage = "Your message cannot be blank")]
        [StringLength(200, MinimumLength = 1, ErrorMessage = "Your message must be between 1 to 200 characters")]
        public string Message { get; set; }
        
        [Display(Name = "Visible to the Public")]
        public bool Visible { get; set; }

    }
}