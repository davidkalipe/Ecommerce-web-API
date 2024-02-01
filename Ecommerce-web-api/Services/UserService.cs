using Ecommerce_web_api.Data;
using Ecommerce_web_api.Interfaces;
using Ecommerce_web_api.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce_web_api.Services;

public class UserService : IUser
{
    private readonly DataContext _dataContext;

    public UserService(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public async Task<List<User>> GetAllUsers()
    {
        var userList = await _dataContext.Users.ToListAsync();
        return userList;
    }
}