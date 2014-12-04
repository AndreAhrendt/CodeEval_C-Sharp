// -----------------------------------------------------------------------
// <copyright file="Counting_Primes.cs" company="André Ahrendt">
// Copyright 2014 André Ahrendt. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System.IO;
using System;

class Counting_Primes
{
    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader(args[0]);
        while (!reader.EndOfStream)
        {
			string[] line = reader.ReadLine().Split(',');
			int max = int.Parse(line[1]);
			int count = 0;
			int i = int.Parse(line[0]);
			line = new string[0];
			
			if (i == 1)
			{
				i = 3;
				count = 2;
			}
			else if (i == 2)
			{
				i = 3;
				count = 1;
			}
			
			if (i % 2 == 0) i++;
			
			for ( ; i <= max; i += 2)
			{
				bool find = false;
				for ( int j = 3; j <= i / 2; j+= 2)
				{
					if ( i % j == 0)
					{
						find = true;
						j = i;
					}
				}
				
				if (!find) count++;
			}
			
			Console.WriteLine(count);
        }
		
		reader.Close();
    }
}