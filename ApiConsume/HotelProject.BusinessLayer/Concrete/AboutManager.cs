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
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void DeleteT(About t)
        {
            _aboutDal.Delete(t);
        }

        public About GetByIDT(int id)
        {
            return _aboutDal.GetByID(id);
        }

        public List<About> GetListT()
        {
            return _aboutDal.GetList();
        }

        public void InsertT(About t)
        {
            _aboutDal.Insert(t);
        }

        public void UpdateT(About t)
        {
            _aboutDal.Update(t);
        }
    }
}
