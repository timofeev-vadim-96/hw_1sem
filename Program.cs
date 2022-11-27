Console.WriteLine("This programm determines whether the number is even");
Console.WriteLine("Please, enter a number");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number = number * (-1);
    if (number % 2 == 1)
    {
        Console.WriteLine("The number is odd integer");
    }
    else 
    {
        Console.WriteLine("The number is even");
    }
}
else
{
if (number % 2 == 1)
    {
        Console.WriteLine("The number is odd integer");
    }
    else 
    {
        Console.WriteLine("The number is even");
    }
}