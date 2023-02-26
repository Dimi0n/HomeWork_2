// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2

int[]myArray = new int[10];
for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = new Random().Next(0,1000);
}
System.Console.WriteLine("Массив случайных чисел: ");
System.Console.WriteLine(string.Join(" ", myArray));
System.Console.WriteLine();
int []myArray2 = Array.FindAll(myArray,i=>i%2==0).ToArray();
int result = myArray2.Length;
System.Console.WriteLine("Kоличество чётных чисел в массиве--->  "+ result);