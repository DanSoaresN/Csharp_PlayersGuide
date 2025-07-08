// See https://aka.ms/new-console-template for more information

Console.WriteLine("Write the Base");
string TBase = Console.ReadLine();
double TBaseNumber = double.Parse(TBase);
Console.WriteLine("Write the Height");
string THeight = Console.ReadLine();
double THeightNumber = double.Parse(THeight);

Console.WriteLine("The Area of the Triangle is: " + CalculateArea(THeightNumber, TBaseNumber));


double CalculateArea(double height, double baseLength)
{
    return (height * baseLength) / 2;
}
