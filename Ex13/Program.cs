Console.Clear();
Console.WriteLine("Write your number : ");
int number = Convert.ToInt32(Console.ReadLine());
if (number / 100 == 0)
    Console.Write("there is no third number");
else
{
    while (Math.Abs(number) >= 1000)
    {
    number = number / 10;
    }
    Console.WriteLine(Math.Abs(number) % 10);
}
