using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpStarterPack.PuzzleInputs;
using CSharpStarterPack.Days;

namespace Tests
{
    // Uncomment to enable testing for this file
    // [TestClass]
    public class Day16Tests
    {
        private readonly int day = 16;
        [TestMethod]
        public void Puzzle_A()
        {
            // Arrenge
            string expected = "";
            string input = PuzzleInput.GetInputAsText(day);

            // Act
            var actual = Day16.PuzzleA();

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
