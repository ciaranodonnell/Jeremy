// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Jeremy!");
Console.WriteLine("What would you like to draw?");
Console.WriteLine("\t1. Triangle");
Console.WriteLine("\t2. Square");
Console.Write("> ");
var input = Console.ReadLine();
int selection = 0;
if (!int.TryParse(input, out selection) || selection < 1 || selection > 2)
{
    Console.WriteLine("Invalid Selection");
    return;
}


switch (selection)
{
    case 1: DrawTriangle(); break;
    case 2: DrawSquare(); break;
}


static void DrawTriangle()
{
    Console.Write("Enter Bottom Width > ");
    var input = Console.ReadLine();
    int selection = 0;
    if (!int.TryParse(input, out selection) || selection < 2 || selection > 50)
    {
        Console.WriteLine("Triangle bottoms need to be between 2 and 50");
        return;
    }

    for (int x = 1; x <= selection; x++)
    {
        Console.WriteLine("".PadRight(x, 'x'));
    }
    Console.WriteLine(); // make a blank link to be nice

}
static void DrawSquare()
{

    Console.Write("Enter Side Length > ");
    var input = Console.ReadLine();
    int selection = 0;
    if (!int.TryParse(input, out selection) || selection < 2 || selection > 50)
    {
        Console.WriteLine("Square sides need to be between 2 and 50");
        return;
    }

    for (int x = 0; x < selection; x++)
    {
        Console.WriteLine("".PadRight(selection, 'x'));
    }
    Console.WriteLine(); // make a blank link to be nice
}
