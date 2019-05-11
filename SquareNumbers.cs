using System;
using System.Collections.Generic;

public class SquareNumbers
{
public static void Main ()

{
	Console.WriteLine("Please enter your number");
	int userNumber = int.Parse(Console.ReadLine());
	sum=0;


	for (int i =1; i<= userNumber; i++)
	{
		for (int j= 1; j < userNumber; j++)
		{

			if(j<i && j*j == i)
			{
				Console.WriteLine(sum(i));
			}
		}

	}


}
}
