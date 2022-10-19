

/* 
1 Пользователь вводит с клавиатуры M чисел. 
2 Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/






int CountGreaterZero(int[] InputInternalArray)
{
    int Result = 0;
    for (int i = 0; i < InputInternalArray.Length; i++)
    {
        if (InputInternalArray[i] > 0)
        {
            Result++;
        }
    }
    return Result;
}

void PrintArray(int[] InputInternalArray)
{
    Console.Write("Массив = ");
    Console.Write("[");
    for (int i = 0; i < InputInternalArray.Length; i++)
    {
        Console.Write(InputInternalArray[i]);
        if (i < InputInternalArray.Length - 1) { Console.Write(", "); }
    }
    Console.Write("]");
    Console.WriteLine();
}

int[] MadeAndFillArray(int InpArrayLength)
{
    int[] InternalArray = new int[InpArrayLength];
    for (int i = 0; i < InternalArray.Length; i++)
    {
        Console.Write($"Введите число с индексом №{i} = ");
        InternalArray[i] = int.Parse(Console.ReadLine());
    }
    return InternalArray;
}





Console.Write("Введите количество чисел в массиве: ");
int NomberOfNombersInArray = int.Parse(Console.ReadLine());


int[] AArray = MadeAndFillArray(NomberOfNombersInArray);

PrintArray(AArray);

Console.Write("Числа больше 0 в массиве: ");
Console.Write(CountGreaterZero(AArray));















/* int[] InputNStirngArray()
{
    Console.WriteLine();

    bool inStopCycle = false;
    int[] InternalArray = null;

    int TempInt = 0;
    int Iteration = 0;

    Console.WriteLine("Начата процедура ввода массива. Введите 'stop' (буква) чтобы прекратить ввод");

    while (inStopCycle == false)
    {
        Console.Write($"Введите число с индексом №{Iteration} = ");

        var InpotNomber = Console.ReadLine();



        if (InpotNomber != "stop")
        {
            //InternalArray.Resize(ref InternalArray[], InternalArray.Length + 1);
            //InternalArray[InternalArray.Length] = int.Parse(InpotNomber);
            // InternalArray.Add(int.Parse(InpotNomber));
            InternalArray[InternalArray.Length] = int.Parse(InpotNomber);
        }
        else
        {
            Console.WriteLine("Процедура ввода массива Закончена.");
            inStopCycle = true;
        }

        //Console.WriteLine("цикл ввода закончен ------------------------");
        Iteration++;

    }
    Console.WriteLine();
    return InternalArray;
} */

