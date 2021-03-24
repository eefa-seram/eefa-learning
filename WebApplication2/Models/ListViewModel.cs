using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace WebApplication2.Models
{
    public class ListViewModel
    {
            [Required(ErrorMessage = "این فیلد اجباری است")]
            [MinLength(2, ErrorMessage = "اسم اشتباه است")]
            public string Name { get; set; }
            [Required(ErrorMessage = "این فیلد اجباری است")]
            [EmailAddress(ErrorMessage = "فرمت ایمیل اشتباه است")]
            public string Email { get; set; }
            [Required(ErrorMessage = "این فیلد اجباری است")]
            [MinLength(2, ErrorMessage = "پیام اشتباه است")]
            public string Message { get; set; }
       
    }
}
