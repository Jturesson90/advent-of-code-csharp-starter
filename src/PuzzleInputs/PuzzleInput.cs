using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CSharpStarterPack.PuzzleInputs
{
    public static class PuzzleInput
    {
        public static string[] GetInputAsArray(int day) => File.ReadAllLines($"Inputs/Day{day}.txt");

        public static string GetInputAsText(int day) => string.Join("\n", (File.ReadAllLines($"Inputs/Day{day}.txt")));

        public static int[] GetInputAsIntArray(int day) => GetInputAsArray(day).Select(int.Parse).ToArray();
        public static int[] GetIntCodeInputAsArray(int day) => GetInputAsText(day).Split(',').Select(int.Parse).ToArray();
        public static long[] GetIntCodeInputAsArrayLong(int day) => GetInputAsText(day).Split(',').Select(long.Parse).ToArray();
        public static string[][] GetInputAsMultiArray(int day) => GetInputAsArray(day).Select((string row) => row.Split(',').ToArray()).ToArray();

        public static byte[] GetInputAsByteArray(int day) => File.ReadAllText($"Inputs/Day{day}.txt").Select(x => (byte)(x - '0')).ToArray();
        public static int[] GetInputSingleRowAsIntArray(int day)
        {
            var array = GetInputAsArray(day)[0];
            var chars = array.ToCharArray();
            var list = new List<int>();
            foreach (var c in chars)
            {
                list.Add(int.Parse(c.ToString()));
            }

            return list.ToArray();
        }

    }
}
