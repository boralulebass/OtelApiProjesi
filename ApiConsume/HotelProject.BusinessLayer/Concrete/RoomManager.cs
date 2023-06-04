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
	public class RoomManager : IRoomService
	{
		private readonly IRoomDal _roomDal;

		public RoomManager(IRoomDal roomDal)
		{
			_roomDal = roomDal;
		}

		public void DeleteT(Room t)
		{
			_roomDal.Delete(t);
		}

		public Room GetByIDT(int id)
		{
			return _roomDal.GetByID(id);	
		}

		public List<Room> GetListT()
		{
			return _roomDal.GetList();
		}

		public void InsertT(Room t)
		{
			_roomDal.Insert(t);
		}

		public void UpdateT(Room t)
		{
			_roomDal.Update(t);
		}
	}
}
