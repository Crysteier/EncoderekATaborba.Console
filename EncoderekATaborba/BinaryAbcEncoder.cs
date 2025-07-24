using System;
using System.Text;
using EncoderekATaborba.Dictionaries;

namespace EncoderekATaborba
{
    public static class BinaryAbcEncoder
    {
        public static string EncodeToBinaryAbc(this string input)
        {
            if (string.IsNullOrEmpty(input))
                throw new ArgumentException("Input cannot be null or empty.", nameof(input));

            var encodedBuilder = new StringBuilder();

            foreach (var character in input.ToUpper())
            {
                if (BinaryAbc.BinaryMapping.TryGetValue(character, out var binaryValue))
                {
                    encodedBuilder.Append(binaryValue);
                }
                else
                {
                    throw new InvalidOperationException($"Character '{character}' is not defined in the BinaryAbc dictionary.");
                }
            }

            var encodedString = encodedBuilder.ToString();
            var formattedBuilder = new StringBuilder();

            for (int i = 0; i < encodedString.Length; i += 5)
            {
                formattedBuilder.Append(encodedString.Substring(i, Math.Min(5, encodedString.Length - i)));
                formattedBuilder.Append(' ');
            }

            return formattedBuilder.ToString();
        }
    }
}
