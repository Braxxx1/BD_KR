string[] wordSpis = Console.ReadLine().Split(" ");
int size = 0;
foreach (var item in wordSpis)
{
    if (item.Length <= 3)
    {
        size += 1;
    }    
}
