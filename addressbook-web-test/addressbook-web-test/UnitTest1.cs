using addressbook_web_test;
using System;
//using Microsoft.VisualStudio.TestPlatform.PlatformAbstractions;



namespace addressbook_web_tests
{
   // [TestClass]
    public class Utitled
    {
      // [TestMetod]
        public void TestMethodSquare()
        {
            Square s1 = new Square(5); //переменная (объект) класса Square
            Square s2 = new Square(10);
            Square s3 = s1; // новый объект не создается. Есть две переменные которые указывают на один и тот же объект
        
            Assert.AreEqual(s1.Size, 5);
            Assert.AreEqual(s2.Size, 10);
            Assert.AreEqual(s3.Size, 5);

            s3.Size = 15;
            Assert.AreEqual(s1.Size, 15);


        }

        public void TestMethodCircle()
        {
            Circle s1 = new Circle(5); //переменная (объект) класса Square
            Circle s2 = new Circle(10);
            Circle s3 = s1; // новый объект не создается. Есть две переменные которые указывают на один и тот же объект

            Assert.AreEqual(s1.Radius, 5);
            Assert.AreEqual(s2.Radius, 10);
            Assert.AreEqual(s3.Radius, 5);

            s3.Radius = 15;
            Assert.AreEqual(s1.Radius, 15);


        }
    }
}