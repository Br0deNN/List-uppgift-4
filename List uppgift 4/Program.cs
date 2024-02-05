using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string[] myString = { "hej", "nej", "ja" };       
        Console.WriteLine(FinnsTecknetIAllaSträngar(myString,'e')); //e blir false och h blir true


    }

    static bool FinnsTecknetIAllaSträngar(string[] myString, char myChar)
    {
        bool finnsIalla = true;

        for (int i = 0; i < myString.Length; i++)
        {
            bool xstring = false;
            for (int j = 0; j < myString[i].Length; j++)
            {
                if (myString[i][j] == myChar)
                {
                    xstring = true;
                    break;
                }
            }

            if (xstring == false)
            {
                finnsIalla = false;
                break;
            }
        }
        return finnsIalla;

        
    }
}