using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;



namespace TrackMyTime
{

    public partial class TimeTracker : Form
    {
        int hr;
        int min;
        int sec;
        int activehrs;
        int activemins;
        int activesecs;
        int idhrs;
        int idmins;
        int idsecs;
        bool isActive;
        


        [DllImport("user32.dll")]
        public static extern Boolean GetLastInputInfo(ref tagLASTINPUTINFO plii);

        public struct tagLASTINPUTINFO
        {
            public uint cbSize;
            public Int32 dwTime;
        }


        public TimeTracker()
        {
            //FILE
            InitializeComponent();
            timer1.Start();
            ResetTime();
            isActive = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void timer_Click(object sender, EventArgs e)
        {

        }

        private void actualtime_Click(object sender, EventArgs e)
        {
            actualtime.Text = DateTime.Now.ToLongTimeString();

        }

        private void CurrentTime_Click(object sender, EventArgs e)
        {

        }

        private void idletimer_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TimeTracker_Load(object sender, EventArgs e)
        {

        }


        private void Startbtn1_Click(object sender, EventArgs e)
        {
            
            activetimer.Start();
            totaltimer.Start();
            idletimer.Start();
            isActive = true;
            
        }
        private void stop_Click(object sender, EventArgs e)
        {
            totaltimer.Stop();
            activetimer.Stop();
            idletimer.Stop();
            isActive = false;
        }


        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            actualtime.Text = time.ToString("hh:mm:ss:tt");
        }

        private void totaltimer_Tick(object sender, EventArgs e)
        {

            if (isActive)
            {
                sec++;
                if (sec > 59)
                {
                    min++;
                    sec = 0;
                }
                if (min > 59)
                {
                    hr++;
                    min = 0;
                }
            }
            totalhr.Text = String.Format("{0:00}", hr);
            totalmins.Text = String.Format("{0:00}", min);
            totalsecs.Text = String.Format("{0:00}",sec);

        }

        private void totalhour_Click(object sender, EventArgs e)
        {

        }

        private void totalhr_Click(object sender, EventArgs e)
        {
           
        }

        private void activetimer_Tick(object sender, EventArgs e)
        {
            if (isActive)
            {
                activesecs++;
                if (activesecs > 59)
                {
                    activemins++;
                    activesecs = 0;
                }
                if (activemins > 59)
                {
                    activehrs++;
                    activemins = 0;
                }
            }
            acthr.Text = String.Format("{0:00}", activehrs);
            actmin.Text = String.Format("{0:00}", activemins);
            actsec.Text = String.Format("{0:00}", activesecs);

        }

        private void idletimer_Tick(object sender, EventArgs e)
        {
            tagLASTINPUTINFO LastInput = new tagLASTINPUTINFO();
            
            LastInput.cbSize = (uint)Marshal.SizeOf(LastInput);
            LastInput.dwTime = 0;
            activetimer.Start();
            int IdleTime;
            int idleTimeFromUser = Convert.ToInt32 (this.comboBox1.SelectedItem);

            if (GetLastInputInfo(ref LastInput))
            {                
                IdleTime = (System.Environment.TickCount - LastInput.dwTime) / 1000;
                if (isActive)
                {
                    if (IdleTime > (idleTimeFromUser * 60))
                    {
                        idsecs++;
                        if (idsecs > 59)
                        {
                            idmins++;
                            idsecs = 0;
                        }
                        if (idmins > 59)
                        {
                            idhrs++;
                            idmins = 0;
                        }
                        activetimer.Stop();                        
                    }
                        idlehrs.Text = String.Format("{0:00}", idhrs);
                        idlemins.Text = String.Format("{0:00}", idmins);
                        idlesecs.Text = String.Format("{0:00}", idsecs);
                }
            }            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void idlesecs_Click(object sender, EventArgs e)
        {

        }

        private void actsec_Click(object sender, EventArgs e)
        {

        }

        private void actmin_Click(object sender, EventArgs e)
        {

        }

        private void totalsecs_Click(object sender, EventArgs e)
        {

        }

        private void totalmins_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {            
            ResetTime();
            isActive = false;                           
        }
        private void ResetTime()
        {
            hr = 0;
            min = 0;
            sec = 0;
            activesecs = 0;
            activemins = 0;
            activehrs = 0;
            idhrs = 0;
            idmins = 0;
            idsecs = 0;
            isActive = false;
            totalsecs.Text = String.Format("{0:00}", sec);
            acthr.Text = String.Format("{0:00}", activehrs);
            actmin.Text = String.Format("{0:00}", activemins);
            acthr.Text = String.Format("{0:00}", activehrs);
            actmin.Text = String.Format("{0:00}", activemins);
            actsec.Text = String.Format("{0:00}", activesecs);
            idlehrs.Text = String.Format("{0:00}", idhrs);
            idlemins.Text = String.Format("{0:00}", idmins);
            idlesecs.Text = String.Format("{0:00}", idsecs);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void idlemins_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}