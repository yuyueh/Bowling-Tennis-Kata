using NUnit.Framework;

namespace Tennis.UnitTests
{
    [TestFixture]
    public class TennisTests
    {
        [Test]
        public void LoveAll()
        {
            // Arrange
            var target = new Tennis();
            var expected = "Love-All";

            // Act
            var result = target.Score();

            // Assert
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void FifteenLove()
        {
            // Arrange
            var target = new Tennis();
            var expected = "Fifteen-Love";

            // Act
            target.GivenFirstPlayerScore(1);
            var result = target.Score();

            // Assert
            Assert.AreEqual(result, expected);
        }
    }
}
