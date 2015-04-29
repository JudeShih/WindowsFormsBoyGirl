using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I'm such a genius right, Miss?");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I'll be right next time, Mr.?");
        }
    }
}
