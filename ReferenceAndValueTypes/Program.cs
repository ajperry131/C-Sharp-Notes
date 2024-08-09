namespace HelloWorld
{
    class Program {
        static void Main(string[] args) {
            // integers are value types
            var a = 10; // 10
            var b = a; // 10
            b++; // a = 10, b = 11
            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

            // arrays are reference types
            var array1 = new int[3] {1, 2, 3}; // 1, 2, 3
            var array2 = array1; // 1, 2, 3
            array2[0] = 0; // array1[0] = 0, array2[0] = 0
            System.Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));

        }
    }
}