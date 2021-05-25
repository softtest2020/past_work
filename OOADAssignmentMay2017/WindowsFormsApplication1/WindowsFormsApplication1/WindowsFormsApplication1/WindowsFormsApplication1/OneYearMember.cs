using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class OneYearMember:Member
    {
        public OneYearMember(string aName, string aIc, string aDob, DateTime aMembership, string aPhoneNum, Car aCar)
            : base(aName, aIc,aDob,aMembership,aPhoneNum,aCar)
       { 
       }
    }
}
