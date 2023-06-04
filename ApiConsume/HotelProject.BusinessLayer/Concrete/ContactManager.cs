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
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void DeleteT(Contact t)
        {
            _contactDal.Delete(t);
        }

        public Contact GetByIDT(int id)
        {
            return _contactDal.GetByID(id);
        }

        public List<Contact> GetListT()
        {
           return _contactDal.GetList();
        }

        public void InsertT(Contact t)
        {
           _contactDal.Insert(t);
        }

        public int TGetContactCount()
        {
          return  _contactDal.GetContactCount();
        }

        public void UpdateT(Contact t)
        {
            _contactDal.Update(t);
        }
    }
}
