
namespace  BackendProject.Models;

public class EventSpeaker
{
    public int Id { get; set; }
    public int SpeakerId { get; set; }
    public Speaker? Speaker { get; set; }
    public int EventDetailId { get; set; }
    public EventDetail? eventDetail { get; set; }
}