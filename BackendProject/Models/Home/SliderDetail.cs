 
 namespace BackendProject.Models;

 public class SliderDetail
 {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Desc { get; set; }
        public string? Button { get; set; }
        public string? ImageUrl { get; set; }


        public int SliderId { get; set; }
       public Slider? slider { get; set; }
 }