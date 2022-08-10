// Задача 58. Заполнить спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1  2  3  4
// 12 13 14 5
// 11 16 15 6
// 10  9  8  7


int rows = 4;
int columns = 4;
int[,] array = new int[rows,columns];
int max = 0;

GetArray(array);
PrintArray(array);

int MaxElement(int[,] Massive)
{ 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (Massive[i,j] > max)
            {
                max = Massive[i,j];
            }
        }
    }
    return max;
}

void GetArray(int[,] Massive)
{
    int rows = Massive.GetLength(0);
    int columns = Massive.GetLength(1);

    for (int j = 0; j < columns; j++)
    {
        int i = 0;
        Massive[i,j] = j + 1;
        MaxElement(Massive);
    } 
 
        for (int i = 1; i < rows; i++)
        {
            int j = columns - 1;
            Massive[i,j] = max + 1;
            MaxElement(Massive);
        }
  
            for (int j = columns - 2; j > 0; j--)
            {
                int i = rows - 1;
                Massive[i,j] = max + 1;
                MaxElement(Massive);
            }
    
                for (int i = rows - 1; i > 0; i--)
                {
                    int j = 0;
                    Massive[i,j] = max + 1;
                    MaxElement(Massive);
                }
    
                    for (int j = columns - 3; j < columns - 1; j++)
                    {
                        int i = rows - 3;
                        Massive[i,j] = max + 1;
                        MaxElement(Massive);
                    }
                    
                        for (int j = columns - 2; j > 0; j--)
                        {
                            int i = rows - 2;
                            Massive[i,j] = max + 1;
                            MaxElement(Massive);
                        }
}

void PrintArray(int[,] ourArray)
{
     for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < ourArray.GetLength(1); j++)
        {
           Console.Write(ourArray[i,j] + "\t")  ;
        }
        Console.WriteLine();
    }
}
