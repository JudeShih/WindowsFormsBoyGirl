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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            String name = textBox1.Text;
            Form1 A = new Form1();
            Form2 B = new Form2();
            Form3 C = new Form3();
            Random random = new Random();
            int randomnumber = random.Next(0, 2);
            
            
            string GenderGuess = (randomnumber == 1) ? "You're a man aren't you," + name + "?" : "You're a woman aren't you," + name + "?";
        
            MessageBox.Show(GenderGuess);

            A.Close();
            
            if(randomnumber == 1)
            B.Show(this);
           
            else
            C.Show(this);

          



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 B = new Form2(); 
            B.Show(this);
        }
    }
}
