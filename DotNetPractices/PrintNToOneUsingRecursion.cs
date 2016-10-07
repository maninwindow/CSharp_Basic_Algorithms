using System;  
  
class RecExercise1  
{  
    static int printNatural(int ctr,int stval)  
    {  
    if (ctr < 1)  
    {  
        return stval;  
    }  
  
    Console.Write(" {0} ",ctr);  
        ctr--;  
    return printNatural(ctr,stval);  
    }  
      
    static void Main()  
    {  
    Console.Write("\n\n Recursion : Print the natural numbers from n to 1 :\n");  
    Console.Write("--------------------------------------------------------\n");  
    Console.Write(" How many numbers to print : ");  
    int ctr= Convert.ToInt32(Console.ReadLine());  
    // Call recursive method with two parameters.     
    printNatural(ctr,1);  
    Console.Write("\n\n");  
    }  
} 
