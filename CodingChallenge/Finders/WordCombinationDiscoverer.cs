namespace WordCombinationFinder
{
    public class WordCombinationDiscoverer : IWordCombinationDiscoverer
    {
        public List<string> FindCombinations(List<string> words, int maxLength)
        {
            List<string> combinations = new List<string>();
            List<string> correctCombinations = new List<string>();
            HashSet<string> uniqueCombinations = new HashSet<string>();

            correctCombinations = words.Where(word => word.Length ==  maxLength).ToList();

            foreach (string word1 in words)
            {
                foreach (string word2 in words)
                {
                    if (word1 != word2 && word1.Length + word2.Length == maxLength)
                    {
                        string combinedWord = word1 + word2;
                        if (correctCombinations.Contains(combinedWord) && !uniqueCombinations.Contains(combinedWord))
                        {
                            combinations.Add($"{word1}+{word2}={combinedWord}");
                            uniqueCombinations.Add(combinedWord);
                        }
                    }
                }
            }

            return combinations;
        }
    }
}
