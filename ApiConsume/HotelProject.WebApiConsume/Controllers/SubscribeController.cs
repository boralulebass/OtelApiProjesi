﻿using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApiConsume.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SubscribeController : ControllerBase
	{
		private readonly ISubscribeService _SubscribeService;

		public SubscribeController(ISubscribeService SubscribeService)
		{
			_SubscribeService = SubscribeService;
		}

		[HttpGet]
		public IActionResult SubscribeList()
		{
			var values = _SubscribeService.GetListT();
			return Ok(values);
		}
		[HttpPost]
		public IActionResult AddSubscribe(Subscribe Subscribe)
		{
			_SubscribeService.InsertT(Subscribe);
			return Ok();
		}
		[HttpDelete]
		public IActionResult DeleteSubscribe(int id)
		{
			var values = _SubscribeService.GetByIDT(id);
			_SubscribeService.DeleteT(values);
			return Ok();
		}
		[HttpPut]
		public IActionResult UpdateSubscribe(Subscribe Subscribe)
		{
			_SubscribeService.UpdateT(Subscribe);
			return Ok();
		}
		[HttpGet("{id}")]
		public IActionResult GetSubscribe(int id)
		{
			var values = _SubscribeService.GetByIDT(id);
			return Ok(values);
		}
	}
}
