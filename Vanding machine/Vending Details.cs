using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanding_machine
{
    public class Vending_Details
    {
        public int pin;
        public string firstName;


        public Vending_Details(int pin, string firstName)
        {
            this.pin = pin;
            this.firstName = firstName;
        }
    }
}
