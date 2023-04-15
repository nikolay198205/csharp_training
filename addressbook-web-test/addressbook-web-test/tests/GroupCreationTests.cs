using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using addressbook_web_test.model;
using NUnit.Framework;

namespace WebAddressbookTests //������������ ����
{
    [TestFixture]
    public class GroupCreationTests : TestBase // ��������� ����� ������������ TestBase//����� ��� �������� ������������ �������� �����
    {
        [Test]
        public void GroupCreationTest() //�������� �����
        {
            app.Navigator.GoToHomePage(); // ������� �� �������� ��������. ���������� ���������
            app.Auth.Login(new AccountData("admin", "secret")); // ��� ����� ���������� ���� ����� � ����������� admin � secret
            app.Navigator.GoToGroupsPage();
            app.Groups.InitGroupCreation();
            
            //������ ������������ ����� �������� ������ ���������� ������
            GroupData group = new GroupData("aaa");
            group.Header = "dddd";
            group.Footer = "ffff";
            
            app.Groups.FillGroupForm(group);
            app.Groups.SubmitNewGroupCreation();
            app.Groups.ReturnToGroupsPage();
        }

     
       
      
      

      
    }
}
