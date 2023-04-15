using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using addressbook_web_test.model;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests //пространство имен
{
    [TestFixture]
    public class ContactCreationTests //Класс для проверки правильности создания групп
    {
        private IWebDriver driver; //поле содержит данные
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost/addressbook/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest() //метод содержат код
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            //Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void ContactCreationTest() //тестовый метод
        {
            OpenHomePage();
            Login(new AccountData("admin", "secret")); // тут будем передавать один обект с параметрами admin и secret
            InitContactCreation();
            ContactData contact = new ContactData("A"); // тут записываем данные в поля контактов
            contact.Last_name = "B";
            contact.Middle_name = "C";
            FillContactForm(contact); // тут передаем данные контакта все разом

        }

        private void Login(AccountData account) // метод логирования. будем в него принимать один параметр типа AccountData
        {
            driver.FindElement(By.Name("user")).Click();
            driver.FindElement(By.Name("user")).Clear();
            driver.FindElement(By.Name("user")).SendKeys(account.Username); // вводятся в поля значения свойств объекта account
            driver.FindElement(By.Name("pass")).Click();
            driver.FindElement(By.Name("pass")).Clear();
            driver.FindElement(By.Name("pass")).SendKeys(account.Password); // вводятся в поля значения свойств объекта account
            driver.FindElement(By.XPath("//input[@value='Login']")).Click();
        }

        private void InitContactCreation()
        {

            driver.FindElement(By.LinkText("add new")).Click();
        }

        private void FillContactForm(ContactData contact) // метод заполнения полей контакта данными
        {
            driver.FindElement(By.Name("firstname")).Click();
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(contact.First_name);
            driver.FindElement(By.Name("middlename")).Click();
            driver.FindElement(By.Name("middlename")).Clear();
            driver.FindElement(By.Name("middlename")).SendKeys(contact.Middle_name);
            driver.FindElement(By.Name("lastname")).Click();
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys(contact.Last_name);
            driver.FindElement(By.XPath("//div[@id='content']/form/input[21]")).Click();
        }


        private void OpenHomePage() //метод открывающий домащнюю страницу
        {
            driver.Navigate().GoToUrl(baseURL);
        }

        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
