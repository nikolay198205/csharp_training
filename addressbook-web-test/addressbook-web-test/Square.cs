using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook_web_test
{

    class Square : Figure
    {
        private int size;

        public Square(int size) // конструктор
        {
            this.size = size;
        }

        public int Size
        {
            get { return size; }
            set { size = value; }
        }

    }
  }


  

