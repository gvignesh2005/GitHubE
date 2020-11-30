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

	public void Badpassword()
	{
		Random gen = new Random();
		string password = "mypassword" + gen.Next();
	}

	public string Badpasswordcomparison()
	{
		string password = "password";

		//bad comparison
		if (password == "password")
			return password;

		return password;
	}
}