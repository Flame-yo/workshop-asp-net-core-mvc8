using SalesWebMvc8.Data;
using SalesWebMvc8.Models;
using SalesWebMvc8.Services.Exceptions;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace SalesWebMvc8.Services
{
    public class SellerService
    {
        private readonly SalesWebMvc8Context _context;

        public SellerService(SalesWebMvc8Context context)
        {
            _context = context;
        }

        public async Task<List<Seller>> FindAllAsync()
        {
            return await _context.Seller.ToListAsync();
        }

        public async Task InsertAsync(Seller seller)
        {
            _context.Add(seller);
            await _context.SaveChangesAsync();
        }

        public async Task<Seller> FindByIdAsync(int id)
        {
            return await _context.Seller.Include(x => x.Department).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            Seller seller = await _context.Seller.FindAsync(id);
            _context.Seller.Remove(seller);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Seller seller)
        {
            if (! await _context.Seller.AnyAsync(s => s.Id == seller.Id))
            {
                throw new NotFoundException("Id not found");
            }
            try
            {
                _context.Update(seller);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
