using System;

class DeclareVariables
{
    static void Main(string[] args)
    {
        int myInt = 254;
        string myHex = myInt.ToString("X");
        int myNewInt = Convert.ToInt32(myHex, 16); 
    }
}


