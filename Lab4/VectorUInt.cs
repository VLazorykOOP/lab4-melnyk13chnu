namespace pro100user;

public class VectorUInt
{
    private uint[] intArray { get; }
    private uint size { get; }
    private int codeError { get; set; }
    private static uint num_vec { get; }

    public uint this[int i]
    {
        get
        {
            if (size >= i || i < 0)
            {
                codeError = -1;
            }

            return 0;
        }
        set { codeError = i; }
    }

    public VectorUInt()
    {
        intArray = new uint[1]{0};
        size = (uint)intArray.Length;
    }
    
    public VectorUInt(uint size)
    {
        intArray = new uint[size];
        this.size = size;
        for (int i = 0; i < size; i++)
        {
            intArray[i] = 0;
        }
    }
    
    public VectorUInt(uint size, uint number)
    {
        intArray = new uint[size];
        this.size = size;
        for (int i = 0; i < size; i++)
        {
            intArray[i] = number;
        }
    }
    
    ~VectorUInt()
    {
        Console.WriteLine("Диструктор VectorUInt");
    }

    public void Enter()
    {
        Console.WriteLine("\nВведіть значення вектору:");
        try
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Введіть {i} значення: ");
                intArray[i] = uint.Parse(Console.ReadLine());
            }
        }
        catch (Exception e)
        {
            Console.Error.WriteLine("Ви ввели не вірне значення, попробуйте ще раз.");
        }
    }

    public void Print()
    {
        Console.WriteLine("\nЗначення вектору: ");
        foreach (uint value in intArray)
        {
            Console.WriteLine($"{value} ");
        }
    }

    public void SetValueForAllElements(uint value)
    {
        for (int i = 0; i < size; i++)
        {
            intArray[i] = value;
        }
    }

    public static VectorUInt operator +(VectorUInt vector)
    {
        for (int i = 0; i < vector.size; i++)
        {
            vector.intArray[i] = ++vector.intArray[i];
        }

        return vector;
    }
    
    public static VectorUInt operator -(VectorUInt vector)
    {
        for (int i = 0; i < vector.size; i++)
        {
            vector.intArray[i] = --vector.intArray[i];
        }

        return vector;
    }
    
    public static VectorUInt operator +(VectorUInt vector, int scalar)
    {
        for (int i = 0; i < vector.size; i++)
        {
            vector.intArray[i] = (uint)(vector.intArray[i] + scalar);
        }

        return vector;
    }
    
    public static VectorUInt operator -(VectorUInt vector, int scalar)
    {
        for (int i = 0; i < vector.size; i++)
        {
            vector.intArray[i] = (uint)(vector.intArray[i] - scalar);
        }

        return vector;
    }
    
    public static VectorUInt operator /(VectorUInt vector, int scalar)
    {
        for (int i = 0; i < vector.size; i++)
        {
            vector.intArray[i] = (uint)(vector.intArray[i] / scalar);
        }

        return vector;
    }
    
    public static VectorUInt operator *(VectorUInt vector, short scalar)
    {
        for (int i = 0; i < vector.size; i++)
        {
            vector.intArray[i] = (uint)(vector.intArray[i] / scalar);
        }

        return vector;
    }
    
    public static VectorUInt operator %(VectorUInt vector, short scalar)
    {
        for (int i = 0; i < vector.size; i++)
        {
            vector.intArray[i] = (uint)(vector.intArray[i] % scalar);
        }

        return vector;
    }
}