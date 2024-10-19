using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScamBank_infa_dz
{
    class Client : IComparable<Client>
    {
        private string SecondName;
        private string FirstName;
        private string LastName;
        private double PhoneNumber;
        private double PassportSeries;
        private double PassportNumber;
        private double CardNumber;

        public Client(string sn, string fn, string ln, double pn, double passSer, double passNum, double cn)
        {
            SecondName = sn;
            FirstName = fn;
            LastName = ln;
            PhoneNumber = pn;
            PassportSeries = passSer;
            PassportNumber = passNum;
            CardNumber = cn;
        }

        public string Info()
        {
            string s = SecondName + "," + FirstName + "," + LastName + "," + PhoneNumber + "," + PassportSeries + "," + PassportNumber + "," + CardNumber;
            return s;
        }
        public int CompareTo(Client obj)
        {
            int result = this.SecondName.CompareTo(obj.SecondName);
            if (result == 0)
                result = this.FirstName.CompareTo(obj.FirstName);

            return result;
        }

    }
}