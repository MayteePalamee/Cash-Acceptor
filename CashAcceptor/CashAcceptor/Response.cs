using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashAcceptor
{
    public class Response
    {
        private String connect;
        private String disconnect;
        private String fault;
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

        public String Connect
        {
            get { return connect; }
            set { connect = value; }
        }
        public String Ready
        {
            get { return ready; }
            set { ready = value; }
        }
        public String Disconnect
        {
            get { return disconnect; }
            set { disconnect = value; }
        }
        public String Fault
        {
            get { return fault; }
            set { fault = value; }
        }
        public String Unavailable
        {
            get { return unavailable; }
            set { unavailable = value; }
        }
        public String Exclusion
        {
            get { return exclusion; }
            set { exclusion = value; }
        }
        public String Reserved
        {
            get { return reserved; }
            set { reserved = value; }
        }
        public String Invalid
        {
            get { return invalid; }
            set { invalid = value; }
        }
        public String BillReject
        {
            get { return billReject; }
            set { billReject = value; }
        }
        public String BillFish
        {
            get { return billFish; }
            set { billFish = value; }
        }
        public String SensorProblem
        {
            get { return sensorProblem; }
            set { sensorProblem = value; }
        }
        public String StackerOpen
        {
            get { return stackerOpen; }
            set { stackerOpen = value; }
        }
        public String BillRemove
        {
            get { return billRemove; }
            set { billRemove = value; }
        }
        public String BillJam
        {
            get { return billJam; }
            set { billJam = value; }
        }
        public String CheckSumError
        {
            get { return checkSumError; }
            set { checkSumError = value; }
        }
        public String MotorFailure
        {
            get { return motorFailure; }
            set { motorFailure = value; }
        }
        public String Success
        {
            get { return success; }
            set { success = value; }
        }
        public String Poweroff
        {
            get { return poweroff; }
            set { poweroff = value; }
        }
    }
}
