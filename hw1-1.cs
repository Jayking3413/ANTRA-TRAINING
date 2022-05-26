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







2. Write program to enter an integer number of centuries and convert it to years, days, hours,
minutes, seconds, milliseconds, microseconds, nanoseconds. Use an appropriate data
type for every data conversion. Beware of overflows!
Input: 1
Output: 1 centuries = 100 years = 36524 days = 876576 hours = 52594560 minutes
= 3155673600 seconds = 3155673600000 milliseconds = 3155673600000000
microseconds = 3155673600000000000 nanoseconds
Input: 5
Output: 5 centuries = 500 years = 182621 days = 4382904 hours = 262974240
minutes = 15778454400 seconds = 15778454400000 milliseconds = 15778454400000000
microseconds = 15778454400000000000 nanoseconds
Explore following topics
C# Keywords
Main() and command-line arguments
Types (C# Programming Guide)
Statements, Expressions, and Operators
Strings (C# Programming Guide)
Nullable Types (C# Programming Guide)
Nullable reference types
Controlling Flow and Converting Types
Test your Knowledge
1. What happens when you divide an int variable by 0?
2. What happens when you divide a double variable by 0?
3. What happens when you overflow an int variable, that is, set it to a value beyond its
range?
4. What is the difference between x = y++; and x = ++y;?
5. What is the difference between break, continue, and return when used inside a loop
statement?
6. What are the three parts of a for statement and which of them are required?
