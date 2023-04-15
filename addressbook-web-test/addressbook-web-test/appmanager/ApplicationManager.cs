
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;


//переносим в этот класс весь код относящийся к управлению помошниками
//у нас получилась библиотека для работы с тестируемым приложением через пользовательский интерфейс

namespace WebAddressbookTests
{
    public class ApplicationManager
    {
        protected IWebDriver driver; // protectуd - оно внутренее, но наледники получают доступ
        protected string baseURL; // protectуd - оно внутренее, но наледники получают доступ

        //вспомогательные файлы помошники
        protected LoginHelper loginHelper; // нужно объявить помошника тут
        protected NavigetionHelper navigator; // нужно объявить помошника тут
        protected GroupHelper groupHelper; // нужно объявить помошника тут
            
        public ApplicationManager()
        {
            //добавляем код который создает помошников. Это код инициализации

            driver = new FirefoxDriver();
            baseURL = "http://localhost/addressbook/";
          

            loginHelper = new LoginHelper(this);
            navigator = new NavigetionHelper(this, baseURL);
            groupHelper = new GroupHelper(this);
        }

        public IWebDriver Driver 
        {
            get { return driver; }
        }


        public void Stop() // для остановки всего что нужно внутри апликейшнменеджера
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }
        // делаем геттер для для вызова помошников
        public LoginHelper Auth 
        {
        get { return loginHelper; }
        }

        public NavigetionHelper Navigator
        { get { return navigator; } }

        public GroupHelper Groups
        { get { return groupHelper; } }

     
    }
}
