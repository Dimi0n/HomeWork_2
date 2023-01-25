int count = 0;
int limit = int.Parse(Console.ReadLine());
while (count < limit)
{
    count = (count%2 == 0);
    count++;
    Console.WriteLine(count);

    
}
