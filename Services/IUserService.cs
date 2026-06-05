using WebApplication1.DTOs;

namespace WebApplication1.Services
{
    public interface IUserService
    {
        Task<UserDto> GetById(int id);
        Task<UserDto> CreateUser(CreateUserDto user);
    }
}
