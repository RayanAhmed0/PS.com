using ProductStore.Models;

namespace ProductStore.DataAccess.Repository.IRepository
{
    public interface IApplicationUserRepository : IRepository<ApplicationUser>
    {


        public void Update(ApplicationUser applicationUser);
    }
}