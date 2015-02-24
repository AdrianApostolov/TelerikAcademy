/*
Problem 7. Encode/decode

Write a program that encodes and decodes a string using given encryption key (cipher).
The key consists of a sequence of characters.
The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.
*/ 


using System;

namespace EncodeDecodeProblem
{
    class EncodeDecode
    {
        static void Main()
        {
            Console.Write("Please enter some string: ");
            string text = Console.ReadLine();
            Console.Write("Please, enter encryption key: ");
            string encryptionKey = Console.ReadLine();

            string encoded = string.Empty;

            for (int i = 0, j = 0; i < text.Length; i++, j++)
            {
                if (j >= encryptionKey.Length) j = 0;
                encoded += (char)(text[i] ^ encryptionKey[j]);
            }

            Console.WriteLine("Endocded = " + encoded);

            string decoded = string.Empty;
            
            for (int i = 0, j = 0; i < encoded.Length; i++, j++)
            {
                if (j >= encryptionKey.Length) j = 0;
                decoded += (char)(encoded[i] ^ encryptionKey[j]);
            }

            Console.WriteLine("Decoded = " + decoded);
           
        }
    }
}
