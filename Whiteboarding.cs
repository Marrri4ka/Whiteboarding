using System;
using System.Collections.Generic;

public class Program
{
public static void Main()
{
	int max = 10;// 0 1 1 2 3 5 8

	List<int> list = new List<int>();

	for (int i = 1; i < max; i++)
	{
		bool IsPrime = true;
		for (int j = 2; j <= i/2; j++)
		{
			if (i%j == 0)
			{
				IsPrime = false;
			}
		}
		if(IsPrime)
		{
			list.Add(i);
		}
	}
	foreach ( var mn in list)
	{
		Console.WriteLine(mn);
	}
}
}
