namespace WordCombinationFinder
{
    public class FileWordDataSource : IWordDataSource
    {
        private readonly string _filePath;

        public FileWordDataSource(string filePath)
        {
            _filePath = filePath;
        }

        public List<string> GetWords()
        {
            return File.ReadAllLines(_filePath).ToList();
        }
    }
}
