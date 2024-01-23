using ProductStore.DataAccess.Data;
using ProductStore.DataAccess.Repository.IRepository;
using ProductStore.Models;

namespace ProductStore.DataAccess.Repository
{
    public class OrderDetailRepository : Repository<OrderDetail>, IOrderDetailRepository
    {
        public ApplicationDbContext _db;

        public OrderDetailRepository(ApplicationDbContext db) : base(db) // we put the base(db) to send the db context to all the bases (Repository<Categoy> , ICategotyRepository)
        {
            _db = db;
        }

        public void Update(OrderDetail obj)
        {
            _db.OrderDetails.Update(obj);
        }
    }
}