using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace WebAddressbookTests
{
    [TestFixture]
    public class UniteTest1
    {
        [Test]
        public void TestMetod1()

        {
            double total = 900;
            bool vipClient = true;

            if (total > 1000 || vipClient) // && - И. || или
            {
                total = total * 0.9;
                System.Console.Out.WriteLine("Скидка 10%, общая сумма " + total);
            }

            else
            {

                System.Console.Out.WriteLine("Скидка 10%, общая сумма " + total);
            }
        }

    }
}



