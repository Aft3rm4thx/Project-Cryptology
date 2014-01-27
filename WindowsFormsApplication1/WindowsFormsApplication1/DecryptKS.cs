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
    public partial class DecryptKS : Form
    {
        private Cipher cipher = new Cipher("");

        public DecryptKS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cipher.Keyword = textBox1.Text;
            label4.Text = cipher.Keyword.ToUpper();
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
            label6.Text = input;
            label7.Text = cipher.Decode(input);
        }
    }
}
