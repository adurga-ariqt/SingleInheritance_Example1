using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleInheritance_Example1
{
    class StudentMarks: StudentPerformance

    {
        public void PrintMarks()
        {

            String grade = "A";
            Console.WriteLine("Toatal marks is:" + TotalMarks+"\n" +"grade is :"+ grade);
           // TotalMarks = Convert.Todouble(Console.ReadLine());
        }
    }
}
