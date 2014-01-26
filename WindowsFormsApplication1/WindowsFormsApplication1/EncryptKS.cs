using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public partial class EncryptKS : Form
    {
        public EncryptKS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string keyword = textBox1.Text;
            string newkwd = new string(keyword.Distinct().ToArray());
            string alphabet = label1.Text;
            string alphakwd = newkwd + " " + alphabet;
            string final = new string(alphakwd.Distinct().ToArray());
            label4.Text = newkwd;
            label5.Text = final;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*char[] array = label5.Text.ToCharArray();
            
            //label7.Text = Convert.ToString(input);
            //string str = "Darth Vader is scary.";
            
            string input = textBox2.Text;
            for (int x = input.Length; x <= x; array[0]++)
            {
                label6.Text = textBox2.Text;
                label7.Text = input.Replace(input.ElementAt(input.Length - input.Length), array[0]);
            }
            */
            string input = textBox2.Text;
            int x = 0;
            int y = input.Length;
            //char[] array = label5.Text.ToCharArray();
            ArrayList array = new ArrayList();
            array.Add(label5.Text);
            label8.Text = Convert.ToString(y);
            label6.Text = input;
            do
            {
                label7.Text = input.Replace(input.ElementAt(x), Convert.ToChar(array[x]));
                x++;
            }
            while (x < y);
            
                
            
            
        }

    }
}

