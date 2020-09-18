using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FeedBack.Service;
using Microsoft.AspNetCore.Mvc;

namespace FeedBack.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class FeedBackController : ControllerBase
	{
		private IFeedBackService service;
		public FeedBackController(IFeedBackService _service)
		{
			service = _service;
		}
		
		[HttpGet]
		[Route("GetListData")]
		public object GetListData()

		{
			return  service.GetListData();
		}	
		
	}
}
