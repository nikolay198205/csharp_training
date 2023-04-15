﻿using System;
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
    public class GroupHelper : HelperBase
    {


        public GroupHelper(ApplicationManager manager) : base(manager) // конструктор для передачи адресов в driver
        {
        }

        public GroupHelper Create(GroupData group)
        {
           manager.Navigator.GoToGroupsPage(); // обращаемся к менеджеру чтобы он предоставил доступ к другому помошнику
           InitGroupCreation();
           FillGroupForm(group);
           SubmitNewGroupCreation();
           ReturnToGroupsPage();
            return this;
        }

        public GroupHelper Remove(int p)
        {
            manager.Navigator.GoToGroupsPage(); //переход на страницу групп. используем помошник
            SelectGroup(1); //выбрать группу
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
            driver.FindElement(By.Name("group_name")).Click();
            driver.FindElement(By.Name("group_name")).Clear();
            driver.FindElement(By.Name("group_name")).SendKeys(group.Name);
            driver.FindElement(By.Name("group_header")).Click();
            driver.FindElement(By.Name("group_header")).Clear();
            driver.FindElement(By.Name("group_header")).SendKeys(group.Header);
            driver.FindElement(By.Name("group_footer")).Click();
            driver.FindElement(By.Name("group_footer")).Clear();
            driver.FindElement(By.Name("group_footer")).SendKeys(group.Footer);
            return this;
        }

        public GroupHelper SubmitNewGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;
        }

        public GroupHelper RemoveGroup() // удаление группы
        {
            driver.FindElement(By.Name("delete")).Click();
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


    }
}
