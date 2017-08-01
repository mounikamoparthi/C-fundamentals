using System;
using System.Collections.Generic;
namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
//Use the Add function in a similar fashion to push
// Dictionary<string,string> profile = new Dictionary<string,string>();
// //Almost all the methods that exists with Lists are the same with Dictionaries
// profile.Add("Name", "Speros");
// profile.Add("Language", "PHP");
// profile.Add("Location", "Greece");
// Console.WriteLine("Instructor Profile");
// Console.WriteLine("Name - " + profile["Name"]);
// Console.WriteLine("From - " + profile["Location"]);
// Console.WriteLine("Favorite Language - " + profile["Language"]);
// foreach (KeyValuePair<string,string> entry in profile)
// {
//  Console.WriteLine(entry.Key + " - " + entry.Value);
// }
int[] numArray2 = {1,2,3,4,5,6,7,8,9,10};
List<string> names = new List<string>();
//Use the Add function in a similar fashion to push
names.Add("Tim");
names.Add("Martin");
names.Add("Nikki");
names.Add("Sara");
foreach (string manu in names)
{
 Console.WriteLine("-" + manu);
}
bool[] boolArray = new bool[10];
            for(int i = 0; i < 10; i += 2)
            {
                boolArray[i] = true;
            }

 int[,] mult = new int[10,10];
            for(int x = 0; x < 10; x++)
            {
                for(int y = 0; y < 10; y++)
                {
                    mult[x, y] = (x + 1) * (y + 1);
                }
               
            }
            for(int x = 0; x < 10; x++)
            {
                string display = "[ ";
                for(int y = 0; y < 10; y++)
                {
                    display += mult[x, y] + ", ";
                    //Add an extra space for single digit values
                    if(mult[x,y] < 10)
                    {
                        display += " ";
                    }
                }
                display += "]";
                Console.WriteLine(display);
            }
           
List<string> flavors = new List<string>();
//Use the Add function in a similar fashion to push
flavors.Add("Strawberry");
flavors.Add("Chocolate");
flavors.Add("ButterScotch");
flavors.Add("Vanilla");
flavors.Add("Pista");

    Console.WriteLine("The length is {0}", flavors.Count);
    Console.WriteLine("The third entry is:" +flavors[2]);
    flavors.RemoveAt(2);
    Console.WriteLine("The new length is {0}", flavors.Count);
Dictionary<string, string> userInfo = new Dictionary<string,string>();
        Random rand = new Random();
        foreach(string name in names)
        {
            userInfo[name] = flavors[rand.Next(flavors.Count)];
            //Console.WriteLine(rand.Next(flavors.Count));
        }
        foreach (KeyValuePair<string,string> entry in userInfo)
        {
            Console.WriteLine(entry.Key + " - " + entry.Value);
        }
    }
}
}
