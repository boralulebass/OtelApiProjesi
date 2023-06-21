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
    public class BookingManager : IBookingService
    {
        private readonly IBookingDal _bookingDal;

        public BookingManager(IBookingDal bookingDal)
        {
            _bookingDal = bookingDal;
        }

        public void DeleteT(Booking t)
        {
            _bookingDal.Delete(t);
        }

        public Booking GetByIDT(int id)
        {
            return _bookingDal.GetByID(id);
        }

        public List<Booking> GetListT()
        {
            return _bookingDal.GetList();
        }

        public void InsertT(Booking t)
        {
             _bookingDal.Insert(t);
        }

        public List<Booking> Last6Bookings()
        {
           return _bookingDal.Last6Bookings();
        }

        public void TBookingStatusChange(int id)
        {
            _bookingDal.BookingStatusChange(id);
        }

        public int TGetBookingCount()
        {
           return _bookingDal.GetBookingCount();
        }

        public void UpdateT(Booking t)
        {
            _bookingDal.Update(t);
        }
    }
}
