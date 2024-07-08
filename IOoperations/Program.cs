using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

class ExampleBinaryReader
{
    static void Main()
    {
        string filePath = "D:\\Desktop\\C#\\I\\O\\Inoutoperations\\example.txt";
        /*
         *  BinaryWriter
            BinaryWriter writes primitive data types in binary format to a stream. It's often paired with BinaryReader.
        */
        using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
        {
            writer.Write(1.23); // Write a double
            writer.Write("Hello"); // Write a string
        }
        /*BinaryReader
            BinaryReader reads primitive data from a binary stream. It is useful for reading binary files and
        converting bytes back into data types.
        */

        using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
        {
            ArrayList li = new ArrayList();
            try
            {
                while (reader.BaseStream.Position < reader.BaseStream.Length)
                {
                    li.Add(reader.ReadDouble());
                    li.Add(reader.ReadString());
                }
            }
            catch (EndOfStreamException e)
            {
                Console.WriteLine("End of file reached.");
            }
            foreach (var i in li)
            { Console.Write(i + ""); }
        }

        //BufferedStream provides a temporary storage buffer for a stream of bytes,
        //    which improves performance by reducing the number of I / O operations.


        using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
        using (BufferedStream bufferedStream = new BufferedStream(fileStream))
        using (StreamWriter writer = new StreamWriter(bufferedStream))
        {
            writer.WriteLine("Hello, BufferedStream!");
        }



        /*
         * Directory
        The Directory class provides static methods for creating, moving, 
        and enumerating through directories and subdirectories.
        */
        string dirPath = "D:\\Desktop\\C#\\Iooperations\\IOoperations\\exampleDir";

        // Create a new directory
        Directory.CreateDirectory(dirPath);

        // Check if directory exists
        if (Directory.Exists(dirPath))
        {
            Console.WriteLine("Directory created successfully.");
        }

        // Get directories and files
        string[] subdirectories = Directory.GetDirectories(dirPath);
        string[] files = Directory.GetFiles(dirPath);

        // Delete the directory
        // Directory.Delete(dirPath);

        foreach (string v in files)
        {
            Console.WriteLine(v);
        }



        /* DirectoryInfo
DirectoryInfo provides instance methods for creating, moving, and enumerating through directories 
        and subdirectories, similar to Directory, but as an instance class.
        */
        DirectoryInfo dirInfo = new DirectoryInfo("D:\\Desktop\\C#\\Iooperations\\IOoperations");

        foreach (var dir in dirInfo.GetDirectories())
        {
            Console.WriteLine(dir.FullName);
            foreach (var file in dir.GetFiles())
            {
                Console.WriteLine(file.FullName);

            }
        }



        /*DriveInfo
    DriveInfo provides information about the drives on the current system,
        such as the drive type, total size, and available free space.
        */


        Console.Write("Enter the drive name (e.g., C:\\): ");
        string driveName = Console.ReadLine();

        // Create a DriveInfo object for the specified drive
        DriveInfo drives = new DriveInfo(driveName);

        Console.WriteLine($"Drive {drives.Name}");
        Console.WriteLine($"  Drive type: {drives.DriveType}");

        Console.WriteLine($"  Volume label: {drives.VolumeLabel}");
        Console.WriteLine($"  File system: {drives.DriveFormat}");
        Console.WriteLine($"  Available space: {drives.AvailableFreeSpace / (1024 * 1024 * 1024)} GB");
        Console.WriteLine($"  Total size: {drives.TotalSize / (1024 * 1024 * 1024)} GB");

        DriveInfo[] allDrives = DriveInfo.GetDrives();
        foreach (DriveInfo drive in allDrives)
        {
            Console.WriteLine($"Drive {drive.Name}");
            Console.WriteLine($"  Drive type: {drive.DriveType}");
            if (drive.IsReady)
            {
                Console.WriteLine($"  Volume label: {drive.VolumeLabel}");
                Console.WriteLine($"  File system: {drive.DriveFormat}");
                Console.WriteLine($"  Available space: {drive.AvailableFreeSpace / (1024 * 1024 * 1024)} GB");
                Console.WriteLine($"  Total size: {drive.TotalSize / (1024 * 1024 * 1024)} GB");
            }
        }


        /*The File class provides static methods for creating, copying, deleting,
         * moving, and opening files, as well as helping with reading from and writing to files.
         * */

        string filePa = "example.txt";

        // Write text to a file
        File.WriteAllText(filePa, "Hello, File!");

        // Read text from a file
        string content1 = File.ReadAllText(filePa);
        Console.WriteLine(content1);

        // Delete the file
        // File.Delete(filePa);

        //FileInfo
        // FileInfo provides instance methods for the creation, copying, deletion,
        // moving, and opening of files, and aids in the creation of FileStream objects.

        FileInfo fileInfo = new FileInfo("example.txt");

        // Write text to a file
        using (StreamWriter writer = fileInfo.AppendText())
        {
            writer.WriteLine("Hello, FileInfo!");
        }

        // Read text from a file
        using (StreamReader reader = fileInfo.OpenText())
        {
            string content = reader.ReadToEnd();
            Console.WriteLine(content);
        }

        // Delete the file
        // fileInfo.Delete();

        //        FileStream
        //FileStream provides a Stream for a file, supporting both synchronous and asynchronous read
        //and write operations.

        string filePath2 = "example.dat";

        // Write to the file
        using (FileStream fileStream = new FileStream(filePath2, FileMode.Create))
        using (BinaryWriter writer = new BinaryWriter(fileStream))
        {
            writer.Write(12345); // Write an integer
        }

        // Read from the file
        using (FileStream fileStream = new FileStream(filePath2, FileMode.Open))
        using (BinaryReader reader = new BinaryReader(fileStream))
        {
            int number = reader.ReadInt32();
            Console.WriteLine($"Read Integer: {number}");
        }



        //        MemoryStream
        //MemoryStream creates a stream whose backing store is memory,
        //making it useful for temporary storage and manipulation of byte data.
        //    
        byte[] buffer;

        // Write to MemoryStream
        using (MemoryStream memoryStream = new MemoryStream())
        using (StreamWriter writer = new StreamWriter(memoryStream))
        {
            writer.Write("Hello, MemoryStream!");
            writer.Flush();

            buffer = memoryStream.ToArray();
        }

        // Read from MemoryStream
        using (MemoryStream memoryStream = new MemoryStream(buffer))
        using (StreamReader reader = new StreamReader(memoryStream))
        {
            string content = reader.ReadToEnd();
            Console.WriteLine(content);
        }
        //  Path
        //Path provides methods for processing directory strings in a cross - platform manner,
        //such as combining, extracting, and manipulating paths.


        string dir1 = "exampleDir";
        string fileName = "example.txt";

        string fullPath = Path.Combine(dir1, fileName);
        Console.WriteLine($"Combined Path: {fullPath}");

        string directoryName = Path.GetDirectoryName(fullPath);
        Console.WriteLine($"Directory: {directoryName}");

        string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fullPath);
        Console.WriteLine($"File Name without Extension: {fileNameWithoutExtension}");

        string extension = Path.GetExtension(fullPath);
        Console.WriteLine($"Extension: {extension}");


        string filePath3 = "example.txt";
        //StreamWriter
        //StreamWriter is used for writing characters to a stream in a particular encoding.
                // Write to the file
        using (StreamWriter writer = new StreamWriter(filePath3))
        {
            writer.WriteLine("Hello, StreamWriter!");
        }

        //        StreamReader
        //StreamReader is used for reading characters from a byte stream in a particular encoding.
        // Read from the file
        using (StreamReader reader = new StreamReader(filePath3))
        {
            string content = reader.ReadToEnd();
            Console.WriteLine(content);
        }



        //StringReader
       // StringReader reads from a string buffer, making it useful for parsing strings.

                string data = "Hello, StringReader!\nThis is a new line.";

        using (StringReader reader = new StringReader(data))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }

        //StringWriter writes to a string buffer, which is useful for building strings dynamically.

        using (StringWriter writer = new StringWriter())
        {
            writer.WriteLine("Hello, StringWriter!");
            writer.WriteLine("This is a new line.");

            string result = writer.ToString();
            Console.WriteLine(result);
        }
    }
}
