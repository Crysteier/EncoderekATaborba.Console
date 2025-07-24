namespace EncoderekATaborba
{
    public static class ROT13
    {
        public static string Rot13(this string input)
        {
            return new string(input.Select(c =>
            {
                if (c >= 'a' && c <= 'z')
                    return (char)('a' + (c - 'a' + 13) % 26);
                else if (c >= 'A' && c <= 'Z')
                    return (char)('A' + (c - 'A' + 13) % 26);
                else
                    return c;
            }).ToArray());
        }
    }
}
