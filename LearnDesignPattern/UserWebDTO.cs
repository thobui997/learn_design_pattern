using System;
using System.Net;
using System.Xml.Linq;

namespace LearnDesignPattern
{
	public class UserWebDTO
	{
		public String Name { get; set; }
		public String Address { get; set; }
		public String Age { get; set; }
		public override string ToString()
		{
			return "name=" + Name + "\nage=" + Age + "\naddress=" + Address;
		}
	}
}

