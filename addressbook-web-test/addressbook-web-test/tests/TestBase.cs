using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using addressbook_web_test.model;
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
            app = new ApplicationManager();
            app.Navigator.GoToHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));

        }

        [TearDown]
        public void TeardownTest() // содержит код в котором останавливается броузер
        {
            app.Stop();

        }
    }
}