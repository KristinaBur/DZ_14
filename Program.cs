/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

/*Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 100);
PrintArray(array);

Console.WriteLine("Отсортированный массив:");

SortArray(array);
PrintArray(array);

//----------Методы----------
int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}
*/
/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);          

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);      
Console.WriteLine();
int[,] array = GetArray(rows, columns, 0, 10); 
PrintArray(array);
Console.WriteLine(); 
SumLine(array);


//---------Методы----------
int[,] GetArray(int m, int n, int minValue, int maxValue){ 
    int[,] result = new int[m,n]; 
    for(int i = 0; i < m; i++) 
    { 
    for(int j = 0; j < n; j++) 
    { 
    result[i,j] = new Random().Next(minValue, maxValue + 1); 
    } 
    } 
    return result; 
} 
 
void PrintArray(int[,] array)
{ 
    for(int i = 0; i < array.GetLength(0); i++) 
    { 
    for(int j = 0; j < array.GetLength(1); j++) 
    { 
    Console.Write($"{array[i,j]} "); 
    } 
    Console.WriteLine(); 
    } 
} 

void SumLine(int[,] array)
{
    int indexLine = 0;
    int minsum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i,j];
        }
        if (i==0)
        {
            minsum=sum;
        }
        else if (sum<minsum)
        {
            minsum=sum;
            indexLine = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов -> {indexLine+1} ");
}

