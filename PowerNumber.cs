using System;
using System.Collections.Generic;

public class PowerNumber
{
public static void Main()
{
	Console.WriteLine ("Please enter number");
	int userNumber = int.Parse(Console.ReadLine());
	bool isPower = false;
	for (int i =0; i <= userNumber; i*=2)
	{
		if(i == userNumber)
		{
			isPower = true;
		}

	}
	Console.WriteLine (isPower);
}
}
