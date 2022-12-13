namespace pro100user;

public class MatrixUInt
{
    private uint[,] intArray { get; }
    private int n { get; } 
    private int m { get; }
    private int codeError { get; set; }
    private static int num_m { get; }

    public uint this[int i, int j]
    {
        get
        {
            if ((i >= n || i < 0) && (j >= m || j < 0))
            {
                codeError = -1;
            }

            return 0;
        }
        set { codeError = i; }
    }

    public MatrixUInt()
    {
        intArray = new uint[1, 1]{{0}};
        n = intArray.Length;
        m = 1;
    }
    
    public MatrixUInt(int n, int m)
    {
        intArray = new uint[n ,m];
        this.n = n;
        this.m = m;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                intArray[i, j] = 0;
            }
        }
    }
    
    public MatrixUInt(int n, int m, uint value)
    {
        intArray = new uint[n ,m];
        this.n = n;
        this.m = m;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                intArray[i, j] = value;
            }
        }
    }
    
    ~MatrixUInt()
    {
        Console.WriteLine("Диструктор MatrixUInt");
    }

    public void Enter()
    {
        Console.WriteLine("\nВведіть значення матриці:");
        try
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"Введіть matrix[{i}, {j}] значення: ");
                    intArray[i, j] = uint.Parse(Console.ReadLine());
                }
            }
        }
        catch (Exception e)
        {
            Console.Error.WriteLine("Ви ввели не вірне значення, попробуйте ще раз.");
        }
    }

    public void Print()
    {
        Console.WriteLine("\nЗначення матриці: ");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"{intArray[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    public void SetValueForAllElements(uint value)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                intArray[i, j] = value;
            }
        }
    }

    public static MatrixUInt operator +(MatrixUInt matrix)
    {
        for (int i = 0; i < matrix.n; i++)
        {
            for (int j = 0; j < matrix.m; j++)
            {
                matrix.intArray[i, j] = ++matrix.intArray[i, j];
            }
        }

        return matrix;
    }
    
    public static MatrixUInt operator -(MatrixUInt matrix)
    {
        for (int i = 0; i < matrix.n; i++)
        {
            for (int j = 0; j < matrix.m; j++)
            {
                matrix.intArray[i, j] = --matrix.intArray[i, j];
            }
        }

        return matrix;
    }
    
    public static MatrixUInt operator +(MatrixUInt matrix, int scalar)
    {
        for (int i = 0; i < matrix.n; i++)
        {
            for (int j = 0; j < matrix.m; j++)
            {
                matrix.intArray[i, j] = (uint)(matrix.intArray[i, j] + scalar);
            }
        }

        return matrix;
    }
    
    public static MatrixUInt operator -(MatrixUInt matrix, int scalar)
    {
        for (int i = 0; i < matrix.n; i++)
        {
            for (int j = 0; j < matrix.m; j++)
            {
                matrix.intArray[i, j] = (uint)(matrix.intArray[i, j] - scalar);
            }
        }

        return matrix;
    }
    
    public static MatrixUInt operator /(MatrixUInt matrix, int scalar)
    {
        for (int i = 0; i < matrix.n; i++)
        {
            for (int j = 0; j < matrix.m; j++)
            {
                matrix.intArray[i, j] = (uint)(matrix.intArray[i, j] / scalar);
            }
        }

        return matrix;
    }
    
    public static MatrixUInt operator *(MatrixUInt matrix, short scalar)
    {
        for (int i = 0; i < matrix.n; i++)
        {
            for (int j = 0; j < matrix.m; j++)
            {
                matrix.intArray[i, j] = (uint)(matrix.intArray[i, j] / scalar);
            }
        }

        return matrix;
    }
    
    public static MatrixUInt operator %(MatrixUInt matrix, short scalar)
    {
        for (int i = 0; i < matrix.n; i++)
        {
            for (int j = 0; j < matrix.m; j++)
            {
                matrix.intArray[i, j] = (uint)(matrix.intArray[i, j] % scalar);
            }
        }

        return matrix;
    }
}