using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace srav_bukv
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string slovo1 = "xghjg";
           string stroka1 = slovo1[0].ToString();
            string slovo2 = "wertx";
          string stroka2 = "";
            string buk2 = Program.Zap_slova2_v_stroky(slovo2, stroka2);
            string a =Program.Vivod(stroka1, stroka2);// как преобразовать void в string??
            string expected = "Первая буква первого слова равна последней букве второго слова";
           Assert.AreEqual(expected, a);
        }
    }
}
