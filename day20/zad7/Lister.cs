using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad7
{
    /// <summary>
    /// Created class Listener
    /// </summary>

    internal class Lister
    {
        private string _name;

        public Lister(string name)
        {
            _name = name;
        }

        /// <summary>
        /// Created method of subscriber to "listen" event
        /// </summary>
        /// <param name="message"></param>

        public void Listen(string message)
        {
            Console.WriteLine($"{_name} see: {message}");
        }
    }
}
