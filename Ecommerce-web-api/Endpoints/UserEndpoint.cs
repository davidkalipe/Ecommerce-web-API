using AutoMapper;
using Ecommerce_web_api.Data;
using Ecommerce_web_api.DTOs;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce_web_api.Endpoints;

public static class UserEndpoint
{
    public static void MapEndpoints(WebApplication app)
    {
        app.MapGet("User/GetAllUsers", async ([FromServices]DataContext dbContext,[FromServices] IMapper mapper) =>
        {
            var users =await dbContext.Users.ToListAsync();
            var lesInfos = mapper.Map<List<UserInfoDto>>(users);
            return Results.Ok(lesInfos);
        });
    }
}