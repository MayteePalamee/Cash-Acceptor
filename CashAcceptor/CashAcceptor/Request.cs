using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashAcceptor
{
    /// <summary>
    /// Devices Command 
    /// </summary>
    public class Request
    {
        private String accept;
        private String enabled;
        private String disabled;
        private String reset;
        private String initial;
        /// <summary>
        /// 
        /// </summary>
        public String Initial
        {
            get { return initial; }
            set { initial = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String Accept
        {
            get { return accept; }
            set { accept = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String Enabled
        {
            get { return enabled; }
            set { enabled = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String Disabled
        {
            get { return disabled; }
            set { disabled = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String Reset
        {
            get { return reset; }
            set { reset = value; }
        }
    }
}
