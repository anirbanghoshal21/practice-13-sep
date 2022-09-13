using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
        enum Category
        {
            Silver = 2,
            Gold = 3,
            Platinum = 5,

        }
        static void Main(string[] args)
        {
            Category rented = Category.Gold;
            Console.WriteLine(rented);
        }

        private int QtyAvailable;
        public int Qtyavailable
        {
            get { return Qtyavailable; }
            set { Qtyavailable = value; }
        }

        private int qtyrented;

        public int QtyRented
        {
            get { return qtyrented; }
            set { qtyrented = value; }
        }

        private int remaniqty;

        public int Remaniqty
        {
            get { return remaniqty; }
            set { remaniqty = value; }
        }

        public string AvailableStock
        {
            get
            {
                return AvailableStock;
            }
        }
    }
}
