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

    public async Task<User> Register(User user)
    {
        await _dataContext.Users.AddAsync(user);
        await _dataContext.SaveChangesAsync();
        return user;
    }

    public async Task<bool> Login(string phoneNumber, string password)
    {
        var checkPwd = "";
        var user = await _dataContext.Users.Where(u => u.PhoneNumber == phoneNumber && u.Password == checkPwd).FirstOrDefaultAsync();
        if (user is null)
            return false;
        return true;
    }
}