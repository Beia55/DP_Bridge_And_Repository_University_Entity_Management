using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp
{
    class StudentRepository: IBaseRepository
    {
        public void Insert(BaseEntity baseEntity)
        {
            Type t = typeof(Student);
            if (typeof(BaseEntity) == t)
            {
                Console.WriteLine("Saved student: " + baseEntity);
            }
        }
    }
}
