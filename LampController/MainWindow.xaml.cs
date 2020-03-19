using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.IO.Ports;
using System.Management;

namespace LampController
{
    public partial class MainWindow : MetroWindow
    {
        private bool sector_1_on = false;
        private bool sector_2_on = false;
        private bool sector_3_on = false;
        private bool sector_4_on = false;
        private bool sector_all_on = false;
        private List<string> available_ports = new List<string>();
        private Port port;
        private SerialPort serial_port;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void GetConnectedPorts()
        {
            available_ports.Clear();
            available_ports = ConnectedPorts();
            foreach (string actual in available_ports)
            {
                listBox_ports.Items.Insert(0, actual);
            }
        }
        private List<string> ConnectedPorts()
        {
            List<String> allConnectedPorts = new List<String>();
            foreach (String portName in SerialPort.GetPortNames())
            {
                allConnectedPorts.Add(portName);
            }
            return allConnectedPorts;

        }
        private void Connection_Create()
        {
            try
            {
                if (listBox_ports.SelectedItem != null)
                {

                    port = new Port(listBox_ports.SelectedItem.ToString());
                    serial_port = port.getPort();
                    serial_port.ReadTimeout = 3000;
                    serial_port.Open();
                    listBox_logs.Items.Insert(0, serial_port.PortName.ToString() + " Selected");
                    Lamp_Reset();
                }
                else
                {
                    listBox_logs.Items.Insert(0, "Select a connected device!");
                }
            }
            catch (TimeoutException e)
            {
                listBox_logs.Items.Insert(0, "TimeoutException");
            }
            catch (Exception)
            {
                listBox_logs.Items.Insert(0, "Cannot connect");
            }
        }
        private void Connection_Lost()
        {
            port = null;
            listBox_ports.Items.Clear();
            available_ports.Clear();
            if (serial_port != null)
            {
                serial_port.Close();
                listBox_logs.Items.Insert(0, "Connection lost");
            }


        }
        private void Lamp_Reset()
        {
            try
            {
                serial_port.Write("off");
                listBox_logs.Items.Insert(0, serial_port.ReadLine());
            }
            catch (Exception)
            { 

            }
            finally
            {
                sector_1_on = false;
                sector_2_on = false;
                sector_3_on = false;
                sector_4_on = false;
                sector_all_on = false;
                button_sector_1.Background = Brushes.DarkGray;
                button_sector_2.Background = Brushes.DarkGray;
                button_sector_3.Background = Brushes.DarkGray;
                button_sector_4.Background = Brushes.DarkGray;
                button_sector_all.Background = Brushes.DarkGray;
                button_mode_infra.Background = Brushes.DarkGray;
                button_mode_norm.Background = Brushes.Red;
            }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }
        private void button_refresh_Click(object sender, RoutedEventArgs e)
        {
            listBox_ports.Items.Clear();
            available_ports.Clear();
            GetConnectedPorts();
        }
        private void button_select_Click(object sender, RoutedEventArgs e)
        {
            Connection_Create();
        }
        private void all_sector_check()
        {
            if ((sector_1_on == true) && (sector_2_on == true) && (sector_3_on == true) && (sector_4_on == true))
            {
                sector_all_on = true;
                button_sector_all.Background = Brushes.Red;
            }
            else
            {
                sector_all_on = false;
                button_sector_all.Background = Brushes.DarkGray;
            }
        }
        private void MetroWindow_Initialized(object sender, EventArgs e)
        {

        }
        private void button_sector_1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (sector_1_on == false)
                {
                    serial_port.Write("5on");
                    button_sector_1.Background = Brushes.Red;
                    sector_1_on = true;
                    listBox_logs.Items.Insert(0, serial_port.ReadLine());
                    all_sector_check();
                }
                else
                {
                    serial_port.Write("5off");
                    button_sector_1.Background = Brushes.DarkGray;
                    sector_1_on = false;
                    all_sector_check();
                    listBox_logs.Items.Insert(0, serial_port.ReadLine());
                }
            }
            catch (Exception)
            {
                Connection_Lost();
            }
        }
        private void button_sector_2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (sector_2_on == false)
                {
                    serial_port.Write("2on");
                    button_sector_2.Background = Brushes.Red;
                    sector_2_on = true;
                    all_sector_check();
                    listBox_logs.Items.Insert(0, serial_port.ReadLine());
                }
                else
                {
                    serial_port.Write("2off");
                    button_sector_2.Background = Brushes.DarkGray;
                    sector_2_on = false;
                    all_sector_check();
                    listBox_logs.Items.Insert(0, serial_port.ReadLine());
                }
            }
            catch (Exception)
            {
                Connection_Lost();
            }
        }
        private void button_sector_3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (sector_3_on == false)
                {
                    serial_port.Write("3on");
                    button_sector_3.Background = Brushes.Red;
                    sector_3_on = true;
                    all_sector_check();
                    listBox_logs.Items.Insert(0, serial_port.ReadLine());
                }
                else
                {
                    serial_port.Write("3off");
                    button_sector_3.Background = Brushes.DarkGray;
                    sector_3_on = false;
                    all_sector_check();
                    listBox_logs.Items.Insert(0, serial_port.ReadLine());
                }
            }
            catch (Exception)
            {
                Connection_Lost();
            }
        }
        private void button_sector_4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (sector_4_on == false)
                {
                    serial_port.Write("4on");
                    button_sector_4.Background = Brushes.Red;
                    sector_4_on = true;
                    all_sector_check();
                    listBox_logs.Items.Insert(0, serial_port.ReadLine());
                }
                else
                {
                    serial_port.Write("4off");
                    button_sector_4.Background = Brushes.DarkGray;
                    sector_4_on = false;
                    all_sector_check();
                    listBox_logs.Items.Insert(0, serial_port.ReadLine());
                }
            }
            catch (Exception)
            {
                Connection_Lost();
            }
        }
        private void button_sector_all_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (sector_all_on == false)
                {
                    serial_port.Write("allon");
                    button_sector_all.Background = Brushes.Red;
                    button_sector_1.Background = Brushes.Red;
                    button_sector_2.Background = Brushes.Red;
                    button_sector_3.Background = Brushes.Red;
                    button_sector_4.Background = Brushes.Red;
                    sector_1_on = true;
                    sector_2_on = true;
                    sector_3_on = true;
                    sector_4_on = true;
                    sector_all_on = true;
                    listBox_logs.Items.Insert(0, serial_port.ReadLine());
                }
                else
                {
                    button_sector_all.Background = Brushes.DarkGray;
                    button_sector_1.Background = Brushes.DarkGray;
                    button_sector_2.Background = Brushes.DarkGray;
                    button_sector_3.Background = Brushes.DarkGray;
                    button_sector_4.Background = Brushes.DarkGray;
                    sector_1_on = false;
                    sector_2_on = false;
                    sector_3_on = false;
                    sector_4_on = false;
                    serial_port.Write("alloff");
                    button_sector_all.Background = Brushes.DarkGray;
                    sector_all_on = false;
                    listBox_logs.Items.Insert(0, serial_port.ReadLine());
                }
            }
            catch (Exception)
            {
                Connection_Lost();
            }
        }
        private void button_reset_Click(object sender, RoutedEventArgs e)
        {
            Lamp_Reset();
        }
        private void button_mode_norm_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                serial_port.Write("1off");
                button_mode_norm.Background = Brushes.Red;
                button_mode_infra.Background = Brushes.DarkGray;
                listBox_logs.Items.Insert(0, serial_port.ReadLine());
            }
            catch (Exception)
            {
                Connection_Lost();
            }
        }
        private void button_mode_infra_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                serial_port.Write("1on");
                button_mode_norm.Background = Brushes.DarkGray;
                button_mode_infra.Background = Brushes.Red;
                listBox_logs.Items.Insert(0, serial_port.ReadLine());
            }
            catch (Exception)
            {
                Connection_Lost();
            }
        }
    }
}

