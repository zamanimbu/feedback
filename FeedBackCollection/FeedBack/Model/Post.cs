using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FeedBack.Model
{
	public class Post
	{
		[Key]
		public int PostId { get; set; }
		public string Description { get; set; }
		public string User { get; set; }
		public DateTime? Time { get; set; }
		public List<Comments> Commentses { get; set; }
	
	}
}
