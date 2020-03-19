using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Ports;
using System.Management;

namespace LampController
{
    class Port
    {
        private string port_id;
        private SerialPort serial_port;
        public Port(string port_id)
        {
            this.port_id = port_id;
            createConnection();
        }
        private void createConnection()
        {
            serial_port = new SerialPort(port_id, 9600, Parity.None, 8, StopBits.One);
            
        }
        public SerialPort getPort()
        {
            return serial_port;
        }
    }
}
