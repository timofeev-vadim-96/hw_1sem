Console.WriteLine("This programm compare two numbers and write the largest number of them");
Console.WriteLine("Please, enter the first number");
int FirstNumb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please, enter the second number");
int SecondNumb = Convert.ToInt32(Console.ReadLine());
if (FirstNumb == SecondNumb)
{
    Console.WriteLine("The numbers are equal");
}
else
{
    if (FirstNumb > SecondNumb)
    {
        Console.WriteLine(FirstNumb + " is the largest number");
        Console.WriteLine(SecondNumb + " is the smallest number");
    }
    else 
    {
        Console.WriteLine(SecondNumb + " is the largest number");
        Console.WriteLine(FirstNumb + " is the smallest number");
    }
}