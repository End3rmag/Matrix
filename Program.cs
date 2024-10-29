Console.WriteLine("Введите размерность квадротичной таблицы (N): ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное значение случайных чисел: ");
int minVal = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение случайных чисел: ");
int maxVal = Convert.ToInt32(Console.ReadLine());

int size = n;

int[,] A = new int[n, n];
int[,] B = new int[n, n];

Fill(A, minVal, maxVal,size);
Fill(B, minVal, maxVal,size);

Console.WriteLine("Матрица A: "); 
Print(A,size); 

Console.WriteLine("Матрица B: ");
Print(B,size);

Console.WriteLine("Выберите операцию:");
Console.WriteLine("1 - Сложение");
Console.WriteLine("2 - Вычитание");
int choice = Convert.ToInt32(Console.ReadLine());

switch (choice) 
{
    case 1: 
        
            int[,] sum = Plus(A, B, size);
            Console.WriteLine("Сумма матриц ровна: ");
            Print(sum,size);
        break;
        
    case 2:
            int[,] ras = Plus(A, B, size);
            Console.WriteLine("Сумма матриц: ");
            Print(ras,size);
        break;

    default:
        Console.WriteLine("Не верный выбор! Пожалуйста, выбирите 1 или 2");
        break;
}

static void Fill(int[,] matrix, int min, int max, int size)
{
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            matrix[i, j] = random.Next(min, max);
        }
    }
}

static void Print(int[,] matrix, int size)
{
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

static int[,] Plus(int[,] A, int[,] B, int size) 
{
    int[,] result = new int[size, size];
    for(int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++) 
        {
            result [i, j] = A[i, j] + B[i, j];
        }
    }
    return result;
}

static int[,] Minus(int[,] A, int[,] B, int size)
{
    int[,] result = new int[size, size];
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            result[i, j] = A[i, j] - B[i, j];
        }
    }
    return result;
}





