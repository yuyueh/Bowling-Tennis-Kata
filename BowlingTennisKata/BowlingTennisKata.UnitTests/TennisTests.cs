using NUnit.Framework;

namespace Tennis.UnitTests
{
    [TestFixture]
    public class TennisTests
    {
        private Tennis _target;

        [SetUp]
        public void SetUp()
        {
            _target = new Tennis();
        }

        [Test]
        public void LoveAll()
        {
            // Arrange
            var expected = "Love-All";

            // Act
            var result = _target.Score();

            // Assert
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void FifteenLove()
        {
            // Arrange
            var expected = "Fifteen-Love";

            // Act
            _target.GivenFirstPlayerScore(1);
            var result = _target.Score();

            // Assert
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void ThirtyLove()
        {
            // Arrange
            var expected = "Thirty-Love";

            // Act
            _target.GivenFirstPlayerScore(2);
            var result = _target.Score();

            // Assert
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void FortyLove()
        {
            // Arrange
            var expected = "Forty-Love";

            // Act
            _target.GivenFirstPlayerScore(3);
            var result = _target.Score();

            // Assert
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void LoveFifteen()
        {
            // Arrange
            var expected = "Love-Fifteen";

            // Act
            _target.GivenSecondPlayerScore(1);
            var result = _target.Score();

            // Assert
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void LoveThirty()
        {
            // Arrange
            var expected = "Love-Thirty";

            // Act
            _target.GivenSecondPlayerScore(2);
            var result = _target.Score();

            // Assert
            Assert.AreEqual(result, expected);
        }
    }
}
