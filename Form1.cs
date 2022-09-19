using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.Create("Jmena.txt");
            StreamWriter streamWriter1 = File.AppendText("Jmena.txt");
            string jmeno = textBox1.Text;
            string prijmeni = textBox2.Text;
            streamWriter1.WriteLine(jmeno, prijmeni.PadLeft(21));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
