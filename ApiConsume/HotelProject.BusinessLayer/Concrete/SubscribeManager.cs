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
	public class SubscribeManager : ISubscribeService
	{
		private readonly ISubscribeDal _subsDal;

		public SubscribeManager(ISubscribeDal subsDal)
		{
			_subsDal = subsDal;
		}

		public void DeleteT(Subscribe t)
		{
			_subsDal.Delete(t);
		}

		public Subscribe GetByIDT(int id)
		{
			return _subsDal.GetByID(id);
		}

		public List<Subscribe> GetListT()
		{
			return _subsDal.GetList();
		}

		public void InsertT(Subscribe t)
		{
			_subsDal.Insert(t);
		}

		public void UpdateT(Subscribe t)
		{
			_subsDal.Update(t);
		}
	}
}
