using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OnlineJewelShopping
{
    class UserAdminModules
    {
        SqlConnection sqlConnection = Connection.getDetails();

        //getting the GetUserAdminEnums and display to user
        public string GetUserAdminEnums()
        {

            StringBuilder stringBuilder = new StringBuilder();
            foreach (MajorOption adminUserEnum in Enum.GetValues(typeof(MajorOption)))
            {
                stringBuilder.Append("--"+adminUserEnum + "\n");
            }
            return stringBuilder.ToString();
        }
        //getting GetAdminEnums and to display to user
        public string GetAdminEnums()
        {
            
            StringBuilder stringBuilder = new StringBuilder();
            foreach (AdminOption adminEnum in Enum.GetValues(typeof(AdminOption)))
            {
                stringBuilder.Append("--" + adminEnum + "\n");
            }
            return stringBuilder.ToString();
        }

        public string GetAdminOptions()
        {

            StringBuilder stringBuilder = new StringBuilder();
            foreach (AdminLoginOption adminEnum in Enum.GetValues(typeof(AdminLoginOption)))
            {
                stringBuilder.Append("--" + adminEnum + "\n");
            }
            return stringBuilder.ToString();
        }
        //Getting GetUserEnums and display to users
        public string GetUserEnums()
        {
            Console.WriteLine("**********************************************Mathre Jewellary Shopping*************************************************");
            StringBuilder stringBuilder = new StringBuilder();
            foreach (UserOption userEnum in Enum.GetValues(typeof(UserOption)))
            {
                stringBuilder.Append("--" + userEnum + "\n");
            }
            return stringBuilder.ToString();
        }
        
        public void AdminOperation()
        {
            

            Console.WriteLine(GetAdminEnums());
            AdminDetails register = new AdminDetails();
            Console.WriteLine("Enter the Option");
            string adminsOption = Console.ReadLine();
            //
            AdminOption adminOption = (AdminOption)Enum.Parse(typeof(AdminOption), adminsOption);
            do
            {
                switch (adminOption)
                {
                    case AdminOption.AddAdmin:
                        register.AddAdmin(sqlConnection);
                        break;
                    
                    case AdminOption.AdminLogin:
                        register.Login(sqlConnection);
                        break;
                    default:
                        break;

                }
                Console.WriteLine(GetAdminEnums());
                Console.WriteLine("Enter the Option");
                adminsOption = Console.ReadLine();
                adminOption = (AdminOption)Enum.Parse(typeof(AdminOption), adminsOption);
            } while (adminsOption != "Exit");




        }
        public void AdminsWork()
        {
            Console.WriteLine(GetAdminOptions());
            ProductRepositary productRepositary = new ProductRepositary();
            Console.WriteLine("Enter the Option");
            string usersOption = Console.ReadLine();
            AdminLoginOption userOption = (AdminLoginOption)Enum.Parse(typeof(AdminLoginOption), usersOption);
            do
            {
                switch (userOption)
                {
                    case AdminLoginOption.AddProduct:
                        productRepositary.AddProduct(sqlConnection);
                        break;
                    case AdminLoginOption.ViewProduct:
                        productRepositary.ViewProduct(sqlConnection);
                        break;
                    case AdminLoginOption.RemoveProduct:
                        productRepositary.RemoveProduct(sqlConnection);
                        break;
                }
                Console.WriteLine(GetAdminOptions());
                Console.WriteLine("Enter the Option");
                usersOption = Console.ReadLine();
                userOption = (AdminLoginOption)Enum.Parse(typeof(AdminLoginOption), usersOption);
            } while (usersOption != "Exit");

        }
        public void UserOperation()
        {
            Console.WriteLine(GetUserEnums());
            UserRepositary userRepositary = new UserRepositary();
            Console.WriteLine("Enter the Option");
            //LoginWindow login = new LoginWindow();
            string usersOption = Console.ReadLine();
            //checking whether the usersoption is present in UserOption or not
            UserOption userOption = (UserOption)Enum.Parse(typeof(UserOption), usersOption);

            switch (userOption)
            {
                case UserOption.SignUp:
                    userRepositary.SignUpDetails();
                    Console.WriteLine("Do you want to login now?");
                    Console.WriteLine("If yes press 1 or press 2 to exit");
                    int userChoices = Convert.ToInt32(Console.ReadLine());
                    if (userChoices == 1)
                    {

                        userRepositary.LoginDetails();

                    }
                    else
                    {
                        System.Environment.Exit(0);
                    }
                    break;
                case UserOption.Login:
                    userRepositary.LoginDetails();

                    break;
                case UserOption.Exit:
                    System.Environment.Exit(0);
                    break;
                default:
                    break;
            }





        }
        public void AdminUserOperation()
        {
            Console.WriteLine(GetUserAdminEnums());
            Console.WriteLine("Enter the Option");
            string Role = Console.ReadLine();
            AdminDetails admin = new AdminDetails();
            //checking whether the role is present in MajorOption
            MajorOption AdminuserOption = (MajorOption)Enum.Parse(typeof(MajorOption), Role);
            do
            {
                switch (AdminuserOption)
                {
                    case MajorOption.Admin:
                        //admin.Login();
                        AdminOperation();
                        break;
                    case MajorOption.User:
                        UserOperation();
                        break;

                }
                Console.WriteLine();
                Console.WriteLine(GetUserAdminEnums());
                Console.WriteLine("Enter the Option");
                Role = Console.ReadLine();
                AdminuserOption = (MajorOption)Enum.Parse(typeof(MajorOption), Role);
            } while (Role != "Exit");
        }
    }

}
