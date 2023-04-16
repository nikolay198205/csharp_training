﻿using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
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
            GoToHomePage();
            Login(new AccountData("admin", "secret"));
            SelectContact(1);
            RemoveContact();
            GoToHomePage();
        }

             
    }
}