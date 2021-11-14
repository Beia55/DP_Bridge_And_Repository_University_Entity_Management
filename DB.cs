using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp
{
    class DB: IStorage
    {
        public string Save(BaseEntity baseEntity)
        {
            return "DB saved: " + baseEntity;
        }
    }
}
