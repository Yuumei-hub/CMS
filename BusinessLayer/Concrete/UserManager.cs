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
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void TCreate(User t)
        {
            _userDal.Create(t);
        }

        public void TDelete(User t)
        {
            _userDal.Delete(t);
        }

        public User TGetById(int id)
        {
            return _userDal.GetById(id);
        }

        public List<User> TGetAll()
        {
            return _userDal.GetAll();
        }

        public void TUpdate(User t)
        {
            _userDal.Update(t);
        }
    }
}
