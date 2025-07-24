using System.Text;

namespace EncoderekATaborba
{
    public static class MorseAbcEncoder
    {
        public static string EncodeToMorseAbc(this string input)
        {
            if (string.IsNullOrEmpty(input))
                throw new ArgumentException("Input cannot be null or empty.", nameof(input));
            var resultString = new StringBuilder();
            foreach (var ch in input.ToUpper())
            {
                if (Dictionaries.MorseAbc._textToMorse.TryGetValue(ch, out string morseCode))
                {
                    resultString.Append(morseCode + "  ");
                }
                else
                {
                    throw new ArgumentException($"Character '{ch}' is not a valid letter for Morse encoding.", nameof(input));
                }
            }
            return resultString.ToString().Trim();
        }
    }
}
