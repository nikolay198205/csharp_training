using addressbook_web_test.model;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WebAddressbookTests;

namespace WebAddressbookTests
{
    public class ContactHelper : HelperBase
    {
        private bool acceptNextAlert = true;
        public ContactHelper(ApplicationManager manager) : base(manager)// конструктор для передачи адресов в driver
        {

        }

        //для контактов


        public ContactHelper Create(ContactData contact)
        {
            manager.Navigator.GoToHomePage(); // обращаемся к менеджеру чтобы он предоставил доступ к другому помошнику
            InitContactCreation();
            FillContactForm(contact); // заполнить появившуюся форму
            return this;
        }

       
        public ContactHelper Remove(int p)
        {
            manager.Navigator.GoToHomePage(); //переход на страницу групп. используем помошник
            SelectContact(p); //выбрать группу
            RemoveContact(); // удалить группу
            return this;
        }







        public ContactHelper RemoveContact()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            Assert.IsTrue(Regex.IsMatch(CloseAlertAndGetItsText(), "^Delete 1 addresses[\\s\\S]$"));
            return this;
        }

        public ContactHelper SelectContact(int number)
        {
            driver.FindElement(By.Id(System.Convert.ToString(number))).Click();
            return this;
        }
        public ContactHelper InitContactCreation()
        {

            driver.FindElement(By.LinkText("add new")).Click();
            return this;
        }

        public ContactHelper FillContactForm(ContactData contact) // метод заполнения полей контакта данными
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
            return this;
        }


        public string CloseAlertAndGetItsText()
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
