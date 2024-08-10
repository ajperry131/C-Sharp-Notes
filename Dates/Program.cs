namespace Dates {
    class Program {
        public static void Main(string[] args) {
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            Console.WriteLine(now.Day);
            Console.WriteLine(dateTime.Day);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));


            //normal timespan
            var timeSpan = new TimeSpan(1, 2, 3);
            
            // timespan with just hours
            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: " + duration);

            //Properties
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes); // 1 hour + 1 minute + 1 second

            // Add
            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(5)));
            Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(5)));

            // ToString
            Console.WriteLine("ToString: " + timeSpan.ToString()); // writeline already applies tostring

            // Parse
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
        }
    }
}