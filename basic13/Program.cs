using System;
using System.Collections.Generic;
using System.Linq;
namespace basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print1To255();
            // PrintOdd();
            //PrintSum();
            // int[] myArr = new int[6] {1,3,5,7,9,13};
            // ArrayIterate(myArr);
            // MaxVal(myArr);
            // Avg(myArr);

            // int[] x= PrintOddArr();
            // foreach(int y in x){
            //     Console.WriteLine(y);
            // }
            
        }
        //print from 1 to 255
        // public static void Print1To255()
        // {
        //     for(int i=1; i<=255; i++){
        //         Console.WriteLine(i);
        //     }
            
        // }
        //print Odds from 1 to 255
        // public static void PrintOdd(){
        //     for(int i=1; i<=255; i++){
        //         if((i%2) != 0){
        //             Console.WriteLine(i);
        //         }
        //     }
        // }
        //  public static void PrintSum() {
        //     int sum = 0;
        //     for(int num = 0; num <= 255; num++) {
        //         sum += num; 
        //         Console.WriteLine($"New Number: {num} Sum: {sum}");
        //     }
        // }

        // //Iterate through an array
        // public static void ArrayIterate(int[] arr) {
        //     string output = "[";
        //     for(int i = 0; i < arr.Length; i++) {
        //         output += arr[i] + ", ";
        //     }
        //     output += "]";
        //     Console.WriteLine(output);
        // }
        //max in array
        
        // public static void MaxVal(int[] arr) {
        //     int num = arr.Max();
        //     Console.WriteLine(num);
        // }
        //Finding avg in an array
        // public static void Avg(int[] arr) {
        //     double num = arr.Average();
        //     Console.WriteLine(num);
        // }
        //Odds in array
        public static int[] PrintOddArr() {
            List<int> oddList = new List<int>();
            for(int val = 1; val < 256; val++) {
                if(val % 2 == 1) {
                    oddList.Add(val);

                }
            }
            return oddList.ToArray();
        }
    }

}

