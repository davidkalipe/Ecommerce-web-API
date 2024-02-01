namespace Ecommerce_web_api.DTOs;

public class UserInfoDto
{
    public string Username { get; set; }
    public string PhoneNumber { get; set; }
    public string Password { get; set; }
    public string? ProfileImage { get; set; }
    public bool IsSeller { get; set; }
    public int Graduation { get; set; }
}