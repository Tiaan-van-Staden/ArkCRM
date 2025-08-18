using Microsoft.AspNetCore.Mvc;
using ArkCRM.Models;

namespace ArkCRM.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Overview()
        {
            var customer = new Customer() { CustomerName = "Tiaan", Address = "19 Harry Road", ContactNumber = 0812796647, Email = "tiaanvstaden@gmail.com" };
            return View(customer);
        }
    }
}
