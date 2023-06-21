/*
Задача 21. Напишите программу, которая принимает
на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
*/
int InputNum(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine()!);
    return number;
}
int xA = InputNum("Введите координату x для точки А: ");
int yA = InputNum("Введите координату y для точки А: ");
int zA = InputNum("Введите координату z для точки А: ");
int xB = InputNum("Введите координату x для точки B: ");
int yB = InputNum("Введите координату y для точки B: ");
int zB = InputNum("Введите координату z для точки B: ");

double Root(int xA, int xB, int yA, int yB, int zA, int zB)
{
    double res1 = Math.Pow(xB - xA, 2);
    double res2 = Math.Pow(yB - yA, 2);
    double res3 = Math.Pow(zB - zA, 2);
    double res = Math.Sqrt(res1 + res2 + res3);
    return res;
}
double distance = Root(xA, xB, yA, yB, zA, zB);
Console.WriteLine(Math.Round(distance, 2));
