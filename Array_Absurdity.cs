// -----------------------------------------------------------------------
// <copyright file="Array_Absurdity.cs" company="André Ahrendt">
// Copyright 2014 André Ahrendt. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System.IO;
using System;

class Array_Absurdity
{
    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader(args[0]);
        while (!reader.EndOfStream)
        {
            string[] input = reader.ReadLine().Split(';');
			int number = int.Parse(input[0]);
            input = input[1].Split(',');
			
			for ( int i = 0; i <= number - 2; i++)
			{
				int count = 0;
				for ( int j = 0; j < input.Length; j++)
				{
					if (i == int.Parse(input[j])) count++;
				}
				
				if (count == 2)
				{
					number = i;
					break;
				}
			}
			
			Console.WriteLine(number);
        }
		
		reader.Close();
    }
}