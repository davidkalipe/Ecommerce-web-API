using Ecommerce_web_api.Models;

namespace Ecommerce_web_api.Interfaces;

public interface IUser
{
    Task<List<User>> GetAllUsers();
}