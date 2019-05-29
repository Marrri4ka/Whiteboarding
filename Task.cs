using System;
using System.Collections.Generic;

public class Task
{
public static void Main()
{

	int [] array = new int [] {2,6,8,4};
	// int [] array = new int [] {2,5};
	var sum = 10;
	for (int i=0; i < array.Length; i++)
	{
		for (int j = i+1; j<array.Length; j++)
		{
			if(array[i] + array[j]==sum)
			{
				Console.WriteLine (array[i]);
				Console.WriteLine(array[j]);
			}


		}


	}
}
}
