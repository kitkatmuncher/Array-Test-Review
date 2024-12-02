using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace program
{

public class Program
{

    
   static void Main(string[] args)
   {
      
      string[,] array = new string[5,5];
      for(int i = 0; i < array.GetLength(0); i++)
      {
         for(int j = 0; j < array.GetLength(1); j++)
         {
            Console.WriteLine(array[i,j] = "-");
         }
         Console.WriteLine();
      }
      
      int[,] arr = new int[,]{{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};

      Console.WriteLine("Question: #1");
      for(int i = 0; i < arr.GetLength(0); i++)
      {
         for(int j = 0; j < arr.GetLength(1);j++)
         {
            Console.Write(arr[i,j] + " ");
         }
         Console.WriteLine();
      }
      Console.WriteLine("\nQuestion: #2");
      Console.WriteLine(arr[1,2]);
      Console.WriteLine(arr[2,0]);

      Console.WriteLine("\nQuestion: #3"); 
      int sum = 0;
      for(int i = 0; i < arr.GetLength(0); i++)
      {
         for (int j =0; j < arr.GetLength(1); j++)
         {
            sum = sum + arr[i, j];
         }
      }
      Console.WriteLine(sum);

   }
}
}