using System;
using System.Collections.Generic;

namespace ToHuman
{
    public abstract class Worded
    {
        static readonly Dictionary<int, int> parts = new()
        {
            { 1, 1 },
            { 2, 1 },
            { 3, 100 },
        };

        static readonly Dictionary<int, string> words = new()
        {
            { 0, "Zero " },
            { 1, "One " },
            { 2, "Two " },
            { 3, "Three " },
            { 4, "Four " },
            { 5, "Five " },
            { 6, "Six " },
            { 7, "Seven " },
            { 8, "Eight " },
            { 9, "Nine " },
            { 10, "Ten " },
            { 11, "Eleven " },
            { 12, "Twelve " },
            { 13, "Thirteen " },
            { 14, "Fourteen " },
            { 15, "Fifteen " },
            { 16, "Sixteen " },
            { 17, "Seventeen " },
            { 18, "Eighteen " },
            { 19, "Nineteen " },
            { 20, "Twenty " },
            { 100, "Hundred " },
        };

        public static string Lookup(int value)
        {
            return words.TryGetValue(value, out var rst)
                ? rst : throw new ArgumentNullException(nameof(value));
        }

        public static int Partition(int value)
        {
            return parts.TryGetValue(value, out var rst)
                ? rst : throw new ArgumentNullException(nameof(value));
        }
    }
}