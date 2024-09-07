using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebProje.ViewComponents.Game
{
    public class GameList: ViewComponent
    {
        GameManager gameManager = new GameManager(new EfGameDal()); 
        public IViewComponentResult Invoke()
        {
            var values = gameManager.TGetAll();
            return View(values);
        }
    }
}
