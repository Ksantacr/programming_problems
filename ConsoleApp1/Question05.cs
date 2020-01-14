using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Question05
    {
        public string decrypt(string key, string message)
        {
            if (string.IsNullOrEmpty(message))
                return string.Empty;

            if (string.IsNullOrEmpty(key))
                key = "DCJ";

            List<char> list = new List<char>();
            List<char> response = new List<char>();

            for (int i = 0; i < message.Length; i++)
            {
                list.Add(message[i]);

                if (isKeyPresent(list, key))
                {
                    if (i < message.Length -1 && isVowel(message[i+1].ToString()))
                    {
                        list = new List<char>();
                    }
                    else
                    {
                        response.Add(list[0]);
                        list.RemoveAt(0);
                    }
                }
                else if (key.Length == list.Count)
                {
                    response.Add(list[0]);
                    list.RemoveAt(0);
                }
            }
            response.AddRange(list);
            return string.Join("", response);

        }

        private bool isKeyPresent(List<char> list, string key)
        {
            if (list.Count < key.Length)
            {
                return false;
            }
            for (int i = 0; i < key.Length; i++)
            {
                if (list[i] != key[i])
                {
                    return false;
                }
            }

            return true;
        }

        private bool isVowel(string letter)
        {
            string vowels = "aeiouAEIOU";
            return vowels.IndexOf(letter, StringComparison.Ordinal) >= 0;
        }
    }
}
