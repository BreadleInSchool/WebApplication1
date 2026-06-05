using WebApplication1.DTOs;

namespace WebApplication1.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repo;
        public Task<UserDto> CreateUser(CreateUserDto user)
        {
            throw new NotImplementedException();
        }

        public Task<UserDto> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
