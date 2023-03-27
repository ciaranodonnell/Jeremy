

public class Test
{
    public static void DoTest()
    {
        string input  = Console.ReadLine();

        int inputAsInt = 0;
        bool parsedSuccessfully = int.TryParse(input, out inputAsInt);
    }


    public static int AddTwoIntegers(int number1, int number2)
    {
        Console.Write("Number 1 is ");
        Console.WriteLine(number1);
        Console.Write("Number 2 is ");
        Console.WriteLine(number2);

        return number1 + number2;


    }
}