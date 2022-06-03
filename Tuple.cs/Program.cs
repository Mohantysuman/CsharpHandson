// C# program to create tuple using tuple constructor.
using System;

public class Tuplehandson
{

	// Main method
	static public void Main()
	{

		// Tuple with one element
		Tuple<string> My_Tuple1 = new Tuple<string>("Kelltontech");

		// Tuple with three elements
		Tuple<string, string, int> My_Tuple2 = new Tuple<string, string, int>("Romil", "xyz", 29);

		// Tuple with eight elements
		Tuple<int, int, int, int, int, int, int, Tuple<int>> My_Tuple3 = new Tuple<int, int, int, int, int, int, int, Tuple<int>>(1, 2, 3, 4, 5, 6, 7, new Tuple<int>(8));
	}
}
