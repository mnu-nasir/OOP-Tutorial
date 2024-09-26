namespace ValueType;
internal class CallByValueExample
{
    public void SwapNumbers(int x, int y)
    {
        int temp = x;
        x = y;
        y = temp;

        Console.WriteLine("After swaping the value is below:");
        Console.WriteLine($"Value of X is : {x}");
        Console.WriteLine($"Value of Y is : {y}");
    }

    void IncrementValue(int x)
    {
        x++;
        Console.WriteLine($"Inside method: x = {x}");
    }
}
