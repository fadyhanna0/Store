using MVC_Project.Core.Interfaces;
using Restaurant.Models;
using System;
using System.Collections.Generic;

namespace MVC_Project.EF.Repositories
{
    public class mneuRepository : BaseRepository<Product>, Imenu
    {
        private readonly RestaurantService _Context;
        public mneuRepository(RestaurantService Context) : base(Context)
        {

        }
        public IEnumerable<Product> menu_getall()
        {
            throw new NotImplementedException();
        }
    }
}
