using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook_web_test
{
    internal class Figure // базовый класс. Остальные наследуют его базовые свойства
    {
        private bool colored = false; //проверка закрашен ли объект

        public bool Colored
        {
           //авппр

            get
            {
                return colored;

            }
            set
            {
                colored = value;
            }

        }

    }
}
