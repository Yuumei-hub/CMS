using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebProje.Controllers
{
    public class SliderController : Controller
    {
        SliderManager sliderManager = new SliderManager(new EfSliderDal());
        public IActionResult Index()
        {
            var values = sliderManager.TGetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateSlider()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateSlider(Slider slider)
        {
            sliderManager.TCreate(slider);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteSlider(int id)
        {
            var values = sliderManager.TGetById(id);
            sliderManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateSlider(int id)
        {
            var values = sliderManager.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateSlider(Slider slider)
        {
            sliderManager.TUpdate(slider);
            return RedirectToAction("Index");
        }
    }
}
