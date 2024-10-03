using System;

class TimeCalculator
{
    static void Main(string[] args)
    {
        // Запрашиваем у пользователя количество секунд
        Console.Write("Введите количество секунд: ");
        int seconds = Convert.ToInt32(Console.ReadLine());

        // Вызываем метод CalculateTime с полученным количеством секунд
        CalculateTime(seconds);
    }

    static void CalculateTime(int seconds)
    {
        // Вычисляем количество часов, прошедших с начала суток
        int hours = seconds / 3600; // 3600 - количество секунд в часе

        // Вычисляем количество минут, прошедших с начала часа
        int minutes = (seconds % 3600) / 60; // 60 - количество секунд в минуте

        // Выводим результат на консоль
        Console.WriteLine($"{hours} часов и {minutes} минут прошло.");
    }
}