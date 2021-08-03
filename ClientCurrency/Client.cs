using System;
using System.Collections.Generic;
using System.Text;

namespace ClientCurrency
{
    class Client
    {
        public string Name { set; get; }
        public string PassportNumber { get; set; }

        public override int GetHashCode()
        {
            return PassportNumber.GetHashCode();
        }

        /*
        public string GetHashCode()
        {
            return PassportNumber;
        }
        */

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (!(obj is Client))
                return false;
            return PassportNumber.Equals(obj);
        }

    }
}
