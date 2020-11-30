using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpStarterPack.PuzzleInputs;
using CSharpStarterPack.Days;

namespace Tests
{
    //[TestClass]
    public class Day13Tests
    {
        private readonly int day = 13;
        [TestMethod]
        public void Puzzle_A()
        {
            // Assign
            string expected = "";
            string input = PuzzleInput.GetInputAsText(day);

            // Act
            var actual = Day13.PuzzleA();

            // Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Puzzle_B()
        {
            // Assign
            // Act
            // Assert
            Assert.AreEqual(1, 1);
        }
    }
}
