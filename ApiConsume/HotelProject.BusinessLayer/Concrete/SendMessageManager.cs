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
    public class SendMessageManager : ISendMessageService
    {
        private readonly ISendMessageDal _sendMessageDal;

        public SendMessageManager(ISendMessageDal sendMessageDal)
        {
            _sendMessageDal = sendMessageDal;
        }

        public void DeleteT(SendMessage t)
        {
            _sendMessageDal.Delete(t);
        }

        public SendMessage GetByIDT(int id)
        {
            return _sendMessageDal.GetByID(id);
        }

        public List<SendMessage> GetListT()
        {
            return _sendMessageDal.GetList();
        }

        public void InsertT(SendMessage t)
        {
           _sendMessageDal.Insert(t);
        }

        public int TSendMessageCount()
        {
           return _sendMessageDal.SendMessageCount();
        }

        public void UpdateT(SendMessage t)
        {
            _sendMessageDal.Update(t);
        }
    }
}
