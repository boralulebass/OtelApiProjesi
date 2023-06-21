using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EFBookingDal : GenericRepository<Booking>, IBookingDal
    {
        public EFBookingDal(Context context) : base(context)
        {

        }

        public void BookingStatusChange(int id)
        {
            var context = new Context();
            var values = context.Bookings.FirstOrDefault(x=>x.BookingID==id);
            if(values.Status ==false) { values.Status = true; context.SaveChanges(); }
            else { values.Status = false; context.SaveChanges(); }
        }

        public int GetBookingCount()
        {
            var context = new Context();
            var value = context.Bookings.Count();
            return value;
        }

        public List<Booking> Last6Bookings()
        {
            var context = new Context();
            var value = context.Bookings.OrderByDescending(x=>x.BookingID).Take(6).ToList();
            return value;
        }
    }
}
