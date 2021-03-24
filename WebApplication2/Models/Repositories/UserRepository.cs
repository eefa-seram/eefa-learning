using AspNetCoreMvc.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvc.Models.Repositories
{
    public class UserRepository
    {

        private readonly List<Users> _users = new List<Users>();

        public UserRepository()
        {
            _users.Add(new Users
            {
                Age = 28,
                Email = "gharibehdlife@gmail.com",
                Id = 1,
                Mobile = "09910793449",
                Name = "فرزاد"
            });

            _users.Add(new Users
            {
                Age = 31,
                Email = "behzad.danesh@gmail.com",
                Id = 2,
                Mobile = "09132222222",
                Name = "بهزاد"
            });
            _users.Add(new Users
            {
                Age = 25,
                Email = "saeed.adabi@gmail.com",
                Id = 2,
                Mobile = "09132333222",
                Name = "سعید"
            });
            _users.Add(new Users
            {
                Age = 30,
                Email = "farhad.salehi@gmail.com",
                Id = 2,
                Mobile = "09132244442",
                Name = "فرهاد"
            });
            _users.Add(new Users
            {
                Age = 31,
                Email = "hamidreza.ardakani@gmail.com",
                Id = 2,
                Mobile = "09135555222",
                Name = "حمیدرضا"
            });
        }
        public List<Users> Get()
        {
            return _users;
        }
        public Users Find()
        {
            return _users.FirstOrDefault();
        }
    }
}
