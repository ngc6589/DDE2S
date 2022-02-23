using NDde.Client;
using System.IO.Ports;
using System.Text.RegularExpressions;

namespace DDE2S
{
    public partial class MainForm : Form
    {
        DdeClient ddeClient = new DdeClient("Orbitron", "Tracking");
        ParseString portString = new ParseString();
        Settings setting = new Settings();
        static SerialPort _serialPort = new SerialPort();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            try
            {
                ddeClient.Connect();
                tConnectStatus.Text = "Connected";
            }
            catch (Exception ex)
            {
                tConnectStatus.Text = "Error Connect";
                MessageBox.Show(ex.Message);
            }
            setting.GetSerialPort();
            var comPort = setting.GetString("SERIALPORT");
            bool indexConfirmed = false;
            int i = 0;
            foreach (var (key, value) in setting.sp)
            {
                comboBoxSerialPortName.Items.Add(value);
                if (key == comPort)
                {
                    comboBoxSerialPortName.SelectedIndex = i;
                    indexConfirmed = true;
                }
                i++;
            }
            if (indexConfirmed == false)
            {
                comboBoxSerialPortName.SelectedIndex = 0;
            }
            var baudRate = setting.GetString("BAUDRATE");

            i = 0;
            foreach (var item in comboBoxSerialPortBaudRate.Items)
            {
                if (baudRate == item.ToString())
                {
                    comboBoxSerialPortBaudRate.SelectedIndex = i;
                    break;
                }
                i++;
            }

            int databits = setting.GetInt("DATABITS");
            if (databits == 8)
            {
                radioButtonDataBit8.Checked = true;
            }
            else if (databits == 7)
            {
                radioButtonDataBit7.Checked = true;
            }

            string parity = setting.GetString("PARITY");
            if (parity == "None")
            {
                radioButtonParityNone.Checked = true;
            }
            else if (parity == "Odd")
            {
                radioButtonParityOdd.Checked = true;
            }
            else if (parity == "Even")
            {
                radioButtonParityEven.Checked = true;
            }

            string stopbits = setting.GetString("STOPBITS");
            if (stopbits == "One")
            {
                radioButtonStopBits1.Checked = true;
            }
            else if (stopbits == "Two")
            {
                radioButtonStopBits2.Checked = true;
            }
            else if (stopbits == "OnePointFive")
            {
                radioButtonStopBits15.Checked = true;
            }

            string newline = setting.GetString("NEWLINE");
            if (newline == "False")
            {
                checkBoxNewline.Checked = false;
            }
            else
            {
                checkBoxNewline.Checked = true;
            }

            string semicolon = setting.GetString("SEMICOLON");
            if (semicolon == "False")
            {
                checkBoxSemicolon.Checked = false;
            }
            else
            {
                checkBoxSemicolon.Checked = true;
            }

            var outFormat = setting.GetString("OUTFORMAT");
            textBoxStringFormat.Text = outFormat;

            int interval = setting.GetInt("DDEINTERVAL");
            timer1.Interval = interval;
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                byte[] data = ddeClient.Request("TrackingDataEx", 1, 1000);
                string str_data = System.Text.Encoding.ASCII.GetString(data);
                portString.setstr(str_data);
                tSatName.Text = portString.satellite;
                tAzimuth.Text = portString.azimuth;
                tElevation.Text = portString.elevation;
                tUpLink.Text = String.Concat(portString.upFreq, " Hz");
                tDownLink.Text = String.Concat(portString.dnFreq, " Hz");
                tUplinkMode.Text = portString.upMode;
                tDownlinkMode.Text = portString.dnMode;
                tRange.Text = String.Concat(portString.range, " km");
                tRangeRate.Text = String.Concat(portString.rangeRate, " km/s");
                tAltitude.Text = String.Concat(portString.latitude, " km");

                if (connectBtn.Checked == true)
                {
                    if (_serialPort.IsOpen == false)
                    {
                        _serialPort.PortName = setting.GetString("SERIALPORT");
                        _serialPort.BaudRate = setting.GetInt("BAUDRATE");
                        _serialPort.DataBits = setting.GetInt("DATABITS");
                        _serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), setting.GetString("PARITY"), true);
                        _serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), setting.GetString("STOPBITS"), true);
                        _serialPort.Handshake = Handshake.None;
                        try
                        {
                            _serialPort.RtsEnable = true;
                            _serialPort.Open();
                            _serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                            connectBtn.Text = "DISCONNECT";
                            tSerialStatus.Text = "CONNECTED";
                        }
                        catch (Exception ex)
                        {
                            connectBtn.Checked = false;
                            textBox1.AppendText("CONNECT ERROR ");
                            MessageBox.Show(ex.Message + setting.GetString("SERIALPORT"));
                        }
                    }
                    String outStr = textBoxStringFormat.Text;
                    var regSN = new Regex("<SN>");
                    var regDN = new Regex("<DN>");
                    var regUP = new Regex("<UP>");
                    var regAZ = new Regex("<AZ>");
                    var regEL = new Regex("<EL>");
                    var regCR = new Regex("<CR>");
                    var regLF = new Regex("<LF>");
                    outStr = regSN.Replace(outStr, portString.satellite);
                    outStr = regDN.Replace(outStr, portString.dnFreq);
                    outStr = regUP.Replace(outStr, portString.upFreq);
                    outStr = regAZ.Replace(outStr, portString.azimuth);
                    outStr = regEL.Replace(outStr, portString.elevation);
                    outStr = regCR.Replace(outStr, "\r");
                    outStr = regLF.Replace(outStr, "\n");

                    _serialPort.Write(outStr);
                    if (checkBoxNewline.Checked == true)
                    {
                        outStr += "\r\n";
                    }
                    textBox1.AppendText(outStr);
                }

                if (connectBtn.Checked == false)
                {
                    if (_serialPort.IsOpen == true)
                    {
                        _serialPort.DataReceived -= new SerialDataReceivedEventHandler(DataReceivedHandler);
                        _serialPort.DiscardInBuffer();
                        _serialPort.DiscardOutBuffer();
                        _serialPort.Close();
                    }
                    textBox1.Text = "";
                    connectBtn.Text = "CONNECT";
                    tSerialStatus.Text = "CLOSE";
                }
            }
            catch (Exception ex)
            {
                connectBtn.Checked = false;
                connectBtn.Text = "CONNECT";
                MessageBox.Show(ex.Message);
            }

            if (textBox1.TextLength > 3000)
            {
                textBox1.Select(0, textBox1.TextLength - 3000);
                textBox1.SelectedText = "";
                textBox1.Select(textBox1.TextLength, 0);
                textBox1.ScrollToCaret();
            }

            if (textBox2.TextLength > 3000)
            {
                textBox2.Select(0, textBox2.TextLength - 3000);
                textBox2.SelectedText = "";
                textBox2.Select(textBox2.TextLength, 0);
                textBox2.ScrollToCaret();
            }
        }

        public void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            var regSE = new Regex(";");
            string indata = _serialPort.ReadExisting();
            indata = regSE.Replace(indata, ";\r\n");
            textBox2.AppendText(indata);
        }

        private void ComboBoxSerialPortName_SelectedValueChanged(object sender, EventArgs e)
        {
            var portName = setting.sp.FirstOrDefault(x => x.Value == comboBoxSerialPortName.Text);
            setting.UpdateCnnf("SERIALPORT", portName.Key.ToString());
        }

        private void ComboBoxSerialPortCharSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            setting.UpdateCnnf("BAUDRATE", comboBoxSerialPortBaudRate.Text);
        }

        private void RadioButtonDataBit8_CheckedChanged(object sender, EventArgs e)
        {
            setting.UpdateCnnf("DATABITS", "8");
        }

        private void RadioButtonDataBit7_CheckedChanged(object sender, EventArgs e)
        {
            setting.UpdateCnnf("DATABITS", "7");
        }

        private void RadioButtonParityNone_CheckedChanged(object sender, EventArgs e)
        {
            setting.UpdateCnnf("PARITY", Parity.None.ToString());
        }

        private void RadioButtonParityOdd_CheckedChanged(object sender, EventArgs e)
        {
            setting.UpdateCnnf("PARITY", Parity.Odd.ToString());
        }

        private void RadioButtonParityEven_CheckedChanged(object sender, EventArgs e)
        {
            setting.UpdateCnnf("PARITY", Parity.Even.ToString());
        }

        private void RadioButtonStopBits1_CheckedChanged(object sender, EventArgs e)
        {
            setting.UpdateCnnf("STOPBITS", StopBits.One.ToString());
        }

        private void RadioButtonStopBits15_CheckedChanged(object sender, EventArgs e)
        {
            setting.UpdateCnnf("STOPBITS", StopBits.OnePointFive.ToString());
        }

        private void RadioButtonStopBits2_CheckedChanged(object sender, EventArgs e)
        {
            setting.UpdateCnnf("STOPBITS", StopBits.Two.ToString());
        }

        private void TextBoxStringFormat_TextChanged(object sender, EventArgs e)
        {
            setting.UpdateCnnf("OUTFORMAT", textBoxStringFormat.Text);
        }

        private void comboBoxSerialPortName_SelectedIndexChanged(object sender, EventArgs e)
        {
            var portName = setting.sp.FirstOrDefault(x => x.Value == comboBoxSerialPortName.Text);
            setting.UpdateCnnf("SERIALPORT", portName.Key.ToString());
        }

        private void checkBoxNewline_CheckedChanged(object sender, EventArgs e)
        {
            setting.UpdateCnnf("NEWLINE", checkBoxNewline.Checked.ToString());
        }

        private void checkBoxSemicolon_CheckedChanged(object sender, EventArgs e)
        {
            setting.UpdateCnnf("SEMICOLON", checkBoxSemicolon.Checked.ToString());
        }

        private void connectBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (connectBtn.Checked == true)
            {
                comboBoxSerialPortName.Enabled = false;
                comboBoxSerialPortBaudRate.Enabled = false;
                radioButtonDataBit8.Enabled = false;
                radioButtonDataBit7.Enabled = false;
                radioButtonParityNone.Enabled = false;
                radioButtonParityOdd.Enabled = false;
                radioButtonParityEven.Enabled = false;
                radioButtonStopBits1.Enabled = false;
                radioButtonStopBits15.Enabled = false;
                radioButtonStopBits2.Enabled = false;
            }
            else
            {
                comboBoxSerialPortName.Enabled = true;
                comboBoxSerialPortBaudRate.Enabled = true;
                radioButtonDataBit8.Enabled = true;
                radioButtonDataBit7.Enabled = true;
                radioButtonParityNone.Enabled = true;
                radioButtonParityOdd.Enabled = true;
                radioButtonParityEven.Enabled = true;
                radioButtonStopBits1.Enabled = true;
                radioButtonStopBits15.Enabled = true;
                radioButtonStopBits2.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }
    }
}