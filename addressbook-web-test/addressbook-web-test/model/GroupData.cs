using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// содержит информацию о группе

namespace WebAddressbookTests // пространство имен
{
    public class GroupData // класс с информацией
    {
        private string name; // значение
        private string header = ""; // значение с дефолтным пустым значением
        private string footer = "";

        public GroupData(string name)// конструктор/ основная информация о нашей группе
        {
            this.name = name;
        }

        public GroupData(string name, string header, string footer)// конструктор/ основная информация о нашей группе
        {
            this.name = name;
            this.header = header;
            this.footer = footer;
        }

        public string Name //свойства
        {
            get { return name; } //возвращает значение поля
            set { name = value; } // восстанавливает значение этого поля
        }

        public string Header //свойства
        {
            get { return header; } //возвращает значение поля
            set { header = value; } // восстанавливает значение этого поля
        }

        public string Footer //свойства
        {
            get { return footer; } //возвращает значение поля
            set { footer = value; } // восстанавливает значение этого поля
        }

    }
}
