using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_system.classes
{
    class productreturn
    {
        protected DateTime date;
        protected string department;
        //asset will be drive from asset class as well

        public DateTime Date
        { set { date = value; } get { return date; } }

        public string Department
        { set { department = value; } get { return department; } }
    
    }
}
