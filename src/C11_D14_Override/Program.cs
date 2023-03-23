// Override GetHashCode and Equals methods
// Questions:
// 1. What kind of comparison is done by == operator?
// 2. What kind of comparison is done by HashSet?
// 3. What is the purpose of GetHashCode?

var square_of_10 = new Dimension(10, 10);
var rect_10_by_10 = new Dimension(10, 10);
var rect_10_by_20 = new Dimension(10, 20);
var rect_20_by_10 = new Dimension(20, 10);

Console.WriteLine("Using == operator to compare objects");
Console.WriteLine($"Is square_of_10 == rect_10_by_10? {square_of_10 == rect_10_by_10}");
Console.WriteLine($"Is rect_10_by_10 == rect_10_by_20? {rect_10_by_10 == rect_10_by_20}");
Console.WriteLine($"Is rect_10_by_20 == rect_20_by_10? {rect_10_by_20 == rect_20_by_10}");

Console.WriteLine("Using Object.ReferenceEquals operator to compare objects");
Console.WriteLine($"Is Object.ReferenceEquals(square_of_10, rect_10_by_10)? {object.ReferenceEquals(square_of_10, rect_10_by_10)}");
Console.WriteLine($"Is Object.ReferenceEquals(rect_10_by_10, rect_10_by_20)? {object.ReferenceEquals(rect_10_by_10, rect_10_by_20)}");
Console.WriteLine($"Is Object.ReferenceEquals(rect_10_by_20, rect_20_by_10)? {object.ReferenceEquals(rect_10_by_20, rect_20_by_10)}");

Console.WriteLine("Using Object.ReferenceEquals operator to compare objects");
Console.WriteLine($"Is Object.Equals(square_of_10, rect_10_by_10)? {object.Equals(square_of_10, rect_10_by_10)}");
Console.WriteLine($"Is Object.Equals(rect_10_by_10, rect_10_by_20)? {object.Equals(rect_10_by_10, rect_10_by_20)}");
Console.WriteLine($"Is Object.Equals(rect_10_by_20, rect_20_by_10)? {object.Equals(rect_10_by_20, rect_20_by_10)}");

Console.WriteLine($"Is {rect_10_by_20} == {rect_20_by_10}? {rect_10_by_20 == rect_20_by_10}");

// Remember that HashSet contains unique items
// It does by using the GetHashCode and Equals methods
Console.WriteLine();
Console.WriteLine("Creating and inserting 3 items into HashSet<Dimension>");
HashSet<Dimension> dimensions = new HashSet<Dimension>();
dimensions.Add(rect_10_by_10);
dimensions.Add(rect_10_by_20);
dimensions.Add(rect_20_by_10);

Console.WriteLine($"HashSet contains {dimensions.Count} items:");
foreach (var size in dimensions)
{
    Console.WriteLine("- " + size);
}


public class Dimension
{
    public int Width { get; set; }
    public int Height { get; set; }

    public Dimension(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public override string ToString()
    {
        return $"{Width}x{Height}";
    }

    public override int GetHashCode()
    {
        // A hash code is a single number that can be used to quicky check if two objects are equal
        // If they are different then they are NOT EQUAL
        // If they are the same then they MAY BE EQUAL, but an extra check is needed

        // Uncomment the next line to see how/when this method is called
        // Console.WriteLine("<<GetHashCode method called on " + this + ">>");

        // return 0; // What happens if we return 0?
        return Width + Height; // Since we don't care about rotation, this is correct
        // return HashCode.Combine(Width, Height); // Otherwise this is correct
    }

    public override bool Equals(object? obj)
    {
        // Uncomment the next line to see how/when this method is called
        // Console.WriteLine("<<Equals method called on " + this + " and " + obj+ ">>");
        
        var other = (Dimension)obj;
        var isMatchWithoutRotating = this.Height == other.Height &&
                                     this.Width == other.Width;
        var isMatchWithRotating = this.Height == other.Width &&
                                  this.Width == other.Height;

        return isMatchWithoutRotating || isMatchWithRotating;
    }
}