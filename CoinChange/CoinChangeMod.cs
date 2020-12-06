using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinChange
{
    //This is a way to calculate the required change given for the user's purchase
    //Made by Dimitrios Porfyropoulos

    class CoinChangeModified
    {
        static void Main(string[] args)
        {
            int price, userPay, coinChange;      
            string inputString, inputString2;

            //code in comments is for UK currency
            string[] currency = { "pences", "cents" };

            //int[] coinRange = { 50, 20, 10, 5, 2, 1 }; 
            int[] coinRange = { 25, 10, 5, 1 };

            //int[] coinCount = new int[6];
            int[] coinCount = new int[4];            

            Console.WriteLine("Ηello to the automated venting machine!! How many "+currency[1]+" did the item cost to you?");            
            inputString = Console.ReadLine();
            bool success = int.TryParse(inputString, out price);
                while (!success || price>99 || price <0)
            {
                Console.WriteLine("Please enter a valid integer between 1-99");
                inputString = Console.ReadLine();
                success = int.TryParse(inputString, out price);
            }

            Console.WriteLine("And how many " + currency[1] + " have you slotted into the machine?");            
            inputString2 = Console.ReadLine();
            bool success2 = int.TryParse(inputString2, out userPay);
                while (!success2 || userPay<price || userPay>100)
            {
                Console.WriteLine("Please make sure you have entered the appropriate amount or more!!");
                inputString2 = Console.ReadLine();
                success2 = int.TryParse(inputString2, out userPay);
            }
            coinChange = userPay - price;


            for (int i = 0; i < coinCount.Length; i++)
            {
                coinCount[i] = coinChange / coinRange[i];
                coinChange = coinChange % coinRange[i];

                Console.WriteLine("The number of " +coinRange[i]+ " " + currency[1] + " " + coinCount[i] + "");
            }
            Console.ReadLine();
        }
    }
}
