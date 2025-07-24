namespace EncoderekATaborba
{
    public static class ReverseWordsEncoder
    {
        public static string EncodeToReverseWords(this string input)
        {
            if (string.IsNullOrEmpty(input))
                throw new ArgumentException("Input cannot be null or empty.", nameof(input));

            var words = input.Split(' ');
            var reversedSentence = "";
            foreach (var word in words)
            {
                // reverse the word and make it a readable string
                var reverse = new string(word.Reverse().ToArray());
                //var reverse = word.Reverse().ToArray().ToString();
                reversedSentence += reverse + " ";
            }

            return string.Join(" ", reversedSentence);
        }
    }
}
