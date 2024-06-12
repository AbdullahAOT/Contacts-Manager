using Xunit;
using System.Runtime.CompilerServices;
using Contacts_Manager;

namespace ContactsManagerTest
{
    public class UnitTest1
    {
        [Fact]
        public void AddContactCase()
        {
            Contacts.contactsList.Clear();
            string contactName = "Muhammed";
            List<string> resultList = Contacts.AddContact(contactName);
            bool expectedResult = true;
            bool actualResult = false;
            for(int i = 0; i < resultList.Count; i++)
            {
                if(resultList[i] == contactName)
                {
                    actualResult = true; 
                    break;
                }
            }
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void RemoveContactCase()
        {
            Contacts.contactsList.Clear();
            string contactName = "Muhammed";
            string contactName2 = "Mustafa";
            Contacts.AddContact(contactName);
            Contacts.AddContact(contactName2);
            Contacts.RemoveContact(contactName);
            Assert.Equal(1, Contacts.contactsList.Count);
        }

        [Fact]
        public void ViewContactsCase()
        {
            Contacts.contactsList.Clear();
            string contactName = "Muhammed";
            string contactName2 = "Mustafa";
            List<string> resultList = Contacts.AddContact(contactName);
            resultList = Contacts.AddContact(contactName2);
            resultList = Contacts.ViewContacts();
            Assert.Equal(2, resultList.Count);
        }

        [Fact]
        public void AddContactNameDuplicateCase()
        {
            Contacts.contactsList.Clear();
            string contactName = "Muhammed";
            string contactName2 = "Muhammed";
            List<string> resultList = Contacts.AddContact(contactName);
            resultList = Contacts.AddContact(contactName2);
            bool expectedResult = true;
            bool actualResult = true;
            int count = 0;
            for (int i = 0; i < resultList.Count; i++)
            {
                if (resultList[i] == "Muhammed")
                {
                    count++;
                }
                if (count == 2)
                {
                    actualResult = false;
                    break;
                }
            }
            Assert.Equal(expectedResult, actualResult);
        }
    }
}