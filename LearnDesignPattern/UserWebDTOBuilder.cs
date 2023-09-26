using System;
namespace LearnDesignPattern
{
	public class UserWebDTOBuilder : UserDTOBuilder
	{
		private String? firstName;
		private String? lastName;
		private String age;
		private String address;
		private UserWebDTO dto;

		public UserWebDTO build()
		{
			var dto = new UserWebDTO()
			{
				Name = firstName + " " + lastName,
				Address = address,
				Age = age
			};
			return dto;
		}

		public UserWebDTO GetUserDTO()
		{
			return dto;
		}

		public UserDTOBuilder WithAddress(Address address)
		{
			this.address = address.HouseNumber + ", " + address.Street + ", " + address.City;
			return this;
		}

		public UserDTOBuilder WithBirthday(DateTime date)
		{
			var ageInYear = DateTime.UtcNow.Year - date.Year;
			age = ageInYear.ToString();
			return this;
		}

		public UserDTOBuilder WithFirstName(string fname)
		{
			firstName = fname;
			return this;
		}

		public UserDTOBuilder WithLastName(string lname)
		{
			lastName = lname;
			return this;
		}
	}
}

