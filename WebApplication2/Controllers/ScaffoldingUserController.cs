//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using AspNetCoreMvc.Models.Repositories;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Extensions.Configuration;

//namespace AspNetCoreMvc.Controllers
//{
//    public class ScaffoldingUserController : Controller
//    {

//        private readonly UserRepository _userRepository;

//        public ScaffoldingUserController()
//        {
//            _userRepository = new UserRepository();
//        }    

//        // GET: ScaffoldingUserController
//        public ActionResult Index()
//        {
//            return View(_userRepository.Get());
//        }

//        // GET: ScaffoldingUserController/Details/5
//        public ActionResult Details(int id)
//        {
//            return View(_userRepository.Find());
//        }

//        // GET: ScaffoldingUserController/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

//        // POST: ScaffoldingUserController/Create
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create(IFormCollection collection)
//        {
//            try
//            {
//                return RedirectToAction(nameof(Index));
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        // GET: ScaffoldingUserController/Edit/5
//        public ActionResult Edit(int id)
//        {
//            return View(_userRepository.Find());
//        }

//        // POST: ScaffoldingUserController/Edit/5
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit(int id, IFormCollection collection)
//        {
//            try
//            {
//                return RedirectToAction(nameof(Index));
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        // GET: ScaffoldingUserController/Delete/5
//        public ActionResult Delete(int id)
//        {
//            return View(_userRepository.Find());
//        }

//        // POST: ScaffoldingUserController/Delete/5
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Delete(int id, IFormCollection collection)
//        {
//            try
//            {
//                return RedirectToAction(nameof(Index));
//            }
//            catch
//            {
//                return View();
//            }
//        }
//    }
//}
