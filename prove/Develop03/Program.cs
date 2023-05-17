using System;
using System.Collections.Generic;
public class Program
{
    static void Main()
    {
        ScriptureReference reference = new 
        ScriptureReference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        Console.Clear();
        Console.WriteLine(scripture.GetFormattedScripture());

        while (scripture.HasHiddenWords())
        {
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input == "quit")
                break;

            Console.Clear();
            scripture.HideRandomWords();
            Console.WriteLine(scripture.GetFormattedScripture());
        }

        Console.WriteLine("\nAll words have been hidden. Press Enter to exit.");
        Console.ReadLine();
    }
}