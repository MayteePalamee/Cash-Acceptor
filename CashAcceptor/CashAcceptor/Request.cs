using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashAcceptor
{
    public class Request
    {
        private String accept;
        private String enabled;
        private String disabled;
        private String reset;

        public String Accept
        {
            get { return accept; }
            set { accept = value; }
        }
        public String Enabled
        {
            get { return enabled; }
            set { enabled = value; }
        }
        public String Disabled
        {
            get { return disabled; }
            set { disabled = value; }
        }
        public String Reset
        {
            get { return reset; }
            set { reset = value; }
        }
    }
}
