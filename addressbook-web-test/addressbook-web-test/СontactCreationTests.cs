using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests  //пространство имен
{
    [TestFixture]
    public class ContactCreationTests : TestBase //Класс для проверки правильности создания групп
    {
       

      
        [Test]
        public void ContactCreationTest() //тестовый метод
        {
            GoToHomePage();
            Login(new AccountData("admin", "secret")); // тут будем передавать один обект с параметрами admin и secret
            InitContactCreation();
            ContactData contact = new ContactData("A"); // тут записываем данные в поля контактов
            contact.Last_name = "B";
            contact.Middle_name = "C";
            FillContactForm(contact); // тут передаем данные контакта все разом

        }
 
      
    }
}
