using System.ComponentModel.DataAnnotations;

namespace QuizAssessment.Models
{
	public class Quiz
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Question { get; set; }
		[Required]
		public string Answer { get; set; }
	}
}
