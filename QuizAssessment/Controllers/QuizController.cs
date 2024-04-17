using Microsoft.AspNetCore.Mvc;
using QuizAssessment.Data;
using QuizAssessment.Models;

namespace QuizAssessment.Controllers
{
	public class QuizController : Controller
	{
		private readonly ApplicationDbContext _context;
		public QuizController(ApplicationDbContext db) { 
			_context = db;
		}
        public IActionResult Index()
		{		
			var objQuzList=_context.Quizzes.ToList();
			return View(objQuzList);
		}
		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Create(Quiz obj) { 
			_context.Quizzes.Add(obj);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
