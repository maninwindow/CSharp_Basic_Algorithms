using System;  
  
class RecExercise10  
{  
    public static int FindFibonacci(int n)  
    {  
    int p = 0;  
    int q = 1;  
    for (int i = 0; i < n; i++)  
    {  
        int temp = p;  
        p = q;  
        q = temp + q;  
    }  
    return p;  
    }  
  
    static void Main()  
    {  
        Console.WriteLine("\n\n Recursion : Find the Fibonacci numbers for a n numbers of series :");  
        Console.WriteLine("-----------------------------------------------------------------------");  
      
        Console.Write(" Input number of terms for the Fibonacci series : ");  
        int n1 = Convert.ToInt32(Console.ReadLine());  
        Console.Write("\n The Fibonacci series of {0} terms is : ",n1);  
        for (int i = 0; i < n1; i++)  
            {  
                Console.Write("{0} ",FindFibonacci(i));  
            }  
    Console.ReadKey();  
    }  
} 
