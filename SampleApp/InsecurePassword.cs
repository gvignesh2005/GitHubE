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

	public void badpassword()
	{
		Random gen = new Random();
		string password = "password" + gen.Next();
	}

	public string badpasswordcomparison()
	{
		string password = "password";

		if (password == "password")
		{
			return password;
		}

		return password;
	}
}