using Kata.Prod;
using Kata.Prod.Moves;
using NUnit.Framework;

namespace Kata
{
    [TestFixture]
    public class GameEngineTests
    {
        [Test]
        public void Play_WhenScissors_ShouldLooseToRock()
        {
            // Arrange
            var expected = GameResult.Loose;
            var player = GameMove.Scissors;
            var opponent = GameMove.Rock;
            var game = new GameEngine();
            // Act
            var actual = game.Play(player, opponent);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Play_WhenScissors_ShouldBeatPaper()
        {
            // Arrange
            var expected = GameResult.Win;
            var player = GameMove.Scissors;
            var opponent = GameMove.Paper;
            var game = new GameEngine();
            // Act
            var actual = game.Play(player, opponent);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Play_WhenScissors_ShouldDrawScissors()
        {
            // Arrange
            var expected = GameResult.Draw;
            var player = GameMove.Scissors;
            var opponent = GameMove.Scissors;
            var game = new GameEngine();
            // Act
            var actual = game.Play(player, opponent);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Play_WhenPaper_ShouldLooseToScissors()
        {
            // Arrange
            var expected = GameResult.Loose;
            var player = GameMove.Paper;
            var opponent = GameMove.Scissors;
            var game = new GameEngine();
            // Act
            var actual = game.Play(player, opponent);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Play_WhenPaper_ShouldBeatRock()
        {
            // Arrange
            var expected = GameResult.Win;
            var player = GameMove.Paper;
            var opponent = GameMove.Rock;
            var game = new GameEngine();
            // Act
            var actual = game.Play(player, opponent);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Play_WhenPaper_ShouldDrawPaper()
        {
            // Arrange
            var expected = GameResult.Draw;
            var player = GameMove.Paper;
            var opponent = GameMove.Paper;
            var game = new GameEngine();
            // Act
            var actual = game.Play(player, opponent);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Play_WhenRock_ShouldLooseToPaper()
        {
            // Arrange
            var expected = GameResult.Loose;
            var player = GameMove.Rock;
            var opponent = GameMove.Paper;
            var game = new GameEngine();
            // Act
            var actual = game.Play(player, opponent);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Play_WhenRock_ShouldBeatScissors()
        {
            // Arrange
            var expected = GameResult.Win;
            var player = GameMove.Rock;
            var opponent = GameMove.Scissors;
            var game = new GameEngine();
            // Act
            var actual = game.Play(player, opponent);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Play_WhenRock_ShouldDrawRock()
        {
            // Arrange
            var expected = GameResult.Draw;
            var player = GameMove.Rock;
            var opponent = GameMove.Rock;
            var game = new GameEngine();
            // Act
            var actual = game.Play(player, opponent);
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
