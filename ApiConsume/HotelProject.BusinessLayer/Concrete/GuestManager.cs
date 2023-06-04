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
    public class GuestManager : IGuestService
    {
        private readonly IGuestDal _guestDal;

        public GuestManager(IGuestDal guestDal)
        {
            _guestDal = guestDal;
        }

        public void DeleteT(Guest t)
        {
            _guestDal.Delete(t);
        }

        public Guest GetByIDT(int id)
        {
            return _guestDal.GetByID(id);
        }

        public List<Guest> GetListT()
        {
            return _guestDal.GetList();
        }

        public void InsertT(Guest t)
        {
            _guestDal.Insert(t);
        }

        public void UpdateT(Guest t)
        {
            _guestDal.Update(t);
        }
    }
}
