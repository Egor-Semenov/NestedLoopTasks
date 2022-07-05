using System;

namespace Task19
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceWord = "allergy";
            string[] candidates = new[] { "gallery", "ballerina", "regally", "clergy", "largely", "leading" };

            string[] anagrams = FindAnagrams(sourceWord, candidates);

            foreach (var anagram in anagrams)
            {
                Console.WriteLine(anagram);
            }
        }

        //<summary>
        //A word and a list of possible anagrams are given.
        //Implement method, that selects the correct subset from the list of possible anagrams.
        //Example:
        //"master", { "stream", "pigeon", "maters" }, ExpectedResult = { "stream", "maters" })
        //</summary>
        static string[] FindAnagrams(string sourceWord, string[] candidates)
        {
            string[] anagrams = Array.Empty<string>();

            int countOfAnagrams = 0;

            string copySourceWord;
            string copyCandidate;

            int counter;

            for (int index = 0; index < candidates.Length; index++)
            {
                if (sourceWord.Length != candidates[index].Length)
                {
                    continue;
                }

                counter = 0;

                copySourceWord = sourceWord.ToUpperInvariant();
                copyCandidate = candidates[index].ToUpperInvariant();

                if (copySourceWord == copyCandidate)
                {
                    continue;
                }

                for (int sourceCharIndex = 0; sourceCharIndex < copySourceWord.Length; sourceCharIndex++)
                {
                    for (int candidateCharIndex = 0; candidateCharIndex < copyCandidate.Length; candidateCharIndex++)
                    {
                        if (copySourceWord[sourceCharIndex] == copyCandidate[candidateCharIndex])
                        {
                            counter++;
                            copyCandidate = copyCandidate.Remove(candidateCharIndex, 1);
                            break;
                        }
                    }
                }

                if (counter == copySourceWord.Length)
                {
                    Array.Resize(ref anagrams, anagrams.Length + 1);
                    anagrams[countOfAnagrams] = candidates[index];
                    countOfAnagrams++;
                }
            }

            return anagrams;
        }
    }
}
