using System;

namespace Question2{
	class Q2{
		public static void Main(string[] args){
			Console.WriteLine("Enter any 3 integers: ");
			int number1 = int.Parse(Console.ReadLine());
			int number2 = int.Parse(Console.ReadLine());
			int number3 = int.Parse(Console.ReadLine());

			int sum = number1 + number2 + number3;
			Console.WriteLine("The sum of there integers is: " + sum);
		}
	}
}