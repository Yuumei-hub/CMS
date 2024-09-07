using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SliderManager : ISliderService
    {
        ISliderDal _sliderDal;
        public SliderManager(ISliderDal sliderDal)
        {
            this._sliderDal = sliderDal;
        }

        public void TCreate(Slider t)
        {
            _sliderDal.Create(t);
        }

        public void TDelete(Slider t)
        {
            _sliderDal.Delete(t);
        }

        public List<Slider> TGetAll()
        {
            return _sliderDal.GetAll();
        }

        public Slider TGetById(int id)
        {
            return _sliderDal.GetById(id);
        }

        public void TUpdate(Slider t)
        {
            _sliderDal.Update(t);
        }
    }
}
