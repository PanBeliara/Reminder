using System;
using Microsoft.Win32;
using System.IO;

namespace Reminder
{
    class SetAutorun
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program allows you to add the Reminder to autostart.\n" +
                "Press the corresponding key to choose or any other to exit.");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Remove");
            var keyPressed = Console.ReadKey();
            Console.WriteLine();
            if (keyPressed.Key == ConsoleKey.D1)
            {
                string filePath = Path.GetFullPath("Reminder.exe");
                if (File.Exists(filePath))
                {
                    Console.WriteLine("File retrieved - " + filePath);

                    RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                    rk.SetValue("Reminder", "\"" + filePath + "\"");

                    Console.WriteLine("Key added.");
                }
                else
                {
                    Console.WriteLine("Couldn't find the file.\n" +
                    "Press any key to exit.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }


            }
            else if (keyPressed.Key == ConsoleKey.D2)
            {
                try
                {
                    RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                    rk.DeleteValue("Reminder");

                    Console.WriteLine("Key deleted.");
                }
                catch
                {
                    Console.WriteLine("There is no such record in autostart");
                }
            }
            else
                Environment.Exit(0);

            Console.WriteLine("\nPress any key...");
            Console.ReadKey();

        }
    }
}
