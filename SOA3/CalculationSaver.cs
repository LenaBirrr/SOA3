using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOA3
{
    public class CalculationSaver
    {
        public enum Operation
        {
            Add,
            Sub
        }
        public int CalculateAndSave(int a, int b, Operation c)
        {
            StreamWriter sr = new StreamWriter("test");
            if(c==Operation.Sub)
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
