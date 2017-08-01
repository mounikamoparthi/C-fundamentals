using System;

namespace first_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
        //without modulus
        // for(int val = 1; val <= 100; val++){
        //     string valstr = val.ToString();
        //     int y = 0;
        //         for(int x = 0; x<= valstr.Length; x++){
        //             y += valstr[x];
        //         }
        //     if(y/3 == 0){
        //         Console.WriteLine(valstr);
        //     }
          
        // }
        
        //fizz,buzz
        // for(int val = 1; val <= 100; val++){
        //     if(val % 15 == 0){
        //          Console.WriteLine("FizzBuzz");
        //     }
        //     else if(val % 3 == 0){
        //         Console.WriteLine("Fizz");
        //     }
        //     else if(val % 5 == 0){
        //         Console.WriteLine("Buzz");
        //     }

        
        // }
            // One to 100 devisible by 3 or 5 byt not both.        
        for(int val = 1; val <= 100; val++){
            if(val % 15 == 0){
                //do nothing;
            }
            else if(val % 3 == 0){
                Console.WriteLine(val);
            }
            else if(val % 5 == 0){
                Console.WriteLine(val);
            }
        }
            // One to 255
        //  for(int val = 1; val <= 255; val++)
        //     {
        //         Console.WriteLine(val);
        //     }   


        
    }
}
    }
