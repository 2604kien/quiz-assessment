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
		public IActionResult Exam()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Create(Quiz obj) { 
			if (ModelState.IsValid)
			{
                _context.Quizzes.Add(obj);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
			return View();
		}
		public IActionResult Edit(int? id)
		{
            if ((id==null)||id==0)
            {
				return NotFound();
            }
			Quiz foundedQuiz=_context.Quizzes.Find(id);
			if(foundedQuiz==null)
			{
				return NotFound();
			}
            return View(foundedQuiz);
		}
		[HttpPost]
		public IActionResult Edit(Quiz obj) {
			if(ModelState.IsValid)
			{
				_context.Quizzes.Update(obj);
				_context.SaveChanges();
				return RedirectToAction("Index");
			}
			return View();
		}
        [HttpPost]
        public IActionResult Delete(int id)
        {
            Quiz obj = _context.Quizzes.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _context.Quizzes.Remove(obj);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
