using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace UgadayKartunkuProject
{
    public partial class Itogi : Form
    {
        public Itogi()
        {
            InitializeComponent();
        }
        List<string> ResaultP = new List<string>();
        List<string> ResaultN = new List<string>();
        MainGame main = new MainGame();
        Timer t = new Timer();
        int X, Y,i,S;

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAgain_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void Itogi_Load(object sender, EventArgs e)
        {
            Y = 0;X = 0;
            string path = @"resaultsN.txt";
            string path2 = @"resaultsP.txt";
            using (StreamReader stream = new StreamReader(path))
            {
                while (stream.Peek() >= 0)
                {
                    ResaultN.Add(stream.ReadLine());
                }
            }
            using (StreamReader stream = new StreamReader(path2, true))
            {
                while (stream.Peek() >= 0)
                {
                    ResaultP.Add(stream.ReadLine());
                }
            }
           //sort();
            _foreach(ResaultN, Color.Purple);
            X += 150;
            Y = 0;
            _foreach(ResaultP, Color.Gold);
            //for (int i = 0; i < ResaultN.Count - 1; i++)
            //{
            //    for (int j = 0; j < ResaultP.Count - 1; j++)
            //    {
            //        if (panel1.Controls[i].Tag == panel1.Controls[j].Tag)
            //        {

            //        }
            //    }
            //}
            Random r = new Random();
            lblMainText.ForeColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            t.Interval = 10;
            t.Tick += T_Tick;
            t.Start();
        }
        void sort()
        {
            for (int i = 0; i <= ResaultP.Count - 2; i++)
            {
                for (int j = i + 1; j <= ResaultP.Count - 1; j++)
                {
                    if (Convert.ToInt32(ResaultP[i]) > Convert.ToInt32(ResaultP[j]))
                    {
                        int a = Convert.ToInt32(ResaultP[i]);
                        int b = Convert.ToInt32(ResaultP[j]);
                        a = Convert.ToInt32(ResaultP[j]);
                        b = a;
                    }
                }
            }
        }

        private void T_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            S++;
            if (lblMainText.Location.X < panel2.Width) i++;
            else i = 0;
            lblMainText.Location = new Point(i,0);
            if (S == 50)
            {
                lblMainText.ForeColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
                S = 0;
            }
            //if (S == 1)
            //{
            //    this.BackColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            //    S = 0;
            //}
        }
        void _foreach(List<string> b, Color c)
        {
            int picNum = 0;
            foreach (string a in b)
            {
                Label lbl = new Label();
                lbl.Size = new Size(150, 30);
                lbl.Location = new Point(X, Y);
                lbl.Text = a;
                lbl.ForeColor = c;
                lbl.Font = new Font("ArialBlack", 14);
                panel1.Controls.Add(lbl);
                picNum++;
                Y += 32;
            }
        }
    }
}
