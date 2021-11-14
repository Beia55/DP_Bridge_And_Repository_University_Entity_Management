using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp
{
    class Professor : BaseEntity
    {
        public string Specification { get; set; }

        public Professor(string specification, string name)
            : base(name)
        {
            this.Specification = specification;
        }

        public override string ToString()
        {
            return base.ToString() + ", Year: " + this.Specification;
        }
    }
}
