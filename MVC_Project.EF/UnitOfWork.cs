using MVC_Project.Core.Interfaces;
using MVC_Project.Core.Models;
using MVC_Project.EF.Repositories;
using Restaurant.Models;

namespace MVC_Project.EF
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RestaurantService _Context;
        public IProductListRepository FoodList { get; private set; }
        public IBaseRepository<Category> CategoryRepository { get; private set; }
        public IBaseRepository<Order>OrderRepository { get; private set; }
        public IBaseRepository<OrderItem> OrderItemRepository { get; private set; }
        public IOrderItemRepository OrderItem { get; private set; }
        public IBaseRepository<Payment> PaymentRepository { get; private set; }
        public IBaseRepository<AppUser> AppUser { get; private set; }






        public UnitOfWork(RestaurantService Context)
        {
            _Context = Context;
            FoodList = new ProductListRepository(_Context);
            CategoryRepository = new BaseRepository<Category>(_Context);
            OrderRepository = new BaseRepository<Order>(_Context);
            OrderItemRepository = new BaseRepository<OrderItem>(_Context);
            OrderItem = new OrderItemRepository(_Context);
            PaymentRepository=new BaseRepository<Payment>(_Context);
            AppUser =new BaseRepository<AppUser>(_Context);

        }


        public int Complete()
        {
            return _Context.SaveChanges();
        }



        public void Dispose()
        {
            _Context.Dispose();
        }
    }
}
