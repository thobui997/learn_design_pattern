using System;
namespace LearnDesignPattern
{
	public class PostFactory
	{
		public static Post CreatePost(String type)
		{
			return type switch
			{
				"blog" => new BlogPost(),
				"news" => new NewsPost(),
				"product" => new ProductPost(),
				_ => throw new ArgumentNullException("type is unknown"),
			};
		}
	}
}

