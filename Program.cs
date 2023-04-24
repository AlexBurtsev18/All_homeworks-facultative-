
// Console.WriteLine("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int quad = num2 * num2;

// if(quad == num1)
// {
//     Console.WriteLine("ДА!");
// }
// else
// {
//     Console.WriteLine("No!");
// }

// Task 1. Напишите программу, которая на вход принимает число N,
// а на выходе проказывает все целые числа в промежутке от -N до N. 

// Console.WriteLine("Input your positive number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int current = -num;
// while(current<=num)
// {
//     Console.Write(current + " ");
//     current++;
// }


// Task 2++. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.WriteLine("Input first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input a second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if(num1>num2) Console.WriteLine($"Число {num1} больше числа {num2}");
// else Console.WriteLine($"Число {num2} больше числа {num1}");

// Task 4++: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.WriteLine("Input a first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input a second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input a thirst number: ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// int max = 0;
// if(num1 > num2 & num1 > num3) max = num1;
// if(num2 > num1 & num2 > num3) max = num2;
// if(num3 > num1 & num3 > num2) max = num3;

// Console.WriteLine($"Максимальное число - {max}");

// Task 6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Console.WriteLine("Введите число: ");
// double num = Convert.ToDouble(Console.ReadLine());
// if(num % 2 == 0) Console.WriteLine("Это четное число!");
// else Console.WriteLine("Это НЕчетное число!");

// Также прикладываю вариант с Функцией/методом. 
// bool ProverkaChetnosti(int num)
// {
//     if (num % 2 == 0)
//     {
//         Console.WriteLine("Число четное!");
//         return true;
//     }
//     else
//     {
//         Console.WriteLine("Число НЕчетное!");
//         return false;
//     }
// }
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(ProverkaChetnosti(number));

// Task 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int i = 2;
// while(i < num)
// {
//     Console.Write(i + " ");
//     i+=2;
// }
