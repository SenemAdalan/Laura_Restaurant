using Cafe.Data;
using Cafe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NToastNotify;
using System.Diagnostics;

namespace Cafe.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;
        private readonly IToastNotification _toast;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db, IToastNotification toast)
        {
            _logger = logger;
            _db = db;
            _toast = toast; 
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Menu()
        {
            return View();
        }

        // GET: Customer/Reservation/Create
        public IActionResult Reservation()
        {
            return View();
        }

        // POST: Customer/Reservation/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Reservation([Bind("Id,Name,Email,TelNo,Sayi,Saat,Tarih")] Reservation reservation)
        {
            if (ModelState.IsValid)
            {
                _db.Add(reservation);
                await _db.SaveChangesAsync();
                _toast.AddSuccessToastMessage("Teþekkür ederiz. Rezervasyon iþleminiz baþarýyla gerçekleþtirildi.");
                return RedirectToAction(nameof(Index));
            }
            return View(reservation);
        }


        public IActionResult Gallery()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Blog()
        {
            return View();
        }

        public IActionResult Contact()
        {
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
    }
}
