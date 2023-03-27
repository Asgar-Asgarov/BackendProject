using Microsoft.EntityFrameworkCore;
using BackendProject.Models;

namespace BackendProject.DAL;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Slider>Sliders { get; set; }
     public DbSet<SliderDetail>SliderDetail { get; set; }
}
