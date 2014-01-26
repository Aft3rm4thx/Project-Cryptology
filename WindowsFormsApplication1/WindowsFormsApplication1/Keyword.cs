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
    public partial class Keyword : Form
    {
        public Keyword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EncryptKS EKS = new EncryptKS();
            EKS.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DecryptKS DKS = new DecryptKS();
            DKS.Show();
        }
    }
}
