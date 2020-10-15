using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            int conta = int.Parse(textBox1.Text);
            conta++;
            textBox1.Text = conta.ToString();
            if(conta >= 25)
            {
                textBox1.Text = "25";
                MessageBox.Show("Ya no se puede incrementar");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int conta = int.Parse(textBox1.Text);
            conta--;
            textBox1.Text = conta.ToString();
            if (conta <= 0)
            {
                textBox1.Text = "0";
                MessageBox.Show("Ya no se puede decrementar");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }

