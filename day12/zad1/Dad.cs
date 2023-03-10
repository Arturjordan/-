using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    internal class Dad
    {
        public string color_eyes;
        public string color_hair;
        public int years_old;

        public Dad(string color_eyes, string color_hair, int years_old)
        {
            this.color_eyes = color_eyes;
            this.color_hair = color_hair;
            this.years_old = years_old;
        }

        internal virtual int Years()
        {
            int highYears = years_old ;
            return highYears;
        }
    }
}