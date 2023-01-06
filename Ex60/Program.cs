//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
int a = new Random().Next(1,10);
int b = new Random().Next(1,10);
int c = new Random().Next(1,10);
int [, , ]array = new int [a, b, c];

void Printarray (int[, ,]matrix)

{
for (int z = 0; z< matrix.GetLength(2); z ++)
{
for (int rows = 0; rows < matrix.GetLength(0); rows ++)
{
    for (int column = 0; column < matrix.GetLength(1); column ++)
    {
       Console.Write($" {matrix[rows, column, z]}");
    }
    Console.WriteLine();
}

}
}

// метод заполнения двумерного массива
void FillArray (int[, ,]matrix)
{
    for (int z = 0; z< matrix.GetLength(2); z ++)
    {
    for (int i  = 0; i< matrix.GetLength(0); i++)
    {
        for (int j  = 0; j< matrix.GetLength(1); j++)
       
        {
           matrix[i,j, z] = new Random().Next(1,10); 
        }
    }
}
}

void Adress(int[, ,]matrix)

{
int i = 0;
int j = 0;
int z = 0;
for (z = 0; z< matrix.GetLength(2); z ++)
{
for (i = 0; i < matrix.GetLength(0); i ++)
{
    for (j = 0; j < matrix.GetLength(1); j ++)
    {
       Console.Write($"{matrix[i, j, z]}");
       Console.Write($"({i},{j},{z})");
    }

    Console.WriteLine();

}

}

}


FillArray(array);
Printarray(array);
Adress(array);

