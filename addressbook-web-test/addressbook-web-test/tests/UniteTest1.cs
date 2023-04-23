using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace addressbook_web_test.tests
{

    internal class UniteTest1
    {
        public void TestMetod1()

        {
            double total = 1000;

            if (total > 1000)
            {
                total = total * 0.9;
                System.Console.Out.Write("Скидка 10%, общая сумма " + total);
            }

            else
            {
                System.Console.Out.Write("Скидка 10%, общая сумма " + total);
            }
        }

    }
}



