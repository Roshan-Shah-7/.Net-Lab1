using System;

namespace Question7{
	class Q7{
		public static void Main(string[] args){
			Console.Write("Enter a number: ");
			float number = float.Parse(Console.ReadLine());

			for(int i = 1; i<=10; i++){
				Console.WriteLine(number + "X" + i + "=" + number*i);
			}
		}
	}
}