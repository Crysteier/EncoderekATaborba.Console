using EncoderekATaborba;

var sentence = "megtalaljatok az elso nyomot azon a helyen ahol az ut kette agazik";
Console.WriteLine("Sentence to be encrypted: " + sentence);

var rot13Encoded = sentence.Rot13();
Console.WriteLine("rot13: " + rot13Encoded);

var binaryAbcEncoded = sentence.EncodeToBinaryAbc();
Console.WriteLine("BinaryAbc: " + binaryAbcEncoded);

var numericEncoded = sentence.EncodeToNumericAbc();
Console.WriteLine("Numeric abc: \n" + numericEncoded);

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

    writer.WriteLine("BinaryAbc: " + binaryAbcEncoded);
    writer.WriteLine();

    writer.WriteLine("Numeric abc: \n" + numericEncoded);
    writer.WriteLine();

    writer.WriteLine("Morse abc: " + morseAbcEncoded);
}
