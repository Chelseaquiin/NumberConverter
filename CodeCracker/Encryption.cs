using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCracker
{
    public class Encryption
    {
        private char[] alphabets = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        private char[] keys = { '£', '*', '%', '&', '>', '<', '!', ')', '"', '(', '@', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o' };

        private Dictionary<char, char> encryptionKeys = new Dictionary<char, char>();
        public char[] Alphabets { get; set; }
        public char[] Keys { get; set; }

        public char EncryptionKeys { get; set; }

        public Encryption(char[] alphabets, char[] keys)
        {
            Alphabets = alphabets;
            Keys = keys;
        }


        public string Encrypt(string word)
        {


            string encryptedWord = word;

            for (int i = 0; i < word.Length; i++)
            {
                char currentChar = word.ElementAt(i);
                char replacementChar = (encryptionKeys.Keys.Contains(currentChar) != null) ? encryptedWord[i] : currentChar;

                encryptedWord = encryptedWord.Replace(currentChar, replacementChar);
            }

            return encryptedWord;
        }

        public void init()
        {
            for (int i = 0; i < 26; i++)
            {
                encryptionKeys.Add(Alphabets[i], Keys[i]);
            }
        }
    }
}
