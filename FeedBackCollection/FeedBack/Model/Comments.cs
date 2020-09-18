using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FeedBack.Model
{
	public class Comments
	{
		[Key]
		public int Id { get; set; }
		public string Description { get; set; }
		public int Like { get; set; }
		public int DisLike { get; set; }
		[ForeignKey("PostId")]
		public int PostId { get; set; }
	}
}
