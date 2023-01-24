int count = 0;
int limit = int.Parse(Console.ReadLine());
while (count < limit)
{
    count++;
    System.Console.WriteLine(count);

    if (count/2 == 0)
    {
        System.Console.WriteLine(summ(count));
    }
}
