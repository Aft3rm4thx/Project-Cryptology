using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                Keyword KS = new Keyword();
                KS.Show();
            }
            if(comboBox1.SelectedIndex == 1)
            {
                Columnarkey CKS = new Columnarkey();
                CKS.Show();
            }
            if(comboBox1.SelectedIndex == 2)
            {
                Playfair PC = new Playfair();
                PC.Show();
            }

        }

       
    }
}
