// In the previous example, we called the same method again and again.
// This is called recursion.
// However this program will crash because it "overflow the stack".
// The stack is a data structure that is used to keep track of the methods that were called.
//
// In this case it will be
// "RecursiveFunction that calls RecursiveFunction that calls RecursiveFunction that calls
// RecursiveFunction that calls RecursiveFunction that calls RecursiveFunction that calls
// RecursiveFunction that calls RecursiveFunction that calls RecursiveFunction that calls
// ... You get the idea. 

void RecursiveFunction(int counter)
{
    Console.WriteLine(counter);
    RecursiveFunction(counter + 1);
}

RecursiveFunction(0);