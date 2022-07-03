// Find the distanse between two points in 3D. Print out in colors :)

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("   Enter 6 numbers (3 coordinats for 2 point):");
double ax = EnterNumber("ax"), ay = EnterNumber("ay"), az = EnterNumber("az"),
       bx = EnterNumber("bx"), by = EnterNumber("by"), bz = EnterNumber("bz");
double distance = Math.Pow((ax - bx) * (ax - bx) +
                           (ay - by) * (ay - by) +
                           (az - bz) * (az - bz),
                           (double) 1/2);
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"The distanse is {Math.Round(distance, 2)}");
Console.ResetColor();


double EnterNumber(string coordinate_name)
{
    double correct_coordinate = 0;
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write($"Enter {coordinate_name}: ");
    while (!double.TryParse(Console.ReadLine(), out correct_coordinate))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"'{coordinate_name}' should be a number, try again: ");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
    }
    return correct_coordinate;
}