using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace SerialToArduino
{
    public partial class Form1 : Form
    {
        string dataOut, Memory, Direction;

        string dataIn;
        string strIn1;
        string strIn2;
        string strIn3;
        string strIn4;
        string strIn5;
        string strOut1;
        string strOut2;
        string strOut3;
        string strOut4;
        string strOut5;
        string OutRange1;
        string OutRange2;
        string OutRange3;
        string OutRange4;
        string OutRange5;
        string OutRange6;
        string OutRange7;
        string OutRange8;
        string OutRange9;
        string OutRange10;

        string strMemoryUse;

        #region Main Fanction

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string [] ports = SerialPort.GetPortNames();
            cBoxComPort.Items.AddRange(ports);

            cBoxBaudRate.Text = "115200";
            cBoxDataBits.Text = "8";
            cBoxStopBits.Text = "One";
            cBoxParityBits.Text = "None";

            tbText.Enabled = false;

            btnMemory1.Enabled = false;
            btnMemory2.Enabled = false;
            btnMemory3.Enabled = false;
            btnMemory4.Enabled = false;
            btnMemory5.Enabled = false;

            btnUse1.Enabled = false;
            btnUse2.Enabled = false;
            btnUse3.Enabled = false;
            btnUse4.Enabled = false;
            btnUse5.Enabled = false;

            btnReset.Enabled = false;
            btnSetZero.Enabled = false;

            lbMemoryUse.Text = "";
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cBoxComPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(cBoxBaudRate.Text);
                serialPort1.DataBits = Convert.ToInt32(cBoxDataBits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBoxStopBits.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cBoxParityBits.Text);

                serialPort1.Open();
                
                progressBar1.Value = 100;

                btnClear.Enabled = true;
                btnIn.Enabled = true;
                btnOut.Enabled = true;
                btnClose.Enabled = true;

                btnUse1.Enabled = true;
                btnUse2.Enabled = true;
                btnUse3.Enabled = true;
                btnUse4.Enabled = true;
                btnUse5.Enabled = true;

                btnReset.Enabled = true;
                btnSetZero.Enabled = true;

                checkBox1.Enabled = false;
                cBoxComPort.Enabled = false;
                cBoxBaudRate.Enabled = false;
                cBoxDataBits.Enabled = false;
                cBoxStopBits.Enabled = false;
                cBoxParityBits.Enabled = false;
                btnOpen.Enabled = false;

                lbStatus.Text = "Connect";

                serialPort1.Write("-/-/-/-/0/0;");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            lbStatus.Text = "Disconnect";

            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;

                lbMemoryUse.Text = "";

                btn0.Enabled = false;
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;
                btnIn.Enabled = false;
                btnOut.Enabled = false;
                btnClear.Enabled = false;
                tbText.Enabled = false;
                btnClose.Enabled = false;

                btnUse1.Enabled = false;
                btnUse2.Enabled = false;
                btnUse3.Enabled = false;
                btnUse4.Enabled = false;
                btnUse5.Enabled = false;

                btnReset.Enabled = false;
                btnSetZero.Enabled = false;

                tbIn1.Clear();
                tbIn2.Clear();
                tbIn3.Clear();
                tbIn4.Clear();
                tbIn5.Clear();
                tbOut1.Clear();
                tbOut2.Clear();
                tbOut3.Clear();
                tbOut4.Clear();
                tbOut5.Clear();
                tbText.Clear();

                cBoxComPort.Enabled = true;
                cBoxBaudRate.Enabled = true;
                checkBox1.Enabled = true;
                btnOpen.Enabled = true;

                if(checkBox1.Checked == true)
                {
                    cBoxDataBits.Enabled = true;
                    cBoxStopBits.Enabled = true;
                    cBoxParityBits.Enabled = true;
                }
            }
        }

        private void cBoxComPort_DropDown(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBoxComPort.Items.Clear();
            cBoxComPort.Items.AddRange(ports);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                cBoxDataBits.Enabled = true;
                cBoxStopBits.Enabled = true;
                cBoxParityBits.Enabled = true;
            }
            else
            {
                cBoxDataBits.Enabled = false;
                cBoxStopBits.Enabled = false;
                cBoxParityBits.Enabled = false;
            }
        }

        #endregion

        #region Tx

        private void tbText_TextChanged(object sender, EventArgs e)
        {
            if (tbText.Text.Length > 0)
            {
                btnMemory1.Enabled = true;
                btnMemory2.Enabled = true;
                btnMemory3.Enabled = true;
                btnMemory4.Enabled = true;
                btnMemory5.Enabled = true;
            }
            else
            {
                btnMemory1.Enabled = false;
                btnMemory2.Enabled = false;
                btnMemory3.Enabled = false;
                btnMemory4.Enabled = false;
                btnMemory5.Enabled = false;
            }
        }

        private void tbText_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsDigit(c) && c != 8)
            {
                e.Handled = true;
            }
        }

        #region NumPad

        private void btn1_Click(object sender, EventArgs e)
        {
            if (tbText.Text.Length < 6)
            {
                tbText.Text += "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (tbText.Text.Length < 6)
            {
                tbText.Text += "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (tbText.Text.Length < 6)
            {
                tbText.Text += "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (tbText.Text.Length < 6)
            {
                tbText.Text += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (tbText.Text.Length < 6)
            {
                tbText.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (tbText.Text.Length < 6)
            {
                tbText.Text += "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (tbText.Text.Length < 6)
            {
                tbText.Text += "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (tbText.Text.Length < 6)
            {
                tbText.Text += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (tbText.Text.Length < 6)
            {
                tbText.Text += "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (tbText.Text.Length < 6)
            {
                tbText.Text += "0";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbText.Clear();
            tbText.Enabled = false;

            btn0.Enabled = false;
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
            btnIn.Enabled = true;
            btnOut.Enabled = true;
        }

        #endregion

        #region Selected Direction

        private void btnIn_Click(object sender, EventArgs e)
        {
            Direction = "1";

            tbText.Enabled = true;

            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btnIn.Enabled = false;
            btnOut.Enabled = true;

            tbText.Focus();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            Direction = "2";

            tbText.Enabled = true;

            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btnOut.Enabled = false;
            btnIn.Enabled = true;

            tbText.Focus();
        }

        #endregion

        #region Send Data

        #region Memory

        private void btnMemory1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                Memory = "1";
                dataOut = Memory + "/" + "-" + "/" + Direction + "/" + tbText.Text + "/0/0;";
                serialPort1.Write(dataOut);
                tbText.Clear();
                tbText.Enabled = false;

                Direction = "0";

                Hidden();
            }
        }

        private void btnMemory2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                Memory = "2";
                dataOut = Memory + "/" + "-" + "/" + Direction + "/" + tbText.Text + "/0/0;";
                serialPort1.Write(dataOut);
                tbText.Clear();
                tbText.Enabled = false;

                Direction = "0";

                Hidden();
            }
        }

        private void btnMemory3_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                Memory = "3";
                dataOut = Memory + "/" + "-" + "/" + Direction + "/" + tbText.Text + "/0/0;";
                serialPort1.Write(dataOut);
                tbText.Clear();
                tbText.Enabled = false;

                Direction = "0";

                Hidden();
            }
        }

        private void btnMemory4_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                Memory = "4";
                dataOut = Memory + "/" + "-" + "/" + Direction + "/" + tbText.Text + "/0/0;";
                serialPort1.Write(dataOut);
                tbText.Clear();
                tbText.Enabled = false;

                Direction = "0";

                Hidden();
            }
        }

        private void btnMemory5_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                Memory = "5";
                dataOut = Memory + "/" + "-" + "/" + Direction + "/" + tbText.Text + "/0/0;";
                serialPort1.Write(dataOut);
                tbText.Clear();
                tbText.Enabled = false;

                Direction = "0";

                Hidden();
            }
        }

        private void btnSetZero_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                Memory = "1";
                dataOut = Memory + "/-/-/-/0/1;";
                serialPort1.Write(dataOut);
                tbText.Clear();
                tbText.Enabled = false;

                Direction = "0";

                Hidden();
            }
        }

        private void Hidden()
        {
            btnIn.Enabled = true;
            btnOut.Enabled = true;
            btn0.Enabled = false;
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
        }

        #endregion

        #region Use Memory

        private void btnUse1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("-/1/-/-/0/0;");
            }
        }

        private void btnUse2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("-/2/-/-/0/0;");
            }
        }

        private void btnUse3_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("-/3/-/-/0/0;");
            }
        }

        private void btnUse4_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("-/4/-/-/0/0;");
            }
        }

        private void btnUse5_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("-/5/-/-/0/0;");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("-/-/-/-/1/0;");

                btnUse1.Enabled = false;
                btnUse2.Enabled = false;
                btnUse3.Enabled = false;
                btnUse4.Enabled = false;
                btnUse5.Enabled = false;
                btnSetZero.Enabled = false;

                System.Threading.Thread.Sleep(2000);

                btnUse1.Enabled = true;
                btnUse2.Enabled = true;
                btnUse3.Enabled = true;
                btnUse4.Enabled = true;
                btnUse5.Enabled = true;
                btnSetZero.Enabled = true;
            }
        }

        #endregion

        #endregion

        #endregion

        #region Rx

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                dataIn += serialPort1.ReadExisting();
                RxIn1Data(dataIn);

                this.Invoke(new EventHandler(ShowData));
                dataIn = null;
            }
            catch (Exception)
            {
                //MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowData(object sender, EventArgs e)
        {
            if (strIn1 != "-")
            {
                tbIn1.Text = strIn1;
            }
            if (strIn2 != "-")
            {
                tbIn2.Text = strIn2;
            }
            if (strIn3 != "-")
            {
                tbIn3.Text = strIn3;
            }
            if (strIn4 != "-")
            {
                tbIn4.Text = strIn4;
            }
            if (strIn5 != "-")
            {
                tbIn5.Text = strIn5;
            }

            if (strOut1 != "-")
            {
                tbOut1.Text = strOut1;
            }
            if (strOut2 != "-")
            {
                tbOut2.Text = strOut2;
            }
            if (strOut3 != "-")
            {
                tbOut3.Text = strOut3;
            }
            if (strOut4 != "-")
            {
                tbOut4.Text = strOut4;
            }
            if (strOut5 != "-")
            {
                tbOut5.Text = strOut5;
            }
            if (strMemoryUse != "-")
            {
                if(strMemoryUse == "1")
                {
                    lbMemoryUse.Text = "P1";
                }
                else if (strMemoryUse == "2")
                {
                    lbMemoryUse.Text = "P2";
                }
                else if (strMemoryUse == "3")
                {
                    lbMemoryUse.Text = "P3";
                }
                else if (strMemoryUse == "4")
                {
                    lbMemoryUse.Text = "P4";
                }
                else if (strMemoryUse == "5")
                {
                    lbMemoryUse.Text = "P5";
                }
            }
        }

        private string RxIn1Data(string dataWaitProcess)
        {
            int Cut;

            Cut = dataWaitProcess.IndexOf("/");
            strIn1 = dataWaitProcess.Substring(0, Cut);

            OutRange1 = dataWaitProcess.Substring(Cut + 1);
            RxIn2Data(OutRange1);

            return strIn1;
        }

        private string RxIn2Data(string dataWaitProcess)
        {
            int Cut;

            Cut = dataWaitProcess.IndexOf("/");
            strIn2 = dataWaitProcess.Substring(0, Cut);

            OutRange2 = dataWaitProcess.Substring(Cut + 1);
            RxIn3Data(OutRange2);

            return strIn2;
        }

        private string RxIn3Data(string dataWaitProcess)
        {
            int Cut;

            Cut = dataWaitProcess.IndexOf("/");
            strIn3 = dataWaitProcess.Substring(0, Cut);

            OutRange3 = dataWaitProcess.Substring(Cut + 1);
            RxIn4Data(OutRange3);

            return strIn3;
        }

        private string RxIn4Data(string dataWaitProcess)
        {
            int Cut;

            Cut = dataWaitProcess.IndexOf("/");
            strIn4 = dataWaitProcess.Substring(0, Cut);

            OutRange4 = dataWaitProcess.Substring(Cut + 1);
            RxIn5Data(OutRange4);

            return strIn4;
        }

        private string RxIn5Data(string dataWaitProcess)
        {
            int Cut;

            Cut = dataWaitProcess.IndexOf("/");
            strIn5 = dataWaitProcess.Substring(0, Cut);

            OutRange5 = dataWaitProcess.Substring(Cut + 1);
            RxOut1Data(OutRange5);

            return strIn5;
        }

        private string RxOut1Data(string dataWaitProcess)
        {
            int Cut;

            Cut = dataWaitProcess.IndexOf("/");
            strOut1 = dataWaitProcess.Substring(0, Cut);

            OutRange6 = dataWaitProcess.Substring(Cut + 1);
            RxOut2Data(OutRange6);

            return strOut1;
        }

        private string RxOut2Data(string dataWaitProcess)
        {
            int Cut;

            Cut = dataWaitProcess.IndexOf("/");
            strOut2 = dataWaitProcess.Substring(0, Cut);

            OutRange7 = dataWaitProcess.Substring(Cut + 1);
            RxOut3Data(OutRange7);

            return strOut2;
        }

        private string RxOut3Data(string dataWaitProcess)
        {
            int Cut;

            Cut = dataWaitProcess.IndexOf("/");
            strOut3 = dataWaitProcess.Substring(0, Cut);

            OutRange8 = dataWaitProcess.Substring(Cut + 1);
            RxOut4Data(OutRange8);

            return strOut3;
        }

        private string RxOut4Data(string dataWaitProcess)
        {
            int Cut;

            Cut = dataWaitProcess.IndexOf("/");
            strOut4 = dataWaitProcess.Substring(0, Cut);

            OutRange9 = dataWaitProcess.Substring(Cut + 1);
            RxOut5Data(OutRange9);

            return strOut4;
        }

        private string RxOut5Data(string dataWaitProcess)
        {
            int Cut;

            Cut = dataWaitProcess.IndexOf("/");
            strOut5 = dataWaitProcess.Substring(0, Cut);

            OutRange10 = dataWaitProcess.Substring(Cut + 1);
            RxStatusMemoryData(OutRange10);

            return strOut5;
        }

        private string RxStatusMemoryData(string dataWaitProcess)
        {
            int Cut;

            Cut = dataWaitProcess.IndexOf(";");
            strMemoryUse = dataWaitProcess.Substring(0, Cut);

            return strMemoryUse;
        }

        #endregion

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            string NowTime;
            string NowDate;
            string DataSaveAll;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter(saveFileDialog1.FileName.ToString());
                NowDate = Convert.ToString(DateTime.Now.Day) + "/" + Convert.ToString(DateTime.Now.Month) + "/" + Convert.ToString(DateTime.Now.Year);
                NowTime = Convert.ToString(DateTime.Now.Hour) + ":" + Convert.ToString(DateTime.Now.Minute) + ":" + Convert.ToString(DateTime.Now.Second);
                DataSaveAll = "DateSetting :\t" + NowDate + "\nTime :\t\t" + NowTime + "\nMemory" + "\t\tServo In" + "\t\tServo Out" + "\nProgram 1 :" + "\t" + tbIn1.Text + "\t\t" + tbOut1.Text + "\nProgram 2 :" + "\t" + tbIn2.Text + "\t\t" + tbOut2.Text + "\nProgram 3 :" + "\t" + tbIn3.Text + "\t\t" + tbOut2.Text + "\nProgram 4 :" + "\t" + tbIn4.Text + "\t\t" + tbOut4.Text + "\nProgram 5 :" + "\t" + tbIn5.Text + "\t\t" + tbOut5.Text + "\nMemory Use : " + lbMemoryUse.Text;
                file.WriteLine(DataSaveAll);
                file.Close();
            }
        }
    }
}