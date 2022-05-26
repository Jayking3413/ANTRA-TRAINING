/*Test your Knowledge
  1. What type would you choose for the following “numbers”?
    A person’s telephone number - int
    A person’s height   - double
    A person’s age - int
    A person’s gender (Male, Female, Prefer Not To Answer) 
    A person’s salary - decimal
    A book’s ISBN - int
    A book’s price - deciaml 
    A book’s shipping weight double 
    A country’s population - int
    The number of stars in the universe - long 
    The number of employees in each of the small or medium businesses in the United Kingdom (up to about 50,000 employees per business) - int

  2.What are the difference between value type and reference type variables? What is boxing and unboxing?
    Value type 
        - int, float, double, bool
        - Direct contain their data
        - Each has its own copy of data
        - operation on one can not effect another
    reference type
        - string, stringBuilder, object
        - store references to their data (kown as objects)
        - two reference variable can reference the same object
        - operation on one can effect another
    boxing - convert a value type to a reference type
    unboxing - convert the reference type to a value type

  3. What is meant by the terms managed resource and unmanaged resource in .NET
    managed resource - directly under the control of the garbage collector
    unmanaged resource - not directly under the control of the garbage collector. 

  4. Whats the purpose of Garbage Collector in .NET?
    
    Garbage Collector: automatic memory manager
      •Benefits:
        •Don’t need to manually release memory
        •Allocates objects on managed heap efficiently*/

/*Practice number sizes and ranges

1. Create a console application project named /02UnderstandingTypes/ that outputs the
number of bytes in memory that each of the following number types uses, and the
minimum and maximum values they can have: sbyte, byte, short, ushort, int, uint, long, ulong, float, double, and decimal.*/


Console.WriteLine(sbyte.MaxValue);
Console.WriteLine(sbyte.MinValue);
Console.WriteLine(byte.MaxValue);
Console.WriteLine(byte.MinValue);
Console.WriteLine(short.MaxValue);
Console.WriteLine(short.MinValue);
Console.WriteLine(ushort.MaxValue);
Console.WriteLine(ushort.MinValue);
Console.WriteLine(int.MaxValue);
Console.WriteLine(int.MinValue);
Console.WriteLine(uint.MaxValue);
Console.WriteLine(uint.MinValue);
Console.WriteLine(long.MaxValue);
Console.WriteLine(long.MinValue);
Console.WriteLine(ulong.MaxValue);
Console.WriteLine(ulong.MinValue);
Console.WriteLine(float.MaxValue);
Console.WriteLine(float.MinValue);
Console.WriteLine(double.MaxValue);
Console.WriteLine(double.MinValue);
Console.WriteLine(decimal.MaxValue);
Console.WriteLine(decimal.MinValue);



