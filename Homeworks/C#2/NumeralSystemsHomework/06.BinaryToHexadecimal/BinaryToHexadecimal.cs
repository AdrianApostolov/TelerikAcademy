/*
Problem 6. binary to hexadecimal

Write a program to convert binary numbers to hexadecimal numbers (directly).
*/


using System;

class BinaryToHexadecimal
{
    static string BinaryToHexadecimalNumber(string binaryNumber)
    {
        int digits = binaryNumber.Length % 4;
        switch (digits)
        {
            case 1:
                binaryNumber = "000" + binaryNumber;
                break;
            case 2:
                binaryNumber = "00" + binaryNumber;
                break;
            case 3:
                binaryNumber = "0" + binaryNumber;
                break;
        }
        
        Char[] hexadecimal = binaryNumber.ToCharArray();
        string result = "";
        string[] hecadecimalNumber = new string[binaryNumber.Length / 4];
       
        for (int i = 0; i < hecadecimalNumber.Length; i++)
        {
            for (int j = i * 4; j < (i * 4) + 4; j++)
            {

                hecadecimalNumber[i] += hexadecimal[j].ToString();

            }

        }
            
        for (int i = 0; i < hecadecimalNumber.Length; i++)
        {
            switch (hecadecimalNumber[i])
            {
                case "0000":
                    result += "0";
                    break;
                case "0001":
                    result += "1";
                    break;
                case "0010":
                    result += "2";
                    break;
                case "0011":
                    result += "3";
                    break;
                case "0100":
                    result += "4";
                    break;
                case "0101":
                    result += "5";
                    break;
                case "0110":
                    result += "6";
                    break;
                case "0111":
                    result += "7";
                    break;
                case "1000":
                    result += "8";
                    break;
                case "1001":
                    result += "9";
                    break;
                case "1010":
                    result += "A";
                    break;
                case "1011":
                    result += "B";
                    break;
                case "1100":
                    result += "C";
                    break;
                case "1101":
                    result += "D";
                    break;
                case "1110":
                    result += "E";
                    break;
                case "1111":
                    result += "F";
                    break;
            }
        }
        return result;
    }

    static void Main()
    {
        Console.Write("Please, enter binary number: ");
        string hexadecimal = Console.ReadLine();

        string result = BinaryToHexadecimalNumber(hexadecimal);
        Console.WriteLine("Hexadecimal representation is: " + result);
    }
}

