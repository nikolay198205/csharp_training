using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests //пространство имен
{
    [TestFixture]
    public class ContactModificationTests : TestBase//Класс для проверки правильности создания групп
    {
        [Test]
        public void ContactModificationTest() //тестовый метод
        {
            ContactData newData = new ContactData("C"); // тут записываем данные в поля контактов
            newData.Last_name = "C";
            newData.Middle_name = "C";
            app.Contacts.Modify(1, newData); // тут передаем данные контакта все разом

        }

    }
}
