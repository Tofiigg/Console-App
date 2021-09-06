using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
     static class utils
    {
        public static T GetInputFromConsole<T>(string message = "Please enter text: ", string error = "\nError -> Invalid input!\n", bool isPassword = false, bool allowEmpty = false, int rightOffset = 0, ConsoleColor messageColor = ConsoleColor.Blue, ConsoleColor inputColor = ConsoleColor.Yellow)
        {
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();

                if (input != String.Empty && !allowEmpty)
                {
                    try
                    {
                        if (Convert.ChangeType(input, typeof(T)) is T)
                        {
                            return (T)Convert.ChangeType(input, typeof(T));
                        }
                        else
                        {
                            Console.WriteLine("Error!");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error!");
                    }
                }
                else
                {
                    Console.WriteLine("\nError -> Input is empty!\n");
                }
            }
        }
        public static void ClearConsole() => Console.Clear();

        public static string RepeatString(this string str, int repeat = 0)
        {
            string final = $"{str}";
            for (int i = 0; i < repeat; i++)
            {
                final += str;
            }
            return final;
        }


    }
}
