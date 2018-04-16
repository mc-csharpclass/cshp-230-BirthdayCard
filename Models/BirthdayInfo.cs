using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BirthdayCard.Models
{
    public class BirthdayInfo
    {
        [Required(ErrorMessage = "Please enter you name")]
        public string SenderName { get; set; }
        [Required(ErrorMessage = "Please enter the birthday person's name")]
        public string RecieverName { get; set; }
        [Required(ErrorMessage = "Please enter a birthday message")]
        public string Message { get; set; }
    }
}