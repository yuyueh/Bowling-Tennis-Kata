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
            _target = new Tennis("Lin", "DZ");
        }

        [Test]
        public void Test_LoveAll()
        {
            // Arrange
            var expected = "Love-All";

            // Act
            var result = _target.Score();

            // Assert
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void Test_FifteenLove()
        {
            // Arrange
            var expected = "Fifteen-Love";

            // Act
            _target.SetFirstPlayerScore(1);
            var result = _target.Score();

            // Assert
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void Test_ThirtyLove()
        {
            // Arrange
            var expected = "Thirty-Love";

            // Act
            _target.SetFirstPlayerScore(2);
            var result = _target.Score();

            // Assert
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void Test_FortyLove()
        {
            // Arrange
            var expected = "Forty-Love";

            // Act
            _target.SetFirstPlayerScore(3);
            var result = _target.Score();

            // Assert
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void Test_LoveFifteen()
        {
            // Arrange
            var expected = "Love-Fifteen";

            // Act
            _target.SetSecondPlayerScore(1);
            var result = _target.Score();

            // Assert
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void Test_LoveThirty()
        {
            // Arrange
            var expected = "Love-Thirty";

            // Act
            _target.SetSecondPlayerScore(2);
            var result = _target.Score();

            // Assert
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void Test_LoveForty()
        {
            // Arrange
            var expected = "Love-Forty";

            // Act
            _target.SetSecondPlayerScore(3);
            var result = _target.Score();

            // Assert
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void Test_FifteenAll()
        {
            // Arrange
            var expected = "Fifteen-All";

            // Act
            _target.SetFirstPlayerScore(1);
            _target.SetSecondPlayerScore(1);
            var result = _target.Score();

            // Assert
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void Test_ThirtyAll()
        {
            // Arrange
            var expected = "Thirty-All";

            // Act
            _target.SetFirstPlayerScore(2);
            _target.SetSecondPlayerScore(2);
            var result = _target.Score();

            // Assert
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void Test_FortyDeuce()
        {
            // Arrange
            var expected = "Deuce";

            // Act
            _target.SetFirstPlayerScore(3);
            _target.SetSecondPlayerScore(3);
            var result = _target.Score();

            // Assert
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void Test_FullScoreDeuce()
        {
            // Arrange
            var expected = "Deuce";

            // Act
            _target.SetFirstPlayerScore(4);
            _target.SetSecondPlayerScore(4);
            var result = _target.Score();

            // Assert
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void Test_LinAdv()
        {
            // Arrange
            var expected = "Lin Adv";

            // Act
            _target.SetFirstPlayerScore(4);
            _target.SetSecondPlayerScore(3);
            var result = _target.Score();

            // Assert
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void Test_LinWin()
        {
            // Arrange
            var expected = "Lin Win";

            // Act
            _target.SetFirstPlayerScore(5);
            _target.SetSecondPlayerScore(3);
            var result = _target.Score();

            // Assert
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void Test_DZAdv()
        {
            // Arrange
            var expected = "DZ Adv";

            // Act
            _target.SetFirstPlayerScore(3);
            _target.SetSecondPlayerScore(4);
            var result = _target.Score();

            // Assert
            Assert.AreEqual(result, expected);
        }
    }
}
