#pragma warning disable
using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.InteropServices;
namespace Vertex
{
    public class Vertex
    {
        public static string cToken = "";
        public static string csToken = "";
        public static string clToken = "";
        public static string coToken = "";
        public static bool inIfStatement = false;
        public static bool inIfStatement2 = false;
        public static string[] commands = 
        {
            "import",
            "print",
            "int",
            "flt",
            "str",
            "if",
            "end",
            "inp",
            "end",
            "finish",
            "html",
            "lgl",
            "db",
        };
        public static string[] specialCharacters = 
        {
            "[ns]",
            "[nl]",
        };
        public static Dictionary<string,string> Str = new Dictionary<string,string>();
        public static Dictionary<string,int> Int = new Dictionary<string,int>();
        public static Dictionary<string,float> Flt = new Dictionary<string,float>();
        public static Dictionary<int,Dictionary<int,string>> If = new Dictionary<int,Dictionary<int,string>>();
        public static Dictionary<int,Dictionary<int,string>> Functions = new Dictionary<int,Dictionary<int,string>>();
        public static Dictionary<int,string> allCommands = new Dictionary<int,string>();
        public static Dictionary<string,bool> extensions = new Dictionary<string,bool>()
        {
            {"lgl",false},
            {"db",false},
            {"html",false},
        };
        public static void Parse(string line,StreamReader fileReader)
        {
            if (line == null)
            {
                return;
            }
            foreach (var token in line.Split(' '))
            {
                foreach (var command in commands)
                {
                    if (token.Contains(command) && cToken != token)
                    {
                        if (token == "end")
                        {
                            if (inIfStatement == true && inIfStatement2 == false)
                            {
                                inIfStatement = false;
                            }
                            if (inIfStatement == true && inIfStatement2 == true)
                            {
                                inIfStatement2 = false;
                            }
                            string newLine = fileReader.ReadLine();
                            newLine = newLine.Replace("\t","");
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
                        if (token == "html")
                        {
                            if (extensions["html"] == true)
                            {
                                cToken = token;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("VT-009: Unknown token : " + token);
                            }
                        }
                        if (token == "lgl")
                        {
                            if (extensions["lgl"] == true)
                            {
                                cToken = token;
                                string newLine = fileReader.ReadLine();
                                newLine = newLine.Replace("\t","");
                                if (newLine != null)
                                {
                                    cToken = null;
                                    csToken = null;
                                    Parse(newLine,fileReader);
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("VT-009: Unknown token : " + token);
                            }
                        }
                        if (token == "db")
                        {
                            if (extensions["db"] == true)
                            {
                                cToken = token;
                                string newLine = fileReader.ReadLine();
                                newLine = newLine.Replace("\t","");
                                if (newLine != null)
                                {
                                    cToken = null;
                                    csToken = null;
                                    Parse(newLine,fileReader);
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("VT-009: Unknown token : " + token);
                            }
                        }
                        if (token == "finish")
                        {
                            return;
                        }
                        else
                        {
                            cToken = token;
                        }
                        break;
                    }
                    else
                    {
                        if ((token != null || token != "") && (token != cToken || token != csToken))
                        {
                            if (inIfStatement == false)
                            {
                                if (cToken == "print")
                                {
                                    if (Str.ContainsKey(token))
                                    {
                                        Console.WriteLine(Str[token]);
                                        string newLine = fileReader.ReadLine();
                                        newLine = newLine.Replace("\t","");
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
                                        newLine = newLine.Replace("\t","");
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
                                        newLine = newLine.Replace("\t","");
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
                                        newLine = newLine.Replace("\t","");
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
                                        newLine = newLine.Replace("\t","");
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
                                if (cToken == "int" && (csToken != null && token != csToken))
                                {
                                    int value;
                                    if (int.TryParse(token,out value))
                                    {
                                        Int.Add(csToken,value);
                                        Int[csToken] = value;
                                        string newLine = fileReader.ReadLine();
                                        newLine = newLine.Replace("\t","");
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
                                if (cToken == "str" && (csToken != null && token != csToken))
                                {
                                    string value = token.Replace("[ns]"," ");
                                    value = value.Replace("[nl]","\n");
                                    Str.Add(csToken,value);
                                    Str[csToken] = value;
                                    string newLine = fileReader.ReadLine();
                                    newLine = newLine.Replace("\t","");
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
                                if (cToken == "flt" && (csToken != "" && csToken == null))
                                {
                                    float value;
                                    if (float.TryParse(token,out value))
                                    {
                                        Flt.Add(csToken,value);
                                        Flt[csToken] = value;
                                        string newLine = fileReader.ReadLine();
                                        newLine = newLine.Replace("\t","");
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
                                if (cToken == "if" && (csToken == null && coToken == null && clToken == null))
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
                                if (cToken == "if" && (csToken != null && coToken == null && clToken == null))
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
                                            coToken = token;
                                            break;
                                        }
                                    }
                                }
                                if (cToken == "if" && (csToken != null && coToken != null && clToken == null))
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
                                            clToken = token;
                                            break;
                                        }
                                    }
                                }
                                if (cToken == "if" && (csToken!= null && coToken != null && clToken != null))
                                {
                                    if (Str.ContainsKey(csToken))
                                    {
                                        if (Str.ContainsKey(clToken))
                                        {
                                            if (coToken == "==")
                                            {
                                                if (Str[csToken] == Str[clToken])
                                                {
                                                    if (inIfStatement == false)
                                                    {
                                                        inIfStatement = true;
                                                        string newLine = fileReader.ReadLine();
                                                        newLine = newLine.Replace("\t","");
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
                                                        inIfStatement2 = true;
                                                        string newLine = fileReader.ReadLine();
                                                        newLine = newLine.Replace("\t","");
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
                                            }
                                            if (coToken == "!=")
                                            {
                                                if (Str[csToken] != Str[clToken])
                                                {
                                                    if (inIfStatement == false)
                                                    {
                                                        inIfStatement = true;
                                                        string newLine = fileReader.ReadLine();
                                                        newLine = newLine.Replace("\t","");
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
                                                        inIfStatement2 = true;
                                                        string newLine = fileReader.ReadLine();
                                                        newLine = newLine.Replace("\t","");
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
                                            }
                                            if (coToken == ">")
                                            {
                                                if (Str[csToken].Length > Str[clToken].Length)
                                                {
                                                    if (inIfStatement == false)
                                                    {
                                                        inIfStatement = true;
                                                        string newLine = fileReader.ReadLine();
                                                        newLine = newLine.Replace("\t","");
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
                                                        inIfStatement2 = true;
                                                        string newLine = fileReader.ReadLine();
                                                        newLine = newLine.Replace("\t","");
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
                                            }
                                            if (coToken == "<")
                                            {
                                                if (Str[csToken].Length < Str[clToken].Length)
                                                {
                                                    if (inIfStatement == false)
                                                    {
                                                        inIfStatement = true;
                                                        string newLine = fileReader.ReadLine();
                                                        newLine = newLine.Replace("\t","");
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
                                                        inIfStatement2 = true;
                                                        string newLine = fileReader.ReadLine();
                                                        newLine = newLine.Replace("\t","");
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
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("VT-004: Cannot compare other variable type with string");
                                        }
                                    }
                                    if (Int.ContainsKey(csToken))
                                    {
                                        if (Int.ContainsKey(clToken))
                                        {
                                            if (coToken == "==")
                                            {
                                                if (Int[csToken] == Int[clToken])
                                                {
                                                    if (inIfStatement == false)
                                                    {
                                                        inIfStatement = true;
                                                        string newLine = fileReader.ReadLine();
                                                        newLine = newLine.Replace("\t","");
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
                                                        inIfStatement2 = true;
                                                        string newLine = fileReader.ReadLine();
                                                        newLine = newLine.Replace("\t","");
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
                                            }
                                            if (coToken == "!=")
                                            {
                                                if (Int[csToken] != Int[clToken])
                                                {
                                                    if (inIfStatement == false)
                                                    {
                                                        inIfStatement = true;
                                                        string newLine = fileReader.ReadLine();
                                                        newLine = newLine.Replace("\t","");
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
                                                        inIfStatement2 = true;
                                                        string newLine = fileReader.ReadLine();
                                                        newLine = newLine.Replace("\t","");
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
                                            }
                                            if (coToken == ">")
                                            {
                                                if (Int[csToken] > Int[clToken])
                                                {
                                                    if (inIfStatement == false)
                                                    {
                                                        inIfStatement = true;
                                                        string newLine = fileReader.ReadLine();
                                                        newLine = newLine.Replace("\t","");
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
                                                        inIfStatement2 = true;
                                                        string newLine = fileReader.ReadLine();
                                                        newLine = newLine.Replace("\t","");
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
                                            }
                                            if (coToken == "<")
                                            {
                                                if (Int[csToken] < Int[clToken])
                                                {
                                                    if (inIfStatement == false)
                                                    {
                                                        inIfStatement = true;
                                                        string newLine = fileReader.ReadLine();
                                                        newLine = newLine.Replace("\t","");
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
                                                        inIfStatement2 = true;
                                                        string newLine = fileReader.ReadLine();
                                                        newLine = newLine.Replace("\t","");
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
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("VT-006: Cannot compare other variable type with intenger");
                                        }
                                    }
                                    if (Flt.ContainsKey(csToken))
                                    {
                                        if (Flt.ContainsKey(clToken))
                                        {
                                            if (coToken == "==")
                                            {
                                                if (Flt[csToken] == Flt[clToken])
                                                {
                                                    if (inIfStatement == false)
                                                    {
                                                        inIfStatement = true;
                                                        string newLine = fileReader.ReadLine();
                                                        newLine = newLine.Replace("\t","");
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
                                                        inIfStatement2 = true;
                                                        string newLine = fileReader.ReadLine();
                                                        newLine = newLine.Replace("\t","");
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
                                            }
                                            if (coToken == "!=")
                                            {
                                                if (Flt[csToken] != Flt[clToken])
                                                {
                                                    if (inIfStatement == false)
                                                    {
                                                        inIfStatement = true;
                                                        string newLine = fileReader.ReadLine();
                                                        newLine = newLine.Replace("\t","");
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
                                                        inIfStatement2 = true;
                                                        string newLine = fileReader.ReadLine();
                                                        newLine = newLine.Replace("\t","");
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
                                            }
                                            if (coToken == ">")
                                            {
                                                if (Flt[csToken] > Flt[clToken])
                                                {
                                                    if (inIfStatement == false)
                                                    {
                                                        inIfStatement = true;
                                                        string newLine = fileReader.ReadLine();
                                                        newLine = newLine.Replace("\t","");
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
                                                        inIfStatement2 = true;
                                                        string newLine = fileReader.ReadLine();
                                                        newLine = newLine.Replace("\t","");
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
                                            }
                                            if (coToken == "<")
                                            {
                                                if (Flt[csToken] < Flt[clToken])
                                                {
                                                    if (inIfStatement == false)
                                                    {
                                                        inIfStatement = true;
                                                        string newLine = fileReader.ReadLine();
                                                        newLine = newLine.Replace("\t","");
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
                                                        inIfStatement2 = true;
                                                        string newLine = fileReader.ReadLine();
                                                        newLine = newLine.Replace("\t","");
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
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("VT-007: Cannot compare other variable type with float");
                                        }
                                    }
                                }
                                if (cToken == "import")
                                {
                                    if (cToken == "import" && token == "lgl")
                                    {
                                        extensions["lgl"] = true;
                                        string newLine = fileReader.ReadLine();
                                        newLine = newLine.Replace("\t","");
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
                                    if (cToken == "import" && token == "db")
                                    {
                                        extensions["db"] = true;
                                        string newLine = fileReader.ReadLine();
                                        newLine = newLine.Replace("\t","");
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
                                    if (cToken == "import" && token == "html")
                                    {
                                        extensions["html"] = true;
                                        string newLine = fileReader.ReadLine();
                                        newLine = newLine.Replace("\t","");
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
                                        Console.WriteLine("VT-008: Invalid extension");
                                    }
                                }
                                if (cToken == "set" && csToken == null)
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
                                if (cToken == "set" && (csToken != null && token != csToken))
                                {
                                    if (Str.ContainsKey(csToken))
                                    {
                                        string value = token.Replace("[ns]"," ");
                                        value = value.Replace("[nl]","\n");
                                        Str[csToken] = value;
                                        string newLine = fileReader.ReadLine();
                                        newLine = newLine.Replace("\t","");
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
                                    if (Int.ContainsKey(csToken))
                                    {
                                        int value;
                                        if (int.TryParse(token,out value))
                                        {
                                            Int[csToken] = value;
                                            string newLine = fileReader.ReadLine();
                                            newLine = newLine.Replace("\t","");
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
                                    if (Flt.ContainsKey(csToken))
                                    {
                                        float value;
                                        if (float.TryParse(token,out value))
                                        {
                                            Flt[csToken] = value;
                                            string newLine = fileReader.ReadLine();
                                            newLine = newLine.Replace("\t","");
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
                                            Console.WriteLine("VT-004: Invalid float type : " + token);
                                            break;
                                        }
                                    }
                                }
                                if (cToken == "html")
                                {
                                    if (Str.ContainsKey(token))
                                    {
                                        if (Str[token].StartsWith("p:") && Str[token].EndsWith(":p"))
                                        {
                                            string instance = Str[token].Replace("p:","<p>");
                                            string id = instance.Substring(instance.IndexOf("["),instance.IndexOf("]") - instance.IndexOf("[")).Replace("[","");
                                            instance = instance.Replace("[" + id,"");
                                            instance = instance.Replace("[","");
                                            instance = instance.Replace("]","");
                                            instance = instance.Replace("<p>","<p id='" + id + "'>");
                                            instance = instance.Replace(":p","</p>");
                                            instance = instance.Replace("[ns]"," ");
                                            instance = instance.Replace("[nl]","\n");
                                            Str[token] = instance;
                                            string newLine = fileReader.ReadLine();
                                            newLine = newLine.Replace("\t",""); 
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
                                        if (Str[token].StartsWith("h1:") && Str[token].EndsWith(":h1"))
                                        {
                                            string instance = Str[token].Replace("h1:","<h1>");
                                            string id = instance.Substring(instance.IndexOf("["),instance.IndexOf("]") - instance.IndexOf("[")).Replace("[","");
                                            instance = instance.Replace("[" + id,"");
                                            instance = instance.Replace("[","");
                                            instance = instance.Replace("]","");
                                            instance = instance.Replace("h1:","<h1 id='" + id + "'>");
                                            instance = instance.Replace(":h1","</h1>");
                                            instance = instance.Replace("[ns]"," ");
                                            instance = instance.Replace("[nl]","\n");
                                            Str[token] = instance;
                                            string newLine = fileReader.ReadLine();
                                            newLine = newLine.Replace("\t",""); 
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
                                        if (Str[token].StartsWith("h2:") && Str[token].EndsWith(":h2"))
                                        {
                                            string instance = Str[token].Replace("h2:","<h2>");
                                            string id = instance.Substring(instance.IndexOf("["),instance.IndexOf("]") - instance.IndexOf("[")).Replace("[","");
                                            instance = instance.Replace("[" + id,"");
                                            instance = instance.Replace("[","");
                                            instance = instance.Replace("]","");
                                            instance = instance.Replace("h2:","<h2 id='" + id + "'>");
                                            instance = instance.Replace(":h2","</h2>");
                                            instance = instance.Replace("[ns]"," ");
                                            instance = instance.Replace("[nl]","\n");
                                            Str[token] = instance;
                                            string newLine = fileReader.ReadLine();
                                            newLine = newLine.Replace("\t",""); 
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
                                        if (Str[token].StartsWith("h3:") && Str[token].EndsWith(":h3"))
                                        {
                                            string instance = Str[token].Replace("h3:","<h3>");
                                            string id = instance.Substring(instance.IndexOf("["),instance.IndexOf("]") - instance.IndexOf("[")).Replace("[","");
                                            instance = instance.Replace("[" + id,"");
                                            instance = instance.Replace("[","");
                                            instance = instance.Replace("]","");
                                            instance = instance.Replace("h3:","<h3 id='" + id + "'>");
                                            instance = instance.Replace(":h3","</h3>");
                                            instance = instance.Replace("[ns]"," ");
                                            instance = instance.Replace("[nl]","\n");
                                            Str[token] = instance;
                                            string newLine = fileReader.ReadLine();
                                            newLine = newLine.Replace("\t",""); 
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
                                        if (Str[token].StartsWith("h4:") && Str[token].EndsWith(":h4"))
                                        {
                                            string instance = Str[token].Replace("h4:","<h4>");
                                            string id = instance.Substring(instance.IndexOf("["),instance.IndexOf("]") - instance.IndexOf("[")).Replace("[","");
                                            instance = instance.Replace("[" + id,"");
                                            instance = instance.Replace("[","");
                                            instance = instance.Replace("]","");
                                            instance = instance.Replace("h4:","<h4 id='" + id + "'>");
                                            instance = instance.Replace(":h4","</h4>");
                                            instance = instance.Replace("[ns]"," ");
                                            instance = instance.Replace("[nl]","\n");
                                            Str[token] = instance;
                                            string newLine = fileReader.ReadLine();
                                            newLine = newLine.Replace("\t",""); 
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
                                        if (Str[token].StartsWith("h5:") && Str[token].EndsWith(":h5"))
                                        {
                                            string instance = Str[token].Replace("h5:","<h5>");
                                            string id = instance.Substring(instance.IndexOf("["),instance.IndexOf("]") - instance.IndexOf("[")).Replace("[","");
                                            instance = instance.Replace("[" + id,"");
                                            instance = instance.Replace("[","");
                                            instance = instance.Replace("]","");
                                            instance = instance.Replace("h5:","<h5 id='" + id + "'>");
                                            instance = instance.Replace(":h5","</h5>");
                                            instance = instance.Replace("[ns]"," ");
                                            instance = instance.Replace("[nl]","\n");
                                            Str[token] = instance;
                                            string newLine = fileReader.ReadLine();
                                            newLine = newLine.Replace("\t",""); 
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
                                        if (Str[token].StartsWith("h6:") && Str[token].EndsWith(":h6"))
                                        {
                                            string instance = Str[token].Replace("h6:","<h6>");
                                            string id = instance.Substring(instance.IndexOf("["),instance.IndexOf("]") - instance.IndexOf("[")).Replace("[","");
                                            instance = instance.Replace("[" + id,"");
                                            instance = instance.Replace("[","");
                                            instance = instance.Replace("]","");
                                            instance = instance.Replace("h6:","<h6 id='" + id + "'>");
                                            instance = instance.Replace(":h6","</h6>");
                                            instance = instance.Replace("[ns]"," ");
                                            instance = instance.Replace("[nl]","\n");
                                            Str[token] = instance;
                                            string newLine = fileReader.ReadLine();
                                            newLine = newLine.Replace("\t",""); 
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
                                        if (Str[token].StartsWith("a:") && Str[token].EndsWith(":a"))
                                        {
                                            string instance = Str[token];
                                            string link = instance.Substring(instance.IndexOf("{"),instance.IndexOf("}") - instance.IndexOf("{"));
                                            string id = instance.Substring(instance.IndexOf("["),instance.IndexOf("]") - instance.IndexOf("[")).Replace("[","");
                                            instance = instance.Replace("[" + id,"");
                                            instance = instance.Replace(link,"");
                                            instance = instance.Replace("[","");
                                            instance = instance.Replace("]","");
                                            instance = instance.Replace("a:","<a id='" + id + "' href='" + link + "'>");
                                            instance = instance.Replace("[ns]"," ");
                                            instance = instance.Replace("[nl]","\n");
                                            instance = instance.Replace("{","");
                                            instance = instance.Replace("}","");
                                            instance = instance.Replace(":a","</a>");
                                            Str[token] = instance;
                                            string newLine = fileReader.ReadLine();
                                            newLine = newLine.Replace("\t",""); 
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
                                        if (Str[token].StartsWith("img:") && Str[token].EndsWith(":img"))
                                        {
                                            string instance = Str[token];
                                            string link = instance.Substring(instance.IndexOf("{link:"),instance.IndexOf("}") - instance.IndexOf("{"));
                                            string id = instance.Substring(instance.IndexOf("["),instance.IndexOf("]") - instance.IndexOf("[")).Replace("[","");
                                            instance = instance.Replace("[" + id,"");
                                            instance = instance.Replace(link,"");
                                            instance = instance.Replace("[","");
                                            instance = instance.Replace("]","");
                                            instance = instance.Replace("img:","<img id='" + id + "' src='" + link + "'/>");
                                            instance = instance.Replace(":img","");
                                            instance = instance.Replace("{","");
                                            instance = instance.Replace("}","");
                                            instance = instance.Replace("[ns]"," ");
                                            instance = instance.Replace("[nl]","\n");
                                            Str[token] = instance;
                                            string newLine = fileReader.ReadLine();
                                            newLine = newLine.Replace("\t",""); 
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
                                }
                            }
                        }
                    }
                }
            }
        }
        public static void vTSOS()
        {
            Console.WriteLine("vTSOS");
            string line = "";
            string cData = "";
            string csData = "";
            string[] datas = 
            {
                "*system",
                "*install",
                "*version",
                "*help",
                "*license",
                "*run",
                "*quit",
            };
            Console.WriteLine("Commands");
            foreach (var data in datas)
            {
                Console.WriteLine(data);
            }
            while (true)
            {
                Console.WriteLine(">> ");
                line = Console.ReadLine();
                if (line == "*system")
                {
                    Console.WriteLine("vTSOS");
                }
                if (line == "*install")
                {
                    Console.WriteLine("Username: ");
                    string usr = Console.ReadLine();
                    Console.WriteLine("Password: ");
                    string pwd = Console.ReadLine();
                    Console.WriteLine("Installed vTSOS");
                    StreamWriter writer = new StreamWriter("data.spc");
                    writer.WriteLine("usr: " + usr);
                    writer.WriteLine("pwd: " + pwd);
                }
                if (line == "*version")
                {
                    Console.WriteLine("0.5.0");
                }
                if (line == "*help")
                {
                    Console.WriteLine("Commands");
                    foreach (var data in datas)
                    {
                        Console.WriteLine(data);
                    }
                }
                if (line == "*license")
                {
                    Console.WriteLine("MIT License");
                }
                if (line == "*quit")
                {
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            string cArg = "";
            if (args.Length == 0)
            {
                Console.WriteLine("Vertex\nUsage: Vertex <options>\nOptions:\n--r <file>.vt (Run)\n--v (Version)\n--l (License)\n--s (Sub Operating System)");
                return;
            }
            foreach (var arg in args)
            {
                if (arg == "--run")
                {
                    cArg = arg;
                    break;
                }
                if (arg == "--v")
                {
                    Console.WriteLine("0.5.0");
                    return;
                }
                if (arg == "--l")
                {
                    Console.WriteLine("MIT License");
                    return;
                }
                if (arg != null && cArg == "--r")
                {
                    if (arg.EndsWith(".vt"))
                    {
                        Console.Clear();
                        StreamReader fileReader = new StreamReader(arg);
                        String line;
                        line = fileReader.ReadLine();
                        line = line.Replace("\t","");
                        if  (line != null)
                        {
                            Parse(line,fileReader);
                            return;
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
                if (arg == "--s")
                {
                    vTSOS();
                    return;
                }
            }
        }
    }
}