﻿using HotelProject.DataAccessLayer.Abstract;
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
            var values = context.Bookings.Find(id);
            if(values.Status ==true) { values.Status = false;}
            else { values.Status = true;}
            context.SaveChanges();    
        }
    }
}