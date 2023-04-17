using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// содержит информацию о контакте

namespace WebAddressbookTests // пространство имен
{
    public class ContactData // класс с информацией
    {
        private string first_name; // значение
        private string middle_name = ""; // значение 
        private string last_name = "";

        public ContactData(string first_name)// конструктор/ основная информация о нашем контакте
        {
            this.first_name = first_name;
        }

        public ContactData(string first_name, string middle_name, string last_name)// конструктор/ основная информация о нашем контакте
        {
            this.first_name = first_name;
            this.middle_name = middle_name;
            this.last_name = last_name;
        }

        public string First_name //свойства
        {
            get { return first_name; } //возвращает значение поля
            set { first_name = value; } // восстанавливает значение этого поля
        }

        public string Middle_name //свойства
        {
            get { return middle_name; } //возвращает значение поля
            set { middle_name = value; } // восстанавливает значение этого поля
        }

        public string Last_name //свойства
        {
            get { return last_name; } //возвращает значение поля
            set { last_name = value; } // восстанавливает значение этого поля
        }

    }
}