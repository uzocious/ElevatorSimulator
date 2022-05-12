namespace ElevatorSimulator
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picElevatorCarClosed = new System.Windows.Forms.PictureBox();
            this.btn1stFloorRequestButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnGroundFloorRequestButton = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pic1stFloorDoorRight = new System.Windows.Forms.PictureBox();
            this.pic1stFloorDoorLeft = new System.Windows.Forms.PictureBox();
            this.picGroundFloorDoorRight = new System.Windows.Forms.PictureBox();
            this.picGroundFloorDoorLeft = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpControlPanel = new System.Windows.Forms.GroupBox();
            this.picElevatorCarDisplayWindow = new System.Windows.Forms.PictureBox();
            this.btnGoingDown_GroundFloor = new System.Windows.Forms.Button();
            this.btnGoingUp_FirstFloor = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.picGroundFloorDisplayWindow = new System.Windows.Forms.PictureBox();
            this.pic1stFloorDisplayWindow = new System.Windows.Forms.PictureBox();
            this.lstElevatorDBLog = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.btnDisplayFullLog = new System.Windows.Forms.Button();
            this.picElevatorCarOpenedFF = new System.Windows.Forms.PictureBox();
            this.picElevatorCarOpenedGF = new System.Windows.Forms.PictureBox();
            this.tmrElevatorCar_InMotion_Controller = new System.Windows.Forms.Timer(this.components);
            this.tmrDoorsOpening_Controller = new System.Windows.Forms.Timer(this.components);
            this.tmrDoorsClosing_Controller = new System.Windows.Forms.Timer(this.components);
            this.tmrAutomatic_DoorsClosing_Controller = new System.Windows.Forms.Timer(this.components);
            this.tmrElevCar_InMotion_after_DoorsClosed_Controller = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picElevatorCarClosed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1stFloorDoorRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1stFloorDoorLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGroundFloorDoorRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGroundFloorDoorLeft)).BeginInit();
            this.grpControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picElevatorCarDisplayWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGroundFloorDisplayWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1stFloorDisplayWindow)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picElevatorCarOpenedFF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picElevatorCarOpenedGF)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(384, 305);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // picElevatorCarClosed
            // 
            this.picElevatorCarClosed.Image = ((System.Drawing.Image)(resources.GetObject("picElevatorCarClosed.Image")));
            this.picElevatorCarClosed.Location = new System.Drawing.Point(125, 398);
            this.picElevatorCarClosed.Name = "picElevatorCarClosed";
            this.picElevatorCarClosed.Size = new System.Drawing.Size(146, 231);
            this.picElevatorCarClosed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picElevatorCarClosed.TabIndex = 3;
            this.picElevatorCarClosed.TabStop = false;
            // 
            // btn1stFloorRequestButton
            // 
            this.btn1stFloorRequestButton.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1stFloorRequestButton.ForeColor = System.Drawing.Color.Black;
            this.btn1stFloorRequestButton.Location = new System.Drawing.Point(348, 140);
            this.btn1stFloorRequestButton.Name = "btn1stFloorRequestButton";
            this.btn1stFloorRequestButton.Size = new System.Drawing.Size(37, 28);
            this.btn1stFloorRequestButton.TabIndex = 4;
            this.btn1stFloorRequestButton.Text = "▼";
            this.btn1stFloorRequestButton.UseVisualStyleBackColor = true;
            this.btn1stFloorRequestButton.Click += new System.EventHandler(this.btn1stFloorRequestButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox2.Location = new System.Drawing.Point(125, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(146, 228);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox3.Location = new System.Drawing.Point(125, 398);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(146, 228);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // btnGroundFloorRequestButton
            // 
            this.btnGroundFloorRequestButton.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGroundFloorRequestButton.ForeColor = System.Drawing.Color.Black;
            this.btnGroundFloorRequestButton.Location = new System.Drawing.Point(348, 500);
            this.btnGroundFloorRequestButton.Name = "btnGroundFloorRequestButton";
            this.btnGroundFloorRequestButton.Size = new System.Drawing.Size(37, 28);
            this.btnGroundFloorRequestButton.TabIndex = 7;
            this.btnGroundFloorRequestButton.Text = "▲";
            this.btnGroundFloorRequestButton.UseVisualStyleBackColor = true;
            this.btnGroundFloorRequestButton.Click += new System.EventHandler(this.btnGroundFloorRequestButton_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1, 361);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(384, 305);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pic1stFloorDoorRight
            // 
            this.pic1stFloorDoorRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pic1stFloorDoorRight.Image = ((System.Drawing.Image)(resources.GetObject("pic1stFloorDoorRight.Image")));
            this.pic1stFloorDoorRight.Location = new System.Drawing.Point(198, 38);
            this.pic1stFloorDoorRight.Name = "pic1stFloorDoorRight";
            this.pic1stFloorDoorRight.Size = new System.Drawing.Size(73, 231);
            this.pic1stFloorDoorRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1stFloorDoorRight.TabIndex = 17;
            this.pic1stFloorDoorRight.TabStop = false;
            // 
            // pic1stFloorDoorLeft
            // 
            this.pic1stFloorDoorLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pic1stFloorDoorLeft.Image = ((System.Drawing.Image)(resources.GetObject("pic1stFloorDoorLeft.Image")));
            this.pic1stFloorDoorLeft.Location = new System.Drawing.Point(125, 38);
            this.pic1stFloorDoorLeft.Name = "pic1stFloorDoorLeft";
            this.pic1stFloorDoorLeft.Size = new System.Drawing.Size(73, 231);
            this.pic1stFloorDoorLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1stFloorDoorLeft.TabIndex = 18;
            this.pic1stFloorDoorLeft.TabStop = false;
            // 
            // picGroundFloorDoorRight
            // 
            this.picGroundFloorDoorRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picGroundFloorDoorRight.Image = ((System.Drawing.Image)(resources.GetObject("picGroundFloorDoorRight.Image")));
            this.picGroundFloorDoorRight.Location = new System.Drawing.Point(198, 398);
            this.picGroundFloorDoorRight.Name = "picGroundFloorDoorRight";
            this.picGroundFloorDoorRight.Size = new System.Drawing.Size(73, 231);
            this.picGroundFloorDoorRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGroundFloorDoorRight.TabIndex = 19;
            this.picGroundFloorDoorRight.TabStop = false;
            // 
            // picGroundFloorDoorLeft
            // 
            this.picGroundFloorDoorLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picGroundFloorDoorLeft.Image = ((System.Drawing.Image)(resources.GetObject("picGroundFloorDoorLeft.Image")));
            this.picGroundFloorDoorLeft.Location = new System.Drawing.Point(125, 398);
            this.picGroundFloorDoorLeft.Name = "picGroundFloorDoorLeft";
            this.picGroundFloorDoorLeft.Size = new System.Drawing.Size(73, 231);
            this.picGroundFloorDoorLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGroundFloorDoorLeft.TabIndex = 20;
            this.picGroundFloorDoorLeft.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "First Floor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ground Floor";
            // 
            // grpControlPanel
            // 
            this.grpControlPanel.BackColor = System.Drawing.Color.Transparent;
            this.grpControlPanel.Controls.Add(this.picElevatorCarDisplayWindow);
            this.grpControlPanel.Controls.Add(this.btnGoingDown_GroundFloor);
            this.grpControlPanel.Controls.Add(this.btnGoingUp_FirstFloor);
            this.grpControlPanel.Controls.Add(this.pictureBox5);
            this.grpControlPanel.Location = new System.Drawing.Point(412, 216);
            this.grpControlPanel.Name = "grpControlPanel";
            this.grpControlPanel.Size = new System.Drawing.Size(126, 232);
            this.grpControlPanel.TabIndex = 26;
            this.grpControlPanel.TabStop = false;
            this.grpControlPanel.Text = "Elevator Control Panel";
            // 
            // picElevatorCarDisplayWindow
            // 
            this.picElevatorCarDisplayWindow.BackColor = System.Drawing.Color.Black;
            this.picElevatorCarDisplayWindow.Location = new System.Drawing.Point(27, 27);
            this.picElevatorCarDisplayWindow.Name = "picElevatorCarDisplayWindow";
            this.picElevatorCarDisplayWindow.Size = new System.Drawing.Size(73, 71);
            this.picElevatorCarDisplayWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picElevatorCarDisplayWindow.TabIndex = 28;
            this.picElevatorCarDisplayWindow.TabStop = false;
            // 
            // btnGoingDown_GroundFloor
            // 
            this.btnGoingDown_GroundFloor.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoingDown_GroundFloor.ForeColor = System.Drawing.Color.Black;
            this.btnGoingDown_GroundFloor.Location = new System.Drawing.Point(39, 167);
            this.btnGoingDown_GroundFloor.Name = "btnGoingDown_GroundFloor";
            this.btnGoingDown_GroundFloor.Size = new System.Drawing.Size(52, 44);
            this.btnGoingDown_GroundFloor.TabIndex = 7;
            this.btnGoingDown_GroundFloor.Text = "G";
            this.btnGoingDown_GroundFloor.UseVisualStyleBackColor = true;
            this.btnGoingDown_GroundFloor.Click += new System.EventHandler(this.btnGoingDown_GroundFloor_Click);
            // 
            // btnGoingUp_FirstFloor
            // 
            this.btnGoingUp_FirstFloor.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoingUp_FirstFloor.ForeColor = System.Drawing.Color.Black;
            this.btnGoingUp_FirstFloor.Location = new System.Drawing.Point(39, 112);
            this.btnGoingUp_FirstFloor.Name = "btnGoingUp_FirstFloor";
            this.btnGoingUp_FirstFloor.Size = new System.Drawing.Size(52, 44);
            this.btnGoingUp_FirstFloor.TabIndex = 6;
            this.btnGoingUp_FirstFloor.Text = "1";
            this.btnGoingUp_FirstFloor.UseVisualStyleBackColor = true;
            this.btnGoingUp_FirstFloor.Click += new System.EventHandler(this.btnGoingUp_FirstFloor_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(6, 19);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(114, 207);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 27;
            this.pictureBox5.TabStop = false;
            // 
            // picGroundFloorDisplayWindow
            // 
            this.picGroundFloorDisplayWindow.BackColor = System.Drawing.Color.Black;
            this.picGroundFloorDisplayWindow.Location = new System.Drawing.Point(182, 365);
            this.picGroundFloorDisplayWindow.Name = "picGroundFloorDisplayWindow";
            this.picGroundFloorDisplayWindow.Size = new System.Drawing.Size(31, 27);
            this.picGroundFloorDisplayWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGroundFloorDisplayWindow.TabIndex = 29;
            this.picGroundFloorDisplayWindow.TabStop = false;
            // 
            // pic1stFloorDisplayWindow
            // 
            this.pic1stFloorDisplayWindow.BackColor = System.Drawing.Color.Black;
            this.pic1stFloorDisplayWindow.Location = new System.Drawing.Point(182, 6);
            this.pic1stFloorDisplayWindow.Name = "pic1stFloorDisplayWindow";
            this.pic1stFloorDisplayWindow.Size = new System.Drawing.Size(31, 27);
            this.pic1stFloorDisplayWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1stFloorDisplayWindow.TabIndex = 30;
            this.pic1stFloorDisplayWindow.TabStop = false;
            // 
            // lstElevatorDBLog
            // 
            this.lstElevatorDBLog.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstElevatorDBLog.FormattingEnabled = true;
            this.lstElevatorDBLog.ItemHeight = 18;
            this.lstElevatorDBLog.Location = new System.Drawing.Point(14, 106);
            this.lstElevatorDBLog.Name = "lstElevatorDBLog";
            this.lstElevatorDBLog.Size = new System.Drawing.Size(527, 508);
            this.lstElevatorDBLog.TabIndex = 31;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnClearLog);
            this.groupBox1.Controls.Add(this.btnDisplayFullLog);
            this.groupBox1.Controls.Add(this.lstElevatorDBLog);
            this.groupBox1.Location = new System.Drawing.Point(569, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 639);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elevator Database Log";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(216, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 21);
            this.label5.TabIndex = 37;
            this.label5.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 21);
            this.label4.TabIndex = 36;
            this.label4.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(387, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 35;
            this.label3.Text = "Status";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(445, 20);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 35);
            this.btnExit.TabIndex = 34;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(328, 20);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(92, 35);
            this.btnClearLog.TabIndex = 34;
            this.btnClearLog.Text = "Clear Log";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // btnDisplayFullLog
            // 
            this.btnDisplayFullLog.Location = new System.Drawing.Point(202, 20);
            this.btnDisplayFullLog.Name = "btnDisplayFullLog";
            this.btnDisplayFullLog.Size = new System.Drawing.Size(95, 35);
            this.btnDisplayFullLog.TabIndex = 33;
            this.btnDisplayFullLog.Text = "Display Full Log";
            this.btnDisplayFullLog.UseVisualStyleBackColor = true;
            this.btnDisplayFullLog.Click += new System.EventHandler(this.btnDisplayFullLog_Click);
            // 
            // picElevatorCarOpenedFF
            // 
            this.picElevatorCarOpenedFF.Image = ((System.Drawing.Image)(resources.GetObject("picElevatorCarOpenedFF.Image")));
            this.picElevatorCarOpenedFF.Location = new System.Drawing.Point(125, 38);
            this.picElevatorCarOpenedFF.Name = "picElevatorCarOpenedFF";
            this.picElevatorCarOpenedFF.Size = new System.Drawing.Size(146, 231);
            this.picElevatorCarOpenedFF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picElevatorCarOpenedFF.TabIndex = 33;
            this.picElevatorCarOpenedFF.TabStop = false;
            // 
            // picElevatorCarOpenedGF
            // 
            this.picElevatorCarOpenedGF.Image = ((System.Drawing.Image)(resources.GetObject("picElevatorCarOpenedGF.Image")));
            this.picElevatorCarOpenedGF.Location = new System.Drawing.Point(125, 395);
            this.picElevatorCarOpenedGF.Name = "picElevatorCarOpenedGF";
            this.picElevatorCarOpenedGF.Size = new System.Drawing.Size(146, 231);
            this.picElevatorCarOpenedGF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picElevatorCarOpenedGF.TabIndex = 34;
            this.picElevatorCarOpenedGF.TabStop = false;
            // 
            // tmrElevatorCar_InMotion_Controller
            // 
            this.tmrElevatorCar_InMotion_Controller.Interval = 1;
            this.tmrElevatorCar_InMotion_Controller.Tick += new System.EventHandler(this.tmrElevatorCar_InMotion_Controller_Tick);
            // 
            // tmrDoorsOpening_Controller
            // 
            this.tmrDoorsOpening_Controller.Interval = 1;
            this.tmrDoorsOpening_Controller.Tick += new System.EventHandler(this.tmrDoorsOpening_Controller_Tick);
            // 
            // tmrDoorsClosing_Controller
            // 
            this.tmrDoorsClosing_Controller.Interval = 1;
            this.tmrDoorsClosing_Controller.Tick += new System.EventHandler(this.tmrDoorsClosing_Controller_Tick);
            // 
            // tmrAutomatic_DoorsClosing_Controller
            // 
            this.tmrAutomatic_DoorsClosing_Controller.Interval = 4000;
            this.tmrAutomatic_DoorsClosing_Controller.Tick += new System.EventHandler(this.tmrAutomatic_DoorsClosing_Controller_Tick);
            // 
            // tmrElevCar_InMotion_after_DoorsClosed_Controller
            // 
            this.tmrElevCar_InMotion_after_DoorsClosed_Controller.Interval = 1500;
            this.tmrElevCar_InMotion_after_DoorsClosed_Controller.Tick += new System.EventHandler(this.tmrElevCar_InMotion_after_DoorsClosed_Controller_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1135, 674);
            this.Controls.Add(this.btnGroundFloorRequestButton);
            this.Controls.Add(this.btn1stFloorRequestButton);
            this.Controls.Add(this.picGroundFloorDoorRight);
            this.Controls.Add(this.picGroundFloorDoorLeft);
            this.Controls.Add(this.picElevatorCarOpenedGF);
            this.Controls.Add(this.pic1stFloorDoorRight);
            this.Controls.Add(this.pic1stFloorDoorLeft);
            this.Controls.Add(this.picElevatorCarOpenedFF);
            this.Controls.Add(this.pic1stFloorDisplayWindow);
            this.Controls.Add(this.picGroundFloorDisplayWindow);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpControlPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picElevatorCarClosed);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elevator Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picElevatorCarClosed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1stFloorDoorRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1stFloorDoorLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGroundFloorDoorRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGroundFloorDoorLeft)).EndInit();
            this.grpControlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picElevatorCarDisplayWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGroundFloorDisplayWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1stFloorDisplayWindow)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picElevatorCarOpenedFF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picElevatorCarOpenedGF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picElevatorCarClosed;
        private System.Windows.Forms.Button btn1stFloorRequestButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnGroundFloorRequestButton;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pic1stFloorDoorRight;
        private System.Windows.Forms.PictureBox pic1stFloorDoorLeft;
        private System.Windows.Forms.PictureBox picGroundFloorDoorRight;
        private System.Windows.Forms.PictureBox picGroundFloorDoorLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpControlPanel;
        private System.Windows.Forms.Button btnGoingDown_GroundFloor;
        private System.Windows.Forms.Button btnGoingUp_FirstFloor;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox picElevatorCarDisplayWindow;
        private System.Windows.Forms.PictureBox picGroundFloorDisplayWindow;
        private System.Windows.Forms.PictureBox pic1stFloorDisplayWindow;
        private System.Windows.Forms.ListBox lstElevatorDBLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.Button btnDisplayFullLog;
        private System.Windows.Forms.PictureBox picElevatorCarOpenedFF;
        private System.Windows.Forms.PictureBox picElevatorCarOpenedGF;
        private System.Windows.Forms.Timer tmrElevatorCar_InMotion_Controller;
        private System.Windows.Forms.Timer tmrDoorsOpening_Controller;
        private System.Windows.Forms.Timer tmrDoorsClosing_Controller;
        private System.Windows.Forms.Timer tmrAutomatic_DoorsClosing_Controller;
        private System.Windows.Forms.Timer tmrElevCar_InMotion_after_DoorsClosed_Controller;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

