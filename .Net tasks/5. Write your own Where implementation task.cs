using System;
using System.Collections.Generic;

//
// Practical task:
// Imagine that LINQ is unavailable. Write your own implementation of LINQ "Where" to make code below working.
// link on the .NET fiddle: https://dotnetfiddle.net/NyQsZy
//
					
public static class Program
{
	// Test data class
	private class SomeNumber {
		public int Value { get; private set; }
		
		public SomeNumber(int value)
		{
			Value = value;
		}
	}
	
	public static void Main()
	{
		// Arrange
		var listOfSomeNumbers = 
			new List<SomeNumber>
			{
				new SomeNumber(1),
				new SomeNumber(2),
				new SomeNumber(3),
				new SomeNumber(4),
				new SomeNumber(5),
			};		
		
		// Action: your "Where" implementation should work fine with this code
		var listOfEvenNumbers = listOfSomeNumbers.Where(t => t.Value % 2 == 0);
		
		// Just assertion - do not worry about the code below
		if (System.Linq.Enumerable.All(listOfEvenNumbers, t => t.Value % 2 == 0) 
			&& System.Linq.Enumerable.Count(listOfSomeNumbers, t => t.Value % 2 == 0) == System.Linq.Enumerable.Count(listOfEvenNumbers))
		{
			Console.WriteLine("OK");
		}
		else
		{
			Console.WriteLine("NO");
		}
	}
}
