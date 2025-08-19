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

        public async Task<IActionResult> Index(int? pageNumber, string? SearchText = "")
        {
            const int pageSize = 10;
           
            var customers = _context.Customers
                .OrderBy(c => c.Id);

            var indexResult = await PaginatedList<Customer>.CreateAsync(
               customers.AsNoTracking(),
               pageNumber ?? 1,
               pageSize);


            if (SearchText != "" && SearchText != null)
            {
                indexResult = await PaginatedList<Customer>.CreateAsync(
               _context.Customers.Where(p => p.Name.Contains(SearchText)).AsNoTracking(),
               pageNumber ?? 1,
               pageSize);
            }         

            return View(indexResult);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Id, Name, Address, TelephoneNumber, ContactPersonName, ContactPersonEmail, VatNumber")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                _context.Customers.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var customer = await _context.Customers.FirstOrDefaultAsync(x=>x.Id == id);
            return View(customer);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, Name, Address, TelephoneNumber, ContactPersonName, ContactPersonEmail, VatNumber")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                _context.Customers.Update(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var customer = await _context.Customers.FirstOrDefaultAsync(x => x.Id == id);
            return View(customer);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }
    }
}
