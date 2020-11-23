using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpStarterPack.PuzzleInputs;

namespace Tests
{
    [TestClass]
    public class Day01Tests
    {
        [TestMethod]
        public void Day1_Puzzle_A()
        {
            // Assign
            string expected = "hej";
            // Act
            var actual = PuzzleInput.GetInputAsText(1);
            // Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Day1_Puzzle_B()
        {
            // Assign
            // Act
            // Assert
            Assert.AreEqual(1, 1);
        }
    }
}
