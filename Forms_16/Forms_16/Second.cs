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
    public partial class Second : Form
    {
        public string s,s_out;
        int x,y;

        public Second()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            s_out = lbl1.Text;
            this.Dispose();

            
        }

        private void Second_Load(object sender, EventArgs e)
        { 
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void BtnLetter_Click(object sender, EventArgs e)
        {
            this.Text = s;
            x = 0;
            y = 0;

                foreach(char ab in s)
                {
            Button btn = new Button();
                    btn.Size= new Size(25,25);
                    btn.Location = new Point(x, y);
                    panel1.Controls.Add(btn);
                btn.Text = ab.ToString();
                x += 30;
                btn.Click += Btn_Click;

            }

           }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            lbl1.Text += but.Text;
        }
    }
}
