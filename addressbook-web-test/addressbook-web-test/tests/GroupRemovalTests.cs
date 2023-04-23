using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemovalTests : TestBase // объявляем тесты наследниками TestBase
    { 

        [Test]
        public void GroupRemovalTest()
        {
            app.Groups.Remove(1);
           
        }






    }
}
