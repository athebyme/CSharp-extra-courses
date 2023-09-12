using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_Domino
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int x, y, a, b,q,dd,ew;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDate_Click(object sender, EventArgs e)
        {
            lstDate.Items.Clear();
            lstDate.Items.Add(dateTimePicker1.Value.AddDays(Convert.ToInt32(lstRand.Items[0])).ToShortDateString());
            foreach(int i in lstRand.Items)
            {
                lstDate.Items.Add(dateTimePicker1.Value.AddDays(Convert.ToInt32(lstRand.Items[0])+ i).ToShortDateString() );
            }
            //for(int i = 0; i < 6; i++)
            //{
            //    dd = dateTimePicker1.Value.AddDays(lstRand.Index);
            //    lstDate.Items.Add(dd);
            //}
        }

        private void BtnRand_Click(object sender, EventArgs e)
        {
            lstRand.Items.Clear();
            for(int i = 0;i < 6; i++)
            {
                q = rnd.Next(0, 10);
                lstRand.Items.Add(q);
            }
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            TimeSpan ts = dateTimePicker2.Value - dateTimePicker1.Value;
            int nDays = ts.Days;
            txt3.Text = nDays.ToString();
            txt4.Text = dateTimePicker1.Value.AddDays(30).ToShortDateString();
            txt5.Text = dateTimePicker1.Value.AddMonths(1).ToShortDateString();
            if(dateTimePicker1.Value > dateTimePicker2.Value)txt6.Text = "1я больше";
            else if (dateTimePicker2.Value > dateTimePicker1.Value)txt6.Text = "Вторая дата больше";
            else txt6.Text = "Даты равны";
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Button btn;
            x = 0;
            y = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    btn = new Button();
                    btn.Size = new Size(50, 50);
                    btn.Location = new Point(x, y);
                    panel1.Controls.Add(btn);
                    btn.Click += Btn_Click;
                    btn.Tag = i + "" + j.ToString();
                    btn.Text = i +""+ j.ToString();
                    x += 51;
                }
                x = 0;
                y += 51;

            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button) sender;
                label1.Text =btn.Tag.ToString();
            string s = btn.Tag.ToString();
            char z = s[0];
            string zs = z.ToString();
            label1.Text = zs;
            a = Convert.ToInt16(zs);
            int t = Convert.ToInt16(btn.Tag);
            b = Convert.ToInt16(btn.Tag.ToString()[1].ToString());
            label1.Text += "\ni =" + a + "  j = " + b;
            //double d = Convert.ToInt32(btn.Text) % 10;
            //label2.Text = "j = " + d.ToString();

           
            //a = Convert.ToInt16(Math.Truncate(t / 10.0));
            //label1.Text = "i = " +t.ToString();
            //a = Convert.ToInt16(btn.Tag.ToString().Substring(0, 1));
            //b = Convert.ToInt16(btn.Tag.ToString().Substring(1, 1));

        }
    }
}
