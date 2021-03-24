using WebApplication2.Models.Entities;
using WebApplication2.Models.ViewModels;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;


namespace WebApplication2.Models.Repositories
{



    public class UserRepository
    {
        private readonly List<Users> _users;

        public UserRepository()
        {
            _users = new List<Users>();

            //add fake user


            _users.Add(new Users
            {
                Address = "یزد - اردکان- خیابان شیخ بهایی - کوچه مهران - پلاک 3 - واحد 2",
                Email = "farhad@gmail.com",
                Id = 1,
                Job = "سرپرست تیم",
                LastName = "صالحی",
                Name = "فرهاد",
                PhoneNumber = "09130000002",
            });
            _users.Add(new Users
            {
                Address = "یزد - اردکان- خیابان شیخ بهایی - کوچه مهران - پلاک 3 - واحد 22",
                Email = "saeed@gmail.com",
                Id = 2,
                Job = "پشتیبانی نرم افزار",
                LastName = "ادبی",
                Name = "سعید",
                PhoneNumber = "09130000002",
            });

            _users.Add(new Users
            {
                Address = "یزد - اردکان- خیابان صدرآباد - کوچه مهران - پلاک 3 - واحد 2",
                Email = "farzad@gmail.com",
                Id = 3,
                Job = "برنامه نویس",
                LastName = "همت جو",
                Name = "فرزاد",
                PhoneNumber = "09130000002",
            });

        }


        public List<UserListViewModel> GetUserList()
        {
            List<UserListViewModel> users = _users.Select(p => new UserListViewModel
            {
                Id = p.Id,
                Email = p.Email,
            }).ToList();
            return users;
        }

        public UserDetailViewModel Find(long Id)
        {
            var user = _users.Where(p => p.Id == Id).FirstOrDefault();
            return new UserDetailViewModel()
            {
                Address = user.Address,
                Email = user.Email,
                Id = user.Id,
                Job = user.Job,
                LastName = user.LastName,
                Name = user.Name,
                PhoneNumber = user.PhoneNumber,
            };
        }




        //public class UserRepository
        //{

        //    private readonly List<Users> _users = new List<Users>();

        //    public UserRepository()
        //    {
        //        _users.Add(new Users
        //        {
        //            Age = 28,
        //            Email = "gharibehdlife@gmail.com",
        //            Id = 1,
        //            Mobile = "09910793449",
        //            Name = "فرزاد"
        //        });

        //        _users.Add(new Users
        //        {
        //            Age = 31,
        //            Email = "behzad.danesh@gmail.com",
        //            Id = 2,
        //            Mobile = "09132222222",
        //            Name = "بهزاد"
        //        });
        //        _users.Add(new Users
        //        {
        //            Age = 25,
        //            Email = "saeed.adabi@gmail.com",
        //            Id = 2,
        //            Mobile = "09132333222",
        //            Name = "سعید"
        //        });
        //        _users.Add(new Users
        //        {
        //            Age = 30,
        //            Email = "farhad.salehi@gmail.com",
        //            Id = 2,
        //            Mobile = "09132244442",
        //            Name = "فرهاد"
        //        });
        //        _users.Add(new Users
        //        {
        //            Age = 31,
        //            Email = "hamidreza.ardakani@gmail.com",
        //            Id = 2,
        //            Mobile = "09135555222",
        //            Name = "حمیدرضا"
        //        });
        //    }
        //    public List<Users> Get()
        //    {
        //        return _users;
        //    }
        //    public Users Find()
        //    {
        //        return _users.FirstOrDefault();
        //    }
        //}
    }

}