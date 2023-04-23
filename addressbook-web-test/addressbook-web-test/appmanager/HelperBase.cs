using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System.Runtime.CompilerServices;

namespace WebAddressbookTests
{
    public class HelperBase
    {
        protected ApplicationManager manager;
        protected IWebDriver driver; // объявление поля где хранится ссылка на драйвер ч/з который управляется броузер

        //делаем конструктор
        public HelperBase(ApplicationManager manager)
        {
            this.manager = manager;
            this.driver = manager.Driver; // получает ссылку на драйвер у менеджера и потом этой ссылкой все могут пользоваться
        }

        public void Type(By locator, string text) // проверка на то, что модифицировать
        {
            if (text != null) // != неравно. Если передается null  - то ничего менять не надо
            {
                driver.FindElement(locator).Click(); // 
                driver.FindElement(locator).Clear(); // найти элемент по локатору group_name и отчистить
                driver.FindElement(locator).SendKeys(text);
            }

        }

    }
}