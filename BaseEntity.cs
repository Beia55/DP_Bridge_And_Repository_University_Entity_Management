using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp
{
    public abstract class BaseEntity
    {
        public string Name { get; set; }

        public BaseEntity(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return "Name:" + this.Name;
        }
    }
}
