using ProductStore.DataAccess.Data;
using ProductStore.DataAccess.Repository.IRepository;
using ProductStore.Models;

namespace ProductStore.DataAccess.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        public ApplicationDbContext _db;

        public ApplicationUserRepository(ApplicationDbContext db) : base(db) // we put the base(db) to send the db context to all the bases (Repository<Categoy> , ICategotyRepository)
        {
            _db = db;
        }
        public void Update(ApplicationUser applicationUser)
        {
            _db.ApplicationUsers.Update(applicationUser);


        }
    }
}