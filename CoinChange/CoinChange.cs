using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinChange
{
    //This is a way to calculate the required change given for the user's purchase
    //Made by Dimitrios Porfyropoulos

    class CoinChange
    {
        static void Main(string[] args)
        {
            int price;
            int userPay;
            int coinChange;
            int i;
            int a=0, b=0, c=0, d=0, e=0, f=0;
            string inputString, inputString2;

            Console.WriteLine("Ηello to the automated venting machine!! How many pences did the item cost to you?");            
            inputString = Console.ReadLine();
            bool success = int.TryParse(inputString, out price);
                while (!success || price>99 || price <0)
            {
                Console.WriteLine("Please enter a valid integer between 1-99");
                inputString = Console.ReadLine();
                success = int.TryParse(inputString, out price);
            }

            Console.WriteLine("And how many pences have you slotted into the machine?");            
            inputString2 = Console.ReadLine();
            bool success2 = int.TryParse(inputString2, out userPay);
                while (!success2 || userPay>100 || userPay <0)
            {
                Console.WriteLine("Please enter a valid integer between 1-100");
                inputString2 = Console.ReadLine();
                success2 = int.TryParse(inputString2, out userPay);
            }
            coinChange = userPay - price;           
            
                while (coinChange >= 50) 
            {
                a = coinChange / 50;
                coinChange = coinChange % 50;
                for (i = 1; i <= a; i++)
                    a=a++;
            }
                while (coinChange >= 20) 
            {
                b = coinChange / 20;
                coinChange = coinChange % 20;
                for (i = 1; i <= b; i++)
                    b=b++;
            }
                while (coinChange >= 10) 
            {
                c = coinChange / 10;
                coinChange = coinChange % 10;
                for (i = 1; i <= c; i++)
                    c=c++;
            }
                while (coinChange >= 5) 
            {
                d = coinChange / 5;
                coinChange = coinChange % 5;
                for (i = 1; i <= d; i++)
                    d=d++;
            }
                while (coinChange >= 2) 
            {
                e = coinChange / 2;
                coinChange = coinChange % 2;
                for (i = 1; i <= e; i++)
                    e=e++;
            }
            while (coinChange >= 1) 
            {
                f = coinChange / 1;
                coinChange = coinChange % 1;
                for (i = 1; i <= f; i++)
                    f=f++;
            }
            Console.WriteLine("The number of 50p coins is " +a+ "");
            Console.WriteLine("The number of 20p coins is " +b+ "");
            Console.WriteLine("The number of 10p coins is " +c+ "");
            Console.WriteLine("The number of 5p coins is " +d+ "");
            Console.WriteLine("The number of 2p coins is " +e+ "");
            Console.WriteLine("The number of 1p coins is " +f+ "");
        }
    }
}
