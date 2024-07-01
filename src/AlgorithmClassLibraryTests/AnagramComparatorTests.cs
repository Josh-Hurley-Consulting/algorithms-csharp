using AlgorithmClassLibrary;

namespace AlgorithmClassLibraryTests
{
    public class AnagramComparatorTests
    {
        [Fact]
        public void AreAnagrams_ShouldReturnTrue_WhenStringsAreAnagrams()
        {
            // Arrange
            string s1 = "listen";
            string s2 = "silent";

            // Act
            bool result = AnagramComparator.AreAnagrams(s1, s2);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void AreAnagrams_ShouldReturnFalse_WhenStringsAreNotAnagrams()
        {
            // Arrange
            string s1 = "hello";
            string s2 = "world";

            // Act
            bool result = AnagramComparator.AreAnagrams(s1, s2);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void AreAnagrams_ShouldReturnFalse_WhenStringsHaveDifferentLengths()
        {
            // Arrange
            string s1 = "listen";
            string s2 = "silentt";

            // Act
            bool result = AnagramComparator.AreAnagrams(s1, s2);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void AreAnagrams_ShouldReturnFalse_WhenStringsHaveDifferentCaseCharacters()
        {
            // Arrange
            string s1 = "listen";
            string s2 = "lisTen";

            // Act
            bool result = AnagramComparator.AreAnagrams(s1, s2);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void AreAnagrams_ShouldReturnFalse_WhenOneStringIsEmpty()
        {
            // Arrange
            string s1 = string.Empty;
            string s2 = "silentt";

            // Act
            bool result = AnagramComparator.AreAnagrams(s1, s2);

            // Assert
            Assert.False(result);
        }
    }
}