using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebProje.Controllers
{
    public class GameController : Controller
    {
        GameManager gameManager = new GameManager(new EfGameDal());
        public IActionResult Index()
        {
            var values = gameManager.TGetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateGame()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateGame(Game game)
        {
            gameManager.TCreate(game);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteGame(int id)
        {
            var values = gameManager.TGetById(id);
            gameManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateGame(int id) 
        {
            var values = gameManager.TGetById(id);
            return View(values);
        }
        [HttpPost]

        public IActionResult UpdateGame(Game game) 
        {
            gameManager.TUpdate(game);
            return RedirectToAction("Index");
        }
    }
}
