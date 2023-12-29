using SalesWebMvc8.Data;
using SalesWebMvc8.Models;
using System.Linq;
using System.Collections.Generic;

namespace SalesWebMvc8.Services
{
    public class SellerService
    {
        private readonly SalesWebMvc8Context _context;

        public SellerService(SalesWebMvc8Context context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
