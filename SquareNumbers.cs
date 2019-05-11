using System;
using System.Collections.Generic;

public class SquareNumbers
{
public static void Main ()

{
	Console.WriteLine("Please enter your number");
	int userNumer = int.Parse(Console.ReadLine());

	bool isSquare = false;
	for (int i= 0; i < userNumer; i++)
	{

		if(i<userNumer && i*i == userNumer)
		{
			isSquare = true;
		}
	}
	if(isSquare == true)
	{
		Console.WriteLine("isSquare");
	}
	else
	{
		Console.WriteLine ("sorry,no");
	}

}
}
