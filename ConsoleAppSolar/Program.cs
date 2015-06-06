using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSolar
{
    class Program
    {
        static void Main(string[] args)
        {
            SolarTerm st = new SolarTerm();
            st.JQtest(2015);
            st.paiYue(2015);
        }
    }
}
