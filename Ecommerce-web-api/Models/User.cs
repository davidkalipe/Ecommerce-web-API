
namespace Ecommerce_web_api.Models;

public class User
{
    public Guid UserId { get; set; } = Guid.NewGuid();
    public string Username { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string? ProfileImage { get; set; } = string.Empty;
    public bool IsSeller { get; set; } = false;
    public int Graduation { get; set; } = 0;
}