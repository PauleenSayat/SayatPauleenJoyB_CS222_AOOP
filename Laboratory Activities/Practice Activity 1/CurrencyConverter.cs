//Problem #2: CurrencyConverter.cs

using System;

public class CurrencyConverter{
	public static void Main(string[] args)
	{	
		Console.Write("Enter amount is QAR: ");
		double amount = double.Parse(Console.ReadLine());

		Console.Write("Enter exchange rate from QAR to PHP: ");
		double php_rate = double.Parse(Console.ReadLine());


		double exchanged_amount = amount * php_rate;
		Console.Write($"Amount in PHP: {exchanged_amount}");
		

		
	}
}
