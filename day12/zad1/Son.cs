using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    internal class Son:Dad
    {
        public string name;
 

        public Son(string name, int years_old, string color_eyes, string color_hair) : base(color_eyes, color_hair, years_old) 
        { 
            this.name = name;
            this.years_old = years_old;
        }

        internal override int Years() 
        {
            int endYear = base.Years() - (int) Math.Sqrt(years_old);

            return endYear;
        } 
    }
}
