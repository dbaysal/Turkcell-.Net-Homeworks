using System.Collections.Generic;

int[] array = { 13, 14, 34, 1, 10, 5, 4, 20 };

int max = Int32.MinValue;
int min = Int32.MaxValue;
int i;

//Finding min and max with for loop
for (i = 0; i < array.Length; i++)
{
    max = max < array[i] ? array[i] : max;
    min = min > array[i] ? array[i] : min;
}


//Finding min and max with while loop
max = Int32.MinValue;
min = Int32.MaxValue;
i = 0;
while(i < array.Length)
{
    max = max < array[i] ? array[i] : max;
    min = min > array[i] ? array[i] : min;
    i++;
}


//Finding min and max with foreach loop
max = Int32.MinValue;
min = Int32.MaxValue;
foreach (int item in array)
{
    max = max < item ? item : max;
    min = min > item ? item : min;
}


//Average operation will only be done to last min and max value as all of them are same
double average = (double)(max + min) / 2;

Console.WriteLine($"Minimum value is: {min}");
Console.WriteLine($"Maximum value is: {max}");
Console.WriteLine($"Average of min and max value is: {average}");


