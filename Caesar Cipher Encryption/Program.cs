using System;

namespace CaesarCipher
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int indexNr;
            Console.WriteLine("tell me your secret Message:");
            string secretMsg = Console.ReadLine().ToLower();
            char[] secretMessage = secretMsg.ToCharArray();

            Console.WriteLine("1 - Encryption");
            Console.WriteLine("2 - Decryption");
            string auswahl = Console.ReadLine();

            switch(auswahl)
            {
                case "1":
                    Console.WriteLine("What is the encryption factor?");
                    indexNr = Convert.ToInt32(Console.ReadLine());
                       Encrypt(secretMessage, indexNr);
                    break;

                case "2":
                    Console.WriteLine("What is the dencryption factor?");
                    indexNr = Convert.ToInt32(Console.ReadLine());
                    Decrypt(secretMessage, indexNr);
                    break;
            }


            
        }
        public static void Encrypt(char[] secretMessage, int indexNr)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            

            char[] encryptedMessage = new char[secretMessage.Length];

            for (int i = 0; i < secretMessage.Length; i++)
            {
                char letter = secretMessage[i];
                int index1 = Array.IndexOf(alphabet, letter);
                int letterPosition = (index1 + indexNr) % alphabet.Length;
                letter = alphabet[letterPosition];
                encryptedMessage[i] = letter;


            }
            string encryptedMsg = String.Join("", encryptedMessage);
            Console.WriteLine(encryptedMsg);
        }
        public static void Decrypt(char[] secretMessage, int indexNr)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

           

            char[] decryptedMessage = new char[secretMessage.Length];
            
            for(int i = 0; i < secretMessage.Length; i++)
            {
                char letter = secretMessage[i];
                int index1 = Array.IndexOf(alphabet, letter);
                int letterPosition = (index1 - indexNr) % alphabet.Length;
                letter = alphabet[letterPosition];
                decryptedMessage[i] = letter;
            }
            string decryptedMsg = String.Join("", decryptedMessage);
            Console.WriteLine(decryptedMsg);
        }
    }
}
/*
The app doesnt work with sentences.


The app doesn’t work with symbols, like ! or ?. 
Skip any symbols in your loop so that they are not encrypted.

-------------------------------------------------------------------------------------------------------
Rewrite the loop as a method Encrypt() which takes 
a character array and key and returns an encrypted character array . 


Write a Decrypt() method which takes a character array and key 
and returns a decrypted character array.

char[] secretMessage = {'h', 'e', 'l', 'l', 'o'};
 
// encrypted should equal  {'k', 'h', 'o', 'o', 'r'}
string encrypted = Encrypt(secretMessage, 3);
 
// decrypted should equal {'h', 'e', 'l', 'l', 'o'}
string decrypted = Decrypt(encrypted, 3);
 
 */