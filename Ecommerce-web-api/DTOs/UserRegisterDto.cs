namespace Ecommerce_web_api.DTOs;

public class UserRegisterDto
{
    public string Username { get; set; }
    public string PhoneNumber { get; set; }
    public string Password { get; set; }
    public string? ProfileImage { get; set; }
}