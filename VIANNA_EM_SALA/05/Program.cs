﻿class Program
{
    static void Main(string[] args)
    {
        int num;
        
        Console.Write("Inteiro: ");
        num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0 && num % 3 == 0 && num % 5 != 0)
        {
            Console.WriteLine("{0} é divisível por 2 e por 3 e não é por 5", num);
        }
        else
        {
            Console.WriteLine("{0} NÃO é divisível por 2 ou não é por 3 ou é por 5", num);
        }
    }
}