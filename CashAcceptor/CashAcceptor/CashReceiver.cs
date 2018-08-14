using System;
using System.IO.Ports;
using System.Threading;
namespace CashReceiver
{
    /// <summary>
    /// cash acceptor class
    /// </summary>
    public class Cashreceiver : SerialPortHelper
    {
        private string _invoke = "";
        //Acknowledge event
        private delegate string _acknowledge(String e);
        private event _acknowledge _accept;
        private string _message = "";
        /// <summary>
        /// Receive return data from device
        /// </summary>
        /// <param name="e">808f</param>
        private string OnAccept(string e)
        {
            _message = _accept?.Invoke(e);
            return _message;
        }

        /// <summary>
        /// Declare the event using EventHandler cash acceptor.
        /// </summary>
        public event EventHandler<CashEvent> Receiver;
        /// <summary>
        /// delegate method handle cash accept event
        /// </summary>
        /// <param name="e">serial data received</param>
        protected virtual void OnReceive(CashEvent e)
        {
            Receiver?.Invoke(this, e);
        }

        private SerialPort _serialPort = new SerialPort();
        private void _serialPortDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            /*something code*/
            if (_serialPort.IsOpen)
            {
                SerialPort sp = (SerialPort)sender;
                int count = sp.BytesToRead;
                byte[] data = new byte[count];

                sp.Read(data, 0, data.Length);
                string result = OnAccept(ConvertByteToString(data));

                OnReceive(new CashEvent(result));

            }
        }
        private InitialPort initPort;
        /// <summary>
        /// setter serial port
        /// </summary>
        /// <param name="port">port name</param>
        public void SetPort(String port)
        {
            initPort = new InitialPort();
            initPort.Comport = port;
            initPort.BaudRate = 9600;
            initPort.DataBits = 8;
            initPort.DtrEnable = false;

            _serialPort = Initial(initPort);
        }
        /// <summary>
        /// getter port
        /// </summary>
        /// <returns>port name </returns>
        public String GetPort()
        {
            return _serialPort.PortName == null ? "" : _serialPort.PortName;
        }
        /// <summary>
        /// Enabled Devices.
        /// </summary>
        /// <returns>Command 3E return status</returns>
        public String Open()
        {
            Byte[] data = { };
            try
            {
                if (!_serialPort.IsOpen)
                {
                    _serialPort.Open();
                }
                if (_serialPort.IsOpen)
                {
                    //Enable Device
                    data = ConvertHexToByte("3E");
                    _serialPort.Write(data, 0, data.Length);
                    //Initial state
                    _accept += Acknowledge;

                    Thread.Sleep(100);
                    CallbackState();
                    if (_invoke.Equals(CashStatus.Ready.ToString()))
                    {
                        _serialPort.DataReceived += _serialPortDataReceived;
                    }
                }
            }
            catch (Exception exception)
            {
                _serialPort.Close();
                Console.WriteLine("exception : " + exception);
            }
            return _invoke;
        }

        /// <summary>
        /// Disabled devices.
        /// </summary>
        /// <returns>Boolean</returns>
        public String Close()
        {
            Byte[] data = { };
            try
            {
                if (!_serialPort.IsOpen)
                {
                     _serialPort.Open();
                }
                if (_serialPort.IsOpen)
                {
                    //Disabled Device
                    data = ConvertHexToByte("5E");
                    _serialPort.Write(data, 0, data.Length);
                    //Initial state
                    _accept += Acknowledge;
                    Thread.Sleep(100);
                    CallbackState();
                }
                _serialPort.DiscardOutBuffer();
                _serialPort.DiscardInBuffer();
                _serialPort.Close();
            }
            catch (Exception exception)
            {
                _serialPort.Close();
                Console.WriteLine("exception : " + exception);
            }
            _accept -= Acknowledge;
            _serialPort.DataReceived -= _serialPortDataReceived;
            return _invoke;
        }       
        
        /// <summary>
        /// current status device
        /// </summary>
        /// <returns>string status</returns>
        public String CurrentStatus()
        {
            byte[] data = { };
            try
            {
                _serialPort.DataReceived -= _serialPortDataReceived;
                if (!_serialPort.IsOpen)
                {
                    _serialPort.Open();
                }

                if (_serialPort.IsOpen)
                {
                    CallbackState();
                }
            }
            catch (Exception exception)
            {
                _serialPort.Close();
                Console.WriteLine("exception : " + exception);
            }
            Console.WriteLine("current state : " + _invoke);
            _serialPort.DataReceived += _serialPortDataReceived;
            return _invoke;
        }
        private string Acknowledge(string e)
        {
            byte[] data = { };
            string result = "";
            if (_serialPort.IsOpen)
            {
                switch (e.ToUpper())
                {
                      case "808F":  /*start device*/
                        data = ConvertHexToByte("02");
                        _serialPort.Write(data, 0, data.Length);
                        result = "";
                        break;
                    case "8140": /*20*/
                        data = ConvertHexToByte("02");
                        _serialPort.Write(data, 0, data.Length);
                        result = "20";
                        break;
                    case "8141": /*50*/
                        data = ConvertHexToByte("02");
                        _serialPort.Write(data, 0, data.Length);
                        result = "50";
                        break;
                    case "8142": /*100*/
                        data = ConvertHexToByte("02");
                        _serialPort.Write(data, 0, data.Length);
                        result = "100";
                        break;
                    case "8143": /*500*/
                        data = ConvertHexToByte("02");
                        _serialPort.Write(data, 0, data.Length);
                        result = "500";
                        break;
                    case "8144": /*1000*/
                        data = ConvertHexToByte("02");
                        _serialPort.Write(data, 0, data.Length);
                        result = "1000";
                        break;
                    case "10": /*success*/
                        result = "";
                        break;
                    default :
                        result = "";//e.ToUpper();
                        break;
                }                
            }
            return result;
        }
        private void CallbackState()
        {
            byte[] data = { };
            try
            {
                _serialPort.DataReceived -= _serialPortDataReceived;
                if (!_serialPort.IsOpen)
                {
                    _serialPort.Open();
                }
                
                if (_serialPort.IsOpen)
                {
                     data = ConvertHexToByte("0C");
                     _serialPort.Write(data, 0, data.Length);
                     Thread.Sleep(100);
                     CallState(_serialPort);
                }
            }
            catch(Exception exception)
            {
                _serialPort.Close();
                Console.WriteLine("exception : " + exception);
            }
        }

        private delegate void getStatus(string data);
        private void GetState(string data)
        {
            switch (data.ToUpper())
            {
                case "00" :
                    _invoke = CashStatus.Poweroff.ToString();
                    break;
                case "20":
                    _invoke = CashStatus.MotorFailure.ToString();
                    break;
                case "21":
                    _invoke = CashStatus.CheckSumError.ToString();
                    break;
                case "22":
                    _invoke = CashStatus.BillJam.ToString();
                    break;
                case "23":
                    _invoke = CashStatus.BillRemove.ToString();
                    break;
                case "24":
                    _invoke = CashStatus.StackerOpen.ToString();
                    break;
                case "25":
                    _invoke = CashStatus.SensorProblem.ToString();
                    break;
                case "27":
                    _invoke = CashStatus.BillFish.ToString();
                    break;
                case "29":
                    Console.WriteLine("Bill Reject");
                    break;
                case "2A":
                    Console.WriteLine("Invalid Command");
                    break;
                case "2E":
                    Console.WriteLine("Reserved");
                    break;
                case "2F":
                    Console.WriteLine("Response when Error Status is Exclusion");
                    break;
                case "3E":
                    _invoke = CashStatus.Ready.ToString();
                    break;
                case "5E":
                    _invoke = CashStatus.Unavailable.ToString();
                    break;
                default:
                    _invoke = "";
                    break;
            }
        }
        private void CallState(SerialPort serialPort)
        {
            if (serialPort.IsOpen)
            {
                int count = serialPort.BytesToRead;
                serialPort.ReadTimeout = 1000;
                int totBytesRead = 0;
                byte[] rxBytes = new byte[count];

                    while (totBytesRead < count)
                    {
                        int bytesRead = serialPort.Read(rxBytes, totBytesRead, count - totBytesRead);
                        totBytesRead += bytesRead;
                    }
                getStatus get = new getStatus(GetState);
                get(ConvertByteToString(rxBytes));
            }
        }
    }
}
