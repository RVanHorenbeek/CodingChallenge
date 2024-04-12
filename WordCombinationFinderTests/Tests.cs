using WordCombinationFinder;

namespace WordCombinationFinderTests
{
    public class WordCombinationFinderTests
    {
        [Fact]
        public void FindCombinations_Should_Return_Unique_Combinations()
        {
            // Arrange
            var words = new List<string> { "foobar", "foo", "bar", "baz", "qux" }; // Sample words
            var maxLength = 6;
            var discoverer = new WordCombinationDiscoverer();

            // Act
            List<string> combinations = discoverer.FindCombinations(words, maxLength);

            // Assert
            Assert.All(combinations, combination =>
            {
                Assert.Single(combinations, c => c == combination);
            });
        }

        [Theory]
        [InlineData(6)]
        public void FindCombinations_Should_Return_Combinations_With_Length_Equal_To_MaxLength(int maxLength)
        {
            // Arrange
            var words = new List<string> { "foobar", "foo", "bar", "baz", "qux" }; // Sample words
            var discoverer = new WordCombinationDiscoverer();

            // Act
            List<string> combinations = discoverer.FindCombinations(words, maxLength);

            // Assert
            foreach (var combination in combinations)
            {
                string[] partsWithPlus = combination.Split('=');
                string[] parts = partsWithPlus[0].Split('+');
                string combinedWord = parts[0] + parts[1];
                Assert.Equal(maxLength, combinedWord.Length);
            }
        }
    }
}
