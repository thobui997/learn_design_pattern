// See https://aka.ms/new-console-template for more information
using LearnDesignPattern;

User createUser()
{
	User user = new User()
	{
		FirstName = "tho",
		LastName = "bui",
		Birthday = new DateTime(1997, 5, 21),
		Address = new Address()
		{
			HouseNumber = "127",
			Street = "Kim Giang",
			City = "Ha Noi",
			State = "Thanh Tri",
			Zipcode = "000000"
		}
	};

	return user;
}

UserWebDTO directBuild(UserDTOBuilder builder, User user)
{
	var dto = builder
		.WithFirstName(user.FirstName)
		.WithLastName(user.LastName)
		.WithBirthday(user.Birthday)
		.WithAddress(user.Address)
		.build();

	return dto;
}

User user = createUser();
UserDTOBuilder builder = new UserWebDTOBuilder();
UserWebDTO dto = directBuild(builder, user);
Console.WriteLine(dto.ToString());