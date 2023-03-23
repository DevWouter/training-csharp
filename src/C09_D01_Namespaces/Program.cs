namespace DisplayColors
{
    public enum Color
    {
        White,
        Red,
        Green,
        Blue
    }
}

namespace PrinterColors
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
        // Console.WriteLine("Color: " + Color.White); // Which Color is this? The one from DisplayColors or PrinterColors?
        
        // We can use the fully qualified name to specify which Color we want
        //                                    ┌ Namespace
        //                                    │             ┌ Typename (enum)
        //                                    │             │     ┌ Enum value
        Console.WriteLine("Printer color: " + PrinterColors.Color.Black);
        Console.WriteLine("Display color: " + DisplayColors.Color.Red);
    }
}