using System;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KupriyanovNM.Sprint1.Task6.V5.Lib
{
    public class DataService : ISprint1Task6V5
    {
        public string CheckSymmetricalWords(string value)
        {
            value = value.Replace("*", "");
            value = value.Replace("?", "");
            value = value.Replace("!", "");
            value = value.Replace(":", "");
            value = value.Replace(";", "");
            value = value.Replace(".", "");
            value = value.Replace(",", "");
            string[] words = value.Split(' ');
            string result = "";
            foreach (string word in words)
            {
                if (word == "")
                {
                    continue;
                }
                char[] letters = word.ToCharArray();
                Array.Reverse(letters);
                string reverseWord = new string(letters);
                if (word.ToLower() == reverseWord.ToLower())
                {
                    if (result != "")
                    {
                        result += " ";
                    }
                    result += word;
                }
            }
            return result;
        }
    }
}
