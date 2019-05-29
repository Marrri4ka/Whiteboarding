using System;
using System.Collections.Generic;

public class Return
{
public static void Main()
{
	Console.WriteLine ("Please enter a number!");
	int userInput = int.Parse(Console.ReadLine());

	for (int i = 0; i < userInput; i++)
	{


		if(i%2 == 0)
		{
			Console.WriteLine ("+");
		}
		else
		{
			Console.WriteLine("-");
		}
	}
}


}
