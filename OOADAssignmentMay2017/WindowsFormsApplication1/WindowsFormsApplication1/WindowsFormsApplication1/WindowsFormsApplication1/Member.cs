using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Member
    {
        private string name;
        private string ic;
        private string dateOfBirth;
        private DateTime membership;
        private string phoneNum;
        private Car car;
        private string typeOfMembership;
        public Member(string name, string ic, string dateOfBirth, DateTime membership, string phoneNum, Car car)
        {
            this.name = name;
            this.ic = ic;
            this.dateOfBirth = dateOfBirth;
            this.membership = membership;
            this.phoneNum = phoneNum;
            this.car = car;
        }
        public string Name
        {
            get { return name; }
        }

        public string Ic
        {
            get { return ic; }

        }
        public string DateOfBirth
        {
            get { return dateOfBirth; }
        }
        public DateTime Membership
        {
            get { return membership; }
            set { membership = value; }
        }
        public string PhoneNum
        {
            get { return phoneNum; }
            set { phoneNum = value; }
        }
        public Car Car
        {
            get { return car; }
        }
        public virtual void Renewal()
        {
            membership=membership.AddYears(1);
        }

    }
}
