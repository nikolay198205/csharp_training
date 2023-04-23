using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests //������������ ����
{
    [TestFixture]
    public class GroupCreationTests : TestBase // ��������� ����� ������������ TestBase//����� ��� �������� ������������ �������� �����
    {
        [Test]
        public void GroupCreationTest() //�������� ����� �� �������� �� ������ �������� � ������
        {
           //������� �������� ������
            GroupData group = new GroupData("aaa");
            group.Header = "dddd";
            group.Footer = "ffff";
           //��������� ����������
           // app.Navigator.GoToGroupsPage();
            //� ��������� ������� ��������
            app.Groups.Create(group);
           
        }



        [Test] // ������� ���������, ��� ����� ��������� ������ � ������� ��������
        public void EmptyGroupCreationTest() //�������� ����� �� �������� ������ �������� � ������
        {
           
            GroupData group = new GroupData("");
            group.Header = "";
            group.Footer = "";
            
            app.Navigator.GoToGroupsPage();

            //� ��������� ������� ��������
            app.Groups.Create(group);
        }



    }
}
