namespace WordCombinationFinder
{
    public class WordCombinationProcessor
    {
        private readonly IWordDataSource _wordDataSource;
        private readonly IWordCombinationDiscoverer _wordCombinationDiscoverer;

        public WordCombinationProcessor(IWordDataSource wordDataSource, IWordCombinationDiscoverer wordCombinationFinder)
        {
            _wordDataSource = wordDataSource;
            _wordCombinationDiscoverer = wordCombinationFinder;
        }

        public List<string> FindWordCombinations(int maxLength)
        {
            List<string> words = _wordDataSource.GetWords();
            return _wordCombinationDiscoverer.FindCombinations(words, maxLength);
        }
    }
}
