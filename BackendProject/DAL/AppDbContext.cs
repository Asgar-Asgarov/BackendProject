using Microsoft.EntityFrameworkCore;
using BackendProject.Models;

namespace BackendProject.DAL;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
    //home
     public DbSet<Slider>Sliders { get; set; }
     public DbSet<SliderDetail>SliderDetail { get; set; }
     public DbSet<Notice>Notices { get; set; }
     public DbSet<Info> info { get; set; }

     //course
     public DbSet<Category> categories  { get; set; }
     public DbSet<Course> courses { get; set; }

}
