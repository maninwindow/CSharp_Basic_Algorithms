using System;  
class RecExercise14  
    {  
        static void Main()  
        {  
            string str;   
            Console.WriteLine("\n\n Recursion : Get the reverse of a string :");  
            Console.WriteLine("----------------------------------------------");   
            Console.Write(" Input the string : ");  
            str = Console.ReadLine();  
            str = StringReverse(str);  
            Console.Write(" The reverse of the string is : ");  
            Console.Write(str);  
            Console.ReadKey();  
             Console.Write("\n");   
              
        }  
  
        public static string StringReverse(string str)  
        {  
            if (str.Length > 0)  
                return str[str.Length - 1] + StringReverse(str.Substring(0, str.Length - 1));  
            else  
                return str;  
        }  
    } 
