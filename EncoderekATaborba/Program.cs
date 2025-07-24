using EncoderekATaborba;

var sentence = "ADAM ADAM";
var rot13Encoded = sentence.Rot13();
Console.WriteLine("rot13: " + rot13Encoded);

var binaryAbcEncoded = sentence.EncodeToBinaryAbc();
Console.WriteLine("BinaryAbc: " + binaryAbcEncoded);