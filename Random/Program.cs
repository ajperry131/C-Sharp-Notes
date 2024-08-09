using System.Runtime.InteropServices;

namespace Rando {
    class Program {
        public static void Main(string[] args) {
            var random = new Random();
            
            //random numbers between 1-10
            for (var i = 0; i <= 10; i++) {
                Console.WriteLine(random.Next(1, 10));
            }
            
            //random ascii alphabet
            for (var i = 0; i <= 10; i++) {
                Console.Write((char) random.Next(97, 122));
            }
            Console.WriteLine();

            //random ascii alphabet with offset
            for (var i = 0; i <= 10; i++) {
                Console.Write((char)('a' + random.Next(0, 26)));
            }
            Console.WriteLine();

            //randopm ascii aplhabet with offset and char array for storage
            var buffer = new char[10];
            for (var i = 0; i < 10; i++) {
                buffer[i] = (char)('a' + random.Next(0, 26));
            }
            var password = new string(buffer);
                // can do instead -- var password = string.Join("", buffer);
            Console.WriteLine(password);

            /*****************************/
            /*       PRACTICE TESTS      */
            /*****************************/
            // 1- Write a program to count how many numbers between 1 and 100 are 
            // divisible by 3 with no remainder. Display the count on the console.
            // -----------------------------------------------------------------
            // var count = 0;
            // for (var i = 1; i <= 100; i++) {
            //     if (i%3 == 0)
            //         count++;
            // }
            // Console.WriteLine(count);

            // 2- Write a program and continuously ask the user to enter a number 
            // or "ok" to exit. Calculate the sum of all the previously entered 
            // numbers and display it on the console.
            // -----------------------------------------------------------------
            // var sum = 0;
            // while (true) {
            //     Console.Write("Enter a number: ");
            //     var input = Console.ReadLine();
            //     if (input == "ok")
            //         break;
            //     sum += int.Parse(input);
            // }
            // Console.WriteLine("Sum: " + sum);
            
            // 3- Write a program and ask the user to enter a number. Compute the 
            // factorial of the number and print it on the console. For example, if 
            // the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 
            // and display it as 5! = 120.
            // -----------------------------------------------------------------
            // Console.Write("Enter a number: ");
            // var factorial = int.Parse(Console.ReadLine());
            // var total = 1;
            // while (factorial > 0) {
            //     total *= factorial;
            //     factorial--;
            // }
            // Console.WriteLine(total);

            // 4- Write a program and ask the user to enter a series of numbers separated 
            // by comma. Find the maximum of the numbers and display it on the console. 
            // For example, if the user enters “5, 3, 8, 1, 4", the program should display 8. 
            // Console.Write("Enter a list of numbers (seperated by commas): ");
            // -----------------------------------------------------------------
            // var input = Console.ReadLine();
            // var numbers = input.Split(", ").Select(int.Parse).ToArray();
            // var max = numbers[0];
            // foreach (var number in numbers) {
            //     if (number > max) {
            //         max = number;
            //     }
            // }
            // Console.WriteLine(max);
            
        }
    }
}