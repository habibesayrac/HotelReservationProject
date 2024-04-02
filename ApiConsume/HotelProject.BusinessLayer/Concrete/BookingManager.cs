﻿using HotelProject.BusinessLayer.Abstract;
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

        public void TBookingStatusChangeApproved3(int id)
        {
            _bookingDal.BookingStatusChangeApproved3(id);
        }

        public void TBookingStatusChangedApproved(Booking booking)
        {
            _bookingDal.BookingStatusChangedApproved(booking);
        }

        public void TBookingStatusChangedApproved2(int id)
        {
            _bookingDal.BookingStatusChangedApproved2(id);

        }

        public void TDelete(Booking t)
        {
           _bookingDal.Delete(t);
        }

		public int TGetBookingCount()
		{
            return _bookingDal.GetBookingCount();
		}

		public Booking TGetByID(int id)
        {
           return _bookingDal.GetByID(id);
        }

        public List<Booking> TGetList()
        {
            return _bookingDal.GetList();
        }

        public void TInsert(Booking t)
        {
          _bookingDal.Insert(t);
        }

        public List<Booking> TLast6Bookings()
        {
            return _bookingDal.Last6Bookings();
        }

        public void TUpdate(Booking t)
        {
            _bookingDal.Update(t);
        }
    }
}
