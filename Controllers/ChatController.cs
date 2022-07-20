using Microsoft.AspNetCore.Mvc;

namespace ProjectPRN211.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Chat()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();

        }public IActionResult Register()
        {
            return View();
        }
    }
}
