
using System;
using System.Collections.Generic;

namespace boxing
{
    class Program
    {
        static void Main(string[] args)
        {
           List<object> casting = new List<object>();
            casting.Add(7);
            casting.Add(28);
            casting.Add(-1);
            casting.Add(true);
            casting.Add("chair");
            int sum = 0;
            int x;
             foreach(var obj in casting) {
                Console.WriteLine(obj);
                 if(obj is int){
                     sum += 1;
                     //sum += (int)obj;
                     x = (int)obj;
                 }
             }
    
                 Console.WriteLine("The sum of all the integers in the list is {0}",sum);
                 
        }
    }
}
