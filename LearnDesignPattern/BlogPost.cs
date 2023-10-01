using System;
namespace LearnDesignPattern
{
	public class BlogPost : Post
	{
		public String Author { get; set; }
		public List<String> Tags { get; set; }
	}
}

