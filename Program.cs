
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

// Task 1++ seminara 2. Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// int CutNumber(int num)
// {
//     int hundreds = num / 100;
//     int unites = num % 10;
//     int result = hundreds * 10 + unites;
//     return result;
// }

// int randNumber = new Random().Next(100, 1000);
// int shortNumber = CutNumber(randNumber);

// Console.WriteLine($"New version of {randNumber} is {shortNumber}");

// Task 2 seminara 2. Напишите программу, которая выводит случайное число из отрезка от 10 до 99
//  и показывает наибольшую цифру этого числа.

// int ChooseNumber(int num)
// {
//     int decades = num / 10;
//     int units = num % 10;
//     if(decades > units) return decades;
//     else return units;
// }
// int number = new Random().Next(10, 100);
// Console.WriteLine(number);
// Console.WriteLine(ChooseNumber(number));

// Task 3++ seminara 2. Напишите программу, которая принимает 2 числа и определяет,
// является ли второе число кратным первому?

// bool Kratnost(int num1, int num2)
// {
//     if(num2 % num1 == 0)
//     {
//         Console.WriteLine("Yes");
//         return true;
//     }
//     else
//     {
//         Console.WriteLine("No");
//         return false;
//     }
// }
// Console.WriteLine("Input first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Kratnost(num1, num2);

// Task 4++. Напишите программу, которая принимает на вход число n и проверяет, кратно ли оно одновременно a и b.

// bool ProverkaKratnosti(int num, int a, int b)
// {
//     if(a % num == 0 && b % num == 0)
//     {
//         Console.WriteLine("Yes!");
//         return true;
//     }
//     else
//     {
//         Console.WriteLine("No!");
//         return false;
//     }
// }

// Console.WriteLine("Введите проверяемое число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число b: ");
// int b = Convert.ToInt32(Console.ReadLine());
// ProverkaKratnosti(num, a, b);

// Task 10++: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// int CutNumber(int num)
// {
//     num = num / 10 % 10;
//     return num;
// }
// Console.WriteLine("Input 3digits number: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int result = CutNumber(n);
// Console.WriteLine($"Вторая цифра числа {n} это {result}");

// Task 13++: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// bool CheckNumber(int num)
// {
//     if(num>100)
//     return true;
    
//     else
//     {
//         Console.WriteLine("Третьей цифры нет! Введите другое число!");
//         return false;
//     }
// }

// int CutNumber(int num)
// {
//     while(num>999) num = num / 10;
//     int cutNum = num % 10;
//     return cutNum;
// }
// Console.WriteLine("Введите ваше число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int cutNum = CutNumber(num);
// if(CheckNumber(num))
// {
//     Console.WriteLine($"Третья цифра вашего числа {num} это {cutNum}");
// }

// Task 15++: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

// bool CheckWeekend(int num)
// {
//     if(num != 0 && num<8) return true;
//     else
//     {
//         Console.WriteLine("Это не день недели!");
//         return false;
//     }
// }

// bool IsWeekend(int n)
// {
//     if(n > 5 && n <=7)
//     {
//         Console.WriteLine("Сегодня выходной!");
//         return true;
//     }
//     else
//     {
//         Console.WriteLine("Придется работать!");
//         return false;
//     }
// }
// Console.WriteLine("Введите цифру дня недели: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if(CheckWeekend(num))
// {
//     Console.WriteLine(IsWeekend(num));
// }

// Task 1++. Напишите программу, которая по заданному номеру четверти показывает
// диапазон возможных координат точек в этой четверти.

// void ShowRange(int quad)
// {
//     if(quad == 1) Console.WriteLine("x > 0 and y >0");
//     else if(quad == 2) Console.WriteLine("x < 0 and y > 0");
//     else if(quad == 3) Console.WriteLine("x < 0 and y < 0");
//     else if(quad == 4) Console.WriteLine("x > 0 and y < 0");
//     else Console.WriteLine("Wrong number of quadrant!");
// }

// Console.Write("Input number of quadrant: ");
// int quadrant = Convert.ToInt32(Console.ReadLine());

// ShowRange(quadrant);

// Task 1++. Напишите программу, которая принимает на вход координаты точки и выдает номер четверти,
//  в которой эта точка находится.

// void Quadrant(int numX, int numY)
// {
//     if(numX > 0 && numY > 0) Console.WriteLine("Ваша четверть - 1");
//     else if(numX < 0 && numY > 0) Console.WriteLine("Ваша четверть - 2");
//     else if(numX < 0 && numY < 0) Console.WriteLine("Ваша четверть - 3");
//     else if(numX > 0 && numY < 0) Console.WriteLine("Ваша четверть - 4");
//     else Console.WriteLine("Вы находитесь в точке 0");
// }

// Console.WriteLine("Введите координату X:");
// int numX = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y:");
// int numY = Convert.ToInt32(Console.ReadLine());
// Quadrant(numX, numY);


// Task 2. Напишите программу, кторая принимет на вход число и выдает таблицу квадратов чисел от 1 до N.
// void

// void Table(int num)
// {
//     int count = 1;
//     while(count<=num)
//     {
//         Console.WriteLine($"Квадрат {count} составляет {count*count}");
//         count++;
//     }
// }
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Table(num);

// Task 3. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2d пространстве.

// double Otrezok(double Ax, double Ay, double Bx, double By)
// {
//     double AC = Bx - Ax;
//     double BC = By - Ay;
//     double AB = Math.Sqrt(AC*AC + BC*BC);
//     return AB;
// }
// Console.WriteLine("Введите координату Ax: ");
// double Ax = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координату Ay: ");
// double Ay = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координату Bx: ");
// double Bx = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координату By: ");
// double By = Convert.ToDouble(Console.ReadLine());

// double result = Math.Round(Otrezok(Ax, Ay, Bx, By),2);
// Console.WriteLine($"расстояние между точками А и В составляет - {result}");

// Homework к семинару 3. 
// Task 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int Palindrom(int num)
{
    int revNum = 0;
    while(num>0)
    {
        revNum = revNum * 10 + num % 10;
        num = num / 10;
    }
    return revNum;
}
bool IsPalindrom(int num)
{
    int revNum = Palindrom(num);
    if(revNum == num)
    {
        Console.WriteLine("Это палиндром");
        return true;
    }
    else 
    {
        Console.WriteLine("Это Не палиндром");
        return false;
    }
}
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
IsPalindrom(num);



