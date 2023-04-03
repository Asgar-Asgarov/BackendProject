
namespace   BackendProject.Models;

public class Blog
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? ImageUrl { get; set; }
    public string? Author { get; set; }
    public DateTime time { get; set; }

    public int CommentCount { get; set; }
    
       
    public  BlogDetail? blogDetail { get; set; }
}