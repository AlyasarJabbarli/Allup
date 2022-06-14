using Allup.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Allup.Models;
using Allup.ViewModels.BasketViewModels;
using Newtonsoft.Json;

namespace Allup.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        public ProductController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            
            return View(await _context.Products.ToListAsync());
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) 
            { 
                return BadRequest();
            }

            Product product = await _context.Products
                .Include(p=> p.ProductImages)
                .Include(p=> p.Brand)
                .Include(p=> p.ProductTags).ThenInclude(pt=>pt.Tag)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (product == null) 
            {
                return NotFound();
            }

            return View(product);
        }

        public  async Task<IActionResult> DetailForModal(int ? id) 
        {
            if (id == null)
            {
                return BadRequest();
            }

            Product product = await _context.Products
                .Include(p => p.ProductImages)
                .Include(p => p.Brand)
                .Include(p => p.ProductTags).ThenInclude(pt => pt.Tag)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }
            return PartialView("_ProductModalPartial" , product);
        }

        public async  Task<IActionResult> Search(string search)
        {
            List<Product> products = await _context.Products
                .Where(p => p.Name.ToLower().Contains(search.Trim().ToLower()) 
                || p.Brand.Name.ToLower().Contains(search.Trim().ToLower()) 
                || p.ProductTags.Any(pt => pt.Tag.Name.Contains(search.Trim().ToLower())))
                .ToListAsync();

            return PartialView("_SearchPartial", products);
        }

        public async Task<IActionResult> AddToBasket(int? id)
        {
            if(id == null)
            {
                return BadRequest();
            }

            Product product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);

            if(product == null)
            {
                return NotFound();
            }

            string basket = HttpContext.Request.Cookies["basket"];

            List<BasketVM> basketVMs = null;

            if(basket != null)
            {
                basketVMs = JsonConvert.DeserializeObject<List<BasketVM>>(basket);
            }
            else
            {
                basketVMs = new List<BasketVM>();
            }
            if (basketVMs.Exists(b => b.ProductID == id))
            {
                basketVMs.Find(b => b.ProductID == id).Count++;
            }
            else
            {
                BasketVM basketVM = new BasketVM
                {
                    ProductID = product.Id,
                    Count = 1,
                    Image = product.MainImage,
                    Name = product.Name,
                    Price = product.DiscountPrice > 0 ? product.DiscountPrice : product.Price,
                    ExTax = product.ExTax
                };

                basketVMs.Add(basketVM);
            }



            basket = JsonConvert.SerializeObject(basketVMs);

            HttpContext.Response.Cookies.Append("basket", basket);

            return PartialView("_BasketPartial", basketVMs);

            return PartialView("_BasketPartial");
        }

        public IActionResult DeleteFromBasket(int? id) 
        {
            if (id == null)
            {
                return BadRequest();
            }

            string basket = HttpContext.Request.Cookies["basket"];

            List<BasketVM> basketVMs = JsonConvert.DeserializeObject<List<BasketVM>>(basket); 
            

            if (basketVMs.Exists(b => b.ProductID == id))
            {
                basketVMs.Remove(basketVMs.Find(b => b.ProductID == id));
            }

            return PartialView("_BasketPartial", basketVMs);
        }
    }
}
