using Microsoft.AspNetCore.Mvc;

namespace MB.MCPA2022.Web.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
    }
}
