
using Dapper.Contrib.Extensions;

namespace Blog.Models;

[Table("[User]")]
public class User : BaseModel
{
    public User()
        => Roles = new List<Role>();

    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public string Bio { get; set; }
    public string Image { get; set; }

    [Write(false)]
    public List<Role> Roles { get; set; }
}