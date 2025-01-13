using System;
class Ciphercomp
{
    public void Encryption(string ptxt)
    {
        Console.WriteLine("Enter the key");
        string key = Console.ReadLine(), str = "", newptxt = ptxt, extend="";
        string[] symbols = { " ", ".", "?", "/", "|", ",", "'", "\\", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "+", "-", "*", "_", "&", "\"", "^", "@", "!", "@", "#", "$", "%", "(", ")", ";", ":", "<", ">", "=", "~", "[", "]", "{", "}", "`", "+" };
        char mx;
        foreach (string symbol in symbols)
        {
            newptxt = newptxt.Replace(symbol, "");
        }
        
        try {
            while (newptxt.Length > extend.Length)
            {
                extend = extend + key;
            }
            extend = extend.ToLower();
        }
        catch { Console.WriteLine("The key could not be generated"); }
        try
        {
            for (int i = 0; i < newptxt.Length; i++)
            {
                if (char.IsLetter(newptxt[i]))
                {
                    if (char.IsLower(newptxt[i]))
                    {
                        int lg = newptxt[i] + extend[i];
                        if (lg <= 219)
                        { 
                            mx = (char)(lg - 97);
                            str += mx;
                        }
                        else
                        { 
                            mx = (char)(lg - 123);
                            str += mx;
                        }
                    }
                    else
                    {
                        int ug = newptxt[i] + extend[i];
                        if (ug <= 187)
                        {
                            mx = (char)(ug - 97);
                            str += mx;
                        }
                        else
                        {
                            mx = (char)(ug - 123);
                            str += mx;
                        }
                    }
                }
                else { str += newptxt[i]; }
            }
            string ws = newptxt;
            for (int i = 0; i < ptxt.Length; i++)
            {
                foreach (string symbol in symbols)
                {
                    if (char.ToString(ptxt[i]) == symbol)
                    {
                        str = str.Insert(i, symbol);
                    }
                }
            }
            Console.WriteLine("The encrypted statement is: " + str);
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
        }
        catch { Console.WriteLine("An error occured during the encryption process"); }
    }
    public void Decryption(string ptxt)
    {
        Console.WriteLine("Enter the key");
        string key = Console.ReadLine(), str = "", newptxt = ptxt, extend = "";
        string[] symbols = { " ", ".", "?", "/", "|", ",", "'", "\\", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "+", "-", "*", "_", "&", "\"", "^", "@", "!", "@", "#", "$", "%", "(", ")", ";", ":", "<", ">", "=", "~", "[", "]", "{", "}", "`", "+" };
        char mx;
        foreach (string symbol in symbols)
        {
            newptxt = newptxt.Replace(symbol, "");
        }
        try
        {
            while (newptxt.Length > extend.Length)
            {
                extend = extend + key;
            }
            extend = extend.ToLower();
        }
        catch { Console.WriteLine("The key could not be generated"); }
        try
        {
            for (int i = 0; i < newptxt.Length; i++)
            {
                if (char.IsLetter(newptxt[i]))
                {
                    if (char.IsLower(newptxt[i]))
                    {
                        int lg = newptxt[i] - extend[i];
                        if (lg >= 0)
                        {
                            mx = (char)(lg + 97);
                            str += mx;
                        }
                        else
                        {
                            mx = (char)(lg + 123);
                            str += mx;
                        }
                    }
                    else
                    {
                        int ug = newptxt[i] - extend[i];
                        if (ug >= -32)
                        {
                            mx = (char)(ug + 97);
                            str += mx;
                        }
                        else
                        {
                            mx = (char)(ug + 123);
                            str += mx;
                        }
                    }
                }
                else { str += newptxt[i]; }
            }
            string ws = newptxt;
            for (int i = 0; i < ptxt.Length; i++)
            {
                foreach (string symbol in symbols)
                {
                    if (char.ToString(ptxt[i]) == symbol)
                    {
                        str = str.Insert(i, symbol);
                    }
                }
            }
            Console.WriteLine("The decrypted statement is: " + str);
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
        }
        catch { Console.WriteLine("An error occured during the decrypted process"); }
    }
}
class MainProg
{
    public static void Main()
    {
        Console.WriteLine("This is a vignere cipher program");
        Console.WriteLine(@"The commands are
                             1. /e: Encryption
                             2. /d: Decryption
                             2. Empty space: Exit program");
        string enc = "/e", br = "", dec = "/d";
        Ciphercomp comp = new Ciphercomp();
        for(; ;) {
            Console.WriteLine("Enter the command");
            string cmd = Console.ReadLine();
            if (cmd.Trim() == enc) 
            {
                for(; ; ) 
                {
                    Console.WriteLine("Enter the string to encrypt (or empty space to exit)");
                    string plain = Console.ReadLine();
                    if (plain == br) { break; }
                    else { comp.Encryption(plain); }
                }
            }
            else if (cmd.Trim() == dec) 
            {
                for (; ; ) 
                {
                    Console.WriteLine("Enter the string to decrypt (or empty space to exit)");
                    string plain = Console.ReadLine();
                    if (plain == br) { break; }
                    else { comp.Decryption(plain); }
                }
            }
            else if (cmd.Trim() == br) { break;}
            else { continue; }
        }
    }
}