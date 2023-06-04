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
	public class StaffManager : IStaffService
	{
		private readonly IStaffDal _staffDal;

		public StaffManager(IStaffDal staffDal)
		{
			_staffDal = staffDal;
		}

		public void DeleteT(Staff t)
		{
			_staffDal.Delete(t);
		}

		public Staff GetByIDT(int id)
		{
			return _staffDal.GetByID(id);
		}

		public List<Staff> GetListT()
		{
			return _staffDal.GetList();
		}

		public void InsertT(Staff t)
		{
			_staffDal.Insert(t);
		}

		public void UpdateT(Staff t)
		{
			_staffDal.Update(t);
		}
	}
}
