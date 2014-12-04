// -----------------------------------------------------------------------
// <copyright file="Bit_Positions.cs" company="André Ahrendt">
// Copyright 2014 André Ahrendt. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System.IO;
using System;

class Bit_Positions
{
    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader(args[0]);
		
        while (!reader.EndOfStream)
        {
            string[] input = reader.ReadLine().Split(',');
			int min = Int32.Parse(input[1]);
			int max = Int32.Parse(input[2]);
			string bit = Convert.ToString(Int32.Parse(input[0]), 2);
			input = new string[0];
            
            if (bit[bit.Length - min] == bit[bit.Length - max]) Console.WriteLine("true");
			else Console.WriteLine("false");
        }
        
        reader.Close();
    }
}