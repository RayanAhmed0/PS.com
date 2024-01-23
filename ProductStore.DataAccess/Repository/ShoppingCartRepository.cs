using ProductStore.DataAccess.Data;
using ProductStore.DataAccess.Repository.IRepository;
using ProductStore.Models;

namespace ProductStore.DataAccess.Repository
{
    public class ShoppingCartRepository : Repository<ShoppingCart>, IShoppingCartRepository
    {
        public ApplicationDbContext _db;

        public ShoppingCartRepository(ApplicationDbContext db) : base(db) // we put the base(db) to send the db context to all the bases (Repository<Categoy> , ICategotyRepository)
        {
            _db = db;
        }

        public void Update(ShoppingCart obj)
        {
            _db.ShoppingCarts.Update(obj);
        }
    }
}