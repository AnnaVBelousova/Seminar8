//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int Naturalnumber(int M, int N)
{


if (M==N) return M;
else return M + Naturalnumber (M+1, N);


}
Console.WriteLine(Naturalnumber(2, 3));
