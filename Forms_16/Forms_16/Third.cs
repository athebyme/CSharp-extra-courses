using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_16
{
    public partial class Third : Form
    {
        public Third()
        {
            InitializeComponent();
        }
        public string login;
        private void BtnGo_Click(object sender, EventArgs e)
        {
            login = textBox1.Text;
            Form1 form = new Form1();
            Second frm = new Second();
            form.Text = textBox1.Text;
            form.log = textBox1.Text;
            this.Hide();
            form.ShowDialog();
            this.Show();
            this.Dispose();
            
        }

        private void Third_Load(object sender, EventArgs e)
        {

        }
    }
}
