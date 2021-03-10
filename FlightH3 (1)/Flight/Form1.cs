using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight
{
    public partial class Form1 : Form
    {
        Flight Flight = new Flight();
        public Form1()
        {
            InitializeComponent();
        }

        
        private void btStart_Click(object sender, EventArgs e)
        {
            Flight.TakeValues(edAngle.Value, edSpeed.Value, edHeight.Value, edWeight.Value, edSquare.Value);
            Flight.StartValues();

            chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.AddXY(Flight.x, Flight.y);

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Flight.Calculation(Flight.S, Flight.m);

            chart1.Series[0].Points.AddXY(Flight.x, Flight.y);
            if (Flight.y <= 0) timer1.Stop();
        }
    }

}
