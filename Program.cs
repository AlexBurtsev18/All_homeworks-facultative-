
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
// Task 19++. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// int Palindrom(int num)
// {
//     int revNum = 0;
//     while(num>0)
//     {
//         revNum = revNum * 10 + num % 10;
//         num = num / 10;
//     }
//     return revNum;
// }
// bool IsPalindrom(int num)
// {
//     int revNum = Palindrom(num);
//     if(revNum == num)
//     {
//         Console.WriteLine("Это палиндром");
//         return true;
//     }
//     else 
//     {
//         Console.WriteLine("Это Не палиндром");
//         return false;
//     }
// }
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// IsPalindrom(num);

// Task 21++. Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

// double Distance(double Ax, double Ay, double Az, double Bx, double By, double Bz)
// {
//     double ACx = Bx - Ax;
//     double ACy = By - Ay;
//     double ACz = Bz - Az;
//     double result = Math.Sqrt(ACx*ACx + ACy*ACy + ACz*ACz);
//     return result;
// }
// Console.WriteLine("Введите x координату точки A:");
// double Ax = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите y координату точки A:");
// double Ay = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите z координату точки A:");
// double Az = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите x координату точки B:");
// double Bx = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите y координату точки B:");
// double By = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите z координату точки B:");
// double Bz = Convert.ToDouble(Console.ReadLine());
// double result = Math.Round(Distance(Ax, Ay, Az, Bx, By, Bz),2);
// Console.WriteLine($"Расстояние между точками A и B d 3D пространстве составляет {result}");

// Task 23++. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// void TablCube(double num)
// {
//     double count = 1;
//     while(count<=num)
//     {
//         Console.WriteLine(Math.Pow(count,3));
//         count++;
//     }
// }
// Console.Write("Введите число: ");
// double num = Convert.ToDouble(Console.ReadLine());
// TablCube(num);

// Seminar 4. 
// Task 1++. Напишите программу, которая принимает на вход число А и выдает сумму чисел от 1 до А.

// void Summa(int num)
// {
//     int count = 1;
//     int sum = 0;
//     while(count <=num)
//     {
//         sum += count;
//         count++;
//     }
//     Console.WriteLine(sum);
// }
// Console.WriteLine("Input your number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Summa(num);

// Task 2++. Напишите программу, которая принимает на вход число А и выдает произведение чисел от 1 до А.

// void Faktorial(int num)
// {
//     int composition = 1;
//     int count = 1;
//     while(count<=num)
//     {
//     composition *= count;
//     count++;
//     }
//     Console.Write(composition);
// }
// Console.WriteLine("Input your number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Faktorial(num);

// Homework at seminar 4.
// Task 25++: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// double Grade(double A, double B)
// {
//     double result = Math.Pow(A, B);
//     return result;
// }
// Console.WriteLine("Input your number A: ");
// double A = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input your number A: ");
// double B = Convert.ToDouble(Console.ReadLine());
// double res = Math.Round(Grade(A,B));
// Console.WriteLine($"число {A} в степени {B} это {res}");

// Task 27++: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int SumDigits(int num)
// {
//     int summa = 0;
//     if(num == 0) summa = 0;
//     while(num != 0)
//     {
//         summa = summa + (num % 10);
//         num /= 10;
//     }
//     return summa;
// }
// Console.WriteLine("Input your number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int res = SumDigits(num);
// Console.WriteLine(res);

// Task 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// void Array(int[] array)
// {
//     int length = array.Length;
//     int index = 0;
//     while(index<length)
//     {
//         array[index] = new Random().Next(1,20);
//         index++;
//     }
// }

// void PrintArray(int[] collection)
// {
//     int count = collection.Length;
//     int i = 0;
//     while(i<count)
//     {
//         Console.WriteLine(collection[i]);
//         i++;
//     }
// }
//  int[] array = new int[8];
//  Array(array);
//  PrintArray(array);

// Seminar 5. 

// int[] CreateRanndomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];

//     for(int i = 0; i<size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i<array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int GetSumOfNegatives(int[] array)
// {
//     int sum = 0;

//     for(int i = 0; i<array.Length; i++)
//         if(array[i]<0) 
//             sum += array[i];
//     return sum;
// }

// Console.Write("Input a quantity of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRanndomArray(size, min, max);
// ShowArray(myArray);

// Console.Write("Sum of negatives elements is " + GetSumOfNegatives(myArray));

// Task 1. Напишите программу для замены элементов массива. Положительные элементы заменяются на отрицательные и наоборот

// int[] MakePositive(int[] array)
// {
//     for(int i = 0; i<array.Length; i++)
//     {
//         array[i] *= (-1);
//     }
//     return array;
// }

// Console.Write("Input a quantity of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRanndomArray(size, min, max);
// ShowArray(myArray);
// int[] newArray = MakePositive(myArray);
// ShowArray(newArray);

// Task 2. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// bool CheckNumber(int[] array, int find)
// {
//     for(int i = 0; i<array.Length; i++)
//         if(array[i] == find)
//         {
//             Console.WriteLine("Данное число есть в списке!");
//             return true;
//         }
//     Console.WriteLine("Данное числа в списке НЕТ!");
//     return false;
// }
// Console.Write("Input a quantity of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input target number: ");
// int find = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRanndomArray(size, min, max);
// ShowArray(myArray);
// CheckNumber(myArray, find);

// Task 3. Задайте одномерный массив из m случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в промежутка от a до b.

// int Quantity(int[] array, int a, int b)
// {
//     int sum = 0;
//     for(int i = 0; i<array.Length; i++)
//         if(array[i]> a && array[i]< b) sum++;
//     return sum;
// }
// Console.Write("Input a quantity of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input mim border: ");
// int minBorder = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max border: ");
// int maxBorder = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRanndomArray(size, min, max);
// ShowArray(myArray);
// int result = Quantity(myArray, minBorder, maxBorder);
// Console.WriteLine($"Количество элементов в пределах {minBorder} и {maxBorder} составляет {result}");

// Task 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
// в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Homework at seminar 5. 
// Task 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] CreateRanndomArray(int size)
// {
//     int[] array = new int[size];

//     for(int i = 0; i<size; i++)
//         array[i] = new Random().Next(100, 1000);
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i<array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.WriteLine();
// }

// int CheckParity(int[] array)
// {
//     int count = 0;
//     for(int i = 0; i<array.Length; i++)
//         if(array[i] % 2 == 0) count++;
//     return count;
// }

// Console.WriteLine("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRanndomArray(size);
// ShowArray(myArray);
// Console.WriteLine($"Среди выведенных чисел {CheckParity(myArray)} четных");

// Task 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// int[] CreateRanndomArray(int size)
// {
//     int[] array = new int[size];

//     for(int i = 0; i<size; i++)
//         array[i] = new Random().Next(10, 100);
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i<array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.WriteLine();
// }

// int SummaNotParityNumbers(int[] array)
// {
//     int sum = 0;
//     for(int i=0; i<array.Length; i = i+2)
//         sum += array[i];
//     return sum;
// }

// Console.WriteLine("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRanndomArray(size);
// ShowArray(myArray);
// Console.WriteLine($"Сумма чисел на нечетных позициях составлет {SummaNotParityNumbers(myArray)}.");

// Task 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// int[] CreateRanndomArray(int size)
// {
//     int[] array = new int[size];

//     for(int i = 0; i<size; i++)
//         array[i] = new Random().Next(-100, 100);
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i<array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.WriteLine();
// }

// int FindMinMaxNumbers(int[] array)
// {
//     int max = array[0];
//     int min = array[0];
//     for(int i = 0; i<array.Length; i++)
//         if(array[i]>max) max = array[i];
//     for(int i = 0; i<array.Length; i++)
//         if(array[i]<min) min = array[i];  
//     int result = max - min;
//     return result;  
// }

// Console.WriteLine("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateRanndomArray(size);
// ShowArray(myArray);
// int res = FindMinMaxNumbers(myArray);
// Console.WriteLine($"Разница между максимальным числом составляет {res}");

// Seminar 6. 

// Task 1. 

// int[] CreateRanndomArray(int size)
// {
//     int[] array = new int[size];

//     for(int i = 0; i<size; i++)
//         array[i] = new Random().Next(100, 1000);
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i<array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.WriteLine();
// }

// void ReverseArray(int[] array)
// {
//     for(int i = 0, j = array.Length-1; i<j; i++, j--)
//     {
//         int temp = array[i];
//         array[i] = array[j];
//         array[j] = temp;
//     }
// }



// Console.WriteLine("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateRanndomArray(size);
// ShowArray(myArray);
// ReverseArray(myArray);
// ShowArray(myArray);

// Task 2. Напишите программу, которая принимает на вход 3 числа и проверяет, 
// может ли существовать треугольник с такими сторонами.
// bool. 3 аргумента.

// bool Triangle(int a, int b, int c)
// {
//     if(a+b<c) return false;
//     if(a+c<b) return false;
//     if(b+c<a) return false;
//     else return true;
// }
// Console.WriteLine("Введите число стороны a ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число стороны b ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число стороны c ");
// int c = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Triangle(a,b,c));

// Task 3. Задать ряд Fibonacci.
// массив.
// int[] Fibonacci(int n)
// {
//     int[] array = new int[n];
//     array[0] = 0;
//     array[1] = 1;
//     for(int i = 2; i<n; i++)
//     {
//         array[i] = array[i-1] + array[i-2];
//     }
//     return array;
// }

// Console.WriteLine("Введите количество элементов массива: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] array = Fibonacci(num);
// ShowArray(array);


// Task 4. напишите программу, которая будет осуществлять копирование массива поэлементно. 

// void Copy(int[] array, int[] copiedArray)
// {
//     for(int i = 0; i<array.Length; i++)
//     copiedArray[i] = array[i];
// }

// int[] array = {1, 5, 4, 12, 15};
// int[] copiedArray = new int[array.Length];

// Copy(array, copiedArray);
// ShowArray(array);
// ShowArray(copiedArray);

// Homework at seminar 7. 

// Task 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// int Prompt(string message)
// {
//     Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }

// int[] InputArray(int length)
// {
//     int[] array = new int[length];
//     for(int i = 0; i<array.Length; i++)
//         array[i] = Prompt($"Введите {i + 1}-й элемент: ");
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for(int i = 0; i<array.Length; i++)
//         Console.WriteLine($"a[{i}] = {array[i]}");
// }


// int CountPositiveNumbers(int[] array)
// {
//     int count = 0;
//     for(int i = 0; i<array.Length; i++)
//         if(array[i]>0) count++;
//     return count;
// }

// int length = Prompt("Введите количество элементов > ");
// int[] array;
// array = InputArray(length);
// PrintArray(array);
// int result = CountPositiveNumbers(array);
// Console.WriteLine($"Количество чисел больше 0 - {result}");

// Task 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());
 
 
var x = (b2 - b1) / (k1 - k2);
var y = k1 * x + b1;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
Console.WriteLine($"Пересечение в точке: ({x};{y})");