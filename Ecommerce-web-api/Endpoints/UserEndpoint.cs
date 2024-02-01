using AutoMapper;
using Ecommerce_web_api.DTOs;
using Ecommerce_web_api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce_web_api.Endpoints;

public static class UserEndpoint
{
    public static void MapEndpoints(WebApplication app)
    {
        app.MapGet("User/GetAllUsers", async ([FromServices]UserService userService,[FromServices] IMapper mapper) =>
        {
            var users = await userService.GetAllUsers();
            var lesInfos = mapper.Map<List<UserInfoDto>>(users);
            return Results.Ok(lesInfos);
        });
    }
}