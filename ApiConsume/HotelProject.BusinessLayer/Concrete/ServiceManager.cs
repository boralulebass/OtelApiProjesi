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
	public class ServiceManager : IServiceService
	{
		private readonly IServicesDal _serviceDal;

		public ServiceManager(IServicesDal serviceDal)
		{
			_serviceDal = serviceDal;
		}

		public void DeleteT(Service t)
		{
			_serviceDal.Delete(t);
		}

		public Service GetByIDT(int id)
		{
			return _serviceDal.GetByID(id);
		}

		public List<Service> GetListT()
		{
			return _serviceDal.GetList();
		}

		public void InsertT(Service t)
		{
			_serviceDal.Insert(t);
		}

		public void UpdateT(Service t)
		{
			_serviceDal.Update(t);
		}
	}
}
