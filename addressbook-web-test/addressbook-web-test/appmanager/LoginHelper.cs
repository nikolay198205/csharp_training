using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using addressbook_web_test.model;

namespace WebAddressbookTests
{
    public class LoginHelper : HelperBase
    {
       

        public LoginHelper(IWebDriver driver) : base(driver)// конструктор для передачи адресов в driver
        {
        }


        public void Login(AccountData account) // метод. будем в него принимать один параметр типа AccountData
        {
            driver.FindElement(By.Name("user")).Click();
            driver.FindElement(By.Name("user")).Clear();
            driver.FindElement(By.Name("user")).SendKeys(account.Username); // вводятся в поля значения свойств объекта account
            driver.FindElement(By.Name("pass")).Click();
            driver.FindElement(By.Name("pass")).Clear();
            driver.FindElement(By.Name("pass")).SendKeys(account.Password); // вводятся в поля значения свойств объекта account
            driver.FindElement(By.XPath("//input[@value='Login']")).Click();
        }

    }
}
