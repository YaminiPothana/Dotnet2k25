
using Microsoft.AspNetCore.Mvc;

namespace Ticket_Management.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult BookTickets(int ticketCount)
        {
            if (ticketCount < 0 || ticketCount > 6)
            {
                TempData["Message"] = "You can book a maximum of 6 tickets only!";
            }
            else
            {
                TempData["Message"] = $"Your {ticketCount} ticket(s) are booked!";
            }

            return RedirectToAction("Index");
        }
    }
}
