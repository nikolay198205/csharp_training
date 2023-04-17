using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using addressbook_web_test.model;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests //пространство именs
{
    [TestFixture]
    public class ContactRemovalTests : TestBase
    {


        [Test]
        public void ContactRemovalTest()
        {
            app.Navigator.GoToHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Contacts.SelectContact(1);
            app.Contacts.RemoveContact();
            app.Navigator.GoToHomePage();
        }


    }
}
