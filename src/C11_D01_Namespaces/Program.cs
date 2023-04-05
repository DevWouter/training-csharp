namespace Display
{
    public enum Color
    {
        White,
        Red,
        Green,
        Blue
    }
}

namespace Printer
{
    public enum Color
    {
        White,
        Cyan,
        Magenta,
        Yellow,
        Black
    }
}

public static class Program
{
    public static void Main()
    {
        // Which Color is this? The one from Display or Printer?
        // Console.WriteLine("Color: " + Color.White); 
        
        // We can use the fully qualified name to specify which Color we want
        //                                    ┌ Namespace
        //                                    │       ┌ Typename (enum)
        //                                    │       │     ┌ Enum value
        Console.WriteLine("Printer color: " + Printer.Color.Black);
        Console.WriteLine("Display color: " + Display.Color.Red);
    }
}