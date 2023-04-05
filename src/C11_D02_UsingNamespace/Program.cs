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

namespace C09_D02_UsingNamespace
{
    // ┌ Using-keyword
    // │     ┌ Namespace that we want to import
    using PrinterColors;

    public static class Program
    {
        public static void Main()
        {
            // By using the "using" keyword, we can import the namespace "PrinterColors", that way we don't have to write "PrinterColors.Color" every time we
            // want to use an enum value from that namespace. 
            Console.WriteLine("Color: " + Color.White);

            // We can use the fully qualified name to specify which Color we want
            //                                    ┌ Namespace
            //                                    │             ┌ Typename (enum)
            //                                    │             │     ┌ Enum value
            Console.WriteLine("Printer color: " + PrinterColors.Color.Black);
            Console.WriteLine("Display color: " + DisplayColors.Color.Red);
        }
    }
}