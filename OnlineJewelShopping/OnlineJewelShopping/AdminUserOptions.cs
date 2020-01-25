using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJewelShopping
{
    public enum MajorOption
    {
        Admin,
        User,
        Exit

    };
    //enum for User
    public enum UserOption
    {
        SignUp,
        Login,
        Exit
    };
    //Enum for admin operation
    public enum AdminOption
    {
        AddAdmin,
        AdminLogin,
        Exit

    };
    public enum AdminLoginOption
    {
        AddProduct,
        ViewProduct,
        RemoveProduct,
        Exit
    }

    

}
