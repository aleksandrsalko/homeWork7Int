/*Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
  и возвращает значение этого элемента или же указание, что такого элемента нет.
  Например, задан массив:
  1 4 7 2
  5 9 2 3
  8 4 2 4
  17 -> такого числа в массиве нет
*/

int Input(string output)
{
  Console.Write(output);
  return Convert.ToInt32(Console.ReadLine());
}

int positionM = Input("Введите позицыю m: ");
int positionN = Input("Введите позицыю n: ");


int[,] numbers = new int[5,5];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
ElementArray(numbers);


void FillArrayRandomNumbers(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array [i,j] = Convert.ToInt32(new Random().Next(0, 10));
    }
  }
}

void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
  Console.WriteLine("");
  }
}

void ElementArray(int[,] array)
{
   if (positionM < 0 
   || positionM > array.GetLength(0) - 1 
   || positionN < 0 
   || positionN > array.GetLength(1) - 1)
   {
     Console.WriteLine("Такого числа в массиве нет");
   }
   else
   {
     Console.WriteLine($"Значение элемента массива [{positionM}, {positionN}] = {array[positionM, positionN]}");
   }
}