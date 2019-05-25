using System;
using System.Collections.Generic;

public class CombineTwoArrays
{
public static void Main ()
{
	Console.WriteLine ("Please enter three numbers");
	string userInput = Console.ReadLine();
	char[] charArr = userInput.ToCharArray();
	Console.WriteLine("Please enter three numbers");
	string userInput2 = Console.ReadLine();
	char[] charArr2 = userInput2.ToCharArray();

	int i = 0;
	int j = 0;
	List<char> arr =  new List<char> {
	};

	//
	// 4
	// i = 3, j = 2
	while (i < charArr.Length && j < charArr2.Length)
	{
		if(charArr[i] < charArr2[j])
		{
			arr.Add(charArr[i]);
			i++;
		}
		else if(charArr2[j] <= charArr[i])
		{
			arr.Add(charArr2[j]);
			j++;
		}
	}
	for (int k=i; k<charArr.Length; k++)
	{
		arr.Add(charArr[k]);
	}
	for (int m =j; m<charArr2.Length; m++)
	{
		arr.Add(charArr2[m]);
	}
	foreach (char k in arr)
	{
		Console.WriteLine (k);
	}
}
}
