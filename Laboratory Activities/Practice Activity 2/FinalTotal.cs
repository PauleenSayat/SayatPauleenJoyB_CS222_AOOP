//Problem #1

using System;

public class FinalTotal
{
    public static void Main(string[] args)
    {
        int total = 10;
        
        Console.Write("Enter an integer: ");
		int num = int.Parse(Console.ReadLine());

		if (num%2 == 0){
		    Console.WriteLine("The number is even.");
		    num = num*num;
		    total = total + num;
		    Console.WriteLine(total);
		    
		} else if (num == 0){
            Console.WriteLine("Nothing Happened.");
            
		} else{
		    Console.WriteLine("The number is odd.");
		    num = num*num*num;
		    total = total + num;
		    Console.WriteLine(total);		    
		}
    }
}
