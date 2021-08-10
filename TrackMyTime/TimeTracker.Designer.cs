
namespace TrackMyTime
{
    partial class TimeTracker
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.totaltimer = new System.Windows.Forms.Timer(this.components);
            this.activetimer = new System.Windows.Forms.Timer(this.components);
            this.idletimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idlesecs = new System.Windows.Forms.Label();
            this.idlemins = new System.Windows.Forms.Label();
            this.actsec = new System.Windows.Forms.Label();
            this.actmin = new System.Windows.Forms.Label();
            this.totalsecs = new System.Windows.Forms.Label();
            this.totalmins = new System.Windows.Forms.Label();
            this.totalhr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stop = new System.Windows.Forms.Button();
            this.Startbtn1 = new System.Windows.Forms.Button();
            this.idlehrs = new System.Windows.Forms.Label();
            this.acthr = new System.Windows.Forms.Label();
            this.actualtime = new System.Windows.Forms.Label();
            this.idletime = new System.Windows.Forms.Label();
            this.activetime = new System.Windows.Forms.Label();
            this.CurrentTime = new System.Windows.Forms.Label();
            this.TextView = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // totaltimer
            // 
            this.totaltimer.Interval = 1000;
            this.totaltimer.Tick += new System.EventHandler(this.totaltimer_Tick);
            // 
            // activetimer
            // 
            this.activetimer.Interval = 1000;
            this.activetimer.Tick += new System.EventHandler(this.activetimer_Tick);
            // 
            // idletimer
            // 
            this.idletimer.Interval = 1000;
            this.idletimer.Tick += new System.EventHandler(this.idletimer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.idlesecs);
            this.panel1.Controls.Add(this.idlemins);
            this.panel1.Controls.Add(this.actsec);
            this.panel1.Controls.Add(this.actmin);
            this.panel1.Controls.Add(this.totalsecs);
            this.panel1.Controls.Add(this.totalmins);
            this.panel1.Controls.Add(this.totalhr);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.stop);
            this.panel1.Controls.Add(this.Startbtn1);
            this.panel1.Controls.Add(this.idlehrs);
            this.panel1.Controls.Add(this.acthr);
            this.panel1.Controls.Add(this.actualtime);
            this.panel1.Controls.Add(this.idletime);
            this.panel1.Controls.Add(this.activetime);
            this.panel1.Controls.Add(this.CurrentTime);
            this.panel1.Controls.Add(this.TextView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 344);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.comboBox1.DropDownHeight = 98;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25"});
            this.comboBox1.Location = new System.Drawing.Point(436, 167);
            this.comboBox1.MaxDropDownItems = 10;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(44, 21);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.TabStop = false;
            this.comboBox1.Tag = "";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(355, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 36);
            this.button1.TabIndex = 23;
            this.button1.Text = "RESET";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.Font = new System.Drawing.Font("DS-Digital", 14.25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(384, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = ":";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Font = new System.Drawing.Font("DS-Digital", 14.25F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(332, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = ":";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("DS-Digital", 14.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(384, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = ":";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("DS-Digital", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(332, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = ":";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("DS-Digital", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(384, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = ":";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("DS-Digital", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(332, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = ":";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // idlesecs
            // 
            this.idlesecs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idlesecs.BackColor = System.Drawing.SystemColors.Desktop;
            this.idlesecs.Font = new System.Drawing.Font("DS-Digital", 14.25F);
            this.idlesecs.ForeColor = System.Drawing.SystemColors.Window;
            this.idlesecs.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.idlesecs.Location = new System.Drawing.Point(403, 169);
            this.idlesecs.Name = "idlesecs";
            this.idlesecs.Size = new System.Drawing.Size(27, 19);
            this.idlesecs.TabIndex = 16;
            this.idlesecs.Text = "00";
            this.idlesecs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.idlesecs.Click += new System.EventHandler(this.idlesecs_Click);
            // 
            // idlemins
            // 
            this.idlemins.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idlemins.BackColor = System.Drawing.SystemColors.Desktop;
            this.idlemins.Font = new System.Drawing.Font("DS-Digital", 14.25F);
            this.idlemins.ForeColor = System.Drawing.SystemColors.Window;
            this.idlemins.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.idlemins.Location = new System.Drawing.Point(351, 169);
            this.idlemins.Name = "idlemins";
            this.idlemins.Size = new System.Drawing.Size(27, 19);
            this.idlemins.TabIndex = 15;
            this.idlemins.Text = "00";
            this.idlemins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.idlemins.Click += new System.EventHandler(this.idlemins_Click);
            // 
            // actsec
            // 
            this.actsec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.actsec.BackColor = System.Drawing.SystemColors.Desktop;
            this.actsec.Font = new System.Drawing.Font("DS-Digital", 14.25F);
            this.actsec.ForeColor = System.Drawing.SystemColors.Window;
            this.actsec.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.actsec.Location = new System.Drawing.Point(403, 126);
            this.actsec.Name = "actsec";
            this.actsec.Size = new System.Drawing.Size(27, 19);
            this.actsec.TabIndex = 14;
            this.actsec.Text = "00";
            this.actsec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.actsec.Click += new System.EventHandler(this.actsec_Click);
            // 
            // actmin
            // 
            this.actmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.actmin.BackColor = System.Drawing.SystemColors.Desktop;
            this.actmin.Font = new System.Drawing.Font("DS-Digital", 14.25F);
            this.actmin.ForeColor = System.Drawing.SystemColors.Window;
            this.actmin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.actmin.Location = new System.Drawing.Point(351, 125);
            this.actmin.Name = "actmin";
            this.actmin.Size = new System.Drawing.Size(27, 19);
            this.actmin.TabIndex = 13;
            this.actmin.Text = "00";
            this.actmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.actmin.Click += new System.EventHandler(this.actmin_Click);
            // 
            // totalsecs
            // 
            this.totalsecs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalsecs.BackColor = System.Drawing.SystemColors.Desktop;
            this.totalsecs.Font = new System.Drawing.Font("DS-Digital", 14.25F);
            this.totalsecs.ForeColor = System.Drawing.SystemColors.Window;
            this.totalsecs.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.totalsecs.Location = new System.Drawing.Point(403, 75);
            this.totalsecs.Name = "totalsecs";
            this.totalsecs.Size = new System.Drawing.Size(27, 19);
            this.totalsecs.TabIndex = 12;
            this.totalsecs.Text = "00";
            this.totalsecs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.totalsecs.Click += new System.EventHandler(this.totalsecs_Click);
            // 
            // totalmins
            // 
            this.totalmins.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalmins.BackColor = System.Drawing.SystemColors.Desktop;
            this.totalmins.Font = new System.Drawing.Font("DS-Digital", 14.25F);
            this.totalmins.ForeColor = System.Drawing.SystemColors.Window;
            this.totalmins.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.totalmins.Location = new System.Drawing.Point(351, 75);
            this.totalmins.Name = "totalmins";
            this.totalmins.Size = new System.Drawing.Size(27, 19);
            this.totalmins.TabIndex = 11;
            this.totalmins.Text = "00";
            this.totalmins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.totalmins.Click += new System.EventHandler(this.totalmins_Click);
            // 
            // totalhr
            // 
            this.totalhr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalhr.BackColor = System.Drawing.SystemColors.Desktop;
            this.totalhr.Font = new System.Drawing.Font("DS-Digital", 14.25F);
            this.totalhr.ForeColor = System.Drawing.SystemColors.Window;
            this.totalhr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.totalhr.Location = new System.Drawing.Point(299, 75);
            this.totalhr.Name = "totalhr";
            this.totalhr.Size = new System.Drawing.Size(27, 19);
            this.totalhr.TabIndex = 10;
            this.totalhr.Text = "00";
            this.totalhr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.totalhr.Click += new System.EventHandler(this.totalhr_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(65, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Total time";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // stop
            // 
            this.stop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stop.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.stop.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.stop.Location = new System.Drawing.Point(221, 276);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(105, 36);
            this.stop.TabIndex = 8;
            this.stop.Text = "STOP";
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // Startbtn1
            // 
            this.Startbtn1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Startbtn1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Startbtn1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Startbtn1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Startbtn1.Location = new System.Drawing.Point(81, 276);
            this.Startbtn1.Name = "Startbtn1";
            this.Startbtn1.Size = new System.Drawing.Size(105, 36);
            this.Startbtn1.TabIndex = 7;
            this.Startbtn1.Text = "START";
            this.Startbtn1.UseVisualStyleBackColor = false;
            this.Startbtn1.Click += new System.EventHandler(this.Startbtn1_Click);
            // 
            // idlehrs
            // 
            this.idlehrs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idlehrs.BackColor = System.Drawing.SystemColors.Desktop;
            this.idlehrs.Font = new System.Drawing.Font("DS-Digital", 14.25F);
            this.idlehrs.ForeColor = System.Drawing.SystemColors.Window;
            this.idlehrs.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.idlehrs.Location = new System.Drawing.Point(299, 169);
            this.idlehrs.Name = "idlehrs";
            this.idlehrs.Size = new System.Drawing.Size(27, 19);
            this.idlehrs.TabIndex = 6;
            this.idlehrs.Text = "00";
            this.idlehrs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.idlehrs.Click += new System.EventHandler(this.idletimer_Click);
            // 
            // acthr
            // 
            this.acthr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.acthr.BackColor = System.Drawing.SystemColors.Desktop;
            this.acthr.Font = new System.Drawing.Font("DS-Digital", 14.25F);
            this.acthr.ForeColor = System.Drawing.SystemColors.Window;
            this.acthr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.acthr.Location = new System.Drawing.Point(299, 126);
            this.acthr.Name = "acthr";
            this.acthr.Size = new System.Drawing.Size(27, 19);
            this.acthr.TabIndex = 5;
            this.acthr.Text = "00";
            this.acthr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.acthr.Click += new System.EventHandler(this.timer_Click);
            // 
            // actualtime
            // 
            this.actualtime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.actualtime.BackColor = System.Drawing.SystemColors.Desktop;
            this.actualtime.Font = new System.Drawing.Font("DS-Digital", 14.25F);
            this.actualtime.ForeColor = System.Drawing.SystemColors.Window;
            this.actualtime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.actualtime.Location = new System.Drawing.Point(320, 214);
            this.actualtime.Name = "actualtime";
            this.actualtime.Size = new System.Drawing.Size(85, 19);
            this.actualtime.TabIndex = 4;
            this.actualtime.Text = "00:00:00:00";
            this.actualtime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.actualtime.Click += new System.EventHandler(this.actualtime_Click);
            // 
            // idletime
            // 
            this.idletime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idletime.BackColor = System.Drawing.SystemColors.Desktop;
            this.idletime.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idletime.ForeColor = System.Drawing.SystemColors.Window;
            this.idletime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.idletime.Location = new System.Drawing.Point(77, 164);
            this.idletime.Name = "idletime";
            this.idletime.Size = new System.Drawing.Size(88, 24);
            this.idletime.TabIndex = 3;
            this.idletime.Text = "Idle Time";
            this.idletime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.idletime.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // activetime
            // 
            this.activetime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.activetime.BackColor = System.Drawing.SystemColors.Desktop;
            this.activetime.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activetime.ForeColor = System.Drawing.SystemColors.Window;
            this.activetime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.activetime.Location = new System.Drawing.Point(65, 123);
            this.activetime.Name = "activetime";
            this.activetime.Size = new System.Drawing.Size(116, 20);
            this.activetime.TabIndex = 2;
            this.activetime.Text = "Active Time";
            this.activetime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.activetime.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // CurrentTime
            // 
            this.CurrentTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CurrentTime.BackColor = System.Drawing.SystemColors.Desktop;
            this.CurrentTime.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTime.ForeColor = System.Drawing.SystemColors.Window;
            this.CurrentTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CurrentTime.Location = new System.Drawing.Point(65, 210);
            this.CurrentTime.Name = "CurrentTime";
            this.CurrentTime.Size = new System.Drawing.Size(110, 23);
            this.CurrentTime.TabIndex = 1;
            this.CurrentTime.Text = "Current Time";
            this.CurrentTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CurrentTime.Click += new System.EventHandler(this.CurrentTime_Click);
            // 
            // TextView
            // 
            this.TextView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextView.BackColor = System.Drawing.SystemColors.Desktop;
            this.TextView.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextView.ForeColor = System.Drawing.SystemColors.Window;
            this.TextView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TextView.Location = new System.Drawing.Point(182, 23);
            this.TextView.Name = "TextView";
            this.TextView.Size = new System.Drawing.Size(163, 36);
            this.TextView.TabIndex = 0;
            this.TextView.Text = "Time Tracker";
            this.TextView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TextView.Click += new System.EventHandler(this.label1_Click);
            // 
            // TimeTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 344);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TimeTracker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimeTracker v1.0.0";
            this.Load += new System.EventHandler(this.TimeTracker_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer totaltimer;
        private System.Windows.Forms.Timer activetimer;
        private System.Windows.Forms.Timer idletimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label idlesecs;
        private System.Windows.Forms.Label idlemins;
        private System.Windows.Forms.Label actsec;
        private System.Windows.Forms.Label actmin;
        private System.Windows.Forms.Label totalsecs;
        private System.Windows.Forms.Label totalmins;
        private System.Windows.Forms.Label totalhr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button Startbtn1;
        private System.Windows.Forms.Label idlehrs;
        private System.Windows.Forms.Label acthr;
        private System.Windows.Forms.Label actualtime;
        private System.Windows.Forms.Label idletime;
        private System.Windows.Forms.Label activetime;
        private System.Windows.Forms.Label CurrentTime;
        private System.Windows.Forms.Label TextView;
    }
}