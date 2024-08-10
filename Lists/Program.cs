namespace Lists {
    class Program {
        public static void Main(string[] args) {
            //add and AddRange()
            var numbers = new List<int>() {1, 2, 3, 4};
            numbers.Add(1);
            numbers.AddRange(new int[] {5, 6, 7, 8});

            Console.Write("Add and AddRange(): ");
            foreach (var number in numbers) {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            // IndexOf()
            Console.WriteLine("Index of 1: " + numbers.IndexOf(1));

            // LastIndexOf()
            Console.WriteLine("Last Index: " + numbers.LastIndexOf(1));

            // Count
            Console.WriteLine("Count: " + numbers.Count);

            // Remove()
            numbers.Remove(1);
            Console.Write("Remove(1): ");
            foreach (var number in numbers) {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            // Remove() for all 1s
            for (var i = 0; i < numbers.Count; i++) {
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            }

            Console.Write("Remove all 1s: ");
            foreach (var number in numbers) {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            // Clear()
            numbers.Clear();
            Console.WriteLine("Count: " + numbers.Count);


            /************************/
            /*    PRACTICE TESTS    */
            /************************/

            //1- When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
            //     If no one likes your post, it doesn't display anything.
            //     If only one person likes your post, it displays: [Friend's Name] likes your post.
            //     If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
            //     If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
            // Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). 
            // Depending on the number of names provided, display a message based on the above pattern. 
            // ------------------------------------------------------------------------------
            // var names = new List<string>();
            // while(true) {
            //     Console.Write("Enter a name: ");
            //     var name = Console.ReadLine();
            //     if (String.IsNullOrWhiteSpace(name))
            //         break;

            //     names.Add(name);
            // }
            // if (names.Count == 1)
            //     Console.WriteLine("{0} likes your post", names[0]);
            // else if (names.Count == 2)
            //     Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
            // else
            //     Console.WriteLine("{0}, {1}, and {2} others like your post", names[0], names[1], names.Count - 2);


            // 2- Write a program and ask the user to enter their name. Use an array to reverse the 
            // name and then store the result in a new string. Display the reversed name on the console.
            // ------------------------------------------------------------------------------
            // Console.Write("Enter your name: ");
            // var name = Console.ReadLine();
            // var array = name.ToCharArray();
            // var reversedArray = array.Reverse();
            // var reversedName = String.Join("", reversedArray);
            // Console.WriteLine(reversedName);


            // 3- Write a program and ask the user to enter 5 numbers. If a number has been previously entered, 
            // display an error message and ask the user to re-try. Once the user successfully enters 5 unique 
            // numbers, sort them and display the result on the console. 
            // ------------------------------------------------------------------------------
            // var userNumbers = new int[5];
            // var index = 0;
            // while (index < userNumbers.Length) {
            //     Console.Write("Enter a number: ");
            //     var userNumber = int.Parse(Console.ReadLine());
                
            //     if (Array.IndexOf(userNumbers, userNumber) != -1) {
            //         Console.WriteLine("Number was previously entered, enter a different number");
            //         continue;
            //     }

            //     userNumbers[index] = userNumber;
            //     index++;
            // }

            // for (var i = 0; i < userNumbers.Length; i++) {
            //     Console.Write(userNumbers[i] + " ");
            // }
            // Console.WriteLine();
            

            // 4- Write a program and ask the user to continuously enter a number or type "Quit" to 
            // exit. The list of numbers may include duplicates. Display the unique numbers that the user has entered. 
            // ------------------------------------------------------------------------------
            
            // var userNumbers = new List<int>();
            // while (true) {
            //     Console.Write("Enter a number: ");
            //     var userResponse = Console.ReadLine();
                
            //     if (userResponse == "Quit")
            //         break;

            //     userNumbers.Add(int.Parse(userResponse));
            // }

            // var noDuplicates = new List<int>();
            // foreach (var number in userNumbers) {
            //     if (noDuplicates.IndexOf(number) == -1)
            //         noDuplicates.Add(number);
            // }

            // foreach (var number in noDuplicates) {
            //     Console.Write(number + " ");
            // }
            // Console.WriteLine();


            // 5- Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). 
            // If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; 
            // otherwise, display the 3 smallest numbers in the list. 
            // ------------------------------------------------------------------------------
            // while (true) {
            //     Console.Write("Enter a list of comma separated numbers: ");
            //     var userResponse = Console.ReadLine();
            //     if (String.IsNullOrWhiteSpace(userResponse)) {
            //         Console.WriteLine("Invalid List. Try again.");
            //         continue;
            //     }

            //     var array = userResponse.Split(", ").Select(int.Parse).ToArray();;
            //     if (array.Length < 5){
            //         Console.WriteLine("Invalid List. Try again.");
            //         continue;
            //     }

            //     Array.Sort(array);
            //     for (int i = 0; i < 3; i++) {
            //         Console.Write(array[i] + " ");
            //     }
            //     Console.WriteLine();
            //     break;
            // }
        }
    }
}
