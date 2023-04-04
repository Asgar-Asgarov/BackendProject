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
     public DbSet<Thought> thought { get; set; }

     //course
     public DbSet<Category> categories  { get; set; }
     public DbSet<Course> courses { get; set; }
     public DbSet<CourseDetail> CourseDetail { get; set; }

     //event
     public DbSet<Event> events { get; set; }
     public DbSet<EventDetail> eventDetail { get; set; }
     public DbSet<Speaker> Speaker { get; set; }
     public DbSet<EventSpeaker> EventSpeaker { get; set; }
     //blog 
     public DbSet<Blog> blog { get; set; }
     public DbSet<BlogDetail> BlogDetail { get; set; }
     

     //teacher


     //Icon
     public DbSet<Icon> Icon { get; set; }    
     



}
