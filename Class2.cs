using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminUser
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public void ApplyToCustomer(Customer customer)
        {
            customer.MobileNumber = MobileNumber;
        }

        public void AddMovie()
        {
            Console.WriteLine("Add movies in the database");

        }

        public void DeleteMovie()
        {
            Console.WriteLine("Delete movies in the database");
        }

        public void UpdateMovie()
        {
            Console.WriteLine("Update movies in the database");
        }

        public Movie Rental(int user, int stock)
        {
            user = user - 1;
            stock = stock - 1;
            Console.WriteLine("Reduction for movie");
        }

        interface Movie
        {
            void delivery();

        }
        class movie : DeliveryUser
        {
            public void delivery()
            {
                Console.WriteLine("Movie Assign");
            }
        }
    }

    internal class DeliveryUser
    {
    }
    public IList<IList<int>> Movielist()
    {

    }

    private IList<int> outstanding = obj.Search(Movielist);
 
}
   
