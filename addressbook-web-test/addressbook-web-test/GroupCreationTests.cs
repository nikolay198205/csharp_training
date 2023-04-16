using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace WebAddressbookTests //пространство имен
{  
    [TestFixture]
    public class GroupCreationTests : TestBase //Класс для проверки правильности создания групп
    {
        

        [Test]
        public void GroupCreationTest() //тестовый метод
        {
            GoToHomePage();
            Login(new AccountData("admin", "secret")); // тут будем передавать один обект с параметрами admin и secret
            GoToGroupsPage();
            InitGroupCreation();
            
            //вместо конструктора можно задавать данные отдельными полями
            GroupData group = new GroupData("aaa");
            group.Header = "dddd";
            group.Footer = "ffff";
            FillGroupForm(group);
            
            SubmitNewGroupCreation();
            ReturnToGroupsPage();
        }





    }
}
