using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using new1.Data;
using new1.Models;

namespace StudentLines.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _db;
        public StudentController(ApplicationDbContext db) => _db = db;

        // GET: صفحة البحث
        public IActionResult Search() => View();

        // POST: تنفيذ البحث
        [HttpPost]
        public async Task<IActionResult> SearchResult(string? keyword,
                                                      string? area,
                                                      string? carNumber,
                                                      string? driverName,
                                                      string? driverCode)

        {
            var q = _db.Drivers.AsQueryable();

            if (!string.IsNullOrWhiteSpace(keyword))
                q = q.Where(d => d.Name.Contains(keyword) ||
                                 d.CarNumber.Contains(keyword) ||
                                 d.Areas.Contains(keyword));

            if (!string.IsNullOrWhiteSpace(area))
                q = q.Where(d => d.Areas.Contains(area));

            if (!string.IsNullOrWhiteSpace(carNumber))
                q = q.Where(d => d.CarNumber.Contains(carNumber));

            if (!string.IsNullOrWhiteSpace(driverName))
                q = q.Where(d => d.Name.Contains(driverName));

            if (!string.IsNullOrWhiteSpace(driverCode))
                q = q.Where(d => d.Id.ToString() == driverCode); // نستخدم Id كرمز

            var list = await q.ToListAsync();
            return View(list); // نمرّر List<Driver>
        }
    }
}