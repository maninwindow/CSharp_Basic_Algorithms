using System;
using System.Collections.Generic;

namespace DotNetPractices.SearchingAndSorting
{
    public class CheckCertainWordInText
    {
        public static List<int> GetWordsOccurrencesIndexes(string word, string sentence)
        {
            var result = new List<int>();
            int currentIndex = 0;
            while (currentIndex < sentence.Length)
            {
                //search word
                int currentWordIndex = 0;
                if (currentIndex + word.Length - 1 < sentence.Length)
                {
                    while (currentWordIndex < word.Length)
                    {
                        //check character by character
                        if (word[currentWordIndex] == sentence[currentIndex + currentWordIndex])
                            currentWordIndex++;
                        else
                            break;
                    }
                }
                if (currentWordIndex == word.Length)
                    result.Add(currentIndex);
                currentIndex++;
            }
            return result;
        }

        public static void ExtractList()
        {
            List<int> listOfIndex = GetWordsOccurrencesIndexes("This", "This is mine");
            foreach (int item in listOfIndex)
            {
                Console.WriteLine(item);
            }
        }
    }
}