using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models.Repositories;

namespace WebApplication2.Controllers
{

    public class UserController : Controller
    {

        private readonly UserRepository _userRepository;

        public UserController()
        {
            _userRepository = new UserRepository();
        }

        public IActionResult Index()
        {
            return View(_userRepository.GetUserList());
        }

        public IActionResult Details(long Id)
        {
            ViewBag.Id = Id;
            return View(_userRepository.Find(Id));
        }

        public IActionResult UserDetailViewComponent(long Id)
        {
            return ViewComponent("UserDetail", new { Id = Id });
        }
    }


    //    public IActionResult Index()
    //    {
    //        return View();
    //    }

    //    [HttpGet]
    //    public IActionResult Register()
    //    {
    //        return View();
    //    }


    //    [HttpPost]
    //    public IActionResult Register(Users users)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            //ok
    //        }
    //        else
    //        {
    //            //not validate
    //        }
    //        return View();
    //    }
    //}
}
