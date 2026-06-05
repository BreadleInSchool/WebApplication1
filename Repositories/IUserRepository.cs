using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public interface IUserRepository
    {
        IQueryable<User> GetAll();
        Task<User> CreateAsync(User user);
    }
}
