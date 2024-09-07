using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebProje.ViewComponents.Slider
{
    public class SliderList: ViewComponent
    {
        SliderManager sliderManager = new SliderManager(new EfSliderDal());
        public IViewComponentResult Invoke()
        {
            var values = sliderManager.TGetAll();
            return View(values);
        }
    }
}
