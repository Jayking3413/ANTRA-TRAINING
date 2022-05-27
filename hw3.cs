/*
Test your knowledge
1. What are the six combinations of access modifier keywords and what do they do? 
•Public - accessible everywhere
•Protected - accessible in the same class or derived class 
•Internal - accessible in the same assembly
•Private - accessible only in current class
•Protected Internal - we can access the protected internal member only in the same assembly or in a derived class in other assemblies.
•Private Protected -  We can access members inside the containing class or in a class that derives from a containing class, but only in the same assembly(project).

2. What is the difference between the static, const, and readonly keywords when applied to a type member?
Constant and ReadOnly keyword - used to make a field constant which value cannot be modified. 
Static keyword - used to make members static that can be shared by all the class objects.
readonly - indicate taht assignment to the field can only occur as part of the declaration or in a constructor in the same class

3. What does a constructor do?
1)is a special method  which shares the same name of the class and doesn't have any return type, not even void
2) constructor is used to create an object of the class and initialize class members
3) if there is no constructor in the class, c# compiler will provide a default constructor
4) if we create any constructor ourselves, the default constructor will be replaced
5) constructor can be overloaded
6) constructor cannot be inherited so a constructor cannot be overriden
7) by default, the derived class constructor will make a call the the base class constructor

4. Why is the partial keyword useful?
The partial keyword indicates that other parts of the class, struct, or interface can be defined in the namespace. 
All the parts must use the partial keyword. All the parts must be available at compile time to form the final type. 
All the parts must have the same accessibility, such as public , private , and so on

5. What is a tuple?
“a data structure which consists of the multiple parts”

6. What does the C# record keyword do?
define a reference type that provides built-in functionality for encapsulating data

7. What does overloading and overriding mean?
method overriding - happens between base class and the derived class; same method signature; 
derived class can have different implementations for the same methods -- runtime polymorphism
method overloading - multiple methods in the same class, with same method name and access modifiers, 
but different input or output parameter -- compile time polymorphism

8. What is the difference between a field and a property?
Properties expose fields. 
Fields should (almost always) be kept private to a class and accessed via get and set properties.

9. How do you make a method parameter optional?
Use Parameter arrays
Default parameter
Use OptionalAttribute
Method Overloading

10. What is an interface and how is it different from abstract class?
Interface supports multiple inheritance but abstract class does not
Interface can not have instanced constructor but abstract class can have
Interface has by default all members abstract and public, but abstract class can have abstract and concrete members
Interface can not have fields but abstract class can have fields.

11. What accessibility level are members of an interface?
Access is limited to the current assembly.

12. True 
Polymorphism allows derived classes to provide different implementations of the same method.

13. True
The override keyword is used to indicate that a method in a derived class is providing its own implementation of a method.

14.  False. 
The new keyword is used to indicate that a method in a derived class is providing its own implementation of a method.

15. False. 
Abstract methods can be used in a normal (non-abstract) class. 

16. True
Normal (non -abstract) methods can be used in an abstract class. 

17.true
Derived classes can override methods that were virtual in the base class. 

18.True
Derived classes can override methods that were abstract in the base class. 

19.False.
In a derived class, you can override a method that was neither virtual non abstract in the base class.

20.False.
A class that implements an interface does not have to provide an implementation for all of the members of the interface.

21.True 
A class that implements an interface is allowed to have other members that aren’t defined in the interface.

22.False.
A class can have more than one base class.

23.True 
A class can implement more than one interface

*/


// working with methods

//public class Revers
//{
//    static void GenerateNumbers(int[] num)
//    {
//        num = {1,2,,3,4,5,6,7,8,9,10};
//    }
//    static void Reverse()
//    {
//        char[] charArray = s.ToCharArray();
//        Array.Reverse(charArray);
//    }
//    static void PrintNumbers()
//    {

//    }
//    static void Main(string[] args)
//    {
//        int[] numbers = GenerateNumbers();
//        Reverse(numbers);
//        PrintNumbers(numbers);
//    }
//}






/*1.Write a program that that demonstrates use of four basic principles of
object-oriented programming /Abstraction/, /Encapsulation/, /Inheritance/ and/Polymorphism/*/

//public class animal
//{
//    private string name = "Lucy";
//    public void legs()
//    {
//        Console.WriteLine("leg");
//    }
//    public void legs(int l)
//    {
//        Console.WriteLine(l);
//    }
//    public string getName()
//    {
//        return name;
//    }
//    public void setName(string name)
//    {
//        this.name = name;
//    }
//}
//public class cat : animal
//{
//    public void legs()
//    {
//        Console.WriteLine("jiao");
//    }
//}





/*2.Use / Abstraction / to define different classes for each person type such as Student
and Instructor. These classes should have behavior for that type of person*/


//public abstract class person 
//{
//    public abstract void persontype();
//}
//public class Type : person
//{
//    public override void persontype()
//    {
//        Console.WriteLine("is a student");
//        Console.WriteLine("is a instructor");
//    }
//}



//3.Use / Encapsulation / to keep many details private in each class.

//public abstract class person
//{
//    public abstract void persontype();
//    private string Name;
//    private string Old;

//}
//public class Type : person
//{
//    public override void persontype()
//    {
//        Console.WriteLine("is a student");
//        Console.WriteLine("is a instructor");
//    }
//}





//4.Use / Inheritance / by leveraging the implementation already created in the Person class to save code in Student and Instructor classes.

//public abstract class person
//{
//    public abstract void persontype();
//}
//public class Type : person
//{
//    public override void persontype()
//    {
//        Console.WriteLine("is a student");
//        Console.WriteLine("is a instructor");
//    }
//}




//5. Use /Polymorphism/ to create virtual methods that derived classes could override to create specific behavior such as salary calculations.

//public abstract class person
//{
//    public abstract void persontype();

//    public void senior(int age)
//    {

//    }

//    public void senior(int age, int workyears)
//    {

//    }
//}
//public class Type : person
//{
//    public override void persontype()
//    {
//        Console.WriteLine("is a student");
//        Console.WriteLine("is a instructor");
//    }
//}


/*6. Make sure to create appropriate /interfaces/ such as ICourseService, IStudentService, IInstructorService, IDepartmentService, 
IPersonService, IPersonService (should have person specific methods).IStudentService, IInstructorService should inherit from IPersonService.

Person
Calculate Age of the Person
Calculate the Salary of the person, Use decimal for salary
Salary cannot be negative number
Can have multiple Addresses, should have method to get addresses

Instructor
Belongs to one Department and he can be Head of the Department
Instructor will have added bonus salary based on his experience, calculate his
years of experience based on Join Date

Student
Can take multiple courses
Calculate student GPA based on grades for courses
Each course will have grade from A to F

Course
Will have list of enrolled students
Department
Will have one Instructor as head
Will have Budget for school year (start and end Date Time)
Will offer list of courses*/











/*7. Try creating the two classes below, and make a simple program to work with them, as described below
Create a Color class:
On a computer, colors are typically represented with a red, green, blue, and alpha
(transparency) value, usually in the range of 0 to 255. Add these as instance variables.
A constructor that takes a red, green, blue, and alpha value.
A constructor that takes just red, green, and blue, while alpha defaults to 255
(opaque).
Methods to get and set the red, green, blue, and alpha values from a Colorinstance.
A method to get the grayscale value for the color, which is the average of the red,
green and blue values.

Create a Ball class:
    The Ball class should have instance variables for size and color (the Color class you just
created). Let’s also add an instance variable that keeps track of the number of times it
has been thrown.
Create any constructors you feel would be useful.
Create a Pop method, which changes the ball’s size to 0.
Create a Throw method that adds 1 to the throw count, but only if the ball hasn’t been
popped (has a size of 0).
A method that returns the number of times the ball has been thrown*/
