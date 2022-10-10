using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOA3
{
    public class CalculationSaver
    {
        public int CalculateAndSave(int a, int b, int c)
        {
            StreamWriter sr = new StreamWriter("test");
            if(c==1)
            {
                sr.Write(a - b);
                return a - b;
            }
            else
            {
                sr.Write(a + b);
                return a + b;
            }
               
        }
    }
}
