
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace MyProtfolio.ViewComponent
{
    public class SoftwareViewComponent : Microsoft.AspNetCore.Mvc.ViewComponent
    {

        public IViewComponentResult Invoke()
        {

            var softwares = new List<SoftwareModel>
            {
                new SoftwareModel
                {
                    Name = "Sina",
                    Family = "hosieni",
                    Namber = 7,
                },
                new SoftwareModel
                {
                    Name = "mohammad",
                    Family =" rezaee",
                    Namber = 2,
                }
                /*farzad2609*/
            };

            return View("_ListView", softwares);

        }

    }
}
