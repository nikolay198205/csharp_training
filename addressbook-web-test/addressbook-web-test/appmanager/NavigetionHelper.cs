using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;

namespace WebAddressbookTests
{
    public class NavigetionHelper : HelperBase
    {
  
        private string baseURL; // объявление поля адрес URL

        public NavigetionHelper(IWebDriver driver, string baseURL) : base(driver)// конструктор для передачи адресов в driver
        {
            this.baseURL = baseURL; // 
        }

        public void GoToHomePage()
        {
            driver.Navigate().GoToUrl(baseURL);
        }



        public void GoToGroupsPage()
        {
            driver.FindElement(By.LinkText("groups")).Click();
        }





    }
}
