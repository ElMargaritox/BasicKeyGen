using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyGen
{
    
    public partial class Form1 : Form
    {
        public Form1 Instance;
        public Form1()
        {
            
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Instance = this;
            Instance.Text = "Hola Mundo UwU";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            int i = 0;
            int numero;
            int numero2;
            char letra;
            char letra2;
            string key = string.Empty;

            while (i < 4)
            {
                numero = rand.Next(9);
                numero2 = rand.Next(10, 26);
                letra = (char)(((int)'A') + numero);
                letra2 = (char)(((int)'A') + numero2);

                if (i == 3) { key = key + letra.ToString().ToUpper() + numero2 + letra2.ToString().ToUpper(); break; }
                key = letra.ToString().ToUpper() + numero2 + letra2.ToString().ToUpper() + "-" + key;
                i++;
              
            }

            textBox1.Text = key;
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox1.Copy();
        }
    }
}
