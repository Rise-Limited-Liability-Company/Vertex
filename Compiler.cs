using System;
using System.Diagnostics;
class Compiler
{
    static public void Main()
    {
        Console.WriteLine("What's your application's path? (*.cs)");
        string request = Console.ReadLine();
        Console.WriteLine("Have you ever installed .NET? (Y/N)");
        string request2 = Console.ReadLine();
        if (request2 == "Y" || request2 == "y")
        {
            Process.Start("rtm.cmd");
        }
        if (request2 == "N" || request2 == "n")
        {
            Process.Start("dnd.cmd");
        }
    }
}