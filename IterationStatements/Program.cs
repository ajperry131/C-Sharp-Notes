namespace Iterations {
    class Program {
        public static void Main(string[] args) {
            // for loop ascending
            for (var i = 0; i <= 10; i++) {
                if (i%2 == 0) {
                    Console.WriteLine(i);
                }
            }

            // for loop descending
            for (var i = 10; i >= 0; i--) {
                if (i%2 == 0) {
                    Console.WriteLine(i);
                }
            }

            //for loop character print
            var name = "John Smith";
            for (var i = 0; i < name.Length; i++) {
                Console.WriteLine(name[i]);
            }

            //foreach loop character print
            name = "Jane Doe";
            foreach (var character in name) {
                Console.WriteLine(character);
            }

            //foreach loop array print
            var numbers = new int[] {1, 2, 3, 4};
            foreach (var number in numbers) {
                Console.WriteLine(number);
            }

            //while loop ascending
            int j = 0;
            while (j <= 10) {
                if (j%2 == 0) {
                    Console.WriteLine(j);
                }
                j++;
            }

            //loop until input is blank
            while (true) {
                Console.WriteLine("Type your name: ");
                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                    break;
                
                Console.WriteLine("@Echo: " + input);
            }

            //loop until input is blank using continue to skip break
            while (true) {
                Console.WriteLine("Type your name: ");
                var input = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(input)) {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }
                    break;
            }

            /*****************************/
            /*       PRACTICE TESTS      */
            /*****************************/
            // 1- Write a program that picks a random number between 1 and 10. Give the 
            // user 4 chances to guess the number. If the user guesses the number, 
            // display “You won"; otherwise, display “You lost". (To make sure the 
            // program is behaving correctly, you can display the secret number on 
            // the console first.) 
            // -----------------------------------------------------------------
            // var number = random.Next(1, 10);
            // Console.WriteLine("The number: " + number);
            // for (var i = 1; i <= 4; i++) {
            //     Console.WriteLine("Guess the number: ");
            //     var guess = int.Parse(Console.ReadLine());
            //     if (guess == number) {
            //         Console.WriteLine("You won");
            //     } else if (i == 4) {
            //         Console.WriteLine("You lost");
            //     }
            // }

        }
    }
}
