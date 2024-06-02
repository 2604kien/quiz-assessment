using QuizAssessment.Models;
using System.Diagnostics.CodeAnalysis;

namespace QuizAssessment.ViewModels
{
	public class QuizAssessmentViewModels
	{
		[AllowNull]
		public List<Quiz>	Quiz { get; set; }
		[AllowNull]
		public Assessment Assessment { get; set; }
	}
}
