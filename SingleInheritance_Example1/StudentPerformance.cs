using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace SingleInheritance_Example1
{
    
    public  class StudentPerformance
    {
       public double TotalMarks { get; set; }
        public void CalculateMarks()
        {
            double telugu = 50;
            double english = 45;
            double hindi = 48;
            TotalMarks = telugu + english + hindi;

        }
    }
}
