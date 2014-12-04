// <copyright file="Lowest_Unique_Number.cs" company="André Ahrendt">
// Copyright 2014 André Ahrendt. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System.IO;
using System;

class Lowest_Unique_Number
{
	static void Main (string[] args)
	{
		StreamReader reader = new StreamReader(args[0]);
		
		while(!reader.EndOfStream)
		{
			string[] values = reader.ReadLine().Split(' ');
			int pos = 0;
			
			for ( int i = 1; i <= 9; i++)
			{
				int temp = 0;
				for ( int j = 0; j < values.Length; j++)
				{
					if ( values[j] == i.ToString())
					{				
						temp++;
						pos = j + 1;
					}
				}
				
				if (temp == 1) break;
				else pos = 0;
			}
			
			Console.WriteLine(pos);
		}
		
		reader.Close();
	}
}