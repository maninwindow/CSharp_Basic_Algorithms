using System;  
  
class RecExercise13  
{  
    public static void Main(string[] args)  
    {  
        int num;  
        DecToBinClass pg = new DecToBinClass();  
        Console.WriteLine("\n\n Recursion : Convert a decimal number to binary :");  
        Console.WriteLine("------------------------------------------------------");   
        Console.Write(" Input a decimal number : ");  
        num = int.Parse(Console.ReadLine());  
        Console.Write(" The binary equivalent of {0} is : ", num);  
        pg.deciToBinary (num);  
        Console.ReadLine();  
        Console.Write("\n");  
    }  
}  
public class DecToBinClass  
{  
    public int deciToBinary(int num)  
    {  
        int bin;  
        if (num != 0)  
        {  
            bin = (num % 2) + 10 * deciToBinary(num / 2);  
            Console.Write(bin);  
            return 0;  
        }  
        else  
        {  
            return 0;  
        }  
   
    }  
}
