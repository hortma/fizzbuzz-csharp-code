while (true)
{
    Console.Write("Type a number: ");
    string? input = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(input))
    {
        Console.WriteLine("Input is either null or empty!");
        continue;
    }

    if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
    {
        break;
    }

    if (!int.TryParse(input, out int num)) {
        Console.WriteLine("Please type a valid number!");
        continue;
    }

    for (int i = 1; i <= num; i++)
    {
        string output = (i % 3 == 0 ? "Fizz" : "") + (i % 5 == 0 ? "Buzz" : "");
        Console.WriteLine(string.IsNullOrWhiteSpace(output) ? $"{i}" : $"{output}");
    }
}

Console.WriteLine("Exiting...");
