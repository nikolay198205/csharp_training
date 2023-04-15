using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System.Runtime.CompilerServices;

namespace WebAddressbookTests
{
    public class HelperBase
    {

        protected IWebDriver driver; // объявление поля где хранится ссылка на драйвер ч/з который управляется броузер

        //делаем конструктор
        public HelperBase(IWebDriver driver)
        { 
            this.driver = driver;
        }
      
    }
}