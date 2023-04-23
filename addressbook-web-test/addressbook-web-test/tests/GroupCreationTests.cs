using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests //пространство имен
{
    [TestFixture]
    public class GroupCreationTests : TestBase // объявляем тесты наследниками TestBase//Класс для проверки правильности создания групп
    {
        [Test]
        public void GroupCreationTest() //тестовый метод по проверке не пустых значений в группе
        {
           //создаем тестовые данные
            GroupData group = new GroupData("aaa");
            group.Header = "dddd";
            group.Footer = "ffff";
           //переходим настраницу
           // app.Navigator.GoToGroupsPage();
            //и выполняем цепочку действий
            app.Groups.Create(group);
           
        }



        [Test] // который проверяет, что можно создавать группы с пустыми именнами
        public void EmptyGroupCreationTest() //тестовый метод по проверке пустых значений в группы
        {
           
            GroupData group = new GroupData("");
            group.Header = "";
            group.Footer = "";
            
            app.Navigator.GoToGroupsPage();

            //и выполняем цепочку действий
            app.Groups.Create(group);
        }



    }
}
