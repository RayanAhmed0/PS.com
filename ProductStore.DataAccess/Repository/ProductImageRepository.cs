using ProductStore.DataAccess.Data;
using ProductStore.DataAccess.Repository.IRepository;
using ProductStore.Models;

namespace ProductStore.DataAccess.Repository
{
    public class ProductImageRepository : Repository<ProductImage>, IProductImageRepository
    {
        public ApplicationDbContext _db;

        public ProductImageRepository(ApplicationDbContext db) : base(db) // we put the base(db) to send the db context to all the bases (Repository<Categoy> , ICategotyRepository)
        {
            _db = db;
        }

        public void Update(ProductImage obj)
        {
            _db.ProductImages.Update(obj);
        }
    }
}