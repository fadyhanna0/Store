using Microsoft.EntityFrameworkCore;
using Restaurant.Models;
using System.Collections.Generic;
using System.Linq;

namespace MVC_Project.EF.Repositories
{
    public class ProductListRepository : BaseRepository<Product>, IProductListRepository
    {
        private readonly RestaurantService _context;

        public ProductListRepository(RestaurantService context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetFood()
        {
            return _context.Products.Include(s => s.Category).ToList();
        }
    }
}
