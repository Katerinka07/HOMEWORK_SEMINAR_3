/*
// Задача 19. Напишите программу, которая принимает на вход пятизначно число и проверяет,
// явлется ли оно палиндромом.
// */

int InputNum(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}
void CheckPalindrom(int number)
{
    if (number >= 10000)
    {
        int digit1 = number / 10000;
        int digit5 = number % 10;

        if (digit1 == digit5)
        {
            number = number / 10;
            int digit2 = (number / 100) % 10;
            int digit4 = number % 10;
            if (digit2 == digit4)
                Console.WriteLine($"Число '{number}' является палиндромом");
            else
                Console.WriteLine($"Число '{number}' не является палиндромом");
        }
        else
            Console.WriteLine($"Число '{number}' не является палиндромом");
    }
    else
        Console.WriteLine("Число не является пятзначным, повторите ввод.");
}
int number = InputNum("Введите пятизначное число: ");
CheckPalindrom(number);

// Второй вариант, для любого числа

int InputNum(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}
int number = InputNum("Введите целое число: ");
int rev = 0;
int Reverse(int number)
{
    while (number > 0)
    {
        int dig = number % 10;
        rev = rev * 10 + dig;
        number = number / 10;
    }
    return rev;
}
int res = Reverse(number);
if (number == res)
    Console.WriteLine($"Число '{number}' является палиндромом");
else
    Console.WriteLine($"Число '{number}' не является палиндромом");
