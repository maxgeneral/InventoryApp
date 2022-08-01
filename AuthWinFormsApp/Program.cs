using AuthWinFormsApp.Data;
using AuthWinFormsApp.Data.Model;
using AuthWinFormsApp.Utils;
using AuthWinFormsApp.Views;

namespace AuthWinFormsApp
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            User user = new User()
            {
                Login = "admin11",
                Password = "admin",
                Activation = new Activation()
                {
                    Code = "1231245555",
                    EnterCode = DateTime.UtcNow,
                    SendCode = DateTime.UtcNow,
                },
                Role = (int)AuthRole.ResponsiblePerson,
                Profile = new Profile()
                {
                    FirstName = "Иван",
                    LastName = "Иванов",
                },
                Email = "user@inventory.app"
            };


            try
            {
                ContextDb db = new ContextDb();
                db.Users.Add(user);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Application.Exit();
            }
            



            /*
            ApplicationConfiguration.Initialize();
            Application.Run(new AuthForm());
            if (AuthState.This().IsAuth)
            {
                switch (AuthState.This().Role)
                {
                    case AuthRole.InventoryPerson: 
                        Application.Run(new MainForm());
                        break;
                    case AuthRole.ResponsiblePerson:
                        Application.Run(new MainForm());
                        break;
                }
            }*/
        }
    }
}