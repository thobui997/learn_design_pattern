using System;
namespace LearnDesignPattern
{
	public interface UserDTOBuilder
	{
		UserDTOBuilder WithFirstName(String fname);
		UserDTOBuilder WithLastName(String lname);
		UserDTOBuilder WithBirthday(DateTime date);
		UserDTOBuilder WithAddress(Address address);
		UserWebDTO build();
		UserWebDTO GetUserDTO();
	}
}

