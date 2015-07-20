namespace RefactorExams
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Text;

    public class MathProblem
    {
        public static void Main()
        {
            string readInput = Console.ReadLine();
            ValidateInput(readInput);

            string[] collectionOfWords = readInput.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Initialize collection of string to keep each word
            var words = new List<string>();

            for (int i = 0; i < collectionOfWords.Length; i++)
            {
                words.Add(collectionOfWords[i]);
            }

            var collectionOfNumbers = new List<int>();
            BigInteger sum = 0;

            for (int i = 0; i < words.Count; i++)
            {
                var currentWord = words[i];
                foreach (var letter in currentWord)
                {
                    if (letter >= 97 || letter <= 119)
                    {
                        collectionOfNumbers.Add(letter - 'a');
                    }
                }

                for (int j = 0; j < collectionOfNumbers.Count; j++)
                {
                    // Convert each number to system with base 19
                    sum += (ulong)collectionOfNumbers[collectionOfNumbers.Count - 1 - j] * (ulong)Math.Pow(19, j);
                }

                collectionOfNumbers.Clear();
            }

            var text = new StringBuilder();

            ulong divisionResult = 0;
            ulong significand = (ulong)sum;
            while (significand > 0)
            {
                divisionResult = significand / 19;
                var resultFromDivision = significand % 19;

                switch (resultFromDivision)
                {
                    case 0:
                        text.Append("a");
                        break;
                    case 1:
                        text.Append("b");
                        break;
                    case 2:
                        text.Append("c");
                        break;
                    case 3:
                        text.Append("d");
                        break;
                    case 4:
                        text.Append("e");
                        break;
                    case 5:
                        text.Append("f");
                        break;
                    case 6:
                        text.Append("g");
                        break;
                    case 7:
                        text.Append("h");
                        break;
                    case 8:
                        text.Append("i");
                        break;
                    case 9:
                        text.Append("j");
                        break;
                    case 10:
                        text.Append("k");
                        break;
                    case 11:
                        text.Append("l");
                        break;
                    case 12:
                        text.Append("m");
                        break;
                    case 13:
                        text.Append("n");
                        break;
                    case 14:
                        text.Append("o");
                        break;
                    case 15:
                        text.Append("p");
                        break;
                    case 16:
                        text.Append("q");
                        break;
                    case 17:
                        text.Append("r");
                        break;
                    case 18:
                        text.Append("s");
                        break;
                }

                significand = divisionResult;
            }

            var textResultAfterTransformation = new StringBuilder();

            for (int i = 0; i < text.ToString().Length; i++)
            {
                int index = text.ToString().Length - 1 - i;
                textResultAfterTransformation.Append(text.ToString()[index]);
            }

            Console.WriteLine("{0} = {1}", textResultAfterTransformation.ToString(), sum);
        }

        private static void ValidateInput(string input)
        {
            if (input == string.Empty)
            {
                throw new ArgumentException("Input cannot be an empty string");
            }
        }
    }
}
