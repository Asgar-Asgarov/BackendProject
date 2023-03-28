 
 namespace BackendProject.Models;

 public class Category
 {
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Course> courses { get; set; }
 }