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
            //SelectContact(p); //выбрать контакт
            RemoveContact(); // удалить контакт
            return this;
        }


        public ContactHelper Modify(int p, ContactData newData)
        {
            manager.Navigator.GoToHomePage(); //переход на страницу контакт. используем помошник
            //SelectContact(p); //выбрать контакт
            InitContactModification(); // модифицировать контакт
            FillContactForm(newData); // заполнить появившуюся форму
            SubmitContactModification();
            return this; // чтобы можно было участвовать в цепочках
        }




        public ContactHelper RemoveContact() // нажатие кнопки "Удаление контакта"
        {
            driver.FindElement(By.XPath("//input[@name='selected[]']")).Click();
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            
            driver.SwitchTo().Alert().Accept();
            driver.FindElement(By.LinkText("home")).Click();



            //driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            // Assert.IsTrue(Regex.IsMatch(CloseAlertAndGetItsText(), "^Delete 1 addresses[\\s\\S]$"));
            return this;
        }

        public ContactHelper SelectContact(int number) // выбор контакта по номеру
        {
            driver.FindElement(By.XPath("//*[@id='maintable']//tr[1]")); 
            return this;
        }
        
        public ContactHelper InitContactModification() // нажимаем кнопку "Править"
        {
            driver.FindElement(By.XPath("//img[@alt='Edit']")).Click();
            return this;
        }
        
        
        public ContactHelper InitContactCreation() // нажимаем кнопку "Добавить"
        {

            driver.FindElement(By.LinkText("add new")).Click();
            return this;
        }

      
        public ContactHelper SubmitContactModification() // нажимаем кнопку "Обновить"
        {
            driver.FindElement(By.Name("update")).Click();
            return this;
        }


        public ContactHelper FillContactForm(ContactData contact) // метод заполнения полей контакта данными
        {
            Type(By.Name("firstname"), contact.First_name);
            Type(By.Name("middlename"), contact.Middle_name);
            Type(By.Name("lastname"), contact.Last_name);
                       
            driver.FindElement(By.XPath("//div[@id='content']/form/input[21]")).Click();
            return this;
        }


        public string CloseAlertAndGetItsText() // закрытие предупреждения перед удалением контакта
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
