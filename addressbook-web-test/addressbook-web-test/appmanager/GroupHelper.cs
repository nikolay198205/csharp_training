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
    public class GroupHelper : HelperBase
    {


        public GroupHelper(ApplicationManager manager) : base(manager) // конструктор для передачи адресов в driver
        {
        }

        public GroupHelper Create(GroupData group)
        {
           manager.Navigator.GoToGroupsPage(); // обращаемся к менеджеру чтобы он предоставил доступ к другому помошнику
           InitGroupCreation();
           FillGroupForm(group); // заполнить появившуюся форму
           SubmitGroupCreation();
           ReturnToGroupsPage();
            return this;
        }

        public GroupHelper Modify(int p, GroupData newData)
        {
            manager.Navigator.GoToGroupsPage(); //переход на страницу групп. используем помошник
            SelectGroup(p); //выбрать группу
            InitGroupModification(); // модифицировать группу
            FillGroupForm(newData); // заполнить появившуюся форму
            SubmitGroupModification();
            ReturnToGroupsPage();
            return this; // чтобы можно было участвовать в цепочках
        }

      

        public GroupHelper Remove(int p)
        {
            manager.Navigator.GoToGroupsPage(); //переход на страницу групп. используем помошник
            SelectGroup(p); //выбрать группу
            RemoveGroup(); // удалить группу
            ReturnToGroupsPage(); // вернуться на страницу групп
            return this;
        }

        public GroupHelper InitGroupCreation()
        {
            driver.FindElement(By.Name("new")).Click();
            return this;
        }


        public GroupHelper FillGroupForm(GroupData group) // метод
        {
            //Будущие параметры метода оформляем как локальные переменные

            Type(By.Name("group_name"), group.Name);// найти элемент по локатору group_name и вписать нужыне значения
            Type(By.Name("group_header"), group.Header);
            Type(By.Name("group_footer"), group.Footer);           
            return this;
        }

      

        public GroupHelper SubmitGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;
        }


        public GroupHelper SelectGroup(int index)
        {
            driver.FindElement(By.XPath("//div[@id='content']/form/span[ " + index + "]/input")).Click();
            return this;
        }



        public GroupHelper ReturnToGroupsPage()
        {
            driver.FindElement(By.LinkText("groups")).Click();
            return this;
        }

        public GroupHelper RemoveGroup() // удаление группы
        {
            driver.FindElement(By.Name("delete")).Click();
            return this;
        }


        public GroupHelper SubmitGroupModification()
        {
            driver.FindElement(By.Name("update")).Click();
            return this;
        }

        public GroupHelper InitGroupModification()
        {
            driver.FindElement(By.Name("edit")).Click();
            return this;
        }

    }
}
