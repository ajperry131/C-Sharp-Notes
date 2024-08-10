using System.Globalization;
using System.Text;

namespace WorkingWithText {
    class Program {
        public static void Main(string[] args)
        {
            var fullName = "Jane Doe ";

            //trimming
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            // substring
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("LastName: " + lastName);

            // split
            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);

            // replace
            Console.WriteLine(fullName.Replace("Doe", "Bosh"));

            // check for nothing
            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            // convert string to number
            var str = "25";
            var num = Convert.ToInt32(str);
            Console.WriteLine(num);

            // convert string to price
            float price = 29.95f;
            Console.WriteLine(price.ToString("C0")); ;

            // shorten text without cutting off word
            var sentence = "This is going to be a really really long text.";
            var summary = SummarizeText(sentence);
            Console.WriteLine(summary);


            // builder practice
            var builder = new StringBuilder();
            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);
            Console.WriteLine(builder);
            builder.Replace('-', '+')
                .Remove(0, 10)
                .Insert(0, "insert");
            Console.WriteLine(builder);
            Console.WriteLine("First char: " + builder[0]);

            /**********************/
            /*   PRACTICE TESTS   */
            /**********************/

            // 1- Write a program and ask the user to enter a few numbers separated by a hyphen. 
            // Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" 
            // or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive". 
            //---------------------------------------------------------------------------------
            // Console.Write("Enter a few numbers separated by a hyphen: ");
            // var input = Console.ReadLine();
            // var numbers = input.Split('-').Select(int.Parse).ToArray();
            
            // var ascending = true;
            // var descending = true;
            // // check for ascending
            // for (var i = 0; i < numbers.Length - 1; i++) {
            //     if (numbers[i + 1] - numbers[i] != 1) {
            //         ascending = false;
            //         break;
            //     } 
            // }
            // //checking for descending
            // for (var i = 0; i < numbers.Length - 1; i++) {
            //     if (numbers[i] - numbers[i + 1] != 1)  {
            //         descending = false;
            //         break;
            //     }
            // }

            // if (ascending || descending)
            //     Console.WriteLine("Consecutive");
            // else
            //     Console.WriteLine("Not Consecutive");


            // 2- Write a program and ask the user to enter a few numbers separated by a hyphen. 
            // If the user simply presses Enter, without supplying an input, exit immediately; 
            // otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console. 
            //---------------------------------------------------------------------------------
            // Console.Write("Enter a few numbers separated by a hyphen: ");
            // var input = Console.ReadLine();
            // if (!String.IsNullOrWhiteSpace(input)) {
            //     string[] numbers = input.Split('-').Order().ToArray();
            //     for (int i = 0; i < numbers.Length - 1; i++) {
            //         if (numbers[i] == numbers[i + 1]) {
            //             Console.WriteLine("Duplicate");
            //             break;
            //         }
            //     }
            // }


            // 3- Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). 
            // A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, 
            // display "Invalid Time". If the user doesn't provide any values, consider it as invalid time. 
            //---------------------------------------------------------------------------------
            // Console.Write("Enter a date (ex. 19:00): ");
            // try {
            //     var input = Console.ReadLine();
            //     var time = DateTime.Parse(input);
            //     Console.WriteLine("Ok");
            // }
            // catch (Exception){
            //     Console.WriteLine("Invalid Time");
            // } 

            // 4- Write a program and ask the user to enter a few words separated by a space. Use the words to create
            // a variable name with PascalCase. For example, if the user types: "number of students", display "NumberOfStudents". 
            // Make sure that the program is not dependent on the input. So, if the user types "NUMBER OF STUDENTS", the program 
            // should still display "NumberOfStudents". 
            //---------------------------------------------------------------------------------
            // Console.Write("Enter a few words separated by a space: ");
            // var input = Console.ReadLine();
            // var words = input.ToLower().Split(' ');
            // for (var i = 0; i < words.Length; i++) {
            //     var uppercaseLetter = Convert.ToChar(words[i][0] - 32);
            //     words[i] = uppercaseLetter + words[i].Substring(1);
            // }
            // var PascalCase = string.Join("", words);
            // Console.WriteLine(PascalCase);


            // 5- Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the 
            // word. So, if the user enters "inadequate", the program should display 6 on the console. 
            //---------------------------------------------------------------------------------
            // Console.Write("Enter an English word: ");
            // var word = Console.ReadLine();

            // var vowels = new char[] {'a', 'e', 'i', 'o', 'u'};
            // var counter = 0;
            // foreach (char character in word) {
            //     if (Array.IndexOf(vowels, character) != -1)
            //         counter++;
            // }
            // Console.WriteLine(counter);
        }

        static string SummarizeText(string text, int maxLength = 20)
        {
            if (text.Length < maxLength)
                return text;

            var words = text.Split(' ');
            var totalCharacters = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word);

                totalCharacters += word.Length + 1;
                if (totalCharacters > maxLength)
                    break;
            }

            return String.Join(" ", summaryWords) + "...";
        }

    }
}

