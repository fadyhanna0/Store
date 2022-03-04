using Microsoft.EntityFrameworkCore;
using Restaurant.Models;
using System.Collections.Generic;
using System.Linq;

namespace MVC_Project.EF.Repositories
{
    public class ProductListRepository : BaseRepository<Product>, IProductListRepository
    {
        private readonly AppService _context;

        public ProductListRepository(AppService context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetProduct()
        {
            return _context.Products.Include(s => s.Category).ToList();
        }
    }
}
