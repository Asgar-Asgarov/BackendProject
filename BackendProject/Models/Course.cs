
namespace BackendProject.Models;

public class Course
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string ImageUrl { get; set; }
    public string CategoryId { get; set; }
    public Category Category { get; set; }        
}