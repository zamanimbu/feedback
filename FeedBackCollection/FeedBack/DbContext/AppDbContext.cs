using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FeedBack.Model;
using Microsoft.EntityFrameworkCore;

namespace FeedBack.DbContext
{
	public class AppDbContext:Microsoft.EntityFrameworkCore.DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options)
			: base(options)
		{
		}

		public DbSet<Post> Posts { get; set; }
		public DbSet<Comments> Commentses { get; set; }
		
	}
}
