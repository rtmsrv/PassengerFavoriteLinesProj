using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassengerFavoriteLinesProj
{
    public class BlankList: Passenger
    {
        public string CreateList(bool IsNew)
        {
            string _return = string.Empty;

            if (IsNew)
            {
                _return = "No Favorite lines Selected";
            }
            else
            {
                _return = string.Empty;
            }

            return _return;
        }
    }
}
