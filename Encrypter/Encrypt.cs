using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encrypter
{
    internal class Encrypt
    {
        public static string Encipher(string userInput)
        {
            List<string> alphabet = new List<string> { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "Æ", "Ø", "Å", " " };

            List<string> originalInput = new List<string>();

            for (int i = 0; i < userInput.Length; i++)
            {
                originalInput.Add(userInput[i].ToString().ToUpper());
            }

            int getNewInputCharPosition = 0;
            List<string> encrypt = new List<string>();
            for (int i = 0; i < originalInput.Count; i++)
            {
                int getOriginalInputCharPosition = alphabet.IndexOf(originalInput[i]);


                if (getOriginalInputCharPosition != alphabet.Count)
                {
                    getNewInputCharPosition = getOriginalInputCharPosition + 1;
                }

                encrypt.Add(alphabet[getNewInputCharPosition]);
            }

            string result = "";
            for (int i = 0; i < encrypt.Count; i++)
            {
               result += encrypt[i];
            }

            return result;

        }

        public static string Decipher(string userInput)
        {
            List<string> alphabet = new List<string> { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "Æ", "Ø", "Å", " " };

            List<string> originalInput = new List<string>();

            for (int i = 0; i < userInput.Length; i++)
            {
                originalInput.Add(userInput[i].ToString().ToUpper());
            }

            int getNewInputCharPosition = 0;
            List<string> encrypt = new List<string>();
            for (int i = 0; i < originalInput.Count; i++)
            {
                int getOriginalInputCharPosition = alphabet.IndexOf(originalInput[i]);


                if (getOriginalInputCharPosition != alphabet.Count)
                {
                    getNewInputCharPosition = getOriginalInputCharPosition - 1;
                }

                encrypt.Add(alphabet[getNewInputCharPosition]);
            }

            string result = "";
            for (int i = 0; i < encrypt.Count; i++)
            {
                result += encrypt[i];
            }

            return result;

        }
    }
}