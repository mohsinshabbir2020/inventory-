using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_system.classes
{
    class po
    {
        protected int ponumber;
        protected DateTime date;
        protected string podescription;


        public int Ponumber
        { set { ponumber = value; } get { return ponumber; } }

        public DateTime Date
        { set { date = value; } get { return date; } }

        public string Podescription
        { set { podescription = value; } get { return podescription; } }
    }
}
