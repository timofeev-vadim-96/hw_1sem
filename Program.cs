Console.WriteLine("This programm compare 3 numbers and print the largest number of them");
Console.WriteLine("Please, enter the first number");
int FirstNumb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please, enter the second number");
int SecondNumb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please, enter the third number");
int ThirdNumb = Convert.ToInt32(Console.ReadLine());
int max = FirstNumb;
if (FirstNumb == SecondNumb)
{
    if (SecondNumb == ThirdNumb)
    {
        Console.WriteLine("The numbers are equal");
    }
    else
    {
        if (max > SecondNumb)
        {
            if (max > ThirdNumb)
            {
                Console.WriteLine(max + " is the largest number");
            }
            else
            {
                max = ThirdNumb;
                Console.WriteLine(max + " is the largest number");
            }
        }
        else
        {
            max = SecondNumb;
            if (max > ThirdNumb)
            {
                Console.WriteLine(max + " is the largest number");
            }
            else
            {
                max = ThirdNumb;
                Console.WriteLine(max + " is the largest number");
            }
        }
    }
}