using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp
{
    class ProfessorRepository : IBaseRepository
    {
        public void Insert(BaseEntity baseEntity) {
            Type t = typeof(Professor);
            if (typeof(BaseEntity) == t) 
            {
                Console.WriteLine("Saved professor: "+baseEntity);    
            }
        }
    }
}
