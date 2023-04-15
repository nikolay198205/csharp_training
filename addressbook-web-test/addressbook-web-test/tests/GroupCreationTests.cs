using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using addressbook_web_test.model;
using NUnit.Framework;

namespace WebAddressbookTests //пространство имен
{
    [TestFixture]
    public class GroupCreationTests : TestBase // объ€вл€ем тесты наследниками TestBase// ласс дл€ проверки правильности создани€ групп
    {
        [Test]
        public void GroupCreationTest() //тестовый метод
        {
            app.Navigator.GoToHomePage(); // переход на домащнюю страницу. используем помошника
            app.Auth.Login(new AccountData("admin", "secret")); // тут будем передавать один обект с параметрами admin и secret
            app.Navigator.GoToGroupsPage();
            app.Groups.InitGroupCreation();
            
            //вместо конструктора можно задавать данные отдельными пол€ми
            GroupData group = new GroupData("aaa");
            group.Header = "dddd";
            group.Footer = "ffff";
            
            app.Groups.FillGroupForm(group);
            app.Groups.SubmitNewGroupCreation();
            app.Groups.ReturnToGroupsPage();
        }

     
       
      
      

      
    }
}
