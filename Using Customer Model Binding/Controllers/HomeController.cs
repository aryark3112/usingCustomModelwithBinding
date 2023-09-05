using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Using_Customer_Model_Binding.Models;


namespace Using_Customer_Model_Binding.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult StudentEditView()
        {
            return View();
        }

        [HttpPost]
        public ContentResult StudentEditView(StudentModel model)
        {
            string result = model.Name + "," + model.Address + "," + model.WhichClass + "," + model.TotalMarks.ToString();
            return Content("Form was submitted:\n" + result);
        }
    }
}
