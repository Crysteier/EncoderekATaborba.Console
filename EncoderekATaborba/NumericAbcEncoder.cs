namespace EncoderekATaborba
{
    public static class NumericAbcEncoder
    {
        private static readonly Random _random = new();

        public static string EncodeToNumericAbc(this string input)
        {
            if (string.IsNullOrEmpty(input))
                throw new ArgumentException("Input cannot be null or empty.", nameof(input));

            var resultString = "";
            foreach (var ch in input)
            {
                var result = Encode(ch);
                resultString += result + "\n";
            }

            return resultString;
        }

        private static string Encode(char letter)
        {
            if (letter == ' ')
                return "";

            char upper = char.ToUpper(letter);

            if (!Dictionaries.NumericAbc.NumericAbcMapper.TryGetValue(upper, out int value))
                throw new ArgumentException($"Character '{letter}' is not a valid letter.", nameof(letter));

            if (value > 1 && _random.Next(2) == 0)
            {
                int subtrahend = _random.Next(1, value);
                int minuend = value + subtrahend;
                //var result = $"{minuend} - {subtrahend} = {upper}";
                var result = $"{minuend} - {subtrahend} = ";
                return result;
            }
            else
            {
                int addend1 = _random.Next(1, value + 1);
                int addend2 = value - addend1;
                //var result = $"{addend1} + {addend2} = {upper}";
                var result = $"{addend1} + {addend2} = ";
                return result;
            }
        }
    }
}
