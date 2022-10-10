using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOA3
{
    public class CalculationSaver
    {
        public delegate int CalculationOperation(int a, int b); 
        public int CalculateAndSave(CalculationOperation operation, int a, int b)
        {
            StreamWriter sr = new StreamWriter("test");
            sr.Write(operation(a, b));
            return operation(a, b);
           
        }
    }
}
