int ReadInt(string argument) 
{
    Console.Write(argument);
    int i;
    while (!int.TryParse(Console.ReadLine(), out i))
    {
        System.Console.WriteLine("Это не число!");
        Console.Write(argument);
    }
    return i;
}

double[,] FillFrrayMatrix(double[,] matr) 
{
    Random rnd =new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = Math.Round(rnd.Next(0, 10) + rnd.NextDouble(), 2);
        }
    }
    return matr;
}

void PrintArrayMatrix(double[,] matr)  
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}




int m = ReadInt("Введите количество столбцов ");
int n = ReadInt("Введите количество строк ");
double[,] matrix = new double[m ,n];
FillFrrayMatrix(matrix);
PrintArrayMatrix(matrix);