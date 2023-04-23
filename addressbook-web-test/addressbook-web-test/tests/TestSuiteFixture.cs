using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [SetUpFixture] // метод
    public class TestSuiteFixture
    {
        
        [OneTimeSetUp]
        public void InitApplicationManager() // инициализация
        {
            ApplicationManager app = ApplicationManager.GetInstance(); // так как конструктор ApplicationManager уже приватный, то вместо конструктора будем обращаться к методу GetInstance
            app.Navigator.GoToHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
        }

        [OneTimeTearDown]
        public void StopApplicationManager()
        {
            ApplicationManager.GetInstance().Stop();
        }
    }
}
