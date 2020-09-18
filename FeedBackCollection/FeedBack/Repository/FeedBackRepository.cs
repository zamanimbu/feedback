using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FeedBack.DbContext;

namespace FeedBack.Repository
{
	public interface IFeedBackRepository
	{
		object GetListData();
	}
	public class FeedBackRepository: IFeedBackRepository
	{
		private AppDbContext _dbContext;

		public FeedBackRepository(AppDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public object GetListData()
		{
			return _dbContext.Posts.ToList();
		}
	}
}
