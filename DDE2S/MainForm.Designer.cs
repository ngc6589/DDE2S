namespace DDE2S
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tUpLink = new System.Windows.Forms.Label();
            this.labelSatName = new System.Windows.Forms.Label();
            this.labelAzimuth = new System.Windows.Forms.Label();
            this.labelUpLink = new System.Windows.Forms.Label();
            this.labelUpLinkMode = new System.Windows.Forms.Label();
            this.tSatName = new System.Windows.Forms.Label();
            this.tAzimuth = new System.Windows.Forms.Label();
            this.tUplinkMode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDownLink = new System.Windows.Forms.Label();
            this.labelElevation = new System.Windows.Forms.Label();
            this.tElevation = new System.Windows.Forms.Label();
            this.tDownLink = new System.Windows.Forms.Label();
            this.tDownlinkMode = new System.Windows.Forms.Label();
            this.labelRange = new System.Windows.Forms.Label();
            this.tRange = new System.Windows.Forms.Label();
            this.tConnectStatus = new System.Windows.Forms.Label();
            this.labelConnectStatus = new System.Windows.Forms.Label();
            this.labelRageRate = new System.Windows.Forms.Label();
            this.tRangeRate = new System.Windows.Forms.Label();
            this.labelAltitude = new System.Windows.Forms.Label();
            this.tAltitude = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBoxSerialPortName = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxSerialPortBaudRate = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonDataBit7 = new System.Windows.Forms.RadioButton();
            this.radioButtonDataBit8 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButtonParityEven = new System.Windows.Forms.RadioButton();
            this.radioButtonParityNone = new System.Windows.Forms.RadioButton();
            this.radioButtonParityOdd = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButtonStopBits2 = new System.Windows.Forms.RadioButton();
            this.radioButtonStopBits15 = new System.Windows.Forms.RadioButton();
            this.radioButtonStopBits1 = new System.Windows.Forms.RadioButton();
            this.connectBtn = new System.Windows.Forms.CheckBox();
            this.tSerialStatus = new System.Windows.Forms.Label();
            this.textBoxStringFormat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBoxNewline = new System.Windows.Forms.CheckBox();
            this.checkBoxSemicolon = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.tUpLink, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelSatName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelAzimuth, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelUpLink, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelUpLinkMode, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tSatName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tAzimuth, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tUplinkMode, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelDownLink, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelElevation, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tElevation, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.tDownLink, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.tDownlinkMode, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelRange, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tRange, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tConnectStatus, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelConnectStatus, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelRageRate, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.tRangeRate, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelAltitude, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tAltitude, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(460, 125);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tUpLink
            // 
            this.tUpLink.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tUpLink.AutoSize = true;
            this.tUpLink.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tUpLink.ForeColor = System.Drawing.Color.Blue;
            this.tUpLink.Location = new System.Drawing.Point(118, 41);
            this.tUpLink.Name = "tUpLink";
            this.tUpLink.Size = new System.Drawing.Size(107, 19);
            this.tUpLink.TabIndex = 0;
            this.tUpLink.Text = "123456789 Hz";
            this.tUpLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSatName
            // 
            this.labelSatName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSatName.AutoSize = true;
            this.labelSatName.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSatName.Location = new System.Drawing.Point(4, 1);
            this.labelSatName.Name = "labelSatName";
            this.labelSatName.Size = new System.Drawing.Size(107, 19);
            this.labelSatName.TabIndex = 0;
            this.labelSatName.Text = "Sat Name:";
            this.labelSatName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAzimuth
            // 
            this.labelAzimuth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAzimuth.AutoSize = true;
            this.labelAzimuth.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAzimuth.Location = new System.Drawing.Point(4, 21);
            this.labelAzimuth.Name = "labelAzimuth";
            this.labelAzimuth.Size = new System.Drawing.Size(107, 19);
            this.labelAzimuth.TabIndex = 1;
            this.labelAzimuth.Text = "Azimuth:";
            this.labelAzimuth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelUpLink
            // 
            this.labelUpLink.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUpLink.AutoSize = true;
            this.labelUpLink.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUpLink.Location = new System.Drawing.Point(4, 41);
            this.labelUpLink.Name = "labelUpLink";
            this.labelUpLink.Size = new System.Drawing.Size(107, 19);
            this.labelUpLink.TabIndex = 2;
            this.labelUpLink.Text = "Uplink:";
            this.labelUpLink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelUpLinkMode
            // 
            this.labelUpLinkMode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUpLinkMode.AutoSize = true;
            this.labelUpLinkMode.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUpLinkMode.Location = new System.Drawing.Point(4, 61);
            this.labelUpLinkMode.Name = "labelUpLinkMode";
            this.labelUpLinkMode.Size = new System.Drawing.Size(107, 19);
            this.labelUpLinkMode.TabIndex = 3;
            this.labelUpLinkMode.Text = "Uplink Mode:";
            this.labelUpLinkMode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tSatName
            // 
            this.tSatName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tSatName.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.tSatName, 3);
            this.tSatName.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tSatName.ForeColor = System.Drawing.Color.Blue;
            this.tSatName.Location = new System.Drawing.Point(118, 1);
            this.tSatName.Name = "tSatName";
            this.tSatName.Size = new System.Drawing.Size(338, 19);
            this.tSatName.TabIndex = 7;
            this.tSatName.Text = "SateliteName";
            this.tSatName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tAzimuth
            // 
            this.tAzimuth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tAzimuth.AutoSize = true;
            this.tAzimuth.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tAzimuth.ForeColor = System.Drawing.Color.Blue;
            this.tAzimuth.Location = new System.Drawing.Point(118, 21);
            this.tAzimuth.Name = "tAzimuth";
            this.tAzimuth.Size = new System.Drawing.Size(107, 19);
            this.tAzimuth.TabIndex = 8;
            this.tAzimuth.Text = "360.0";
            this.tAzimuth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tUplinkMode
            // 
            this.tUplinkMode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tUplinkMode.AutoSize = true;
            this.tUplinkMode.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tUplinkMode.ForeColor = System.Drawing.Color.Blue;
            this.tUplinkMode.Location = new System.Drawing.Point(118, 61);
            this.tUplinkMode.Name = "tUplinkMode";
            this.tUplinkMode.Size = new System.Drawing.Size(107, 19);
            this.tUplinkMode.TabIndex = 10;
            this.tUplinkMode.Text = "FM-N";
            this.tUplinkMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(232, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Downlink mode:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDownLink
            // 
            this.labelDownLink.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDownLink.AutoSize = true;
            this.labelDownLink.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDownLink.Location = new System.Drawing.Point(232, 41);
            this.labelDownLink.Name = "labelDownLink";
            this.labelDownLink.Size = new System.Drawing.Size(107, 19);
            this.labelDownLink.TabIndex = 5;
            this.labelDownLink.Text = "Downlink:";
            this.labelDownLink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelElevation
            // 
            this.labelElevation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelElevation.AutoSize = true;
            this.labelElevation.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelElevation.Location = new System.Drawing.Point(232, 21);
            this.labelElevation.Name = "labelElevation";
            this.labelElevation.Size = new System.Drawing.Size(107, 19);
            this.labelElevation.TabIndex = 4;
            this.labelElevation.Text = "Elevation:";
            this.labelElevation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tElevation
            // 
            this.tElevation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tElevation.AutoSize = true;
            this.tElevation.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tElevation.ForeColor = System.Drawing.Color.Blue;
            this.tElevation.Location = new System.Drawing.Point(346, 21);
            this.tElevation.Name = "tElevation";
            this.tElevation.Size = new System.Drawing.Size(110, 19);
            this.tElevation.TabIndex = 9;
            this.tElevation.Text = "-90.0";
            this.tElevation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tDownLink
            // 
            this.tDownLink.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tDownLink.AutoSize = true;
            this.tDownLink.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tDownLink.ForeColor = System.Drawing.Color.Blue;
            this.tDownLink.Location = new System.Drawing.Point(346, 41);
            this.tDownLink.Name = "tDownLink";
            this.tDownLink.Size = new System.Drawing.Size(110, 19);
            this.tDownLink.TabIndex = 0;
            this.tDownLink.Text = "123456789 Hz";
            this.tDownLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tDownlinkMode
            // 
            this.tDownlinkMode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tDownlinkMode.AutoSize = true;
            this.tDownlinkMode.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tDownlinkMode.ForeColor = System.Drawing.Color.Blue;
            this.tDownlinkMode.Location = new System.Drawing.Point(346, 61);
            this.tDownlinkMode.Name = "tDownlinkMode";
            this.tDownlinkMode.Size = new System.Drawing.Size(110, 19);
            this.tDownlinkMode.TabIndex = 11;
            this.tDownlinkMode.Text = "FM-N";
            this.tDownlinkMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRange
            // 
            this.labelRange.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRange.AutoSize = true;
            this.labelRange.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRange.Location = new System.Drawing.Point(4, 81);
            this.labelRange.Name = "labelRange";
            this.labelRange.Size = new System.Drawing.Size(107, 20);
            this.labelRange.TabIndex = 14;
            this.labelRange.Text = "Range";
            this.labelRange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tRange
            // 
            this.tRange.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tRange.AutoSize = true;
            this.tRange.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tRange.ForeColor = System.Drawing.Color.Blue;
            this.tRange.Location = new System.Drawing.Point(118, 81);
            this.tRange.Name = "tRange";
            this.tRange.Size = new System.Drawing.Size(107, 20);
            this.tRange.TabIndex = 15;
            this.tRange.Text = "99999 km";
            this.tRange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tConnectStatus
            // 
            this.tConnectStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tConnectStatus.AutoSize = true;
            this.tConnectStatus.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tConnectStatus.ForeColor = System.Drawing.Color.Blue;
            this.tConnectStatus.Location = new System.Drawing.Point(346, 102);
            this.tConnectStatus.Name = "tConnectStatus";
            this.tConnectStatus.Size = new System.Drawing.Size(110, 22);
            this.tConnectStatus.TabIndex = 13;
            this.tConnectStatus.Text = "Disconnect";
            this.tConnectStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelConnectStatus
            // 
            this.labelConnectStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConnectStatus.AutoSize = true;
            this.labelConnectStatus.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelConnectStatus.Location = new System.Drawing.Point(232, 102);
            this.labelConnectStatus.Name = "labelConnectStatus";
            this.labelConnectStatus.Size = new System.Drawing.Size(107, 22);
            this.labelConnectStatus.TabIndex = 12;
            this.labelConnectStatus.Text = "Orbitron:";
            this.labelConnectStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelRageRate
            // 
            this.labelRageRate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRageRate.AutoSize = true;
            this.labelRageRate.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRageRate.Location = new System.Drawing.Point(232, 81);
            this.labelRageRate.Name = "labelRageRate";
            this.labelRageRate.Size = new System.Drawing.Size(107, 20);
            this.labelRageRate.TabIndex = 16;
            this.labelRageRate.Text = "Range rate:";
            this.labelRageRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tRangeRate
            // 
            this.tRangeRate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tRangeRate.AutoSize = true;
            this.tRangeRate.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tRangeRate.ForeColor = System.Drawing.Color.Blue;
            this.tRangeRate.Location = new System.Drawing.Point(346, 81);
            this.tRangeRate.Name = "tRangeRate";
            this.tRangeRate.Size = new System.Drawing.Size(110, 20);
            this.tRangeRate.TabIndex = 17;
            this.tRangeRate.Text = "999 km/s";
            this.tRangeRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAltitude
            // 
            this.labelAltitude.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAltitude.AutoSize = true;
            this.labelAltitude.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAltitude.Location = new System.Drawing.Point(4, 102);
            this.labelAltitude.Name = "labelAltitude";
            this.labelAltitude.Size = new System.Drawing.Size(107, 22);
            this.labelAltitude.TabIndex = 18;
            this.labelAltitude.Text = "Altitude:";
            this.labelAltitude.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tAltitude
            // 
            this.tAltitude.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tAltitude.AutoSize = true;
            this.tAltitude.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tAltitude.ForeColor = System.Drawing.Color.Blue;
            this.tAltitude.Location = new System.Drawing.Point(118, 102);
            this.tAltitude.Name = "tAltitude";
            this.tAltitude.Size = new System.Drawing.Size(107, 22);
            this.tAltitude.TabIndex = 19;
            this.tAltitude.Text = "99999 km";
            this.tAltitude.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // comboBoxSerialPortName
            // 
            this.comboBoxSerialPortName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.comboBoxSerialPortName, 3);
            this.comboBoxSerialPortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSerialPortName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxSerialPortName.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSerialPortName.FormattingEnabled = true;
            this.comboBoxSerialPortName.Location = new System.Drawing.Point(66, 1);
            this.comboBoxSerialPortName.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxSerialPortName.Name = "comboBoxSerialPortName";
            this.comboBoxSerialPortName.Size = new System.Drawing.Size(393, 23);
            this.comboBoxSerialPortName.TabIndex = 1;
            this.comboBoxSerialPortName.SelectedIndexChanged += new System.EventHandler(this.comboBoxSerialPortName_SelectedIndexChanged);
            this.comboBoxSerialPortName.SelectedValueChanged += new System.EventHandler(this.ComboBoxSerialPortName_SelectedValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(0, 20);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(230, 104);
            this.textBox1.TabIndex = 2;
            // 
            // comboBoxSerialPortBaudRate
            // 
            this.comboBoxSerialPortBaudRate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSerialPortBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSerialPortBaudRate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxSerialPortBaudRate.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSerialPortBaudRate.FormattingEnabled = true;
            this.comboBoxSerialPortBaudRate.Items.AddRange(new object[] {
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800",
            "921600"});
            this.comboBoxSerialPortBaudRate.Location = new System.Drawing.Point(66, 25);
            this.comboBoxSerialPortBaudRate.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxSerialPortBaudRate.Name = "comboBoxSerialPortBaudRate";
            this.comboBoxSerialPortBaudRate.Size = new System.Drawing.Size(163, 23);
            this.comboBoxSerialPortBaudRate.TabIndex = 3;
            this.comboBoxSerialPortBaudRate.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSerialPortCharSize_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.38428F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.61572F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel2.Controls.Add(this.comboBoxSerialPortName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxSerialPortBaudRate, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label6, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.connectBtn, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.tSerialStatus, 2, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 143);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(460, 97);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(4, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "PORT:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(4, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "SPEED:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(233, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "DataBit:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(4, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Parity:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(233, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Stop Bits:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.radioButtonDataBit7);
            this.panel1.Controls.Add(this.radioButtonDataBit8);
            this.panel1.Location = new System.Drawing.Point(322, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 23);
            this.panel1.TabIndex = 14;
            // 
            // radioButtonDataBit7
            // 
            this.radioButtonDataBit7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonDataBit7.AutoSize = true;
            this.radioButtonDataBit7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonDataBit7.Location = new System.Drawing.Point(64, 2);
            this.radioButtonDataBit7.Margin = new System.Windows.Forms.Padding(1);
            this.radioButtonDataBit7.Name = "radioButtonDataBit7";
            this.radioButtonDataBit7.Size = new System.Drawing.Size(53, 19);
            this.radioButtonDataBit7.TabIndex = 1;
            this.radioButtonDataBit7.TabStop = true;
            this.radioButtonDataBit7.Text = "7bit";
            this.radioButtonDataBit7.UseVisualStyleBackColor = true;
            this.radioButtonDataBit7.CheckedChanged += new System.EventHandler(this.RadioButtonDataBit7_CheckedChanged);
            // 
            // radioButtonDataBit8
            // 
            this.radioButtonDataBit8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonDataBit8.AutoSize = true;
            this.radioButtonDataBit8.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonDataBit8.Location = new System.Drawing.Point(9, 3);
            this.radioButtonDataBit8.Margin = new System.Windows.Forms.Padding(1);
            this.radioButtonDataBit8.Name = "radioButtonDataBit8";
            this.radioButtonDataBit8.Size = new System.Drawing.Size(53, 18);
            this.radioButtonDataBit8.TabIndex = 0;
            this.radioButtonDataBit8.TabStop = true;
            this.radioButtonDataBit8.Text = "8bit";
            this.radioButtonDataBit8.UseVisualStyleBackColor = true;
            this.radioButtonDataBit8.CheckedChanged += new System.EventHandler(this.RadioButtonDataBit8_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.radioButtonParityEven);
            this.panel2.Controls.Add(this.radioButtonParityNone);
            this.panel2.Controls.Add(this.radioButtonParityOdd);
            this.panel2.Location = new System.Drawing.Point(66, 49);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(163, 23);
            this.panel2.TabIndex = 15;
            // 
            // radioButtonParityEven
            // 
            this.radioButtonParityEven.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonParityEven.AutoSize = true;
            this.radioButtonParityEven.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonParityEven.Location = new System.Drawing.Point(110, 2);
            this.radioButtonParityEven.Margin = new System.Windows.Forms.Padding(1);
            this.radioButtonParityEven.Name = "radioButtonParityEven";
            this.radioButtonParityEven.Size = new System.Drawing.Size(53, 19);
            this.radioButtonParityEven.TabIndex = 2;
            this.radioButtonParityEven.TabStop = true;
            this.radioButtonParityEven.Text = "Even";
            this.radioButtonParityEven.UseVisualStyleBackColor = true;
            this.radioButtonParityEven.CheckedChanged += new System.EventHandler(this.RadioButtonParityEven_CheckedChanged);
            // 
            // radioButtonParityNone
            // 
            this.radioButtonParityNone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonParityNone.AutoSize = true;
            this.radioButtonParityNone.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonParityNone.Location = new System.Drawing.Point(10, 2);
            this.radioButtonParityNone.Margin = new System.Windows.Forms.Padding(1);
            this.radioButtonParityNone.Name = "radioButtonParityNone";
            this.radioButtonParityNone.Size = new System.Drawing.Size(53, 19);
            this.radioButtonParityNone.TabIndex = 0;
            this.radioButtonParityNone.TabStop = true;
            this.radioButtonParityNone.Text = "None";
            this.radioButtonParityNone.UseVisualStyleBackColor = true;
            this.radioButtonParityNone.CheckedChanged += new System.EventHandler(this.RadioButtonParityNone_CheckedChanged);
            // 
            // radioButtonParityOdd
            // 
            this.radioButtonParityOdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonParityOdd.AutoSize = true;
            this.radioButtonParityOdd.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonParityOdd.Location = new System.Drawing.Point(65, 2);
            this.radioButtonParityOdd.Margin = new System.Windows.Forms.Padding(1);
            this.radioButtonParityOdd.Name = "radioButtonParityOdd";
            this.radioButtonParityOdd.Size = new System.Drawing.Size(46, 19);
            this.radioButtonParityOdd.TabIndex = 1;
            this.radioButtonParityOdd.TabStop = true;
            this.radioButtonParityOdd.Text = "Odd";
            this.radioButtonParityOdd.UseVisualStyleBackColor = true;
            this.radioButtonParityOdd.CheckedChanged += new System.EventHandler(this.RadioButtonParityOdd_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioButtonStopBits2);
            this.panel3.Controls.Add(this.radioButtonStopBits15);
            this.panel3.Controls.Add(this.radioButtonStopBits1);
            this.panel3.Location = new System.Drawing.Point(322, 49);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(137, 23);
            this.panel3.TabIndex = 16;
            // 
            // radioButtonStopBits2
            // 
            this.radioButtonStopBits2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonStopBits2.AutoSize = true;
            this.radioButtonStopBits2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonStopBits2.Location = new System.Drawing.Point(91, 2);
            this.radioButtonStopBits2.Margin = new System.Windows.Forms.Padding(1);
            this.radioButtonStopBits2.Name = "radioButtonStopBits2";
            this.radioButtonStopBits2.Size = new System.Drawing.Size(32, 19);
            this.radioButtonStopBits2.TabIndex = 2;
            this.radioButtonStopBits2.TabStop = true;
            this.radioButtonStopBits2.Text = "2";
            this.radioButtonStopBits2.UseVisualStyleBackColor = true;
            this.radioButtonStopBits2.CheckedChanged += new System.EventHandler(this.RadioButtonStopBits2_CheckedChanged);
            // 
            // radioButtonStopBits15
            // 
            this.radioButtonStopBits15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonStopBits15.AutoSize = true;
            this.radioButtonStopBits15.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonStopBits15.Location = new System.Drawing.Point(43, 2);
            this.radioButtonStopBits15.Margin = new System.Windows.Forms.Padding(1);
            this.radioButtonStopBits15.Name = "radioButtonStopBits15";
            this.radioButtonStopBits15.Size = new System.Drawing.Size(46, 19);
            this.radioButtonStopBits15.TabIndex = 1;
            this.radioButtonStopBits15.TabStop = true;
            this.radioButtonStopBits15.Text = "1.5";
            this.radioButtonStopBits15.UseVisualStyleBackColor = true;
            this.radioButtonStopBits15.CheckedChanged += new System.EventHandler(this.RadioButtonStopBits15_CheckedChanged);
            // 
            // radioButtonStopBits1
            // 
            this.radioButtonStopBits1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonStopBits1.AutoSize = true;
            this.radioButtonStopBits1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonStopBits1.Location = new System.Drawing.Point(9, 2);
            this.radioButtonStopBits1.Margin = new System.Windows.Forms.Padding(1);
            this.radioButtonStopBits1.Name = "radioButtonStopBits1";
            this.radioButtonStopBits1.Size = new System.Drawing.Size(32, 19);
            this.radioButtonStopBits1.TabIndex = 0;
            this.radioButtonStopBits1.TabStop = true;
            this.radioButtonStopBits1.Text = "1";
            this.radioButtonStopBits1.UseVisualStyleBackColor = true;
            this.radioButtonStopBits1.CheckedChanged += new System.EventHandler(this.RadioButtonStopBits1_CheckedChanged);
            // 
            // connectBtn
            // 
            this.connectBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.connectBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.connectBtn.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.connectBtn, 2);
            this.connectBtn.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.connectBtn.Location = new System.Drawing.Point(1, 73);
            this.connectBtn.Margin = new System.Windows.Forms.Padding(0);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(228, 23);
            this.connectBtn.TabIndex = 19;
            this.connectBtn.Text = "Connect";
            this.connectBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.CheckedChanged += new System.EventHandler(this.connectBtn_CheckedChanged);
            // 
            // tSerialStatus
            // 
            this.tSerialStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tSerialStatus.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.tSerialStatus, 2);
            this.tSerialStatus.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tSerialStatus.Location = new System.Drawing.Point(233, 73);
            this.tSerialStatus.Name = "tSerialStatus";
            this.tSerialStatus.Size = new System.Drawing.Size(223, 23);
            this.tSerialStatus.TabIndex = 18;
            this.tSerialStatus.Text = "CLOSE";
            this.tSerialStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxStringFormat
            // 
            this.textBoxStringFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStringFormat.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxStringFormat.Location = new System.Drawing.Point(11, 276);
            this.textBoxStringFormat.Name = "textBoxStringFormat";
            this.textBoxStringFormat.Size = new System.Drawing.Size(460, 23);
            this.textBoxStringFormat.TabIndex = 5;
            this.textBoxStringFormat.TextChanged += new System.EventHandler(this.TextBoxStringFormat_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(12, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(455, 30);
            this.label8.TabIndex = 6;
            this.label8.Text = "Uplink(Hz): <UP> Dnlink(Hz): <DN> Azimuth: <AZ> Elevation: <EL> \r\nSatname<SN> Lin" +
    "eFeed:<CR><LF>  ex: FA<DN>;  Set freqency VFO-A";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(230, 20);
            this.textBox2.Margin = new System.Windows.Forms.Padding(0);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(231, 104);
            this.textBox2.TabIndex = 7;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.textBox1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBox2, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label9, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.checkBoxNewline, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.checkBoxSemicolon, 1, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(11, 305);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(461, 151);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Send";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(233, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(225, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Receive";
            // 
            // checkBoxNewline
            // 
            this.checkBoxNewline.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxNewline.AutoSize = true;
            this.checkBoxNewline.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxNewline.Location = new System.Drawing.Point(3, 127);
            this.checkBoxNewline.Name = "checkBoxNewline";
            this.checkBoxNewline.Size = new System.Drawing.Size(224, 21);
            this.checkBoxNewline.TabIndex = 10;
            this.checkBoxNewline.Text = "newline";
            this.checkBoxNewline.UseVisualStyleBackColor = true;
            this.checkBoxNewline.CheckedChanged += new System.EventHandler(this.checkBoxNewline_CheckedChanged);
            // 
            // checkBoxSemicolon
            // 
            this.checkBoxSemicolon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxSemicolon.AutoSize = true;
            this.checkBoxSemicolon.Location = new System.Drawing.Point(233, 127);
            this.checkBoxSemicolon.Name = "checkBoxSemicolon";
            this.checkBoxSemicolon.Size = new System.Drawing.Size(225, 21);
            this.checkBoxSemicolon.TabIndex = 11;
            this.checkBoxSemicolon.Text = "Semi-colon to newline";
            this.checkBoxSemicolon.UseVisualStyleBackColor = true;
            this.checkBoxSemicolon.CheckedChanged += new System.EventHandler(this.checkBoxSemicolon_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxStringFormat);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "MainForm";
            this.Text = "DDE2S";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label tUpLink;
        private Label labelSatName;
        private Label labelAzimuth;
        private Label labelUpLink;
        private Label labelUpLinkMode;
        private Label tSatName;
        private Label tAzimuth;
        private Label tUplinkMode;
        private Label tElevation;
        private Label tDownlinkMode;
        private Label label1;
        private Label labelDownLink;
        private Label labelElevation;
        private Label tDownLink;
        private Label labelConnectStatus;
        private Label tConnectStatus;
        private System.Windows.Forms.Timer timer1;
        private Label labelRange;
        private Label tRange;
        private Label labelRageRate;
        private Label tRangeRate;
        private Label labelAltitude;
        private Label tAltitude;
        private ComboBox comboBoxSerialPortName;
        private TextBox textBox1;
        private ComboBox comboBoxSerialPortBaudRate;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private Label label3;
        private RadioButton radioButtonDataBit7;
        private RadioButton radioButtonDataBit8;
        private Label label4;
        private Label label5;
        private RadioButton radioButtonParityEven;
        private RadioButton radioButtonParityOdd;
        private RadioButton radioButtonParityNone;
        private Label label6;
        private RadioButton radioButtonStopBits2;
        private RadioButton radioButtonStopBits15;
        private RadioButton radioButtonStopBits1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label tSerialStatus;
        private TextBox textBoxStringFormat;
        private CheckBox connectBtn;
        private Label label8;
        private TextBox textBox2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label7;
        private Label label9;
        private CheckBox checkBoxNewline;
        private CheckBox checkBoxSemicolon;
    }
}