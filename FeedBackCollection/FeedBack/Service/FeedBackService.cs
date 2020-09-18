using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FeedBack.Repository;

namespace FeedBack.Service
{
	public interface IFeedBackService
	{
		object GetListData();
	}
	public class FeedBackService:IFeedBackService
	{
		private IFeedBackRepository repository;

		public FeedBackService(IFeedBackRepository _repository)
		{
			repository = _repository;
		}
		public object GetListData()
		{
			return repository.GetListData();
		}
	}
}
