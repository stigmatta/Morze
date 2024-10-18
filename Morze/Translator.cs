using System;

namespace Morze
{
    internal class Translator
    {
        static Dictionary<char, string> morseCodeDict = new Dictionary<char, string>
        {
            {'A', ".-"},
            {'B', "-..."},
            {'C', "-.-."},
            {'D', "-.."},
            {'E', "."},
            {'F', "..-."},
            {'G', "--."},
            {'H', "...."},
            {'I', ".."},
            {'J', ".---"},
            {'K', "-.-"},
            {'L', ".-.."},
            {'M', "--"},
            {'N', "-."},
            {'O', "---"},
            {'P', ".--."},
            {'Q', "--.-"},
            {'R', ".-."},
            {'S', "..."},
            {'T', "-"},
            {'U', "..-"},
            {'V', "...-"},
            {'W', ".--"},
            {'X', "-..-"},
            {'Y', "-.--"},
            {'Z', "--.."},
            {'0', "-----"},
            {'1', ".----"},
            {'2', "..---"},
            {'3', "...--"},
            {'4', "....-"},
            {'5', "....."},
            {'6', "-...."},
            {'7', "--..."},
            {'8', "---.."},
            {'9', "----."}
        };

        static Dictionary<string, char> morseToCharDict = new Dictionary<string, char>();

        static Translator()
        {
            foreach (var pair in morseCodeDict)
                morseToCharDict[pair.Value] = pair.Key;
        }

        public string ToMorze(string message)
        {
            string newMes = "";
            string tmpMes = message.ToUpper();
            for (int i = 0; i < tmpMes.Length; i++)
            {
                if (morseCodeDict.ContainsKey(tmpMes[i]))
                {
                    newMes += morseCodeDict[tmpMes[i]] + " ";
                }
            }
            return newMes.Trim();
        }

        public string ToNormal(string message)
        {
            string newMes = "";

            string[] letters = message.Split(" ");

            for(int i = 0; i < letters.Length; i++)
                newMes += morseToCharDict[letters[i]];

            return newMes;
        }
    }
}
