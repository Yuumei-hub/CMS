using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ServiceManager : IServiceService
    {
        IServiceDal _serviceDal;
        public ServiceManager( IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;

        }
        public void TCreate(Service t)
        {
            _serviceDal.Create(t);
        }

        public void TDelete(Service t)
        {
            _serviceDal.Delete(t);
        }

        public List<Service> TGetAll()
        {
            return _serviceDal.GetAll();
        }

        public Service TGetById(int id)
        {
            return _serviceDal.GetById(id);
        }

        public void TUpdate(Service t)
        {
            _serviceDal.Update(t);
        }
    }
}
