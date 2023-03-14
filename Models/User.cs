
using Dapper.Contrib.Extensions;

namespace Blog.Models;

[Table("[User]")]
public class User : BaseModel
{
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public string Bio { get; set; }
    public string Image { get; set; }
}