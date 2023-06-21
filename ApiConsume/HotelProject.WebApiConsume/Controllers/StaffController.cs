﻿using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApiConsume.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class StaffController : ControllerBase
	{
		private readonly IStaffService _staffService;

		public StaffController(IStaffService staffService)
		{
			_staffService = staffService;
		}

		[HttpGet]
		public IActionResult StaffList()
		{
			var values = _staffService.GetListT();
			return Ok(values);
		}
		[HttpPost]
		public IActionResult AddStaff(Staff staff)
		{
			_staffService.InsertT(staff);
			return Ok();
		}
		[HttpDelete("[action]/{id}")]
		public IActionResult DeleteStaff(int id)
		{
			var values = _staffService.GetByIDT(id);
			_staffService.DeleteT(values);
			return Ok();
		}
		[HttpPut]
		public IActionResult UpdateStaff(Staff staff)
		{
			_staffService.UpdateT(staff);
			return Ok();
		}
		[HttpGet("[action]/{id}")]
		public IActionResult GetStaff(int id)
		{
			var values = _staffService.GetByIDT(id);
			return Ok(values);
		}
		[HttpGet("[action]")]
		public IActionResult Last4Staff()
		{
			var values = _staffService.Last4Staff();
			return Ok(values);
		}
	}
}
