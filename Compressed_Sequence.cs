// -----------------------------------------------------------------------
// <copyright file="Compressed_Sequence.cs" company="André Ahrendt">
// Copyright 2014 André Ahrendt. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System.IO;
using System;

class Compressed_Sequence
{
	static void Main (string[] args)
	{
		StreamReader reader = new StreamReader(args[0]);
		
		while(!reader.EndOfStream)
		{
			string[] cases = reader.ReadLine().Split(' ');
			int count = 1;
			int number = int.Parse(cases[0]);
			int temp = 0;
			
			for (int i = 1; i < cases.Length; i++)
			{
				temp = int.Parse(cases[i]);
				if (temp == number) count++;
				else
				{
					Console.Write(string.Format("{0} {1} ", count, number));
					count = 1;
					number = temp;
				}
			}
			
			Console.WriteLine(string.Format("{0} {1}", count, number));
		}
		
		reader.Close();
	}
}