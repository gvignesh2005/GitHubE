using System;


public class InsecurePassword
{

	string GeneratePassword()
	{
		// BAD: Password is generated using a cryptographically insecure RNG
		Random gen = new Random();
		string password = "mypassword" + gen.Next();

		return password;
	}
}