namespace SerialToArduino
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxParityBits = new System.Windows.Forms.ComboBox();
            this.cBoxStopBits = new System.Windows.Forms.ComboBox();
            this.cBoxDataBits = new System.Windows.Forms.ComboBox();
            this.cBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.cBoxComPort = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnMemory5 = new System.Windows.Forms.Button();
            this.btnMemory4 = new System.Windows.Forms.Button();
            this.tbText = new System.Windows.Forms.TextBox();
            this.btnMemory3 = new System.Windows.Forms.Button();
            this.btnMemory2 = new System.Windows.Forms.Button();
            this.btnMemory1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbIn1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbOut1 = new System.Windows.Forms.TextBox();
            this.btnUse5 = new System.Windows.Forms.Button();
            this.btnUse4 = new System.Windows.Forms.Button();
            this.btnUse3 = new System.Windows.Forms.Button();
            this.btnUse2 = new System.Windows.Forms.Button();
            this.btnUse1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.lbMemoryUse = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSetZero = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbOut5 = new System.Windows.Forms.TextBox();
            this.tbOut4 = new System.Windows.Forms.TextBox();
            this.tbOut3 = new System.Windows.Forms.TextBox();
            this.tbOut2 = new System.Windows.Forms.TextBox();
            this.tbIn5 = new System.Windows.Forms.TextBox();
            this.tbIn4 = new System.Windows.Forms.TextBox();
            this.tbIn3 = new System.Windows.Forms.TextBox();
            this.tbIn2 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cBoxParityBits);
            this.groupBox1.Controls.Add(this.cBoxStopBits);
            this.groupBox1.Controls.Add(this.cBoxDataBits);
            this.groupBox1.Controls.Add(this.cBoxBaudRate);
            this.groupBox1.Controls.Add(this.cBoxComPort);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 208);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COMPORT CONTROL";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(21, 180);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(129, 21);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.TabStop = false;
            this.checkBox1.Text = "AdvanceSetting";
            this.toolTip1.SetToolTip(this.checkBox1, "AdvanceSetting");
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Parity Bits";
            this.toolTip1.SetToolTip(this.label5, "Default (None)");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Stop Bits";
            this.toolTip1.SetToolTip(this.label4, "Default (One)");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data Bits";
            this.toolTip1.SetToolTip(this.label3, "Default (8)");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "BaudRate";
            this.toolTip1.SetToolTip(this.label2, "Default (115200)");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "ComPort";
            this.toolTip1.SetToolTip(this.label1, "Selected ComPort");
            // 
            // cBoxParityBits
            // 
            this.cBoxParityBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxParityBits.Enabled = false;
            this.cBoxParityBits.FormattingEnabled = true;
            this.cBoxParityBits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cBoxParityBits.Location = new System.Drawing.Point(105, 149);
            this.cBoxParityBits.Name = "cBoxParityBits";
            this.cBoxParityBits.Size = new System.Drawing.Size(121, 24);
            this.cBoxParityBits.TabIndex = 4;
            this.cBoxParityBits.TabStop = false;
            // 
            // cBoxStopBits
            // 
            this.cBoxStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxStopBits.Enabled = false;
            this.cBoxStopBits.FormattingEnabled = true;
            this.cBoxStopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cBoxStopBits.Location = new System.Drawing.Point(105, 119);
            this.cBoxStopBits.Name = "cBoxStopBits";
            this.cBoxStopBits.Size = new System.Drawing.Size(121, 24);
            this.cBoxStopBits.TabIndex = 3;
            this.cBoxStopBits.TabStop = false;
            // 
            // cBoxDataBits
            // 
            this.cBoxDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxDataBits.Enabled = false;
            this.cBoxDataBits.FormattingEnabled = true;
            this.cBoxDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cBoxDataBits.Location = new System.Drawing.Point(105, 89);
            this.cBoxDataBits.Name = "cBoxDataBits";
            this.cBoxDataBits.Size = new System.Drawing.Size(121, 24);
            this.cBoxDataBits.TabIndex = 2;
            this.cBoxDataBits.TabStop = false;
            // 
            // cBoxBaudRate
            // 
            this.cBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxBaudRate.FormattingEnabled = true;
            this.cBoxBaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "31250",
            "38400",
            "57600",
            "115200",
            "230400",
            "250000",
            "500000",
            "1000000",
            "2000000"});
            this.cBoxBaudRate.Location = new System.Drawing.Point(105, 59);
            this.cBoxBaudRate.Name = "cBoxBaudRate";
            this.cBoxBaudRate.Size = new System.Drawing.Size(121, 24);
            this.cBoxBaudRate.TabIndex = 1;
            this.cBoxBaudRate.TabStop = false;
            // 
            // cBoxComPort
            // 
            this.cBoxComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxComPort.Location = new System.Drawing.Point(105, 29);
            this.cBoxComPort.Name = "cBoxComPort";
            this.cBoxComPort.Size = new System.Drawing.Size(121, 24);
            this.cBoxComPort.TabIndex = 0;
            this.cBoxComPort.TabStop = false;
            this.cBoxComPort.DropDown += new System.EventHandler(this.cBoxComPort_DropDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbStatus);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnOpen);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 169);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.Color.White;
            this.lbStatus.Location = new System.Drawing.Point(70, 80);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(150, 31);
            this.lbStatus.TabIndex = 4;
            this.lbStatus.Text = "Disconnect";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Status :";
            this.toolTip1.SetToolTip(this.label6, "Status communication");
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(17, 127);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(210, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // btnClose
            // 
            this.btnClose.Enabled = false;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(129, 18);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 48);
            this.btnClose.TabIndex = 7;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "&Close";
            this.toolTip1.SetToolTip(this.btnClose, "Disconnect Arduino");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.ForeColor = System.Drawing.Color.Black;
            this.btnOpen.Location = new System.Drawing.Point(11, 18);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(105, 48);
            this.btnOpen.TabIndex = 6;
            this.btnOpen.TabStop = false;
            this.btnOpen.Text = "&Open";
            this.toolTip1.SetToolTip(this.btnOpen, "Connect Arduino");
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnOut
            // 
            this.btnOut.BackColor = System.Drawing.Color.Gray;
            this.btnOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOut.Enabled = false;
            this.btnOut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOut.Location = new System.Drawing.Point(141, 120);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(115, 52);
            this.btnOut.TabIndex = 2;
            this.btnOut.Text = "Servo &OUT";
            this.toolTip1.SetToolTip(this.btnOut, "Backward");
            this.btnOut.UseVisualStyleBackColor = false;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.Gray;
            this.btnIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIn.Enabled = false;
            this.btnIn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Location = new System.Drawing.Point(19, 120);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(115, 52);
            this.btnIn.TabIndex = 1;
            this.btnIn.Text = "Servo &IN";
            this.toolTip1.SetToolTip(this.btnIn, "Forward");
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.Gray;
            this.btn0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn0.Enabled = false;
            this.btn0.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(262, 242);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(75, 122);
            this.btn0.TabIndex = 21;
            this.btn0.TabStop = false;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gray;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Enabled = false;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(262, 120);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 116);
            this.btnClear.TabIndex = 22;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Gray;
            this.btn9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn9.Enabled = false;
            this.btn9.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(181, 306);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 58);
            this.btn9.TabIndex = 20;
            this.btn9.TabStop = false;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Gray;
            this.btn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn8.Enabled = false;
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(100, 306);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 58);
            this.btn8.TabIndex = 19;
            this.btn8.TabStop = false;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Gray;
            this.btn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7.Enabled = false;
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(19, 306);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 58);
            this.btn7.TabIndex = 18;
            this.btn7.TabStop = false;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Gray;
            this.btn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn6.Enabled = false;
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(181, 242);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 58);
            this.btn6.TabIndex = 17;
            this.btn6.TabStop = false;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Gray;
            this.btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5.Enabled = false;
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(100, 242);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 58);
            this.btn5.TabIndex = 16;
            this.btn5.TabStop = false;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Gray;
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4.Enabled = false;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(19, 242);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 58);
            this.btn4.TabIndex = 15;
            this.btn4.TabStop = false;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Gray;
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.Enabled = false;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(181, 178);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 58);
            this.btn3.TabIndex = 14;
            this.btn3.TabStop = false;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Gray;
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.Enabled = false;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(100, 178);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 58);
            this.btn2.TabIndex = 13;
            this.btn2.TabStop = false;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Gray;
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.Enabled = false;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(19, 178);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 58);
            this.btn1.TabIndex = 12;
            this.btn1.TabStop = false;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.btnMemory5);
            this.groupBox4.Controls.Add(this.btnOut);
            this.groupBox4.Controls.Add(this.btnMemory4);
            this.groupBox4.Controls.Add(this.tbText);
            this.groupBox4.Controls.Add(this.btnMemory3);
            this.groupBox4.Controls.Add(this.btnIn);
            this.groupBox4.Controls.Add(this.btnMemory2);
            this.groupBox4.Controls.Add(this.btn0);
            this.groupBox4.Controls.Add(this.btnMemory1);
            this.groupBox4.Controls.Add(this.btn1);
            this.groupBox4.Controls.Add(this.btnClear);
            this.groupBox4.Controls.Add(this.btn2);
            this.groupBox4.Controls.Add(this.btn9);
            this.groupBox4.Controls.Add(this.btn3);
            this.groupBox4.Controls.Add(this.btn8);
            this.groupBox4.Controls.Add(this.btn4);
            this.groupBox4.Controls.Add(this.btn7);
            this.groupBox4.Controls.Add(this.btn5);
            this.groupBox4.Controls.Add(this.btn6);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(271, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(436, 383);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Servo Control";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(352, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Memory";
            // 
            // btnMemory5
            // 
            this.btnMemory5.BackColor = System.Drawing.Color.Gray;
            this.btnMemory5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMemory5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMemory5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMemory5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemory5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemory5.ForeColor = System.Drawing.Color.White;
            this.btnMemory5.Location = new System.Drawing.Point(344, 304);
            this.btnMemory5.Name = "btnMemory5";
            this.btnMemory5.Size = new System.Drawing.Size(75, 60);
            this.btnMemory5.TabIndex = 8;
            this.btnMemory5.Text = "P&5";
            this.toolTip1.SetToolTip(this.btnMemory5, "Save Program5");
            this.btnMemory5.UseVisualStyleBackColor = false;
            this.btnMemory5.Click += new System.EventHandler(this.btnMemory5_Click);
            // 
            // btnMemory4
            // 
            this.btnMemory4.BackColor = System.Drawing.Color.Gray;
            this.btnMemory4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMemory4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMemory4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMemory4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemory4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemory4.ForeColor = System.Drawing.Color.White;
            this.btnMemory4.Location = new System.Drawing.Point(344, 238);
            this.btnMemory4.Name = "btnMemory4";
            this.btnMemory4.Size = new System.Drawing.Size(75, 60);
            this.btnMemory4.TabIndex = 7;
            this.btnMemory4.Text = "P&4";
            this.toolTip1.SetToolTip(this.btnMemory4, "Save Program4");
            this.btnMemory4.UseVisualStyleBackColor = false;
            this.btnMemory4.Click += new System.EventHandler(this.btnMemory4_Click);
            // 
            // tbText
            // 
            this.tbText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbText.Enabled = false;
            this.tbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbText.ForeColor = System.Drawing.Color.White;
            this.tbText.Location = new System.Drawing.Point(29, 32);
            this.tbText.MaxLength = 6;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(298, 68);
            this.tbText.TabIndex = 3;
            this.tbText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.tbText, "index value 0-999,999");
            this.tbText.TextChanged += new System.EventHandler(this.tbText_TextChanged);
            this.tbText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbText_KeyPress);
            // 
            // btnMemory3
            // 
            this.btnMemory3.BackColor = System.Drawing.Color.Gray;
            this.btnMemory3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMemory3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMemory3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMemory3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemory3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemory3.ForeColor = System.Drawing.Color.White;
            this.btnMemory3.Location = new System.Drawing.Point(344, 172);
            this.btnMemory3.Name = "btnMemory3";
            this.btnMemory3.Size = new System.Drawing.Size(75, 60);
            this.btnMemory3.TabIndex = 6;
            this.btnMemory3.Text = "P&3";
            this.toolTip1.SetToolTip(this.btnMemory3, "Save Program3");
            this.btnMemory3.UseVisualStyleBackColor = false;
            this.btnMemory3.Click += new System.EventHandler(this.btnMemory3_Click);
            // 
            // btnMemory2
            // 
            this.btnMemory2.BackColor = System.Drawing.Color.Gray;
            this.btnMemory2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMemory2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMemory2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMemory2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemory2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemory2.ForeColor = System.Drawing.Color.White;
            this.btnMemory2.Location = new System.Drawing.Point(344, 106);
            this.btnMemory2.Name = "btnMemory2";
            this.btnMemory2.Size = new System.Drawing.Size(75, 60);
            this.btnMemory2.TabIndex = 5;
            this.btnMemory2.Text = "P&2";
            this.toolTip1.SetToolTip(this.btnMemory2, "Save Program2");
            this.btnMemory2.UseVisualStyleBackColor = false;
            this.btnMemory2.Click += new System.EventHandler(this.btnMemory2_Click);
            // 
            // btnMemory1
            // 
            this.btnMemory1.BackColor = System.Drawing.Color.Gray;
            this.btnMemory1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMemory1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMemory1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMemory1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemory1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemory1.ForeColor = System.Drawing.Color.White;
            this.btnMemory1.Location = new System.Drawing.Point(344, 40);
            this.btnMemory1.Name = "btnMemory1";
            this.btnMemory1.Size = new System.Drawing.Size(75, 60);
            this.btnMemory1.TabIndex = 4;
            this.btnMemory1.Text = "P&1";
            this.toolTip1.SetToolTip(this.btnMemory1, "Save Program1");
            this.btnMemory1.UseVisualStyleBackColor = false;
            this.btnMemory1.Click += new System.EventHandler(this.btnMemory1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(197, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Servo IN";
            // 
            // tbIn1
            // 
            this.tbIn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbIn1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbIn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIn1.ForeColor = System.Drawing.Color.White;
            this.tbIn1.Location = new System.Drawing.Point(118, 48);
            this.tbIn1.Name = "tbIn1";
            this.tbIn1.ReadOnly = true;
            this.tbIn1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbIn1.Size = new System.Drawing.Size(230, 45);
            this.tbIn1.TabIndex = 28;
            this.tbIn1.TabStop = false;
            this.tbIn1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(430, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Servo OUT";
            // 
            // tbOut1
            // 
            this.tbOut1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbOut1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbOut1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOut1.ForeColor = System.Drawing.Color.White;
            this.tbOut1.Location = new System.Drawing.Point(361, 48);
            this.tbOut1.Name = "tbOut1";
            this.tbOut1.ReadOnly = true;
            this.tbOut1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbOut1.Size = new System.Drawing.Size(230, 45);
            this.tbOut1.TabIndex = 29;
            this.tbOut1.TabStop = false;
            this.tbOut1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnUse5
            // 
            this.btnUse5.BackColor = System.Drawing.Color.Gray;
            this.btnUse5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUse5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUse5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUse5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUse5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUse5.ForeColor = System.Drawing.Color.White;
            this.btnUse5.Location = new System.Drawing.Point(603, 252);
            this.btnUse5.Name = "btnUse5";
            this.btnUse5.Size = new System.Drawing.Size(75, 45);
            this.btnUse5.TabIndex = 42;
            this.btnUse5.TabStop = false;
            this.btnUse5.Text = "P5";
            this.toolTip1.SetToolTip(this.btnUse5, "Select program for run");
            this.btnUse5.UseVisualStyleBackColor = false;
            this.btnUse5.Click += new System.EventHandler(this.btnUse5_Click);
            // 
            // btnUse4
            // 
            this.btnUse4.BackColor = System.Drawing.Color.Gray;
            this.btnUse4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUse4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUse4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUse4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUse4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUse4.ForeColor = System.Drawing.Color.White;
            this.btnUse4.Location = new System.Drawing.Point(603, 201);
            this.btnUse4.Name = "btnUse4";
            this.btnUse4.Size = new System.Drawing.Size(75, 45);
            this.btnUse4.TabIndex = 41;
            this.btnUse4.TabStop = false;
            this.btnUse4.Text = "P4";
            this.toolTip1.SetToolTip(this.btnUse4, "Select program for run");
            this.btnUse4.UseVisualStyleBackColor = false;
            this.btnUse4.Click += new System.EventHandler(this.btnUse4_Click);
            // 
            // btnUse3
            // 
            this.btnUse3.BackColor = System.Drawing.Color.Gray;
            this.btnUse3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUse3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUse3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUse3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUse3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUse3.ForeColor = System.Drawing.Color.White;
            this.btnUse3.Location = new System.Drawing.Point(603, 150);
            this.btnUse3.Name = "btnUse3";
            this.btnUse3.Size = new System.Drawing.Size(75, 45);
            this.btnUse3.TabIndex = 40;
            this.btnUse3.TabStop = false;
            this.btnUse3.Text = "P3";
            this.toolTip1.SetToolTip(this.btnUse3, "Select program for run");
            this.btnUse3.UseVisualStyleBackColor = false;
            this.btnUse3.Click += new System.EventHandler(this.btnUse3_Click);
            // 
            // btnUse2
            // 
            this.btnUse2.BackColor = System.Drawing.Color.Gray;
            this.btnUse2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUse2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUse2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUse2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUse2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUse2.ForeColor = System.Drawing.Color.White;
            this.btnUse2.Location = new System.Drawing.Point(603, 99);
            this.btnUse2.Name = "btnUse2";
            this.btnUse2.Size = new System.Drawing.Size(75, 45);
            this.btnUse2.TabIndex = 39;
            this.btnUse2.TabStop = false;
            this.btnUse2.Text = "P2";
            this.toolTip1.SetToolTip(this.btnUse2, "Select program for run");
            this.btnUse2.UseVisualStyleBackColor = false;
            this.btnUse2.Click += new System.EventHandler(this.btnUse2_Click);
            // 
            // btnUse1
            // 
            this.btnUse1.BackColor = System.Drawing.Color.Gray;
            this.btnUse1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUse1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUse1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUse1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUse1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUse1.ForeColor = System.Drawing.Color.White;
            this.btnUse1.Location = new System.Drawing.Point(603, 48);
            this.btnUse1.Name = "btnUse1";
            this.btnUse1.Size = new System.Drawing.Size(75, 45);
            this.btnUse1.TabIndex = 38;
            this.btnUse1.TabStop = false;
            this.btnUse1.Text = "P1";
            this.toolTip1.SetToolTip(this.btnUse1, "Select program for run");
            this.btnUse1.UseVisualStyleBackColor = false;
            this.btnUse1.Click += new System.EventHandler(this.btnUse1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSaveAs);
            this.groupBox3.Controls.Add(this.lbMemoryUse);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.btnReset);
            this.groupBox3.Controls.Add(this.btnSetZero);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.btnUse5);
            this.groupBox3.Controls.Add(this.tbOut5);
            this.groupBox3.Controls.Add(this.btnUse4);
            this.groupBox3.Controls.Add(this.tbOut4);
            this.groupBox3.Controls.Add(this.btnUse3);
            this.groupBox3.Controls.Add(this.tbOut3);
            this.groupBox3.Controls.Add(this.btnUse2);
            this.groupBox3.Controls.Add(this.tbOut2);
            this.groupBox3.Controls.Add(this.btnUse1);
            this.groupBox3.Controls.Add(this.tbIn5);
            this.groupBox3.Controls.Add(this.tbIn4);
            this.groupBox3.Controls.Add(this.tbIn3);
            this.groupBox3.Controls.Add(this.tbIn2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tbIn1);
            this.groupBox3.Controls.Add(this.tbOut1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 400);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(695, 370);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Memory Position";
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.BackColor = System.Drawing.Color.Red;
            this.btnSaveAs.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSaveAs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSaveAs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnSaveAs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAs.ForeColor = System.Drawing.Color.White;
            this.btnSaveAs.Location = new System.Drawing.Point(198, 308);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(154, 45);
            this.btnSaveAs.TabIndex = 52;
            this.btnSaveAs.TabStop = false;
            this.btnSaveAs.Text = "&Save As";
            this.toolTip1.SetToolTip(this.btnSaveAs, "Save Program on PC");
            this.btnSaveAs.UseVisualStyleBackColor = false;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // lbMemoryUse
            // 
            this.lbMemoryUse.AutoSize = true;
            this.lbMemoryUse.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMemoryUse.ForeColor = System.Drawing.Color.White;
            this.lbMemoryUse.Location = new System.Drawing.Point(131, 315);
            this.lbMemoryUse.Name = "lbMemoryUse";
            this.lbMemoryUse.Size = new System.Drawing.Size(47, 31);
            this.lbMemoryUse.TabIndex = 51;
            this.lbMemoryUse.Text = "P1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 320);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(111, 20);
            this.label16.TabIndex = 50;
            this.label16.Text = "Memory use :";
            this.toolTip1.SetToolTip(this.label16, "Status Memory use");
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Gray;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(361, 308);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(154, 45);
            this.btnReset.TabIndex = 49;
            this.btnReset.TabStop = false;
            this.btnReset.Text = "&Reset MCU";
            this.toolTip1.SetToolTip(this.btnReset, "Reset microcontroller");
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSetZero
            // 
            this.btnSetZero.BackColor = System.Drawing.Color.Gray;
            this.btnSetZero.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSetZero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSetZero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSetZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetZero.ForeColor = System.Drawing.Color.White;
            this.btnSetZero.Location = new System.Drawing.Point(524, 308);
            this.btnSetZero.Name = "btnSetZero";
            this.btnSetZero.Size = new System.Drawing.Size(154, 45);
            this.btnSetZero.TabIndex = 48;
            this.btnSetZero.TabStop = false;
            this.btnSetZero.Text = "Set Zero";
            this.toolTip1.SetToolTip(this.btnSetZero, "Reset All Program");
            this.btnSetZero.UseVisualStyleBackColor = false;
            this.btnSetZero.Click += new System.EventHandler(this.btnSetZero_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(9, 264);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 20);
            this.label15.TabIndex = 47;
            this.label15.Text = "Program 5";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(9, 213);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 20);
            this.label14.TabIndex = 46;
            this.label14.Text = "Program 4";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(9, 162);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 20);
            this.label13.TabIndex = 45;
            this.label13.Text = "Program 3";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(9, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 20);
            this.label12.TabIndex = 44;
            this.label12.Text = "Program 2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(9, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 20);
            this.label11.TabIndex = 43;
            this.label11.Text = "Program 1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(621, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Run";
            // 
            // tbOut5
            // 
            this.tbOut5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbOut5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbOut5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOut5.ForeColor = System.Drawing.Color.White;
            this.tbOut5.Location = new System.Drawing.Point(361, 252);
            this.tbOut5.Name = "tbOut5";
            this.tbOut5.ReadOnly = true;
            this.tbOut5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbOut5.Size = new System.Drawing.Size(230, 45);
            this.tbOut5.TabIndex = 37;
            this.tbOut5.TabStop = false;
            this.tbOut5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbOut4
            // 
            this.tbOut4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbOut4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbOut4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOut4.ForeColor = System.Drawing.Color.White;
            this.tbOut4.Location = new System.Drawing.Point(361, 201);
            this.tbOut4.Name = "tbOut4";
            this.tbOut4.ReadOnly = true;
            this.tbOut4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbOut4.Size = new System.Drawing.Size(230, 45);
            this.tbOut4.TabIndex = 35;
            this.tbOut4.TabStop = false;
            this.tbOut4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbOut3
            // 
            this.tbOut3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbOut3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbOut3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOut3.ForeColor = System.Drawing.Color.White;
            this.tbOut3.Location = new System.Drawing.Point(361, 150);
            this.tbOut3.Name = "tbOut3";
            this.tbOut3.ReadOnly = true;
            this.tbOut3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbOut3.Size = new System.Drawing.Size(230, 45);
            this.tbOut3.TabIndex = 33;
            this.tbOut3.TabStop = false;
            this.tbOut3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbOut2
            // 
            this.tbOut2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbOut2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbOut2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOut2.ForeColor = System.Drawing.Color.White;
            this.tbOut2.Location = new System.Drawing.Point(361, 99);
            this.tbOut2.Name = "tbOut2";
            this.tbOut2.ReadOnly = true;
            this.tbOut2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbOut2.Size = new System.Drawing.Size(230, 45);
            this.tbOut2.TabIndex = 31;
            this.tbOut2.TabStop = false;
            this.tbOut2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbIn5
            // 
            this.tbIn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbIn5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbIn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIn5.ForeColor = System.Drawing.Color.White;
            this.tbIn5.Location = new System.Drawing.Point(118, 252);
            this.tbIn5.Name = "tbIn5";
            this.tbIn5.ReadOnly = true;
            this.tbIn5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbIn5.Size = new System.Drawing.Size(230, 45);
            this.tbIn5.TabIndex = 36;
            this.tbIn5.TabStop = false;
            this.tbIn5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbIn4
            // 
            this.tbIn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbIn4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbIn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIn4.ForeColor = System.Drawing.Color.White;
            this.tbIn4.Location = new System.Drawing.Point(118, 201);
            this.tbIn4.Name = "tbIn4";
            this.tbIn4.ReadOnly = true;
            this.tbIn4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbIn4.Size = new System.Drawing.Size(230, 45);
            this.tbIn4.TabIndex = 34;
            this.tbIn4.TabStop = false;
            this.tbIn4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbIn3
            // 
            this.tbIn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbIn3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbIn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIn3.ForeColor = System.Drawing.Color.White;
            this.tbIn3.Location = new System.Drawing.Point(118, 150);
            this.tbIn3.Name = "tbIn3";
            this.tbIn3.ReadOnly = true;
            this.tbIn3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbIn3.Size = new System.Drawing.Size(230, 45);
            this.tbIn3.TabIndex = 32;
            this.tbIn3.TabStop = false;
            this.tbIn3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbIn2
            // 
            this.tbIn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbIn2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbIn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIn2.ForeColor = System.Drawing.Color.White;
            this.tbIn2.Location = new System.Drawing.Point(118, 99);
            this.tbIn2.Name = "tbIn2";
            this.tbIn2.ReadOnly = true;
            this.tbIn2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbIn2.Size = new System.Drawing.Size(230, 45);
            this.tbIn2.TabIndex = 30;
            this.tbIn2.TabStop = false;
            this.tbIn2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AccessibleDescription = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(721, 784);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(739, 831);
            this.MinimumSize = new System.Drawing.Size(739, 467);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[TGT] ServoPosition Setting";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxParityBits;
        private System.Windows.Forms.ComboBox cBoxStopBits;
        private System.Windows.Forms.ComboBox cBoxDataBits;
        private System.Windows.Forms.ComboBox cBoxBaudRate;
        private System.Windows.Forms.ComboBox cBoxComPort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbIn1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbOut1;
        private System.Windows.Forms.Button btnMemory5;
        private System.Windows.Forms.Button btnMemory4;
        private System.Windows.Forms.Button btnMemory3;
        private System.Windows.Forms.Button btnMemory2;
        private System.Windows.Forms.Button btnMemory1;
        private System.Windows.Forms.Button btnUse5;
        private System.Windows.Forms.Button btnUse4;
        private System.Windows.Forms.Button btnUse3;
        private System.Windows.Forms.Button btnUse2;
        private System.Windows.Forms.Button btnUse1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbOut5;
        private System.Windows.Forms.TextBox tbOut4;
        private System.Windows.Forms.TextBox tbOut3;
        private System.Windows.Forms.TextBox tbOut2;
        private System.Windows.Forms.TextBox tbIn5;
        private System.Windows.Forms.TextBox tbIn4;
        private System.Windows.Forms.TextBox tbIn3;
        private System.Windows.Forms.TextBox tbIn2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSetZero;
        private System.Windows.Forms.Label lbMemoryUse;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnSaveAs;
    }
}

