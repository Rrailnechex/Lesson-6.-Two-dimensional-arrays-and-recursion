



/*
Напишите программу,
которая найдёт точку пересечения двух прямых,
заданных уравнениями
y = k1 * x + b1,
y = k2 * x + b2;

значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/


Console.Write("Введите константу b1: ");
int b1 = int.Parse(Console.ReadLine());

Console.Write("Введите константу k1: ");
int k1 = int.Parse(Console.ReadLine());

Console.Write("Введите константу b2: ");
int b2 = int.Parse(Console.ReadLine());

Console.Write("Введите константу k2: ");
int k2 = int.Parse(Console.ReadLine());







double SolveSmalUravnenie(int b, int k, double x)
{
    double y = k * x + b;
    return y;
}




double[] SolveBigUravnenie(int b1, int k1, int b2, int k2)
{
    double[] CoordinatesXY = new double[2];
    bool StopCycle = false;
    double x = -100.00;

    double RX = 0;
    double RY = 0;

    while (StopCycle != true)
    {
        RX = SolveSmalUravnenie(b1, k1, x);
        RY = SolveSmalUravnenie(b2, k2, x);

        RX = Math.Round(RX, 2);
        RY = Math.Round(RY, 2);


        if (RX == RY)
        {
            Console.WriteLine("Процедура цикла Закончена.");
            StopCycle = true;
        }

        if (x > 100.00)
        {
            Console.WriteLine("точка пересечения очень далеко");
            StopCycle = true;
        }

        Console.WriteLine($"X={Math.Round(x, 2)} A={RX}  B={RY}");

        x += 0.01;
    }

    CoordinatesXY[0] = RX;
    CoordinatesXY[1] = RY;

    return CoordinatesXY;
}






Console.WriteLine("----------------------");

double[] AArrayXY = new double[2];
AArrayXY = SolveBigUravnenie(b1, k1, b2, k2);

Console.WriteLine("----------------------");

Console.WriteLine($"Координаты пересечения: ({AArrayXY[0]};{AArrayXY[1]})");
