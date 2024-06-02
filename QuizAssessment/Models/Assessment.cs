using System.ComponentModel.DataAnnotations;

namespace QuizAssessment.Models
{
    public class Assessment
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public float Grade { get; set; }
    }
}
