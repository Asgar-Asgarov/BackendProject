
namespace BackendProject.Models;

public class Event
{
    public int Id { get; set; }
    public string? IconUrl { get; set; }
    

    public EventDetail? eventDetail { get; set; }
  
}