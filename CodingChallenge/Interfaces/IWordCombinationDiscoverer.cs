namespace WordCombinationFinder
{
    public interface IWordCombinationDiscoverer
    {
        List<string> FindCombinations(List<string> words, int maxLength);
    }
}