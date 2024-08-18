using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PassengerFavoriteLinesProj
{
    public sealed class Customer
    {
        
        public  static string FirstName = "John Smith";
        private static Customer Instance = null;
        private static int Counter = 0;
        public static Customer GetInstance()
        {
            //If the variable instance is null, then create the Singleton instance 
            //else return the already created singleton instance
            //This version is not thread safe
            if (Instance == null)
            {
                Instance = new Customer();    
                
            }
            //Return the Singleton Instance
            return Instance;
        }

        private Customer()
        {
            //Each Time the Constructor called, increment the Counter value by 1
            Counter++;
            Console.WriteLine("Counter Value " + Counter.ToString());
        }

        public void PrintCustomerName()
        {
            Console.WriteLine(PassengerFavoriteLinesProj.Customer.FirstName + "Favorite Rail Lines");
        }

        public string ShowCustomerFavoriteLines()
        {
            Console.WriteLine(PassengerFavoriteLinesProj.Customer.FirstName + "Favorite Rail Lines");
            StringBuilder strMessage = new StringBuilder();
            //using Decotator design pattern to create favorite lines for a passenger
            BlankList nofavLinesobj = new BlankList();
            //initiate favorite lines for an exsiting customer
            string blankLines = nofavLinesobj.CreateList(true);
            strMessage.Append(blankLines);
            //add Lines to the blank line list
            //Initiate LineAdder class
            //send linetype as a parameter to the LineAdder class via constructor
            LineAdder clsAshdodLodLineAdd = new AshdodLodLine(nofavLinesobj);
            string LoadAshdodLine = clsAshdodLodLineAdd.CreateList(false);
            strMessage.Append("\n'" + LoadAshdodLine + "' using AshdodLodLine class");            
            //send linetype as a parameter to the LineAdder class via constructor
            LineAdder clsLodAshdod = new LodAshdodLine(nofavLinesobj);
            string LodAshdodLine = clsLodAshdod.CreateList(false);
            strMessage.Append("\n'" + LodAshdodLine + "' using LodAshdodLine");            
            return strMessage.ToString();
        }

        

    }
}
