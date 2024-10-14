using System.ComponentModel.DataAnnotations;

namespace WorkoutWebApp.Models
{
    public class Workout
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Exercise { get; set; } 
        public int Sets { get; set; }
        public int Reps { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedDatetime { get; set;} = DateTime.Now;    
    }
}
