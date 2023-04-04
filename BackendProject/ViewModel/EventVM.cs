using BackendProject.Models;
namespace BackendProject.ViewModel;

public class EventVM
{
    public List<Event>? events { get; set; }
    public List<EventDetail>? eventDetails { get; set; }

}