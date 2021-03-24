using WebApplication2.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.ViewComponents
{
    
    public class UserDetail:ViewComponent
    {
        private readonly UserRepository _userRepository;

        public UserDetail()
        {
            _userRepository = new UserRepository();
        }
        public IViewComponentResult Invoke(long Id)
        {

            var user = _userRepository.Find(Id);
            return View(viewName: "UserDetail", user);
        }

        //public Task<IViewComponentResult> InvokeAsync(long Id)
        //{

        //    var user = _userRepository.Find(Id);
        //    return View(viewName: "UserDetail",user);
        //}
    }
}
