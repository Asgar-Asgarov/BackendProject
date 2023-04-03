
namespace BackendProject.Models;

public class Slider
{
    public int Id { get; set; }
    public string? ImageUrl { get; set; }

    public SliderDetail? SliderDetail { get; set; }
}