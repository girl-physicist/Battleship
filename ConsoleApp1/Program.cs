using ConsoleApp1;
using System.Collections;
using System.Reflection.Emit;

internal class Program
{
    public static int[] array1;
    public static double[] doubleArray;
    private static void Main(string[] args)
    {


        ShowTask2();   
        ProgramStart programStart = new ProgramStart();
        programStart.Start();
        Task1();
        CreateArray();
        ResetArrayToZero();
        FindElement();
    }

    static void ShowTask2()
    {
        Console.WriteLine("jksdhvfkjesrhvg");
    }
    static void Task1()
    {
        ArrayList al = new ArrayList();

        al.Add(5);
        al.Add(-2);
        al.Add(10);
        al.Add(0);
        al.Add(-8); // al = [5, -2, 10, 0, -8]

        al.Sort();  // al = [-8, -2, 0, 5, 10]

    }
    static void CreateArray()
    {
        array1 = new int[100];
        // объявление массива из 50 вещественных чисел - способ 2
        float[] B = new float[50];
    }
    static void ResetArrayToZero()
    {
        // обнуление одномерного массива из 100 вещественных чисел
        // объявить массив
        doubleArray = new double[100];

        // обнулить массив
        for (int i = 0; i < doubleArray.Length; i++) // D.Length - количество элементов в массиве
            doubleArray[i] = 0;
    }
    static void FindElement()
    {
        // поиск заданного элемента в одномерном массиве
        array1 = new int[10];
        bool presence; // результат: если true, то элемент присутствует в массиве

        // заполнение массива произвольными значениями
        for (int i = 0; i < 10; i++)
            array1[i] = i + i * i;

        int num; // num - искомый элемент
        num = 42;

        // поиск
        presence = false;
        for (int i = 0; i < 10; i++)
            if (num == array1[i])
                presence = true;
    }

    static void Task10()
    {
        // подсчет количества вхождений заданного элемента в одномерном массиве
        int[] M;
        M = new int[20];

        // заполнение массива произвольными значениями
        for (int i = 0; i < 20; i++)
            M[i] = i * 2 - i * i;

        int n; // заданный элемент
        int k; // результат - количество вхождений
        n = 0;

        k = 0;
        for (int i = 0; i < 20; i++)
            if (n == M[i])
                k++;

        // k = 2
    }

    static void Task11()
    {
        // сортировка методом вставки по возрастанию
        // объявление массива из 10 вещественных чисел
        float[] A = new float[10];

        // заполнение элементов массива произвольными значениями

        // ...

        // сортировка
        for (int i = 0; i < 9; i++)
            for (int j = i; j >= 0; j--)
                if (A[j] > A[j + 1])
                {
                    float t = A[j];
                    A[j] = A[j + 1];
                    A[j + 1] = t;
                }
    }

    static void Task21()
    {
        // объявление и использование массива вещественных чисел размером 3*4
        float[,] M = new float[3, 4]; // выделить память для массива

        // заполнение массива произвольными значениями
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 4; j++)
                M[i, j] = (float)(i * 0.2 + j * 0.3);

        // запись значений в отдельные ячейки массива
        M[0, 1] = 0.35f;
        M[2, 2] = 1.45f;
    }
}