using Microsoft.AspNetCore.Mvc;
using SalesWebMvc8.Models;
using SalesWebMvc8.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc8.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }

        public IActionResult Index()
        {
            List<Seller> obj = _sellerService.FindAll();

            return View(obj);
        }
    }
}
