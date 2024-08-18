using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassengerFavoriteLinesProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This assigment demostrate combintation of 2 design patterns, single tone and Decotator
            //single tone - will demonstrate the creation of an instance customer with a list of favorite lines.
            //Decotator design pattern to create favorite lines for a passenger

            //using single tone design pattern to create new customer
            Customer fromTeachaer = Customer.GetInstance();            
            //call ShowCustomerFavoriteLines in Customer Class to create list of lines - using Decotator design pattern
            string customerLines = fromTeachaer.ShowCustomerFavoriteLines();

            //Print results from Cusotmer Instance with  Customer Name and list of favorite Lines
            Console.WriteLine(customerLines);
            Console.Read();
        }
    }
}
