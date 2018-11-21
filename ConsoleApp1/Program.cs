using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  public  class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Введите первое слово: ");
            String slovo1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите второе слово: ");
            String slovo2 = Convert.ToString(Console.ReadLine());
            string stroka1 = "";
            string stroka2 = "";
            stroka1 = slovo1[0].ToString();
            stroka2 = Zap_slova2_v_stroky(slovo2, stroka2);
            Vivod(stroka1, stroka2);
            Console.ReadLine();
        }

        public static void Vivod(string stroka1, string stroka2)
        {
            if (stroka1 == stroka2)
            {
                Console.WriteLine("Первая буква первого слова равна последней букве второго слова");
            }
            else
            {
                Console.WriteLine("Первая буква первого слова не равна последней букве второго слова");
            }
        }

        public static string Zap_slova2_v_stroky(string slovo2, string stroka2)
        {
            int i = 0;
            while (i < slovo2.Length)
            {
                stroka2 = slovo2[i].ToString();
                i++;
            }

            return stroka2;
        }
       
    }
}
