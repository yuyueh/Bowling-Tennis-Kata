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
            _target.GivenFirstPlayerScore(1);
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
            _target.GivenFirstPlayerScore(2);
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
            _target.GivenFirstPlayerScore(3);
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
            _target.GivenSecondPlayerScore(1);
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
            _target.GivenSecondPlayerScore(2);
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
            _target.GivenSecondPlayerScore(3);
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
            _target.GivenFirstPlayerScore(1);
            _target.GivenSecondPlayerScore(1);
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
            _target.GivenFirstPlayerScore(2);
            _target.GivenSecondPlayerScore(2);
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
            _target.GivenFirstPlayerScore(3);
            _target.GivenSecondPlayerScore(3);
            var result = _target.Score();

            // Assert
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void Test_NormalDeuce()
        {
            // Arrange
            var expected = "Deuce";

            // Act
            _target.GivenFirstPlayerScore(4);
            _target.GivenSecondPlayerScore(4);
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
            _target.GivenFirstPlayerScore(4);
            _target.GivenSecondPlayerScore(3);
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
            _target.GivenFirstPlayerScore(5);
            _target.GivenSecondPlayerScore(3);
            var result = _target.Score();

            // Assert
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void Test_LinPerfectWin()
        {
            // Arrange
            var expected = "Lin Win";

            // Act
            _target.GivenFirstPlayerScore(4);
            _target.GivenSecondPlayerScore(0);
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
            _target.GivenFirstPlayerScore(3);
            _target.GivenSecondPlayerScore(4);
            var result = _target.Score();

            // Assert
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void Test_DZWin()
        {
            // Arrange
            var expected = "DZ Win";

            // Act
            _target.GivenFirstPlayerScore(3);
            _target.GivenSecondPlayerScore(5);
            var result = _target.Score();

            // Assert
            Assert.AreEqual(result, expected);
        }
    }
}
