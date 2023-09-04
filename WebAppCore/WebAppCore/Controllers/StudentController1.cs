using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Xml.Linq;
using WebAppCore.Models;

namespace WebAppCore.Controllers
{
    public class StudentController1 : Controller
    {
        List<Student> listStudents = new List<Student>()
        {
            new Student() { Id = 1,Name = "Sam",Class = "Five",Fee = 25000.20},
            new Student() { Id = 2,Name ="Deep",Class = "Five",Fee = 25000.20},
            new Student() { Id = 3,Name ="Soniya",Class = "Four",Fee = 25000.20},
            new Student() { Id = 4,Name ="Renu",Class = "Four",Fee = 25000.20},
            new Student() { Id = 5,Name ="Shinu",Class = "Three",Fee = 25000.20}
        };
      
        public IActionResult Index()
        {
            return View(listStudents);
        }
    }
}
