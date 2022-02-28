using Restaurant.Models;
using System.Collections.Generic;

namespace MVC_Project.EF.Repositories
{
    public interface IProductListRepository : IBaseRepository<Product>
    {
        public IEnumerable<Product> GetFood();
    }
}