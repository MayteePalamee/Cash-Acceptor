using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashAcceptor
{
    /// <summary>
    /// 
    /// </summary>
    public class Response
    {
        private String ready;
        private String unavailable;
        private String exclusion;
        private String reserved;
        private String invalid;
        private String billReject;
        private String billFish;
        private String sensorProblem;
        private String stackerOpen;
        private String billRemove;
        private String billJam;
        private String checkSumError;
        private String motorFailure;
        private String success;
        private String poweroff;
        /// <summary>
        /// 
        /// </summary>
        public String Ready
        {
            get { return ready; }
            set { ready = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String Unavailable
        {
            get { return unavailable; }
            set { unavailable = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String Exclusion
        {
            get { return exclusion; }
            set { exclusion = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String Reserved
        {
            get { return reserved; }
            set { reserved = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String Invalid
        {
            get { return invalid; }
            set { invalid = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String BillReject
        {
            get { return billReject; }
            set { billReject = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String BillFish
        {
            get { return billFish; }
            set { billFish = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String SensorProblem
        {
            get { return sensorProblem; }
            set { sensorProblem = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String StackerOpen
        {
            get { return stackerOpen; }
            set { stackerOpen = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String BillRemove
        {
            get { return billRemove; }
            set { billRemove = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String BillJam
        {
            get { return billJam; }
            set { billJam = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String CheckSumError
        {
            get { return checkSumError; }
            set { checkSumError = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String MotorFailure
        {
            get { return motorFailure; }
            set { motorFailure = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String Success
        {
            get { return success; }
            set { success = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String Poweroff
        {
            get { return poweroff; }
            set { poweroff = value; }
        }
    }
}
