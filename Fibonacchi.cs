using System;
using System.Collections.Generic;

public class Fibonacchi
{
public static void Main()
{
	int number = 10; // 0 1 1 2 3 5 8

	List<int> newList = new List<int> {
		0,1
	};

	for (int i = 2; i <= number; i++)
	{

		newList.Add((newList[i-2])+(newList[i-1]));
	}
	foreach ( int num in newList )
	{
		Console.WriteLine(num);
	}

}
}
