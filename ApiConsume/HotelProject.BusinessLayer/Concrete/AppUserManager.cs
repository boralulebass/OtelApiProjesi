using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class AppUserManager : IAppUserService
    {
        private readonly IAppUserDal _appUserDal;

        public AppUserManager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }

        public int TAppUserCount()
        {
           return _appUserDal.AppUserCount();
        }

        public void DeleteT(AppUser t)
        {
            throw new NotImplementedException();

        }

        public AppUser GetByIDT(int id)
        {
            throw new NotImplementedException();
        }

        public List<AppUser> GetListT()
        {
           return _appUserDal.GetList();
        }

        public void InsertT(AppUser t)
        {
            throw new NotImplementedException();
        }

        public List<AppUser> TUserListWithWorkLocation()
        {
           return _appUserDal.UserListWithWorkLocation();
        }

        public void UpdateT(AppUser t)
        {
            throw new NotImplementedException();
        }
    }
}
