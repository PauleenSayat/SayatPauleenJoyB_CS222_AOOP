
using System;

public class alternatingChars
{
    public static void Main(string[] args)
    {
        Console.Write("First character: ");
        char first_char = char.Parse(Console.ReadLine());
        
        Console.Write("Second character: ");
        char second_char = char.Parse(Console.ReadLine());
        
        Console.Write("Enter size: ");
        int size = int.Parse(Console.ReadLine());
        
         for (int i = 0; i < size; i++){  
            for (int k = 0; k < i; k++){  
               Console.Write("-");  
            }  
            if(i%2 == 0){
                Console.WriteLine(first_char);  
            } else{
                Console.WriteLine(second_char);
            }
         }  
         Console.ReadLine();  
    }
}