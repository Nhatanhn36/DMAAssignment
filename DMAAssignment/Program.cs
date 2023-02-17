 using System;
    using System.IO;

namespace DMAAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the file name from user input
            Console.WriteLine("Enter the file name:");
            string fileName = Console.ReadLine();

            // Get the file path
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), fileName);

            // Check if the file exists
            if (File.Exists(filePath))
            {
                Console.WriteLine("File exists. Reading file contents...");
                // Read the contents of the file
                string fileContents = File.ReadAllText(filePath);
                Console.WriteLine("File contents: " + fileContents);
            }
            else
            {
                Console.WriteLine("File does not exist. Creating file...");
                // Create a new file
                File.Create(filePath).Close();
            }

            // Get the message from user input
            Console.WriteLine("Enter the message to write to the file:");
            string message = Console.ReadLine();

            // Write the message to the file
            File.WriteAllText(filePath, message);

            Console.WriteLine("Message written to file.");

            Console.ReadLine();
        }
    }
}
