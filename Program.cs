#pragma warning disable
using System;
using System.IO;
using System.Collections.Generic;
namespace Vertex
{
    public class Vertex
    {
        public static void App(string file)
        {
            StreamReader fileReader = new StreamReader(file);
            int tokensCounter = 0;
            string line;
            string cToken = "";
            string csToken = "";
            string[] commands = 
            {
                "print",
                "int",
                "flt",
                "str",
                "cls",
                "inp",
            };
            string[] specialCharacters = 
            {
                "[ns]",
                "[nl]",
            };
            Dictionary<string,string> Str = new Dictionary<string,string>();
            Dictionary<string,int> Int = new Dictionary<string,int>();
            Dictionary<string,float> Flt = new Dictionary<string,float>();
            line = fileReader.ReadToEnd();
            foreach (var tokens in line.Split('\n'))
            {
                Console.WriteLine(tokens);
                foreach (var token in tokens.Split(' '))
                {
                    foreach (var command in commands)
                    {
                        if (token.Contains(command))
                        {
                            tokensCounter++;
                            Console.WriteLine(token + " " + tokensCounter + ": cmd");
                            cToken = token;
                            break;
                        }
                        else
                        {
                            if (!token.Contains(command))
                            {
                                if (cToken == "print" && token != "print")
                                {
                                    tokensCounter++;
                                    Console.WriteLine(token + " " + tokensCounter + ": chd");
                                    if (tokensCounter == 2)
                                    {
                                        if (Int.ContainsKey(token))
                                        {
                                            Console.WriteLine(Int[token]);
                                            return;
                                        }
                                        if (Str.ContainsKey(token))
                                        {
                                            Console.WriteLine(Str[token]);
                                            return;
                                        }
                                        if (Flt.ContainsKey(token))
                                        {
                                            Console.WriteLine(Flt[token]);
                                            return;
                                        }
                                        else
                                        {
                                            string modifiedToken = token.Replace("[ns]"," ");
                                            modifiedToken = modifiedToken.Replace("[nl]","\n");
                                            modifiedToken = modifiedToken.Replace(";","");
                                            Console.WriteLine(modifiedToken);
                                            csToken = null;
                                            tokensCounter = 0;
                                            break;
                                        }
                                    }
                                }
                                if (cToken == "int" && token != "int" && csToken == null)
                                {
                                    tokensCounter++;
                                    foreach (var specialCharacter in specialCharacters)
                                    {
                                        if (token.Contains(specialCharacter))
                                        {
                                            Console.WriteLine("VT-002: Special characters are not allowed in a variable");
                                            return;
                                        }
                                        else
                                        {
                                            csToken = token;
                                            return;
                                        }
                                    }
                                }
                                if (cToken == "int" && token != "int" && token != csToken && csToken != null)
                                {
                                    tokensCounter++;
                                    if (tokensCounter == 3)
                                    {
                                        int checker;
                                        if (int.TryParse(token,out checker))
                                        {
                                            string modifiedToken = token.Replace(";","");
                                            Int[csToken] = Convert.ToInt32(modifiedToken);
                                            csToken = null;
                                            tokensCounter = 0;
                                            return;
                                        }
                                        else
                                        {
                                            Console.WriteLine("VT-003: Invalid int value");
                                            return;
                                        }
                                    }
                                }
                                if (cToken == "flt" && token != "flt" && csToken == null)
                                {
                                    tokensCounter++;
                                    foreach (var specialCharacter in specialCharacters)
                                    {
                                        if (token.Contains(specialCharacter))
                                        {
                                            Console.WriteLine("VT-002: Special characters are not allowed in a variable");
                                            return;
                                        }
                                        else
                                        {
                                            csToken = token;
                                            return;
                                        }
                                    }
                                }
                                if (cToken == "flt" && token != "flt" && token != csToken && csToken != null)
                                {
                                    tokensCounter++;
                                    if (tokensCounter == 3)
                                    {
                                        float checker;
                                        if (float.TryParse(token,out checker))
                                        {
                                            string modifiedToken = token.Replace(";","");
                                            Flt[csToken] = Convert.ToSingle(modifiedToken);
                                            csToken = null;
                                            tokensCounter = 0;
                                            return;
                                        }
                                        else
                                        {
                                            Console.WriteLine("VT-004: Invalid float value");
                                            return;
                                        }
                                    }
                                }
                                if (cToken == "str" && token != "str" && csToken == null)
                                {
                                    tokensCounter++;
                                    foreach (var specialCharacter in specialCharacters)
                                    {
                                        if (token.Contains(specialCharacter))
                                        {
                                            Console.WriteLine("VT-002: Special characters are not allowed in a variable");
                                            return;
                                        }
                                        else
                                        {
                                            csToken = token;
                                            return;
                                        }
                                    }
                                }
                                if (cToken == "str" && token != "str" && token != csToken && csToken != null)
                                {
                                    tokensCounter++;
                                    if (tokensCounter == 3)
                                    {
                                        string modifiedToken = token.Replace("[ns]"," ");
                                        modifiedToken = modifiedToken.Replace("[nl]","\n");
                                        modifiedToken = modifiedToken.Replace(";","");
                                        Str[csToken] = Convert.ToString(modifiedToken);
                                        csToken = null;
                                        tokensCounter = 0;
                                        return;
                                    }
                                }
                                if (cToken == "inp" && token != "inp" && csToken == null)
                                {
                                    foreach (var specialCharacter in specialCharacters)
                                    {
                                        if (token.Contains(specialCharacter))
                                        {
                                            Console.WriteLine("VT-002: Special characters are not allowed in a variable");
                                            return;
                                        }
                                        else
                                        {
                                            csToken = token;
                                            string modifiedToken = token.Replace(";","");
                                            if (Str.ContainsKey(modifiedToken))
                                            {
                                                string input = Console.ReadLine();
                                                Str[modifiedToken] = input;
                                                csToken = null;
                                                tokensCounter = 0;
                                                return;
                                            }
                                            else
                                            {
                                                Console.WriteLine("VT-005: String does not has " + modifiedToken);
                                                csToken = null;
                                                return;
                                            }
                                        }
                                    }
                                }
                                /*if (cToken == "inp" && token != "inp" && token == csToken && csToken != null)
                                {
                                    string modifiedToken = token.Replace(";","");
                                    if (Str.ContainsKey(modifiedToken))
                                    {
                                        string input = Console.ReadLine();
                                        Str[modifiedToken] = input;
                                        return;
                                    }
                                    else
                                    {
                                        Console.WriteLine("VT-005: String does not has " + modifiedToken);
                                        return;
                                    }
                                }*/
                            }
                        }
                    }
                }
            }
            fileReader.Close();
        }
        static void Main(string[] args)
        {
            string cArg = "";
            if (args.Length == 0)
            {
                Console.WriteLine("Vertex\nUsage: Vertex <options>\nOptions:\n--r <file>.vt (Run)\n--v (Version)\n--l (License)");
                return;
            }
            foreach (var arg in args)
            {
                if (arg == "--r")
                {
                    cArg = arg;
                }
                if (arg == "--v")
                {
                    Console.WriteLine("1.0");
                }
                if (arg == "--l")
                {
                    Console.WriteLine("MIT License");
                }
                if (arg != null && cArg == "--r")
                {
                    if (arg.EndsWith(".vt"))
                    {
                        Console.Clear();
                        App(arg);
                    }
                    else
                    {
                        Console.WriteLine("VT-001: Invalid file type");
                    }
                }
            }
        }
    }
}