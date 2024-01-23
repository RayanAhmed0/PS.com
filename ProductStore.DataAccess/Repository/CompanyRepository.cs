using ProductStore.DataAccess.Data;
using ProductStore.DataAccess.Repository.IRepository;
using ProductStore.Models;

namespace ProductStore.DataAccess.Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        public ApplicationDbContext _db;

        public CompanyRepository(ApplicationDbContext db) : base(db) // we put the base(db) to send the db context to all the bases (Repository<Company> , ICompanyRepository)
        {
            _db = db;
        }

        public void Update(Company obj)
        {
            _db.Companies.Update(obj);
        }
    }
}