using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace CashAcceptor
{
    /// <summary>
    /// cash acceptor class
    /// </summary>
    public class Cashacceptor : SerialPortHelper
    {
        /// <summary>
        /// Initial command cash acceptor
        /// </summary>
        private Cashacceptor()
        {
            new Request
            {
                Enabled = "3E",
                Disabled = "5E",
                Accept = "0C",
                Reset = "30",
                Initial = "02"
            };
        }
        /// <summary>
        /// Declare the event using EventHandler
        /// </summary>
        public event EventHandler<Events> MessageEvents;
        /// <summary>
        /// Declare the event using EventHandler cash acceptor.
        /// </summary>
        public event EventHandler<Events> CashAccept;
        /// <summary>
        /// delegate method handle raise event
        /// </summary>
        /// <param name="e">message</param>
        protected virtual void OnMessage(Events e)
        {
            MessageEvents?.Invoke(this, e);
        }
        /// <summary>
        /// delegate method handle cash accept event
        /// </summary>
        /// <param name="e">serial data received</param>
        protected virtual void OnAccept(Events e)
        {
            CashAccept?.Invoke(this, e);
        }
        private SerialPort _serialPort = new SerialPort();
        Accept accept;
        /// <summary>
        /// Connect to Devices.
        /// </summary>
        /// <returns>Boolean</returns>
        public Boolean Connect()
        {
            bool result = false;
            try
            {
                _serialPort = Initial();
                if (_serialPort.IsOpen)
                {
                    _serialPort.DataReceived += _serialPortDataReceived;
                }
            }
            catch (Exception ex)
            {
                OnMessage(new Events(ex.Message));
            }
            return result;
        }

        private void _serialPortDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            /*something code*/

            OnAccept(new Events("received cash"));
        }
        /// <summary>
        /// Disabled devices.
        /// </summary>
        /// <returns>Boolean</returns>
        public Boolean Disabled()
        {
            bool result = false;
            try
            {

            }
            catch (Exception ex)
            {
                OnMessage(new Events(ex.Message));
            }
            return result;
        }
        /// <summary>
        /// Disconnect devices.
        /// </summary>
        /// <returns>Boolean</returns>
        public Boolean Disconnect()
        {
            bool result = false;
            try
            {

            }
            catch (Exception ex)
            {
                OnMessage(new Events(ex.Message));
            }
            return result;
        }
        /// <summary>
        /// Enabled Devices.
        /// </summary>
        /// <returns>Boolean</returns>
        public Boolean Enabled()
        {
            bool result = false;
            try
            {

            }
            catch (Exception ex)
            {
                OnMessage(new Events(ex.Message));
            }
            return result;
        }
        /// <summary>
        /// Send command to devices.
        /// </summary>
        /// <param name="command"></param>
        /// <returns>object</returns>
        public Accept Transmitte(string command)
        {
            accept = new Accept();
            try
            {

            }
            catch (Exception ex)
            {
                OnMessage(new Events(ex.Message));
            }
            return accept;
        }
    }
}
