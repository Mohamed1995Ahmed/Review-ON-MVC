using ABC.FirstProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace ABC.FirstProject.Controllers
{
    public class StudentController : Controller
    {
        StudentBL studentBL=new StudentBL();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DisplayAll()

        {
           var t= studentBL.GetAll();
            return View("DisplayAll", t);
        }
        public IActionResult DisplayById(int id)

        {
            //
            var t = studentBL.GetById(id);
            return View("Displaybyid", t);
        }
    }
   
    }
