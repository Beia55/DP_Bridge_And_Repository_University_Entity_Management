using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp
{
    class Student:BaseEntity
    {
        public int Year { get; set; }

        public Student(int year, string name)
            : base(name)
        {
            this.Year = year;
        }

        public override string ToString()
        {
            return base.ToString()+", Year: "+ this.Year;
        }
    }
}
