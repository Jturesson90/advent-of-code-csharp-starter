using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpStarterPack.PuzzleInputs;
using CSharpStarterPack.Days;

namespace Tests
{
    [TestClass]
    public class Day01Tests
    {
        private readonly int day = 3;
        [TestMethod]
        public void Puzzle_A()
        {
            // Arrenge
            string expected = "";
            string input = PuzzleInput.GetInputAsText(day);

            // Act
            var actual = Day01.PuzzleA(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Puzzle_B()
        {
            // Arrenge
            // Act
            // Assert
            Assert.AreEqual(1, 1);
        }
    }
}
