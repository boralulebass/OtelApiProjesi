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
	public class TestimonialManager : ITestimonialService
	{
		private readonly ITestimonialDal _testDal;

		public TestimonialManager(ITestimonialDal testDal)
		{
			_testDal = testDal;
		}

		public void DeleteT(Testimonial t)
		{
			_testDal.Delete(t);
		}

		public Testimonial GetByIDT(int id)
		{
			return _testDal.GetByID(id);
		}

		public List<Testimonial> GetListT()
		{
			return _testDal.GetList();
		}

		public void InsertT(Testimonial t)
		{
			_testDal.Insert(t);
		}

		public void UpdateT(Testimonial t)
		{
			_testDal.Update(t);
		}
	}
}
