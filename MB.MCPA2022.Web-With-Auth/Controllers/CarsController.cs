using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MB.MCPA2022.Web_With_Auth.Controllers
{
    [Authorize]
    public class CarsController : Controller
    {
        public IActionResult CarsList()
        {
            return View();
        }
    }
}
