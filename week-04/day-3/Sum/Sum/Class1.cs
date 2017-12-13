using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    class Class1
    {
        
        public int Sum(List<int> numbers)
        {
            int summary = 0;

            foreach (int number in numbers)
            {
                summary += number;                
            }
            return summary;
        }

    }
}
