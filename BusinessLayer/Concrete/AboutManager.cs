﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;
        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void TCreate(About t)
        {
            _aboutDal.Create(t);

        }

        public void TDelete(About t)
        {
            _aboutDal.Delete(t);

        }

        public List<About> TGetAll()
        {
            return _aboutDal.GetAll();

        }

        public About TGetById(int id)
        {
            return _aboutDal.GetById(id);

        }

        public void TUpdate(About t)
        {
            _aboutDal.Update(t);

        }
    }
}
