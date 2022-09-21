using Microsoft.AspNetCore.Mvc;

namespace Lab3Assignment.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult SignUp()
        {
            return View();
        }
    }
}
