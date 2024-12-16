using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircleProgram
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void TXTradius_TextChanged(object sender, EventArgs e)
        {
            ciclecalc();
        }

        void ciclecalc()
        {
            try
            {
                float radfloat = float.Parse(TXTradius.Text);
                TXTarea.Text = Convert.ToString("Area = " + ((radfloat * radfloat) * Math.PI));
                TXTcircumfrence.Text = Convert.ToString("Circumfrence = " + (radfloat * Math.PI) * 2);
                TXTdiameter.Text = Convert.ToString("Diameter = " + (radfloat * 2));
            }
            catch
            {
                TXTarea.Text = ("");
                TXTcircumfrence.Text = ("");
                TXTdiameter.Text = ("");
                return;
            }

        }
    }
}
