//1# Два числа. Большее или меньшее.
int a,b;
System.Console.WriteLine("Введите первое число: ");
a = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите Второе число: ");
b = int.Parse(Console.ReadLine());

if (a>b)
{
    System.Console.WriteLine("Первое число больше второго");
}
else
{
    System.Console.WriteLine("Второе число больше первого");
}

//2# Максимальное из 3х чисел.
int e,f,g;
System.Console.WriteLine("Введите первое число: ");
e = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите Второе число: ");
f = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите третье число: ");
g = int.Parse(Console.ReadLine());
int max = e;

if (f>max)
{
    max = f;
    
}
if (g>max)
{
    max = g;
 
}
System.Console.WriteLine("Максимальным числом является: " + max);

//3# Четное/нечетное


System.Console.WriteLine("Введите число: ");
int j = int.Parse(Console.ReadLine());
if (j%2 == 0)
{
    System.Console.WriteLine("Число является четным");
}
else
{
    System.Console.WriteLine("Число является НЕчетным");
}

//4# Четные числа до числа N
System.Console.WriteLine("Введите Число: ");
int Number=int.Parse(Console.ReadLine());

for (int i = 1; i <= Number; i++)
{
    if (i %2 == 0)
    {
      
        System.Console.WriteLine(i);
    }
}
