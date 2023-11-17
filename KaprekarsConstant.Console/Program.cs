Console.WriteLine("Enter a 4-digit number:");
string input = Console.ReadLine();

if (!IsValidNumber(input))
{
    Console.WriteLine("Invalid number. Please ensure the number is 4 digits with at least two different digits.");
    return;
}

int number = int.Parse(input);
Console.WriteLine($"Starting with {number}");

while (number != 6174)
{
    number = KaprekarStep(number);
}

Console.WriteLine();
Console.WriteLine("You have reached Kaprekar's constant!");
Console.ReadKey();

static bool IsValidNumber(string number)
    => number.Length == 4 && number.Distinct().Count() > 1;

static int KaprekarStep(int number)
{
    char[] digits = number.ToString("D4").ToCharArray();

    Array.Sort(digits);

    string smallest = new string(digits);
    string largest = new string(digits.Reverse().ToArray());

    Console.WriteLine($"  {largest}");
    Console.WriteLine($"- {smallest}");
    var result = int.Parse(largest) - int.Parse(smallest);
    Console.WriteLine($"= {result}");
    return result;
}