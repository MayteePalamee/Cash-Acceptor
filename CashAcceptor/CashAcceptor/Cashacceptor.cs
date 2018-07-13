using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace CashAcceptor
{
    public class Cashacceptor : SerialPortHelper, IDevicesHelper
    {
        /**
        * event delegate.
        * Declare the event using EventHandler<T>
        **/
        public event EventHandler<Events> RaiseEvents;

        /**
         * delegate method handle raise event
         **/
        protected virtual void OnRaiseEvent(Events e)
        {
            RaiseEvents?.Invoke(this, e);
        }
        /**Initialzed**/
        private SerialPort _serialPort = new SerialPort();
        Response status;

        public Response Connect()
        {
            status = new Response();
            try
            {

            }
            catch (Exception ex)
            {
                status.Fault = ex.Message;
                OnRaiseEvent(new Events(status.Fault));
            }
            return status;
        }

        public Response Disabled()
        {
            status = new Response();
            try
            {

            }
            catch (Exception ex)
            {
                status.Fault = ex.Message;
                OnRaiseEvent(new Events(status.Fault));
            }
            return status;
        }

        public Response Disconnect()
        {
            status = new Response();
            try
            {

            }
            catch (Exception ex)
            {
                status.Fault = ex.Message;
                OnRaiseEvent(new Events(status.Fault));
            }
            return status;
        }

        public Response Enabled()
        {
            status = new Response();
            try
            {

            }
            catch (Exception ex)
            {
                status.Fault = ex.Message;
                OnRaiseEvent(new Events(status.Fault));
            }
            return status;
        }

        public Response Parallel(string command)
        {
            status = new Response();
            try
            {

            }
            catch (Exception ex)
            {
                status.Fault = ex.Message;
                OnRaiseEvent(new Events(status.Fault));
            }
            return status;
        }

        public Response Received()
        {
            status = new Response();
            try
            {

            }
            catch (Exception ex)
            {
                status.Fault = ex.Message;
                OnRaiseEvent(new Events(status.Fault));
            }
            return status;
        }

        public Response Transmitte(string command)
        {
            status = new Response();
            try
            {

            }
            catch (Exception ex)
            {
                status.Fault = ex.Message;
                OnRaiseEvent(new Events(status.Fault));
            }
            return status;
        }
    }
}
