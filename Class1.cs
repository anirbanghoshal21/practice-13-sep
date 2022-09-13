using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Library
{
    public class Class1
    {
        public void Movie(string language, string genres)
        {
            Console.WriteLine("Search different based on language and genre");
        }

        private string login { get; set; }
        public void GetLoginCredential()
        {
            Console.WriteLine("Login successfully for User");
        }
        private string rented { get; set; } 
        private string password { get; set; }

        public string Rented
        {
            get { return rented; }
            set { rented = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
