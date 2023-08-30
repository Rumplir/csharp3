using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S10EP01.Entities
{
    internal class OutsoucerdEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsoucerdEmployee() { }
        public OutsoucerdEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + AdditionalCharge + (AdditionalCharge*0.1);
        }

        public override string ToString()
        {
            return $"{Name} - {Payment():C2}";
        }
    }
}
