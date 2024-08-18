using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassengerFavoriteLinesProj
{
    public  class LineAdder: Passenger
    {
        protected Passenger pass;

        public LineAdder(Passenger pass)
        {
            this.pass = pass;
        }

        public virtual string CreateList(bool IsNew)
        {
            throw new NotImplementedException();
        }
    }
}
