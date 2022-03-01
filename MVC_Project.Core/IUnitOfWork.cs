using MVC_Project.Core.Models;
using MVC_Project.EF.Repositories;
using Restaurant.Models;
using System;

namespace MVC_Project.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        public IProductListRepository ProductList { get; }
        public IBaseRepository<Category> CategoryRepository { get; }
        public IBaseRepository<Order> OrderRepository { get;  }
        public IBaseRepository<OrderItem> OrderItemRepository { get;}
        public IOrderItemRepository OrderItem { get;  }
        public IBaseRepository<Payment> PaymentRepository { get; }
        public IBaseRepository<AppUser> AppUser { get;  }


        int Complete();

    }
}
