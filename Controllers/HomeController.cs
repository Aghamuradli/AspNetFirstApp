using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ASP.NetFİrstApp.Controllers
{

    //action - her ansi bir seifenin ve ya her hansi bir mentiqin arxasinda duran FUNKSIYA
    //bir kontroller icinde bir nece action ola biler 
    //Her bir viewde ise bir action olur

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<string> students = new List<string>();
            students.Add("Babek");
            students.Add("Elshad");
            students.Add("Aydin");


            return View(students);
        }
    }
}
