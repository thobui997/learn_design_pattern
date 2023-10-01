using System;
namespace LearnDesignPattern
{
	public abstract class Post
	{
		public long Id { get; set; }
		public String Title { get; set; }
		public String Content { get; set; }
		public DateTime CreatedOn { get; set; }
		public DateTime PublishedOn { get; set; }
	}
}

