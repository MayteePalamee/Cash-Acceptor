using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashAcceptor
{
    public class Accept
    {
        private String code;
        private String description;

        public String Code
        {
            get { return code; }
            set { code = value; }
        }
        public String Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
