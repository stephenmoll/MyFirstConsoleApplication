using System;
class GlazerCalc
{
    static void Main()
    {

        string myName = "Stephen";
        string myCountry = "South Africa";

        Console.WriteLine($"My name is {myName}, I am from {myCountry}");

        DateTime currentDate = DateTime.Now;

        Console.WriteLine();

        DateTime christmasDate = new DateTime(DateTime.Today.Year, 12, 25);
        int daysUntilChristmas = (christmasDate - DateTime.Today).Days;

        if (daysUntilChristmas < 0)
            {
                christmasDate = christmasDate.AddYears(1);
                daysUntilChristmas = (christmasDate - DateTime.Today).Days;
            }

        Console.WriteLine($"Days until Christmas: {daysUntilChristmas}.");

        Console.WriteLine(); 
        double width, height, woodLength, glassArea;
        string widthString, heightString;

        Console.Write("Enter the width in feet: ");
        widthString = Console.ReadLine();
        width = double.Parse(widthString);

        Console.Write("Enter the hight in feet: ");
        heightString = Console.ReadLine();      
        height = double.Parse(heightString);

        woodLength = 2 * (width + height) * 3.25;
        glassArea = 2 * (width * height);

        Console.WriteLine("The length of the wood is " +
        woodLength + " feet");
        Console.WriteLine("The area of the glass is " +
        glassArea + " square metres");

        Console.ReadKey();
    }
}