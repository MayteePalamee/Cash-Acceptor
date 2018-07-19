using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashAcceptor
{

    public class Accept
    {
        private String state;
        private String description;

        public String State
        {
            get { return state; }
            set { state = value; }
        }
        public String Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
