using System;

namespace Question3{
	class Q3{
		public static void Main(string[] args){
			Console.Write("Enter your name: ");
			string name = Console.ReadLine();
			Console.Write("\nEnter your address: ");
			string address = Console.ReadLine();
			Console.Write("\nEnter your email: ");
			string email = Console.ReadLine();

			Console.Write("\nYour name is " + name);
			Console.Write("\nYou live in " + address);
			Console.Write("\nYour email address is " + email);
			Console.ReadKey();
		}
	}
}