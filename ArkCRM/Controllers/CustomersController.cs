using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ArkCRM.Models;
using ArkCRM.Data;

namespace ArkCRM.Controllers
{
    public class CustomersController : Controller
    {
        private readonly CustomersDbContext _context;
        public CustomersController(CustomersDbContext context) 
        {
            _context = context;
        }

        public async Task <IActionResult> Index()
        {
            var customer = await _context.Customers.ToListAsync();
            return View(customer);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
