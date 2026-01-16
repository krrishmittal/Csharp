// <summary>
// Day 7 - File I/O Operations in C#
// 
// This program demonstrates file input/output operations including:
// - System.IO namespace for file operations
// - StreamWriter for writing to files
// - StreamReader for reading from files
// - Exception handling for file I/O
// - File reading and writing patterns
// - Append vs overwrite modes
// </summary>

using System;
using System.IO;

class Program
{
    public static void Main()
    {
        // ===== EXAMPLE 1: Basic File Writing with StreamWriter =====
        // StreamWriter writes characters to a file
        // Default behavior overwrites existing file content
        // Always use try-catch for exception handling
        // Close() must be called to save changes and free resources
        // 
        // string line = "";
        // try
        // {
        //     StreamWriter sw = new StreamWriter("sample.txt");
        //     sw.WriteLine("Hello my name is c#");
        //     sw.Close();
        // }
        // catch (Exception e)
        // {
        //     Console.WriteLine(e.Message);
        // }


        // ===== EXAMPLE 2: Basic File Reading with StreamReader =====
        // StreamReader reads characters from a file
        // ReadLine() returns null when end of file is reached
        // Use while loop to read all lines sequentially
        // Always close the stream after reading
        // 
        // try
        // {
        //     StreamReader sr = new StreamReader("sample.txt");
        //     line = sr.ReadLine();
        //     while (line != null)
        //     {
        //         Console.WriteLine(line);
        //         // Read the next line
        //         line = sr.ReadLine();
        //     }
        //     sr.Close();
        // }
        // catch (Exception e)
        // {
        //     Console.WriteLine("Exception: " + e.Message);
        // }


        // ===== EXAMPLE 3: File Writing with Append Mode =====
        // append: true parameter enables append mode
        // Adds new content to the end of existing file
        // Without append mode, file content is overwritten
        // Useful for logging or adding data incrementally
        // 
        // try
        // {
        //     StreamWriter sw = new StreamWriter("sample.txt", append: true);
        //     sw.WriteLine("Hello my name is c#");
        //     sw.Close();
        // }
        // catch (Exception e)
        // {
        //     Console.WriteLine(e.Message);
        // }


        // ===== EXAMPLE 4: Writing Multiple Lines with Loop =====
        // Using loops to write multiple lines efficiently
        // Each WriteLine() writes one line to the file
        // Demonstrates writing sequential data (numbers 0-9)
        // File is overwritten in this example (no append mode)
        // 
        // try
        // {
        //     StreamWriter sw = new StreamWriter("sample.txt");
        //     for (int x = 0; x < 10; x++)
        //     {
        //         sw.WriteLine(x);
        //     }
        //     sw.Close();
        // }
        // catch (Exception e)
        // {
        //     Console.WriteLine(e.Message);
        // }


        // ===== EXAMPLE 5: Reading Multiple Lines with Loop =====
        // Standard pattern for reading all lines from a file
        // Initialize line variable before the loop
        // Read first line before entering while loop
        // Continue reading until ReadLine() returns null
        // Display each line as it's read
        // 
        // try
        // {
        //     string line = "";
        //     StreamReader sr = new StreamReader("sample.txt");
        //     line = sr.ReadLine();
        //     while (line != null)
        //     {
        //         Console.WriteLine(line);
        //         line = sr.ReadLine();
        //     }
        //     sr.Close();
        // }
        // catch (Exception e)
        // {
        //     Console.WriteLine(e.Message);
        // }


        // ===== EXAMPLE 6: Complete Read-Write Workflow =====
        // Write data to file first, then read it back to verify
        // Demonstrates complete file I/O cycle
        // First block writes numbers 0-9 to the file
        // Second block reads and displays the written content
        // Each operation has its own try-catch block
        // 
        // try
        // {
        //     StreamWriter sw = new StreamWriter("sample.txt");
        //     for (int x = 0; x < 10; x++)
        //     {
        //         sw.WriteLine(x);
        //     }
        //     sw.Close();
        // }
        // catch (Exception e)
        // {
        //     Console.WriteLine(e.Message);
        // }
        // 
        // try
        // {
        //     string line = "";
        //     StreamReader sr = new StreamReader("sample.txt");
        //     line = sr.ReadLine();
        //     while (line != null)
        //     {
        //         Console.WriteLine(line);
        //         line = sr.ReadLine();
        //     }
        //     sr.Close();
        // }
        // catch (Exception e)
        // {
        //     Console.WriteLine(e.Message);
        // }


        // ===== ALTERNATIVE: Using Static File Methods =====
        // Simpler one-liner methods for basic file operations
        // File.ReadAllText() - Reads entire file as single string
        // File.ReadAllLines() - Reads all lines into string array
        // File.AppendAllText() - Appends text without StreamWriter
        // File.AppendAllLines() - Appends multiple lines
        // 
        // Example usage:
        // string content = File.ReadAllText("sample.txt");
        // string[] lines = File.ReadAllLines("sample.txt");
        // File.AppendAllText("sample.txt", "New line\n");
        // File.AppendAllLines("sample.txt", new[] { "Line 1", "Line 2" });


        // ===== BEST PRACTICES: Using Statement =====
        // 'using' statement automatically closes and disposes streams
        // Ensures resources are freed even if exception occurs
        // Cleaner and safer than manually calling Close()
        // 
        // Example:
        // using (StreamReader sr = new StreamReader("sample.txt"))
        // {
        //     string line;
        //     while ((line = sr.ReadLine()) != null)
        //     {
        //         Console.WriteLine(line);
        //     }
        // }
        // Stream is automatically closed when exiting the using block
    }
}

