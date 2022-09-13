using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonOptions
{
    public class Class3
    {
        public void ChangePassword(int user)
        {
            Console.WriteLine("All the user can change password");
            Console.WriteLine("Every month new password can be set");
        }

        public void ViewProfile()
        {
            Console.WriteLine("User can view the profile");
        }

        public void EditProfile()
        {
            Console.WriteLine("User can edit the profile");
        }
    }
}
