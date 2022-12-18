Console.Clear();
Console.WriteLine("Write a sequence of numbers : ");
int number = Convert.ToInt32(Console.ReadLine());
int max = 0;
int max2 = 0;
while (number != 0)
{
    number = Convert.ToInt32(Console.ReadLine());
    if (max < number)
    {
        max2 = max;
        max = number;
    }
    else if (max != number && max2 < number)
    {
        max2 = number;
    }
}
Console.WriteLine(max2);