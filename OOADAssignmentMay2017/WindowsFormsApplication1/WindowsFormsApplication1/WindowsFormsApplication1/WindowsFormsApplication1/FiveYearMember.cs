using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class FiveYearMember:Member
    {
        public FiveYearMember(string aName, string aIc, string aDob, DateTime aMembership, string aPhoneNum, Car aCar)
            : base(aName, aIc,aDob,aMembership,aPhoneNum,aCar)
        {    
        }
        public override void Renewal()
        {
            Membership = Membership.AddYears(5);
        }
    }
}
