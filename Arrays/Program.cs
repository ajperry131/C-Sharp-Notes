namespace arrays {
    class Program {
        public static void Main(string[] args) {
            var numbers = new[] {3, 7, 9, 2, 14, 6};
            // Length
            Console.WriteLine("Length: " + numbers.Length);

            // IndexOf()
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9: " + index);

            // Clear()
            Array.Clear(numbers, 0, 2);

            Console.Write("Effect of Clear(): ");
            foreach (var number in numbers) {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            // Copy()
            var anotherArray = new int[3];
            Array.Copy(numbers, anotherArray, 3);

            Console.Write("Effect of Copy(): ");
            foreach (var number in anotherArray) {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            // Sort()
            Array.Sort(numbers);
            Console.Write("Effect of Sort(): ");
            foreach (var number in numbers) {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            // Reverse()
            Array.Reverse(numbers);
            Console.Write("Effect of Reverse(): ");
            foreach (var number in numbers) {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}