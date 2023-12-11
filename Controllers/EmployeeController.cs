using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index1(){
            string message = $"Hello World. {DateTime.Now.ToString()}";
            return View("Index1",message);
        }

        public ViewResult Index2(){

            var names = new String[] {
                "Ahmet",
                "Ali",
                "Ayşe"
            };
            return View(names);
        }

        public IActionResult Index3(){
            var list = new List<Employee>()
            {
                new Employee(){Id=1, FirstName="Birkan", LastName="Karaer", Age=23},
                new Employee(){Id=2, FirstName="Emre", LastName="Dağ", Age=23},
                new Employee(){Id=3, FirstName="Hüseyin", LastName="Aktepe", Age=21},
                
            };
            return View("Index3",list);
        }
    }
}