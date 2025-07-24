using EncoderekATaborba;

var sentence = "megtalaljatok az elso nyomot azon a helyen ahol az ut kette agazik";
Console.WriteLine("Sentence to be encrypted: " + sentence);
Console.WriteLine("===========================");

var rot13Encoded = sentence.Rot13();
Console.WriteLine("rot13: " + rot13Encoded);
Console.WriteLine();

var reverseEncoded = sentence.EncodeToReverseWords();
Console.WriteLine("reverse: "+ reverseEncoded);
Console.WriteLine();

var binaryAbcEncoded = sentence.EncodeToBinaryAbc();
Console.WriteLine("BinaryAbc: " + binaryAbcEncoded);
Console.WriteLine();

var numericEncoded = sentence.EncodeToNumericAbc();
Console.WriteLine("Numeric abc: \n" + numericEncoded);
Console.WriteLine();

var morseAbcEncoded = sentence.EncodeToMorseAbc();
Console.WriteLine("Morse abc: " + morseAbcEncoded);

// save all the encoded messages to a txt file
var filePath = "EncodedMessages.txt";
using (var writer = new StreamWriter(filePath))
{
    writer.WriteLine("Sentence to be encrypted: " + sentence);
    writer.WriteLine();

    writer.WriteLine("rot13: " + rot13Encoded);
    writer.WriteLine();

    writer.WriteLine("reverse: " + reverseEncoded);
    writer.WriteLine();

    writer.WriteLine("BinaryAbc: " + binaryAbcEncoded);
    writer.WriteLine();

    writer.WriteLine("Numeric abc: \n" + numericEncoded);
    writer.WriteLine();

    writer.WriteLine("Morse abc: " + morseAbcEncoded);
}
