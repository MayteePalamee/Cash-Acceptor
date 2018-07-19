﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashAcceptor
{
    /// <summary>
    /// event message object class
    /// </summary>
    public class Events : EventArgs
    {
        private readonly String _message;
        /// <summary>
        /// setter message
        /// </summary>
        /// <param name="message">data message</param>
        public Events(String message){
            _message = message;
        }
        /// <summary>
        /// getter message
        /// </summary>
        public String Message
        {
            get { return _message; }
        }
    }
}
