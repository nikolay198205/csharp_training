using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace WebAddressbookTests //пространство имен
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {
      
        [Test]
        public void GroupRemovalTest()
        {
            GoToHomePage();
            Login(new AccountData("admin", "secret"));
            GoToGroupsPage();
            SeleciGroup(1);
            RemoveGroup();
            ReturnToGroupsPage();
        }

       

        
    }
}
