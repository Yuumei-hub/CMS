using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebProje.Controllers
{
    public class UserController : Controller
    {
        UserManager userManager = new UserManager(new EfUserDal());
        public IActionResult Index()
        {
            var values = userManager.TGetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateUser(User user)
        {
            userManager.TCreate(user);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteUser(int id)
        {
            var values = userManager.TGetById(id);
            userManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateUser(int id)
        {
            var values = userManager.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateUser(User user)
        {
            userManager.TUpdate(user);
            return RedirectToAction("Index");
        }
    }
}
