using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebProje.Controllers
{
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());
        public IActionResult Index()
        {
            var values = aboutManager.TGetAll();
            return View(values);
        }
        
        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var values = aboutManager.TGetById(id);
            return View(values);
        }
        [HttpPost]

        public IActionResult UpdateAbout(About about)
        {
            aboutManager.TUpdate(about);
            return RedirectToAction("Index");
        }
    }
}
