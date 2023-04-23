
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
        private ContactHelper contactHelper;
        
        
        private static ThreadLocal<ApplicationManager> app = new ThreadLocal<ApplicationManager>(); // единственный экземпляр ApplicationManager. это специальный объект который будет устанваливть соответствие между текущим потоком и объектом типа 

        private ApplicationManager() // делаем приватным, чтобы он был единственным. чтобы мы могли его конструировать только внутри метода GetInstance
        {
            //добавляем код который создает помошников. Это код инициализации
           
            driver = new FirefoxDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            baseURL = "http://localhost/addressbook/";
            

            loginHelper = new LoginHelper(this);
            navigator = new NavigetionHelper(this, baseURL);
            groupHelper = new GroupHelper(this);
            contactHelper = new ContactHelper(this);
            
        
        }

        //Делаем новый метод для параллельного запуска тестов
        public static ApplicationManager GetInstance() // глобальный метод. может быть вызван везде. ДОлжен вернуть экземпляр класса ApplicationManager
        {
            if (! app.IsValueCreated) // Если для текущего потока внутри хранилища ничего не создано 
            { 
            app.Value = new ApplicationManager();
              //  instance = new ApplicationManager();
            }
            // а если он уже создан - то будет использоваться сделанный ранее объект
            return app.Value;
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

        public ContactHelper Contacts
        { get { return contactHelper; } }

     //
    }
}
