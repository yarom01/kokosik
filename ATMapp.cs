using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ATM
{
    static void Main(string[] args)
    {
        decimal balance = 1000.00m; // Начальный баланс

        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Банкомат ===");
            Console.WriteLine("1. Показать баланс");
            Console.WriteLine("2. Вывести деньги");
            Console.WriteLine("3. Выход");
            Console.Write("Выберите опцию: ");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    ShowBalance(balance);
                    break;
                case "2":
                    balance = WithdrawMoney(balance);
                    break;
                case "3":
                    Console.WriteLine("Спасибо за то что используете банкомат. До свидания!");
                    return;
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                    break;
            }

            Console.WriteLine("\nНажмите любую клавишу чтобы продолжить...");
            Console.ReadKey();
        }
    }

    static void ShowBalance(decimal balance)
    {
        Console.WriteLine($"\nВаш текущий баланс: {balance:0.00} Рублей");
    }

    static decimal WithdrawMoney(decimal balance)
    {
        Console.Write("\nВведите значение для вывода: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal amount))
        {
            if (amount <= 0)
            {
                Console.WriteLine("Неверная сумма. Пожалуйста, введите положительное значение.");
            }
            else if (amount > balance)
            {
                Console.WriteLine("Недостаточно средств на счете. Пожалуйста, попробуйте использовать меньшую сумму.");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"Вывод средств прошел успешно. Ваш новый баланс равен: {balance:0.00} Рублей");
            }
        }
        else
        {
            Console.WriteLine("Неверный ввод. Пожалуйста, введите числовое значение.");
        }

        return balance;
    }
}
