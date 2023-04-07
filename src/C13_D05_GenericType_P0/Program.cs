var numberSlot = new Slot<int>();
numberSlot.Value = 1234;

var stringSlot = new Slot<string>();
stringSlot.Value = "Hello World!";

Console.WriteLine("numberSlot.Value: " + numberSlot.Value);
Console.WriteLine("stringSlot.Value: " + stringSlot.Value);

public class Slot<T>
{
    public T Value { get; set; }
}