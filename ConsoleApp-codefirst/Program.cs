using System;

namespace ConsoleApp_codefirst
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ApplicationContext context = new ApplicationContext();
            context.Accounts.Add(new Account
            {
                FirstName = "muhammed",
                LastName = "sayyar",
                Email = "eng.sayyar@gmail.com",
                Password = "p@ssw0rD"
            });
            context.SaveChanges();
            Console.WriteLine("data saved...");
            Console.ReadKey();
        }
    }
}
