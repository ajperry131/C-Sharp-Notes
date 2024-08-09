namespace HelloWorld
{
    class Program {
        static void Main(string[] args) {

            // convert enum to integer
            var method = ShippingMethod.Express;
            System.Console.WriteLine((int)method);

            //convert integer to enum
            var methodId = 3;
            System.Console.WriteLine((ShippingMethod)methodId);

            //convert enum to string
            System.Console.WriteLine(method.ToString());

            //convert string to enum
            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            System.Console.WriteLine(shippingMethod);
        }
        enum ShippingMethod {
                RegularAirMail = 1,
                RegisteredAirMail = 2,
                Express = 3
        }
    }
}