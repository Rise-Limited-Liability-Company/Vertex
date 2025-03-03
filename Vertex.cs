#pragma warning disable
using System;
using System.IO;
using System.Collections.Generic;
namespace Vertex
{
    public class Vertex
    {
        public static string cToken = "";
        public static string csToken = "";
        public static string cmToken = "";
        public static string[] commands = 
            {
            "print",
            "int",
            "flt",
            "str",
            "cls",
            "inp",
        };
        public static string[] specialCharacters = 
        {
            "[ns]",
            "[nl]",
        };
        public static Dictionary<string,string> Str = new Dictionary<string,string>();
        public static Dictionary<string,int> Int = new Dictionary<string,int>();
        public static Dictionary<string,float> Flt = new Dictionary<string,float>();
        public static void Parse(string line, StreamReader fileReader)
        {
            foreach (var token in line.Split(' '))
            {
                foreach (var command in commands)
                {
                    if (token.Contains(command) && cToken != token)
                    {
                        cToken = token;
                        break;
                    }
                    else
                    {
                        if ((token != null || token != "") && (token != cToken || token != csToken))
                        {
                            if (cToken == "print")
                            {
                                if (Str.ContainsKey(token))
                                {
                                    Console.WriteLine(Str[token]);
                                    string newLine = fileReader.ReadLine();
                                    if (newLine != null)
                                    {
                                        cToken = null;
                                        csToken = null;
                                        Parse(newLine,fileReader);
                                        break;
                                    }
                                    else
                                    {
                                        return;
                                    }
                                }
                                if (Int.ContainsKey(token))
                                {
                                    Console.WriteLine(Int[token]);
                                    string newLine = fileReader.ReadLine();
                                    if (newLine != null)
                                    {
                                        cToken = null;
                                        csToken = null;
                                        Parse(newLine,fileReader);
                                        break;
                                    }
                                    else
                                    {
                                        return;
                                    }
                                }
                                if (Flt.ContainsKey(token))
                                {
                                    Console.WriteLine(Flt[token]);
                                    string newLine = fileReader.ReadLine();
                                    if (newLine != null)
                                    {
                                        cToken = null;
                                        csToken = null;
                                        Parse(newLine,fileReader);
                                        break;
                                    }
                                    else
                                    {
                                        return;
                                    }
                                }
                                else
                                {
                                    string modifiedToken = token.Replace("[ns]"," ");
                                    modifiedToken = modifiedToken.Replace("[nl]","\n");
                                    Console.WriteLine(modifiedToken);
                                    string newLine = fileReader.ReadLine();
                                    if (newLine != null)
                                    {
                                        cToken = null;
                                        csToken = null;
                                        Parse(newLine,fileReader);
                                        break;
                                    }
                                    else
                                    {
                                        return;
                                    }
                                }
                            }
                            if (cToken == "inp")
                            {
                                if (Str.ContainsKey(token))
                                {
                                    Str[token] = Console.ReadLine();
                                    string newLine = fileReader.ReadLine();
                                    if (newLine != null)
                                    {
                                        cToken = null;
                                        csToken = null;
                                        Parse(newLine,fileReader);
                                        break;
                                    }
                                    else
                                    {
                                        return;
                                    }
                                }
                            }
                            if (cToken == "int" && csToken == null)
                            {
                                foreach (var specialCharacter in specialCharacters)
                                {
                                    if (token.Contains(specialCharacter))
                                    {
                                        Console.WriteLine("VT-002: Special characters are not allowed in a variable name");
                                        break;
                                    }
                                    else
                                    {
                                        csToken = token;
                                        break;
                                    }
                                }
                            }
                            if (cToken == "int" && csToken != null && token != csToken)
                            {
                                int value;
                                if (int.TryParse(token,out value))
                                {
                                    Int.Add(csToken,value);
                                    string newLine = fileReader.ReadLine();
                                    if (newLine != null)
                                    {
                                        cToken = null;
                                        csToken = null;
                                        Parse(newLine,fileReader);
                                        break;
                                    }
                                    else
                                    {
                                        return;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("VT-003: Invalid intenger type : " + token);
                                    break;
                                }
                            }
                            if (cToken == "str" && csToken == null)
                            {
                                foreach (var specialCharacter in specialCharacters)
                                {
                                    if (token.Contains(specialCharacter))
                                    {
                                        Console.WriteLine("VT-002: Special characters are not allowed in a variable name");
                                        break;
                                    }
                                    else
                                    {
                                        csToken = token;
                                        break;
                                    }
                                }
                            }
                            if (cToken == "str" && csToken != null)
                            {
                                string value = token.Replace("[ns]"," ");
                                value = value.Replace("[nl]","\n");
                                Str.Add(csToken,value);
                                string newLine = fileReader.ReadLine();
                                if (newLine != null)
                                {
                                    cToken = null;
                                    csToken = null;
                                    Parse(newLine,fileReader);
                                    break;
                                }
                                else
                                {
                                    return;
                                }
                            }
                            if (cToken == "flt" && csToken == null)
                            {
                                foreach (var specialCharacter in specialCharacters)
                                {
                                    if (token.Contains(specialCharacter))
                                    {
                                        Console.WriteLine("VT-002: Special characters are not allowed in a variable name");
                                        break;
                                    }
                                    else
                                    {
                                        csToken = token;
                                        break;
                                    }
                                }
                            }
                            if (cToken == "flt" && (csToken != "" || csToken == null))
                            {
                                float value;
                                if (float.TryParse(token,out value))
                                {
                                    Flt.Add(csToken,value);
                                    string newLine = fileReader.ReadLine();
                                    if (newLine != null)
                                    {
                                        cToken = null;
                                        csToken = null;
                                        Parse(newLine,fileReader);
                                        break;
                                    }
                                    else
                                    {
                                        return;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("VT-003: Invalid float type : " + token);
                                    break;
                                }
                            }
                        }
                    }
                }
            }
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
                        StreamReader fileReader = new StreamReader(arg);
                        String line;
                        line = fileReader.ReadLine();
                        if  (line != null)
                        {
                            Parse(line,fileReader);
                        }
                        else
                        {
                            return;
                        }
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