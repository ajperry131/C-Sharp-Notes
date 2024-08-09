using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace Conditionals
{
    partial class Program {
        static void Main(string[] args) {
            //value comparison if statement
            int hour = 10;
            if (hour > 0 && hour < 12) {
                System.Console.WriteLine("It's morning");
            } else if (hour >= 12 && hour < 18) {
                System.Console.WriteLine("It's afternoon");
            } else {
                System.Console.WriteLine("It's evening");
            }

            //bool-determining if statement
            bool isGoldCustomer = true;
            float price;
            if (isGoldCustomer) {
                price = 19.95f;
            } else {
                price = 29.95f;
            }
            System.Console.WriteLine("Price using bool: {0}", price);

            //shortened bool-determining if statement
            price = isGoldCustomer ? 19.95f : 29.95f;
            System.Console.WriteLine("Price using shortened bool: {0}", price);

            //switch statement with enum cases
            var season = Season.Autumn;
            switch (season) {
                case Season.Autumn:
                    System.Console.WriteLine("It's autumn");
                    break;
                case Season.Summer:
                    System.Console.WriteLine("It's summer");
                    break;
                default:
                    System.Console.WriteLine("Bad Season");
                    break;
            }

            //switch statement with multiple cases one break
            season = Season.Summer;
            switch (season) {
                case Season.Autumn:
                case Season.Summer:
                    System.Console.WriteLine("It's autumn or summer");
                    break;
                default:
                    System.Console.WriteLine("Bad Season");
                    break;
            }

            /************************************/
            /*         PRACTICE TESTS           */
            /************************************/
            // 1- Write a program and ask the user to enter a number. The number should be 
            // between 1 to 10. If the user enters a valid number,  display "Valid" on the 
            // console. Otherwise, display "Invalid". (This logic is used a lot in applications 
            // where values entered into input boxes need to be validated.)
            // ------------------------------------------------------------------------------
            // System.Console.Write("Enter a number: ");
            // int number = int.Parse(Console.ReadLine());
            // if (number >= 1 && number <= 10) {
            //     System.Console.WriteLine("Valid number");
            // } else {
            //     System.Console.WriteLine("Invalid number");
            // }
        
            // 2- Write a program which takes two numbers from the console and displays 
            // the maximum of the two.
            // ------------------------------------------------------------------------------
            // System.Console.Write("Enter a number: ");
            // int number1 = int.Parse(Console.ReadLine());
            // System.Console.Write("Enter another number: ");
            // int number2 = int.Parse(Console.ReadLine());
            // if (number1 > number2) {
            //     System.Console.WriteLine(number1);
            // } else if (number1 < number2) {
            //     System.Console.WriteLine(number2);
            // } else {
            //     System.Console.WriteLine("Both numbers are equal");
            // }

            // 3- Write a program and ask the user to enter the width and height of an image. 
            // Then tell if the image is landscape or portrait. 
            // ------------------------------------------------------------------------------
            // System.Console.Write("Enter the height: ");
            // int height = int.Parse(Console.ReadLine());
            // System.Console.Write("Enter the width: ");
            // int width = int.Parse(Console.ReadLine());
            // if (height > width) {
            //     System.Console.WriteLine("Portait");
            // } else if (height < width) {
            //     System.Console.WriteLine("Landscape");
            // } else {
            //     System.Console.WriteLine("Square");
            // }

            // 4- Write a program that asks the user to enter the speed limit. Once set, the program 
            // asks for the speed of a car. If the user enters a value less than the speed limit, 
            // program should display Ok on the console. If the value is above the speed limit, the 
            // program should calculate the number of demerit points. For every 5km/hr above the 
            // speed limit, 1 demerit points should be incurred and displayed on the console. If the 
            // number of demerit points is above 12, the program should display License Suspended. 
            // ------------------------------------------------------------------------------
            // System.Console.WriteLine("Enter the speed limit");
            // int speedLimit = int.Parse(Console.ReadLine());
            // System.Console.WriteLine("Enter the speed of the car");
            // int carSpeed = int.Parse(Console.ReadLine());
            // if (carSpeed <= speedLimit) {
            //     System.Console.WriteLine("OK");
            // } else if (carSpeed > speedLimit) {
            //     int demeritPoints = (carSpeed - speedLimit) / 5;
            //     System.Console.WriteLine("Demerit Points: " + demeritPoints);
            //     if (demeritPoints > 12) {
            //         System.Console.WriteLine("License Suspended");
            //     }
            // }
        }
    }
}