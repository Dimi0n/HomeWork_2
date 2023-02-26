// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях. [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[]myArray = new int[10];
for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = new Random().Next(0,50);
}
System.Console.WriteLine("Массив случайных чисел: ");
System.Console.WriteLine(string.Join(" ", myArray));
System.Console.WriteLine();
int []myArray2 = Array.FindAll(myArray,i=>i%2!=0).ToArray();
int result = myArray2.Sum();
System.Console.WriteLine("Сумма нечетных чисел массива ---> " + result);