using Diacritics.Extensions;

Console.WriteLine("Enter a word");
string? word = Console.ReadLine();

if (word is null)
{
    return;
}

Console.WriteLine($"Your word: {word}");

word = word.Trim().RemoveDiacritics();
string[] specialCharacters = { ".", ",", "?" };

for (int i = 0; i < word.Length; i++)
{
    for (int j = 0; j < specialCharacters.Length; j++)
    {
        word = word.Replace(specialCharacters[j], string.Empty);
    }
}

Console.WriteLine($"Your word without special characters: {word}");

char[] array = word.ToCharArray();
Array.Reverse(array);

string wordReverse = new string(array);
//wordReverse = wordReverse.Trim(specialCharacters);

Console.WriteLine($"Reversed word: {wordReverse}");

var isPalyndrome = word.ToLower().Equals(wordReverse.ToLower());

if (isPalyndrome)
    Console.WriteLine("The word introduced is a palindrome");
else
    Console.WriteLine("The word introduced is NOT a palindrome ");