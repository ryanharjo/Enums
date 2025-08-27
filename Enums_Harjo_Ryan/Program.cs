namespace Enums_Harjo_Ryan
{
    // Global enum Months starting from Jan=1 to Dec=12
    public enum Months
    {
        Jan = 1,
        Feb,
        Mar,
        Apr,
        May,
        Jun,
        Jul,
        Aug,
        Sep,
        Oct,
        Nov,
        Dec
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Replace these values with your actual birth month/day/year
            int myBirthMonth = (int)Months.Oct;  // example: October
            int myBirthDay = 10;                  // example: 10th day
            int myBirthYear = 1989;               // example: year 1989

            // Create the birth date string
            string myBirthDate = $"My birthday is on {myBirthMonth}/{myBirthDay}/{myBirthYear}.";

            // File path for the original file
            string originalFile = "myFile.txt";

            // Write text to "myFile.txt" with a newline at the end
            string initialText = "This is the initial text in myFile.";
            File.WriteAllText(originalFile, initialText + Environment.NewLine);

            // Read and print the contents of "myFile.txt"
            string readText = File.ReadAllText(originalFile);
            Console.WriteLine("Contents of myFile.txt after WriteAllText:");
            Console.WriteLine(readText);

            // Append some text to the file with a newline
            string appendText = "This text was appended.";
            File.AppendAllText(originalFile, appendText + Environment.NewLine);

            // Read and print the contents again
            readText = File.ReadAllText(originalFile);
            Console.WriteLine("Contents of myFile.txt after AppendAllText:");
            Console.WriteLine(readText);

            // Define the new file path
            string newFile = "newFile.txt";

            // Copy or replace the new file with the original file
            File.Copy(originalFile, newFile, overwrite: true);

            // Append the birth date string to the new file with a newline
            File.AppendAllText(newFile, myBirthDate + Environment.NewLine);

            // Read and print all contents from the new file
            string newFileContents = File.ReadAllText(newFile);
            Console.WriteLine("Contents of newFile.txt after appending birth date:");
            Console.WriteLine(newFileContents);
        }
    }
}
