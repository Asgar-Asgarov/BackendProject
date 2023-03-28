
namespace BackendProject.Models;

public class Event
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string?  Place { get; set; }
    public DateTime date { get; set; }
    public DateTime time { get; set; }
    
}