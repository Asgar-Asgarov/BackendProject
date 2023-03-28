
namespace BackendProject.Models;

public class CourseDetail
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? About { get; set; }
    public string? InfoApply { get; set; }
    public DateTime Date { get; set; }
    public int Duration { get; set; }
    public int ClassDuration { get; set; }
    public string? SkillLevel { get; set; } 
    public string? Language { get; set; }
    public int CountStudent { get; set; }
    public string? Assesment { get; set; }
    public int Price { get; set; }

}