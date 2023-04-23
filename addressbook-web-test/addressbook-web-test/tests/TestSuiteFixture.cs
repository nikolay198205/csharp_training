using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    [SetUpFixture]
    public class TestSuiteFixture
    {
        public static ApplicationManager app; //static - глобальное объявление

        public void InitApplicationManager()
        { 
        app = new ApplicationManager();
            app.Navigator.GoToHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
        }

        [TearDown]

        public void StopApplicationManager() 
        {
            app.Stop();
        }
    }
}
