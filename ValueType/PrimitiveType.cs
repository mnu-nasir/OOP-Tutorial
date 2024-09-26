namespace ValueType;
internal class PrimitiveType
{
    public void PrintValue()
    {
        int num1 = 100;
        int num2 = 200;

        num2 = num1;
        num1 = 500;


        // The below code will print 100 as in line 15, num2 variable, num1 value is copied. 
        // And in line 16, num1 value is re-asigned with a new value (500). But it will not affect the the value of num2 variable
        Console.WriteLine($"Num 2 is {num2}"); // will print 100

        // The below code will print 500. Because in Line 16, num1 variable is re-asigned with a new value
        Console.WriteLine($"Num 1 is {num1}"); // will print 500
    }
}
