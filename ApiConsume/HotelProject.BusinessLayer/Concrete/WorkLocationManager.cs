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
    public class WorkLocationManager : IWorkLocationService
    {
        private readonly IWorkLocationDal _workLocationDal;

        public WorkLocationManager(IWorkLocationDal workLocationDal)
        {
            _workLocationDal = workLocationDal;
        }

        public void DeleteT(WorkLocation t)
        {
            _workLocationDal.Delete(t);
        }

        public WorkLocation GetByIDT(int id)
        {
            return _workLocationDal.GetByID(id);
        }

        public List<WorkLocation> GetListT()
        {
            return _workLocationDal.GetList();
        }

        public void InsertT(WorkLocation t)
        {
            _workLocationDal.Insert(t);
        }

        public void UpdateT(WorkLocation t)
        {
            _workLocationDal.Update(t);
        }
    }
}
