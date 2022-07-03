// Enter a number N,show Cube table from 1 to N
CubeTablePrint();

void CubeTablePrint()
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write("Enter a number (1 or higher): ");
    int N = EnterNumber();
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write($"The cube table for the number {N}: ");
    for (int i = 0; i <= N; i++)
    {
        Console.Write($"{i*i}, ");
    }
    Console.Write("\b \b");
    Console.Write("\b \b");
    Console.ResetColor();
}

int EnterNumber()
{
    int number = 0;
    while(!int.TryParse(Console.ReadLine(), out number) || number < 1)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("This is not a number, or this number < 1, try again: ");
    }
    return number;
}
