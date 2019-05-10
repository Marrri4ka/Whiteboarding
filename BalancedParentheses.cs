using System;
using System.Collections.Generic;

public class BalancedParentheses
{
public static void Main()
{
	string input = ")()(";
	// (}

	bool isBalanced= true;
	string duz = "(";
	string duz1= ")";
	int res=0;
	int res2= 0;
	for (int i =0; i < input.Length; i++)
	{
		if (input[i]=='(')
		{
			res+=1;
		}
		if (input[i]==')')
		{
			res2+=1;
		}
		if (res2>res)
		{
			isBalanced = false;
		}
	}

	if(res != res2)
	{
		isBalanced =false;
	}
	Console.WriteLine(isBalanced);
}
}
