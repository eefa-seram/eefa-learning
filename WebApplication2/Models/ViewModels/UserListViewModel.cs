using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models.ViewModels
{
    public class UserListViewModel
    {
        [DisplayName("شناسه")]
        public long Id { get; set; }
        [DisplayName("ایمیل")]
        public string Email { get; set; }
    }
}
