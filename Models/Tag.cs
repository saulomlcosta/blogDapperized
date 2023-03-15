using Dapper.Contrib.Extensions;

namespace Blog.Models;

[Table("[Tag]")]
public class Tag : BaseModel
{
    [Write(false)]
    public List<Post> Posts { get; set; }
}