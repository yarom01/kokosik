using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ATM
{
    static void Main(string[] args)
    {
        decimal balance = 1000.00m; // ��������� ������

        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== �������� ===");
            Console.WriteLine("1. �������� ������");
            Console.WriteLine("2. ������� ������");
            Console.WriteLine("3. �����");
            Console.Write("�������� �����: ");

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
                    Console.WriteLine("������� �� �� ��� ����������� ��������. �� ��������!");
                    return;
                default:
                    Console.WriteLine("�������� �����. ���������� �����.");
                    break;
            }

            Console.WriteLine("\n������� ����� ������� ����� ����������...");
            Console.ReadKey();
        }
    }

    static void ShowBalance(decimal balance)
    {
        Console.WriteLine($"\n��� ������� ������: {balance:0.00} ������");
    }

    static decimal WithdrawMoney(decimal balance)
    {
        Console.Write("\n������� �������� ��� ������: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal amount))
        {
            if (amount <= 0)
            {
                Console.WriteLine("�������� �����. ����������, ������� ������������� ��������.");
            }
            else if (amount > balance)
            {
                Console.WriteLine("������������ ������� �� �����. ����������, ���������� ������������ ������� �����.");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"����� ������� ������ �������. ��� ����� ������ �����: {balance:0.00} ������");
            }
        }
        else
        {
            Console.WriteLine("�������� ����. ����������, ������� �������� ��������.");
        }

        return balance;
    }
}
