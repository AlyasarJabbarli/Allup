using Allup.DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult>  Index()
        {
            HttpContext.Response.Cookies.Append("p129", "P129 Hello Cookie");
            return View(await _context.Products.ToListAsync());
        }
        public IActionResult GetSession()
        {
            string session = HttpContext.Session.GetString("p129");
            return Content(session);
        }
        public IActionResult GetCookie()
        {
            string session = HttpContext.Request.Cookies["p129"];
            return Content(session);
        }

    }
}
