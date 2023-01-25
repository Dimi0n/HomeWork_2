// Четные и нечетные числа цикла. Их колличество и сумма.

System.Console.WriteLine("Введите чило-начало счета:");
int StartValue = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите чило-конец счета:");
int limit = int.Parse(Console.ReadLine());
int EvenDigitsCount = 0;
int OddDigitsCount = 0;

while (StartValue <= limit)
{
   
    if (StartValue%2 == 0)
    {
        EvenDigitsCount++;
    }    
    else
    {
        OddDigitsCount++;
    }    
    
    StartValue++;
}
System.Console.WriteLine("Колличество четных чисел: " + EvenDigitsCount);
System.Console.WriteLine("Колличество не четных чисел: " + OddDigitsCount);
