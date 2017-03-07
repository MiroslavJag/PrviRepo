using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            pgbBar.Value == 100;

            if (pgbBar.Value)


            MessageBox.Show("Pozdrav." + ((Button)(sender)).Text + " dugme.", "Ovo je title");

        }


        private void btnStop_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Pozdrav." + ((Button)(sender)).Text + " dugme.", "Ovo je title");
            pgbBar = 0;
        }
        private void btnStop_Enter(object sender, EventArgs e)
        {

        }

      
    }
}
