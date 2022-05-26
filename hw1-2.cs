/*1.Create a console application project named /02UnderstandingTypes/ that outputs the
number of bytes in memory that each of the following number types uses, and the minimum and maximum values 
they can have: sbyte, byte, short, ushort, int, uint, long, ulong, float, double, and decimal.*/

/*sbyte a = 1;
byte b = 1;
short c = 1;
ushort d = 1;
int e = 1;
uint f = 1;
long g = 1;
ulong h = 1;
float i = 1;
double j = 1;
decimal k = 1;*/


/*2. Write program to enter an integer number of centuries and convert it to years, days, hours,
minutes, seconds, milliseconds, microseconds, nanoseconds. Use an appropriate data type for every data conversion. Beware of overflows*/

   
        int century = 100;
        int years = century * 100;
        int days = years * 365;
        int hours = days * 24;
        long minutes = hours * 60;
        long seconds = hours * 60;
        long milliseconds = seconds * 1000;
        long microseconds = milliseconds * 1000;
        long nanosecond = microseconds * 1000;

        Console.WriteLine($"{century} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanosecond} nanosecond");
        
   
