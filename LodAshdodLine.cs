using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassengerFavoriteLinesProj
{
    public  class LodAshdodLine: LineAdder
    {
        public LodAshdodLine(Passenger pass): base(pass) 
        { 
            
        }    
        public override string CreateList(bool IsNew)
        {
            return pass.CreateList(IsNew) + AddLine();
        }

        private string AddLine()
        {
            return " Lod Ashdod Line was added";
        }
    }
}
