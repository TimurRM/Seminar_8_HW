
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8


Random random = new Random();
Console.Write("Input quantity of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input quantity of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];
int[] arrayRow = new int [rows];

GetArray(array);
ShowArray(array);
PrintSortArray(array);

void GetArray(int[,] newArray)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for(int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i,j] = random.Next(1,10);
        }
    }
}

void ShowArray(int[,] newArray)
{
     for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for(int j = 0; j < newArray.GetLength(1); j++)
        {
           Console.Write(newArray[i,j] + " ")  ;
        }
    Console.WriteLine();
    }
}

void PrintSortArray(int[,] newArray)
{
    Console.WriteLine("Sorted by rows array: ");

    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            for(int z = j + 1; z < newArray.GetLength(1); z++)
            {
                if(newArray[i,j] > newArray[i,z])
                {
                    int temp = newArray[i,j];
                    newArray[i,j] = newArray[i,z];
                    newArray[i,z] = temp;
                } 
            }  
            Console.Write(newArray[i,j] + " ");       
        }   Console.WriteLine();
    } 
}
