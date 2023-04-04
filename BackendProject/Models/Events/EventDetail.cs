
namespace BackendProject.Models;

public class EventDetail
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? ImageUrl { get; set; }
    public string? Description { get; set; }
    public string?  Place { get; set; }
    public DateTime date { get; set; }
    public DateTime startTime { get; set; }
    public DateTime finishTime { get; set; }
   

    
    public int EventId { get; set; }
    public Event?  Event { get; set; }

    public Speaker? Speaker { get; set; }
}