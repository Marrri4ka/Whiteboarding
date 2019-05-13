using System;
using System.Collections.Generic;

public class SumSquare
{
public static void  Main()
{

	Console.WriteLine ("Enter max");
	int numberMax = int.Parse(Console.ReadLine());
	Console.WriteLine ("Enter min");
	int numberMin = int.Parse(Console.ReadLine());
	// List<int> newList = new List<int> {
	// };

	for (int i= numberMin; i<=numberMax; i++)
	{
		for(int j= 0; j<=i; j++)
		{
			if(j<=i && j*j == i)
			{
				Console.WriteLine(i);
			}
		}
	}
}
}
