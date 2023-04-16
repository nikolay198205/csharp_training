using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace WebAddressbookTests //������������ ����
{  
    [TestFixture]
    public class GroupCreationTests : TestBase //����� ��� �������� ������������ �������� �����
    {
        

        [Test]
        public void GroupCreationTest() //�������� �����
        {
            GoToHomePage();
            Login(new AccountData("admin", "secret")); // ��� ����� ���������� ���� ����� � ����������� admin � secret
            GoToGroupsPage();
            InitGroupCreation();
            
            //������ ������������ ����� �������� ������ ���������� ������
            GroupData group = new GroupData("aaa");
            group.Header = "dddd";
            group.Footer = "ffff";
            FillGroupForm(group);
            
            SubmitNewGroupCreation();
            ReturnToGroupsPage();
        }





    }
}
