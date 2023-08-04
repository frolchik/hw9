/*Task1. Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.*/


/*
void ShowNums(int num)
{
    Console.Write(num + " ");
    if(num > 1)ShowNums(num - 1);
}

ShowNums(7);
*/

/* Task2. Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
*/
/*

int SumElement(int m, int n)
{
    if(m==n) return n;
    else return m + SumElement(m + 1, n);
    }

Console.WriteLine ("Input a number M: ");
int m = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input a number N: ");
int n = Convert.ToInt32 (Console.ReadLine());

SumElement(m, n);

Console.Write($"Сумма элементов: {SumElement(m, n)}");

*/

/* Task3. Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.
*/

int Akkerman(int m, int n)
{
    if(m==0) return n + 1;
    else if (n == 0) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m,n - 1));
    }

Console.WriteLine ("Input a number M: ");
int m = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input a number N: ");
int n = Convert.ToInt32 (Console.ReadLine());

Akkerman(m, n);

Console.Write($" Функция Аккермана: {Akkerman(m, n)}");




