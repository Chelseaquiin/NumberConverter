using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCracker
{
    public class Decryption
    {
        private char[] alphabets = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        private char[] keys = { '£', '*', '%', '&', '>', '<', '!', ')', '"', '(', '@', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o' };

        private Dictionary<char, char> decryptionKeys = new Dictionary<char, char>();
        public char[] Alphabets { get; set; }
        public char[] Keys { get; set; }

        public char DecryptionKeys { get; set; }

        public Decryption(char[] alphabets, char[] keys)
        {
            Alphabets = alphabets;
            Keys = keys;
        }


        public string Decrypt(string word)
        {


            string decryptedWord = word;

            for (int i = 0; i < word.Length; i++)
            {
                char currentChar = word.ElementAt(i);
                char replacementChar = (decryptionKeys.Keys.Contains(currentChar) != null) ? decryptedWord[i] : currentChar;

                decryptedWord = decryptedWord.Replace(currentChar, replacementChar);
            }

            return decryptedWord;
        }

        public void init()
        {
            for (int i = 0; i < 26; i++)
            {
                decryptionKeys.Add(Alphabets[i], Keys[i]);
            }
        }
    }
}

