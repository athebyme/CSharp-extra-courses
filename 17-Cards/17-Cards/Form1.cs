using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17_Cards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int iy,rez,a;
        Random rnd = new Random();
        Object ob;

        private void BtnSpawn_Click(object sender, EventArgs e)
        {

            iy = 2;
            listBox1.Items.Clear();
            for (int i = 0; i <= 9; i++)
            {
                //for (int j = 2; j < 11; j++)
                //{
                //    iy = 13 * i + j;
                //listBox1.Items.Add(iy);
                //}
                listBox1.Items.Add(iy);
                listBox1.Items.Add(iy + 13);
                listBox1.Items.Add(iy + 26);
                listBox1.Items.Add(iy + 39);
                iy++;
            }



           
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Img_Click(object sender, EventArgs e)
        {
            PictureBox im = (PictureBox)sender;
            if (a % 2 == 0)
            {
                lblRez.Text = (rez + 1).ToString(); 
            }
            else
            {
                lblRez.Text = (rez - 1).ToString();
            }
            im.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pnl1.Controls.Clear();
            foreach(int a in listBox1.Items)
            {
 
                PictureBox img = new PictureBox();
                img.Size = new Size(100, 50);
                img.SizeMode = PictureBoxSizeMode.Zoom;
                img.Location = new Point(rnd.Next(0,pnl1.Width - 60), rnd.Next(0, pnl1.Height - 60));
                ob = Properties.Resources.ResourceManager.GetObject("card" + a);
                img.Image = (Bitmap)ob;
                img.Tag = a;
                img.Click += Img_Click;
                pnl1.Controls.Add(img);
            }
        }
    }
}
