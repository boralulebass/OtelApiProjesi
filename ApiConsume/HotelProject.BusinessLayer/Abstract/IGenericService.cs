using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Abstract
{
	public interface IGenericService<T> where T : class
	{
		void InsertT(T t);
		void DeleteT(T t);
		void UpdateT(T t);
		List<T> GetListT();
		T GetByIDT(int id);
	}
}
