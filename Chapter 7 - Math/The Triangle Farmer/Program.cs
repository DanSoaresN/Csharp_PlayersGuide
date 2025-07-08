// Description: This program calculates the area of a triangle based on user input for height and base length.

//to store the user's input number you need to parse the string to a double
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
