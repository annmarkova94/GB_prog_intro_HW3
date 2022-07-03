// Find if the number is a Palindrome
Console.Write("Enter a 5-digit number: ");
int number = 0;
while (!int.TryParse(Console.ReadLine(), out number)
       || number < 10000 || number >= 100000)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("This is not a 5-digit number, try again: ");
    Console.ResetColor();
}

if (number % 10 == number / 10000 &&
    number % 100 / 10 == number / 1000 % 10 )
    Console.WriteLine("This number is a Palinedrome! :)");
else
    Console.WriteLine("This number is NOT a Palinedrome :(");
