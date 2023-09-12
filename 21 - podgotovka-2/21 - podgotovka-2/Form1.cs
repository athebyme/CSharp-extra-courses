using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21___podgotovka_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> lst = new List<int>();
        Random rnd = new Random();
        int a = 0;
        int f,ff;
        int na,x,y;
        Object ob;
        private void BtnList_Click(object sender, EventArgs e)
        {
            lst.Clear();
            for (int i = 0; i < 5; i++)
            {
                a = rnd.Next(10);
                if (!lst.Contains(a))
                {
                    lst.Add(a);
                }
                else
                {
                    i--;
                }
            }
                MyPaint();
        }
        private void MyPaint()
            {
                lblList.Text = null;
                foreach(int b in lst)
                lblList.Text += b + "\r";
            }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            textBox1.Text.Trim();
            if (textBox1.Text == null)
            {
                MessageBox.Show("Введите что-нибудь!!!");
            }
            else
            {
                try
                {
                    if (!lst.Contains(Convert.ToInt32(textBox1.Text)))
                    {
                        lst.Add(Convert.ToInt32(textBox1.Text));
                        lblList.Text += Convert.ToInt32(textBox1.Text) + "\r";
                    }
                    else
                    {
                        MessageBox.Show("Такое число уже есть");
                    }
                }
                catch
                {
                    MessageBox.Show("Введите число!!!");
                }
            }




            //без проверки стринг и без "try", "catch"
            //if (textBox1.Text == "")
            //{
            //    MessageBox.Show("Введите что-нибудь!!!");
            //}
            //else
            //{
            //    if (!lst.Contains(Convert.ToInt16(textBox1.Text)))
            //    {
            //        lst.Add(Convert.ToInt16(textBox1.Text));
            //        lblList.Text += Convert.ToInt16(textBox1.Text) + "\r";
            //    }
            //    else
            //    {
            //        MessageBox.Show("Такое число уже есть");
            //    }
            //}
        }

        private void BtnCombo_Click(object sender, EventArgs e)
        {
            cmb1.Items.Clear();
            foreach(int c in lst)
            {
                cmb1.Items.Add(c);
            }
            cmb1.SelectedIndex = 0;

        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (cmb1.SelectedIndex < cmb1.Items.Count - 1)
            {
                cmb1.SelectedIndex++;
            }
            else
            {
                cmb1.SelectedIndex = 0;
            }
        }

        private void BtnToy_Click(object sender, EventArgs e)
        {
            y += 30;
            txtToy.HideSelection = false;
            timer1.Enabled = !timer1.Enabled;
          
        }


        private void LstToys_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            na = lstToys.SelectedIndex;
            txtToy.Text += lstToys.Items[na].ToString()+" ";
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtToy.Text = null;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            a = txtToy.Text.Trim().Length / 3;
            if (f == a)
            {
                f = 0;
                timer1.Enabled = false;
            }
            else
            {
            ff = f * 3 + f;
            txtToy.HideSelection = false;
            txtToy.Select(ff, 3);
            f++;
            ob = Properties.Resources.ResourceManager.GetObject(txtToy.SelectedText);
            pictureBox1.Image = (Bitmap)ob;
            }

            PictureBox im = new PictureBox();
            for (int i = 0; i <= a; i++)
            {
                ob = Properties.Resources.ResourceManager.GetObject(ff.ToString());
                im.Image = (Bitmap)ob;
                im.Location = new Point(x, y);
                im.Size = new Size(30, 30);
                im.SizeMode = PictureBoxSizeMode.StretchImage;
                pnl1.Controls.Add(im);
                x += 35;
            }
        }
    }
}
