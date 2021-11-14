using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp
{
    class StudentRepository: IBaseRepository
    {
        public IStorage Storage;

        public StudentRepository(IStorage storage)
        {
            this.Storage = storage;
        }

        public void Insert(BaseEntity baseEntity)
        {
           Console.WriteLine(this.Storage.Save(baseEntity));
        }
    }
}
