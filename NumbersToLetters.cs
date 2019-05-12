using System;
using System.Collections.Generic;

public class NumbersToLetters {
public static void Main()
{
	// string sentence = "Mahesh Chand";
	// char[] charArr = sentence.ToCharArray();
	// foreach (char ch in charArr)
	// {
	//      Console.WriteLine(ch);
	// }
	Console.WriteLine("Please enter number");
	string UserInput = Console.ReadLine();
	char[] charArr = UserInput.ToCharArray();

	Dictionary<int, string> dict1 = new Dictionary<int,string>();

	dict1.Add(2,"twohundret");

	Dictionary<int, string> dict2 = new Dictionary<int,string>();

	dict2.Add(5,"fifty");

	Dictionary<int, string> dict3 = new Dictionary<int,string>();

	dict3.Add(4,"four");


	int numOne = int.Parse(charArr[0].ToString());
	int numTwo = int.Parse(charArr[1].ToString());
	int numThree = int.Parse(charArr[2].ToString());
	string res = dict1[numOne] + dict2[numTwo] + dict3[numThree];

	Console.WriteLine (res.Length);
}
}
