using System;

namespace Question4{
	class Q4{
		public static void Main(string[] args){
			Console.Write("Enter principal: ");
			int principle = int.Parse(Console.ReadLine());
			Console.Write("\nEnter time in year: ");
			int time = int.Parse(Console.ReadLine());
			Console.Write("\nEnter rate: ");
			float rate = float.Parse(Console.ReadLine());

			float simpleInterest = (principle * time * rate) / 100;
			Console.WriteLine("The Simple Interest is " + simpleInterest);
		}
	}
}