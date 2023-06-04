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
    public class MessageCategoryManager : IMessageCategoryService
    {
        private readonly IMessageCategoryDal _messageCatDal;

        public MessageCategoryManager(IMessageCategoryDal messageCatDal)
        {
            _messageCatDal = messageCatDal;
        }

        public void DeleteT(MessageCategory2 t)
        {
            _messageCatDal.Delete(t);
        }

        public MessageCategory2 GetByIDT(int id)
        {
            return _messageCatDal.GetByID(id);
        }

        public List<MessageCategory2> GetListT()
        {
            return _messageCatDal.GetList();
        }

        public void InsertT(MessageCategory2 t)
        {
            _messageCatDal.Insert(t);
        }

        public void UpdateT(MessageCategory2 t)
        {
            _messageCatDal.Update(t);
        }
    }
}
