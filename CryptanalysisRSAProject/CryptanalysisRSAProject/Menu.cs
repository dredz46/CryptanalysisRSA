using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptanalysisRSAProject
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new Form1();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new EncryptMessageForm();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new DecryptMessageForm();
            form.Show();
        }
    }
}
