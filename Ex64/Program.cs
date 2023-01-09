//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.


string Naturalnumber(int N, int b)


{
 //string result = string.Empty 

if (N>=b) return $"{N}" + Naturalnumber (N-1, b);
else return String.Empty;


}
Console.WriteLine(Naturalnumber(8, 1));





