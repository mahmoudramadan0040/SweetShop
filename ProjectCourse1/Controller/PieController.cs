using Microsoft.AspNetCore.Mvc;
using ProjectCourse1.Models;

namespace ProjectCourse1.Controllers
{
    public class PieController :Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;
        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }
        public IActionResult List()
        {
            ViewBag.CurrentCategory = "hello world";
            return View(_pieRepository.AllPies);
        }
        public IActionResult Details(int id)
        {
            var pie = _pieRepository.GetPieById(id);
            if(pie == null)
            {
                return NotFound();
            }
            return View(pie);
        }
    }
}
