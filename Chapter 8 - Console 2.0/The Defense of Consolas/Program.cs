int row, col;

Console.Title = "The Defense of Consolas";

Console.Write("Target row: ");
row = int.Parse(Console.ReadLine());
Console.Write("Target column: ");
col = int.Parse(Console.ReadLine());

if (row < 2 || row > 7 || col < 2 || col > 7)
{
    Console.WriteLine("Invalid target position. Please enter values between 2 and 7.");
    return;
}
else
{
    Console.BackgroundColor = ConsoleColor.Yellow;
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Beep();

    Console.WriteLine($"Deploy to: {row}, {--col}");
    Console.WriteLine($"Deploy to: {--row}, {++col}");
    Console.WriteLine($"Deploy to: {++row}, {++col}");
    Console.WriteLine($"Deploy to: {++row}, {--col}");
}
