Console.WriteLine("Enter a 4-digit number:");
string input = Console.ReadLine();
Console.WriteLine();

int steps = 0;

while (!IsValidNumber(input))
{
    Console.WriteLine("Invalid number. Please ensure the number is 4 digits with at least two different digits. Try again:");
    input = Console.ReadLine();
    Console.WriteLine();
}

int number = int.Parse(input);
Console.WriteLine($"Starting with {number}");

while (number != 6174)
{
    number = KaprekarStep(number);
}

Console.WriteLine();
Console.WriteLine($"You have reached Kaprekar's constant in {steps} steps!");
Console.ReadKey();

bool IsValidNumber(string number)
    => number.Length == 4 && number.Distinct().Count() > 1;

int KaprekarStep(int number)
{
    steps++;
    Console.WriteLine();
    Console.WriteLine($"Step {steps}:");

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