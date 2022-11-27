// // // Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

// // // Например:
// // // 4 -> 16 
// // // -3 -> 9 
// // // -7 -> 49

// // Console.WriteLine("Введите число");
// // int number = Convert.ToInt32(Console.ReadLine());
// // int result = number*number;
// // Console.WriteLine(result);
// Console.Write("Введите первое число: "); // Текст-подсказка, которая помогает получить число
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: "); // Текст-подсказка, которая помогает получить число
// int secondNumber = Convert.ToInt32(Console.ReadLine());
// if (secondNumber * secondNumber == firstNumber)
// {
//     System.Console.WriteLine("Первое число является квадратом второго");
// }
// else System.Console.WriteLine("Первое число НЕ является квадратом второго");

// 5. Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"
// int positiveNumber = Convert.ToInt32(Console.ReadLine()); // N

// int negativeNumber = positiveNumber * (-1); // -5 = 5 * (-1), -N

// while (negativeNumber <= positiveNumber) // пока условие истинно
// {
//     Console.Write(negativeNumber + " ");
//     negativeNumber++;  // negativeNumber = negativeNumber + 1
//     // negativeNumber+=1
// }