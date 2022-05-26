/*Test your Knowledge
1. When to use String vs. StringBuilder in C# ?

-While working with the String class, every time you perform some operations on your string, you recreate the entire string in the memory over and over again, 
whereas StringBuilder allocates some buffer space in the memory and applies modifications into that buffer space.
-As the StringBuilder object is mutable, it provides better performance as compared to the String object when heavy string manipulations are involved.
-String operations use more memory as compared to StringBuilder because String creates intermediate garbage instances after each operation.
-String is in System namespace but StringBuilder is in System.Text namespace

2. What is the base class for all arrays in C#?
-The Array class is the base class for all the arrays in C#. It is defined in the System namespace. 
-The Array class provides various properties and methods to work with arrays.
 
3.How do you sort an array in C#?
-We can sort a one-dimensional array in two ways, using Array. Sort() method and using LINQ query.

4.What property of an array object can be used to get the total number of elements in an array?
-length

5. Can you store multiple data types in System.Array?
No, we cannot store multiple datatype in an Array, we can store similar datatype only in an Array.

6. What’s the difference between the System.Array.CopyTo() and System.Array.Clone()
-The Clone() method returns a new array (a shallow copy) object containing all the elements in the original array. 
-The CopyTo() method copies the elements into another existing array. Both perform a shallow copy.

 */



//Array practice


//int[] o = new int[]{1,2,3,4,5,6,7,8,9,0};
//int[] c = new int[o.Length]; 

//for (int i = 0; i < o.Length; i++)
//    c[i] = o[i];

//foreach (int cop in c)
//    Console.Write(cop);
//Console.Write(o);






//var list = new List<string>();
//Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
//string read = Console.ReadLine();
//if(read == "+")
//{
//    return list.Add("");
//}

//return 





//int start = 1, end = 100;
//Console.WriteLine($"The prime numbers between {start} and {end} are :");

//var numbers = Enumerable.Range(start, end - start)
//                        .Where(IsPrime)
//                        .Select(number => number)
//                        .ToList();

//Console.WriteLine(string.Join(", ", numbers));

//bool IsPrime(int number)
//{
//    // local function
//    bool CalculatePrime(int value)
//    {
//        var possibleFactors = Math.Sqrt(number);
//        for (var factor = 2; factor <= possibleFactors; factor++)
//        {
//            if (value % factor == 0)
//            {
//                return false;
//            }
//        }
//        return true;
//    }
//    return number > 1 && CalculatePrime(number);
//}






//public class rRotateSum {
//    static void Rotate(int[] a, int k)
//    {
//        k = k % a.Length;
//        reverse(a, 0, a.Length - 1);
//        reverse(a, 0, k - 1);
//        reverse(a, k, a.Length - 1);
//    }
//    static void reverse(int[] a, int s, int e)
//    {
//        while (s < e)
//        {
//            int temp = a[s];
//            a[s] = a[e];
//            a[e] = temp;
//            s++;
//            e--;
//        }
//    }

//}







//int[] numbers = new[] { 0, 1, 1, 5, 2, 2, 6, 3, 3 };

//int count = 1;
//int longestNum = numbers[0];
//int longestCount = 1;

//for (int i = 1; i < numbers.Length; i++)
//{
//    if (numbers[i] != numbers[i - 1])
//    {
//        count = 0;
//    }
//    count++;

//    if (count > longestCount)
//    {
//        longestCount = count;
//        longestNum = numbers[i];
//    }
//}
//Console.WriteLine(string.Join(" ", Enumerable.Repeat(longestNum, longestCount)));




//int startNum, endNum;

//static int[] FindPrimesInRange(startNum, endNum)
//{
//    for (int i = startNum; i < endNum; i++)
//    {
//        for (int j = 2; j <= i / 2; j++)
//        {
//            if (i % j == 0)
//            {
//                Console.WriteLine();
//                break;
//            }
//        }
//    }
//}





//Practice Strings



//static string Reverse(string s)
//{
//    char[] charArray = s.ToCharArray();
//    Array.Reverse(charArray);
//    return new string(charArray);
//}
//Console.Write(Reverse("jayking"));






//string phrase = "C# is not C++, and PHP is not Delphi!";

//static string ReverseWords(string str)
//{
//    return String.Join(" ", str.Split('.', ' ').Reverse()).ToString();
//}
//Console.WriteLine(ReverseWords(phrase));






//string path = "https://docs.microsoft.com/en-us/dotnet/api/system.uri.scheme?view=net-6.0";
//Uri uri = new Uri(path);
//Console.WriteLine(uri.Scheme); 
//Console.WriteLine(uri.Host);
//Console.WriteLine(uri.AbsolutePath);
