using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOA3
{
    public class CalculationSaver
    {
        public int CalculateAndSave(int a, int b)
        {
            StreamWriter sr = new StreamWriter("test");
            sr.Write(a - b);
            sr.Close();
            return a - b;
        }
    }
}
