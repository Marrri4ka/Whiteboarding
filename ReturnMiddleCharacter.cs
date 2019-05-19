using System;
using System.Collections.Generic;

public class ReturnMiddleCharacter
{
public static void Main()
{
	Console.WriteLine("Please enter sentense:");
	string userInput = Console.ReadLine();

	if (userInput.Length % 2 == 0)
	{
		Console.WriteLine(userInput[userInput.Length/2]);
		Console.WriteLine(userInput[userInput.Length/2-1]);
	}

	else if (userInput.Length%2 != 0)
	{
		Console.WriteLine(userInput[userInput.Length/2]);
	}
}
}
