using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        string fullName = "Иванов Иван Иванович";
        int age = 16;
        string email = "ivanov@mail.ru";
        double programmingScore = 4.7;
        double mathsScore = 5;
        double physicsScore = 4.2;

        Console.WriteLine($"ФИО: {fullName}");
        Console.WriteLine($"Возраст: {age}");
        Console.WriteLine($"E-mail: {email}");
        Console.WriteLine($"Баллы по программированию: {programmingScore}");
        Console.WriteLine($"Баллы по математике: {mathsScore}");
        Console.WriteLine($"Баллы по физике: {physicsScore}");
        Console.ReadKey(true);

        // Подсчет суммы баллов

        double totalAmount = programmingScore + mathsScore + physicsScore;
        Console.WriteLine($"Сумма баллов: {totalAmount}");
        Console.ReadKey(true);
        double avgScore = (totalAmount) / 3;
        Console.WriteLine($"Средний балл: {avgScore.ToString("#.##")}");
        Console.ReadKey(true);
    }
}
