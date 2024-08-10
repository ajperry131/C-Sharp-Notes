namespace WorkingWithFiles {
    class Program {
        public static void Main(string[] args) {
            
            // var originalPath = @"/home/andrew/Pictures/Screenshot_20240713_220835.png";
            // var newPath = @"/home/andrew/Pictures/Test/Screenshot_20240713_220835.png";


            //copy picture at path
            //File.Copy(originalPath, newPath, true);
            
            //delete picture at path
            //File.Delete(originalPath);

            //check if copied file exists
            // if (File.Exists(newPath)) {
            //     Console.WriteLine("I exist");
            // }

            //copy picture back to original path
            //var fileInfo = new FileInfo(newPath);
            //fileInfo.CopyTo(originalPath);
            
            //directory creation
            //Directory.CreateDirectory(@"/home/andrew/Pictures/new directory");

            //directory reading
            // var files = Directory.GetFiles(@"/home/andrew/Pictures/");
            // foreach (var file in files) {
            //     Console.WriteLine(file);
            // }
            // var directories = Directory.GetDirectories(@"/home/andrew/Pictures/", "*.*", SearchOption.AllDirectories);
            // foreach (var directory in directories) {
            //     Console.WriteLine(directory);
            // }

            //var path = @"/home/andrew/Pictures/Screenshot_20240713_220835.png";
            //get extension from path
            // var dotIndex = path.IndexOf('.');
            // var extension = path.Substring(dotIndex);
            // Console.WriteLine(extension);

            //get extension/file name from path
            // Console.WriteLine(Path.GetExtension(path));
            // Console.WriteLine(Path.GetFileName(path));

            /****************************/
            /*      PRACTICE TESTS      */
            /****************************/

            // 1- Write a program that reads a text file and displays the number of words. 
            //-----------------------------------------------------------------------
            // var text = File.ReadAllText(@"/home/andrew/Desktop/test.txt");
            // var words = text.Split(' ');
            // Console.WriteLine("Number of words: " + words.Length);

            // 2- Write a program that reads a text file and displays the longest word in the file. 
            // var text = File.ReadAllText(@"/home/andrew/Desktop/test.txt");
            // var words = text.Split(' ');
            // var longestWord = "";
            // for (var i = 0; i < words.Length; i++) {
            //     if (longestWord.Length < words[i].Length) {
            //         longestWord = words[i];
            //     }
            // }
            // Console.WriteLine(longestWord);
            
        }
    }
}
