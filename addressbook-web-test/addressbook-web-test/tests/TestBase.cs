using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace WebAddressbookTests
{
    public class TestBase
    {
        public ApplicationManager app;

        [SetUp]
        public void SetupTest() // метод для инициализации который инициализирует: драйвер, помошников и метод
                                //и метод тердаун который останавливает драйвер в конце
        {
            //driver = new FirefoxDriver();
            //baseURL = "http://localhost/addressbook/";
            // verificationErrors = new StringBuilder();
            app = TestSuiteFixture.app;


           

        }

    }
}