using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuizAssessment.Data;
using QuizAssessment.Models;
using QuizAssessment.ViewModels;

namespace QuizAssessment.Controllers
{
    public class AssessmentController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AssessmentController(ApplicationDbContext context) {  _context = context; }
        // GET: AssessmentController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AssessmentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AssessmentController/Create
        public ActionResult Exam()
        {
            var quiz=_context.Quizzes.ToList();
            var viewModel = new QuizAssessmentViewModels
            {
                Quiz = quiz,
            };
            return View(viewModel);
        }

        // POST: AssessmentController/Create
        [HttpPost]
       public IActionResult Create(List<string> answer)
        {
            var obj = new Assessment { "Hong Kien", 9.0f};
            if (answer[0]=="2") _context.Add(obj);
			return RedirectToAction("Index");
        }
    }
}
