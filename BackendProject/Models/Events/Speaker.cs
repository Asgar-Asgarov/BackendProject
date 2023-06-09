
namespace BackendProject.Models;

public class Speaker
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? ImageUrl { get; set; }
    public string? Profession { get; set; }
    public string? CompanyName { get; set; }

    public List<EventSpeaker>? EventSpeakers { get; set; }
    
}