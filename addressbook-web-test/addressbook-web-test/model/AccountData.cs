using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Тут задаются логин и пароль пользователя


namespace WebAddressbookTests
{
    public class AccountData // Класс AccountData
    {
        public string username; // значение
        public string password; // значение


        public AccountData(string username, string password) //конструктор/ позволит коструировать новые объекты
        {
            this.username = username; //в поле присваиваем значение переданное как параметр
            this.password = password; //в поле присваиваем значение переданное как параметр
        }

        public string Username // cвойство. Позволяет быстро менять значения
        {
            get { return username; } // возвращает значение поля 
            set { username = value; } // присваивает значение
        }

        public string Password // cвойство. Позволяет быстро менять значения
        {
            get { return password; } // возвращает значение поля 
            set { password = value; } // присваивает значение
        }

    }
}
