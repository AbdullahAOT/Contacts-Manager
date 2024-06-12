namespace Contacts_Manager
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool stayInContactsManager = true;
            try
            {
                while (stayInContactsManager)
                {
                    Contacts.ContactsManager();
                    Console.WriteLine("Do you want to do another process on contacts?" +
                        " if not, enter no, otherwise, enter anything");
                    string? userAnswer = Console.ReadLine();
                    if (userAnswer.ToLower() == "no")
                    {
                        stayInContactsManager = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
