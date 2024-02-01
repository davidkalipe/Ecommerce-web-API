using Ecommerce_web_api.Data;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce_web_api.Endpoints;

public static class UserEndpoint
{
    public static void MapEndpoints(WebApplication app)
    {
        app.MapGet("User/GetAllUsers", async (DataContext dbContext) =>
        {
            await dbContext.Users.ToListAsync();
        });
    }
}