namespace JRedd
{

    public class TestClass
    {
        public static void Main(string[] args)
        {

            // See https://aka.ms/new-console-template for more information
            Console.WriteLine("Hello, Jeremy!");
            Console.WriteLine("What would you like to draw?");
            Console.WriteLine("\t1. Triangle");
            Console.WriteLine("\t2. Square");
            Console.WriteLine("\t3. Hexagon");
            Console.Write("> ");
            var input = Console.ReadLine();
            
            //&& = And Also
            // So True && False == False
            //|| = Or Else
            if (input != "1" && input != "2" && input != "3")
            {
                Console.WriteLine("Invalid Selection");
                return;
            }

            //switch is like "if the value of input is one of these"
            switch (input)
            {
                case "1": DrawTriangle(); break;
                case "2": DrawSquare(); break;
                case "3": DrawHexagon(); break;
                default: //default is like an else
                    Console.WriteLine("Invalid Selection");
                    return;
            }

        }
        static void DrawTriangle()
        {
            Console.Write("Enter Bottom Width > ");
            var input = Console.ReadLine();
            int selection = int.Parse(input);
            if (selection < 2 || selection > 50)
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
            int selection = int.Parse(input);
            if ( selection < 2 || selection > 50)
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


        static void DrawHexagon()
        {

            Console.Write("Enter Side Length > ");
            var input = Console.ReadLine();
            int sideLength = int.Parse(input);
            if ( sideLength < 3 || sideLength > 30)
            {
                Console.WriteLine("Square sides need to be between 3 and 30");
                return;
            }

            for (int row = 1; row <= sideLength; row++)
            {
                Console.Write("".PadRight(sideLength - row, ' '));
                Console.WriteLine("".PadRight(sideLength + (2 * row), 'x'));
            }
            for (int row = sideLength - 1; row > 0; row--)
            {
                Console.Write("".PadRight(sideLength - row, ' '));
                Console.WriteLine("".PadRight(sideLength + (2 * row), 'x'));
            }

            Console.WriteLine(); // make a blank link to be nice
        }
    }
}