using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое слово: ");
            String slovo1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите второе слово: ");
            String slovo2 = Convert.ToString(Console.ReadLine());
            string stroka1 = "";
            string stroka2 = "";
            stroka1 = slovo1[0].ToString();
            int i = 0;
            while (i < slovo2.Length)
            {
                stroka2 = slovo2[i].ToString();
                i++;
            }
            if (stroka1 == stroka2)
            {
                Console.WriteLine("Первая буква первого слова равна последней букве второго слова");
            }
            else
            {
                Console.WriteLine("Первая буква первого слова не равна последней букве второго слова");
            }
            Console.ReadLine();
        }
    }
}
