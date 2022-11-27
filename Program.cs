Console.WriteLine("This programm outputs all even numbers from 1 to yours");
Console.WriteLine("Please, enter a number");
int number = Convert.ToInt32(Console.ReadLine());
int StartNumber = 2;
if (number < 0)
{
    Console.WriteLine("Your number is less then 0");
}
else 
{
    if (number <= 1)
    {
        Console.WriteLine("Your number is 0 or 1, and there are no even numbers from 1 to your");
    }
    else
    {
        while (StartNumber <= number)
        {
        Console.Write(StartNumber + " ");
        StartNumber = StartNumber + 2;
        }
    }
    
}