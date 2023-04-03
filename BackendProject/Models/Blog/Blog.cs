
namespace   BackendProject.Models;

public class Blog
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Author { get; set; }
    public DateTime time { get; set; }
    //comment count property
    
    
       
    public  BlogDetail? blogDetail { get; set; }
}