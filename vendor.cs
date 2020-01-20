using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_system.classes
{
    class vendor:person
    {
        protected int ntnnumber;

        public int Ntnnumber
        { set { ntnnumber = value; } get { return ntnnumber; } }

    }
}
