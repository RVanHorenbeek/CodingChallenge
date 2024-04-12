namespace WordCombinationFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WordCombinationFinder console app started!\n\nDepending on how big the input file is, this might take a while...\n");

            // Setup
            // Get the directory containing the executable file
            string executableDir = AppDomain.CurrentDomain.BaseDirectory;

            // Construct the path to the Input.txt file
            string inputFilePath = Path.Combine(executableDir, @"..\..\..\..\Input.txt");

            // Check if the file exists
            if (!File.Exists(inputFilePath))
            {
                Console.WriteLine("Input file not found.");
                return;
            }

            IWordDataSource wordDataSource = new FileWordDataSource(inputFilePath);
            IWordCombinationDiscoverer wordCombinationDiscoverer = new WordCombinationDiscoverer();
            WordCombinationProcessor processor = new WordCombinationProcessor(wordDataSource, wordCombinationDiscoverer);

            // Usage
            int maxLength = 6;
            var combinations = processor.FindWordCombinations(maxLength);

            // Return found combinations
            foreach (var combination in combinations)
            {
                Console.WriteLine(combination);
            }

            Console.WriteLine("\nWordCombinationFinder console app ended!");
        }
    }
}