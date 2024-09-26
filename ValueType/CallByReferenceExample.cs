namespace ValueType;
internal class CallByReferenceExample
{
    public void SwapNumbers(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;

        Console.WriteLine("After swaping the value is below:");
        Console.WriteLine($"Value of X is : {a}");
        Console.WriteLine($"Value of Y is : {b}");
    }
}
