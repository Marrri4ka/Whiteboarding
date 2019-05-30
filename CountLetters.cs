using System;
using System.Collections.Generic;

public class CountLetter
{
public static void Main()
{


	Console.WriteLine("Enter sentense");
	string userSentence = Console.ReadLine();
	Dictionary <char, int> newDict = new Dictionary <char,int>(){
	};



	for (char c='a'; c<='z'; c++)
	{
		newDict[c]=0;

	}
	for (int i=0; i < userSentence.Length; i++)
	{
		if (userSentence[i] >= 'a' && userSentence[i] <= 'z' || userSentence[i] >= 'A' && userSentence[i] <= 'Z' )
		{
			newDict[userSentence[i]] += 1;


		}

	}

	foreach(KeyValuePair<char, int> entry in newDict) {
		Console.WriteLine (entry);

	}







}
}
