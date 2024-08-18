using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassengerFavoriteLinesProj
{
    public class AshdodLodLine:LineAdder
    {
        public AshdodLodLine(Passenger pass) : base(pass)
        {

        }
        public override string CreateList(bool IsNew)
        {
            return pass.CreateList(IsNew) + AddLine();
        }

        private string AddLine()
        {
            return " Ashdod Lod Line was added";
        }

    }
}
