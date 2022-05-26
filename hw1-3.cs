
/*
1. What happens when you divide an int variable by 0?
    will be error


2. What happens when you divide a double variable by 0?



3. What happens when you overflow an int variable, that is, set it to a value beyond its range?

Integer overflow can cause the value to wrap and become negative, 
which violates the program's assumption and may lead to unexpected behavior 
(for example, 8-bit integer addition of 127 + 1 results in −128, a two's complement of 128).


4. What is the difference between x = y++; and x = ++y;?

prefix: increment returns the value of a variable after it has been incremented. ++someNum
postfix: increment returns the value of a variable before it has been incremented. someNum++

Prefix increment
let prefix = 1;
console.log(++prefix); // 2
console.log(prefix); // 2

Postfix increment
let postfix = 1;
console.log(postfix++);  1
console.log(postfix);  2


5.What is the difference between break, continue, and return when used inside a loop statement?

break statement - terminates the closest enclosing iteration statement or switch statement.
continue statement - starts a new iteration of the closest enclosing iteration statement.
return statement - terminates execution of the function in which it appears and returns control to the caller.


6. What are the three parts of a for statement and which of them are required?



7. What is the difference between the = and == operators?

The equality operator == returns true if its operands are equal, false otherwise. (==)
its assign a variable to a value or other variables (=)


8. Does the following statement compile? for ( ; true; ) ;
no


9.What does the underscore _ represent in a switch expression?

underscore (_) character replaces the default keyword to signify that it should match anything if reached. 

10. What interface must an object implement to be enumerated over by using the foreach statement ?

The foreach statement: enumerates the elements of a collection and executes its body for each element of the collection.

*/

/*int max = 100;
for (byte i = 0; i<max; i++)
{
    if (i%3 == 0)
    {
        Console.WriteLine("fizz");
    }else if (i % 5 == 0)
    {
        Console.WriteLine("buzz");    
    }else if(i%3 == 3 && i%5 == 0)
    {
        Console.WriteLine("fizzbuzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}*/


/*int correctNumber = new Random().Next(3) + 1;

Console.WriteLine("guest a number between 1 and 3");
string guess = Console.ReadLine();
int g = Convert.ToInt32(guess);
if( g > correctNumber)
{
    Console.WriteLine("smaller");

}
else if ( g < correctNumber)
{
    Console.WriteLine("larger");

}
else
{
    Console.WriteLine("bingo");
}*/


//class Program
//{
//    static void Main(string[] args)
//    {
//        int layer = 6, space, star;

//        for (int i = 1; i <= layer; i++)
//        {
//            for(space = 1; space <= layer - i; space++)
//            {
//                Console.Write(" ");
//            }
//            for(star = 1; star <= i *2 -1; star++)
//            {
//                Console.Write("*");
//            }
//            Console.WriteLine();
//        }
//    }
//}



//class Program
//{
//    static void Main(string[] args)
//    {   
//        int correctNumber = new Random().Next(3) + 1;

//        Console.WriteLine("guess a number between 1 and 3");
//        int guessedNumber = int.Parse(Console.ReadLine());

//        while (guessedNumber != correctNumber)
//        {
//            if (guessedNumber > correctNumber)
//            {
//                Console.WriteLine("smaller");
//                break;
//            }
//            else if (guessedNumber < correctNumber)
//            {
//                Console.WriteLine("larger");
//                break;
//            }
//            else if(guessedNumber>3 || guessedNumber < 1)
//            {
//                Console.WriteLine("out of range");
//            }
//        }
//        Console.WriteLine("bingo");
//    }
//}



//class Program
//{
//    static void Main(string[] args)
//    {
//        DateTime dt = new DateTime(1996,7,27);
//        Console.WriteLine(dt.ToString());

//        DateTime now = DateTime.Now;
//        Console.WriteLine(now.ToString());

//        System.TimeSpan diff = now.Subtract(dt);
//        int days = Convert.ToInt32(diff.TotalDays);
//        Console.WriteLine(days.ToString());

//        int daysToNextAnniversary = 10000 - (days % 10000);
//        Console.WriteLine(daysToNextAnniversary.ToString());
//    }
//}


//DateTime currentTime = DateTime.Now;

//if (currentTime.Hour < 12 && currentTime.Hour >= 5)
//{
//    Console.WriteLine("Good Morning");
//}
//else if (currentTime.Hour >= 12)
//{
//    Console.WriteLine("Good Afternoon");
//}
//else if (currentTime.Hour >= 16)
//{
//    Console.WriteLine("Good Evening");
//}
//else if (currentTime.Hour <= 24 || currentTime.Hour > 0)
//{
//    Console.WriteLine("Good Night");
//}



//int ct = 24;

//for (int i = 1; i <= 4; i++)
//{
//    for(int j = 0; j <= ct; j += i)
//    {
//        Console.Write(j.ToString().PadLeft(3));
//    }
//}
//Console.WriteLine();