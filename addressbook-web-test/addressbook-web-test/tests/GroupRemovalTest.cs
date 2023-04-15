using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
using NUnit.Framework;
using addressbook_web_test.model;


namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemovalTests : TestBase // объявляем тесты наследниками TestBase
    { 

        [Test]
        public void GroupRemovalTest()
        {
            app.Navigator.GoToHomePage(); // переход на домащнюю страницу.  используем помошник
            app.Auth.Login(new AccountData ("admin", "secret")); // логирование. Используем помошник
            app.Navigator.GoToGroupsPage(); //переход на страницу групп. используем помошник
            app.Groups.SelectGroup(1); //выбрать группу
            app.Groups.RemoveGroup(); // удалить группу
            app.Groups.ReturnToGroupsPage(); // вернуться на страницу групп
        }






    }
}
