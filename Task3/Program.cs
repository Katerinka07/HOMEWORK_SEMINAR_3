/*Задача 23. Напишите программу, которая принимает на вход число (N)
и выдаёт таблицу кубов чисел от 1 до N.
*/
int InputNum(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}
int number = InputNum("Введите целое число: ");
for (int i = 1; i <= number; i++)
{
    Console.Write(Math.Pow(i, 3));
    if (i < number)
        Console.Write(", ");
    else
        Console.Write(".");
}
