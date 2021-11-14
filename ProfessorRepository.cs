using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp
{
    class ProfessorRepository : IBaseRepository
    {
        public IStorage Storage;

        public ProfessorRepository(IStorage storage) 
        {
            this.Storage = storage;
        }
        
        public void Insert(BaseEntity baseEntity) {
            Console.WriteLine(this.Storage.Save(baseEntity));
        }
    }
}
