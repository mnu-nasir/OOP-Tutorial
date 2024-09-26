// Primitive Type

using ValueType;

PrimitiveType primitive = new PrimitiveType();
primitive.PrintValue();

// The "SwapNumbers" function does not replace the original value of x and y variable.
// Here, in "SwapNumbers" function "x" and "y" variable's value is copied into the function.
// This is called Call By Value
// - A copy of the variable's value is passed to the method.
// - Modifications made within the method do not affect the original variable.
// - This is the default behavior for value types (like int, double, bool, struct, and enum) in C#.
CallByValueExample callByValueExample = new CallByValueExample();
int x = 10;
int y = 20;
callByValueExample.SwapNumbers(x, y);
Console.WriteLine($"Original X value is : {x}");
Console.WriteLine($"Original Y value is : {y}");

// The "SwapNumbers" function will replace the original value of "a" and "b" variable.
// Here, in "SwapNumbers" function "a" and "b" variable's memory address is passed into the function.
// This is called Call By Reference

// - The memory address of the variable is passed to the method.
// - Modifications made within the method directly affect the original variable.
// - This is the default behavior for reference types (like class and object) in C#.
CallByReferenceExample callByReferenceExample = new CallByReferenceExample();
int a = 100;
int b = 200;
callByReferenceExample.SwapNumbers(ref a, ref b);
Console.WriteLine($"Original A value is : {a}");
Console.WriteLine($"Original B value is : {b}");

// Reference Type
string greetings = "Hello Nasir";
string s1 = greetings;
greetings = "Hello Sonya";

Console.WriteLine($"greetings value: {greetings}");
Console.WriteLine($"s1 value: {s1}");


Console.ReadLine();

