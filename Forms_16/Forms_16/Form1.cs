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

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string log;
        private void BtnEnter_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            Second frm = new Second();
            Third log = new Third();

            frm.txt2.Text = txt1.Text;
            frm.s = txt1.Text;
            this.Text = log.login;
            form.Hide();
            frm.ShowDialog();
            this.Text = log.login;
            this.txt1.Text = frm.txt2.Text;
            this.lbl1.Text = frm.s_out;
            this.Show();
            frm.Dispose();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }
    }
}
