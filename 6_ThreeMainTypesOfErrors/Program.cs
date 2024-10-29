// var number = 5 // this will thrown a compilation error

// Runtime errors
var list = new List<int>();
// var firstElement = list.First(); // exception unhandled, sequence contains no elements

// Logical Errors -> needs a space in the string between words
var sentence = MergeWords("A", "little", "duck", "swims", "in", "a", "pond");
Console.WriteLine(sentence);

 static object MergeWords(params string[] words)
{
    return string.Join("", words);
}
Console.ReadKey();