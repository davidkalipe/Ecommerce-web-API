using Ecommerce_web_api.Models;

namespace Ecommerce_web_api.Interfaces;

public interface IUser
{
    Task<List<User>> GetAllUsers();
    Task<User> Register(User user);
    Task<bool> Login(string phoneNumber, string password);
}