using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace UgadayKartunkuProject

{
    public partial class MainGame : Form
    {
        public int[] ResaultsP = { };
        bool IsMuted = false;

        int points, tagIm = 0, x, y, notCorrectAnswers, howManyPics; public int CountOfGames, X, Y, s, amountOfRandInLIst, indxNow, Current = 1, _rnd, p, v;
        int _Volume, Skip = 0;
        string lie; public string playerName, randRange, musicPlaying;
        Random rnd = new Random();

        int checkforlbl;

        List<int> lst = new List<int>();
        Label lblTag = new Label();
        List<int> openRand = new List<int>();
        public List<string> choosenThemes = new List<string>();
        public List<int> choosenThemesIndexes = new List<int>();
        List<int> convertedIndx = new List<int>();
        List<int> randomChoosenPicsIndx = new List<int>();
        List<int> randomChoosenPicsIndx2 = new List<int>();
        List<string> ABC = new List<string>();
        List<int> Skipped = new List<int>();
        public List<int> allResaultsPoints = new List<int>();
        public List<string> allResaultsNames = new List<string>();

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg,
        IntPtr wParam, IntPtr lParam);

        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;

        bool IsSkipped = false;
        string[] RelaxMusic =
        {
            "game_ost_1","game_ost_2"
        };
        int[] indexesOfRnd =
        {
        //rnd ind(0) - Электроника  
        1, //компьютер
        2, //смартфон
        3, //микрофон
        4, //телевизор
        5, //монитор
        6, //компьютерная мышь
        7,//клавиатура
        8,//наушники
        //rnd ind(1) — Животные
        9,//лиса
        10,//медведь
        11,//волк
        12,//пингвин
        13,//ястреб
        14,//мышь
        15,//слон
        16,//кит
        //rnd ind(2) — Города России
        17,//москва
        18,//санкт-петербург
        19,//Петропавловск-Камчатский
        20,//калининград
        21,//сочи
        22,//симферополь
        23,//краснодар
        24,//екатеринбург
        //rnd ind(3) — Достопримечательности
        25,//пизанская башня
        26,//медный всадник
        27,//эйфелева башня
        28,//кремль
        29,//большой каньон
        30,//ниагарский водопад
        31,//александринская колонна
        32,//большой театр
        //rnd ind(4) — Логотипы компаний
        33,//гугл
        34,//яндекс
        35,//ютуб
        36,//макдональдс
        37,//мерседес
        38,//xiaomi
        39,//kapple  
        40,//starbucs
        //rnd ind(5) — Другое
        41,//лес
        42,//чёрная дыра
        43,//майнкрафт
        44,//гитара
        45,//пианино
        46,//роналду
        47,//сша
        48,//шляпа
        };
        string[] namesOfPics =
        {
            //0
            "компьютер",
            "смартфон",
            "микрофон",
            "телевизор",
            "монитор",
            "компьютерная мышь",
            "клавиатура",
            "наушники",
            //1
            "лиса",
            "медведь",
            "волк",
            "пингвин",
            "ястреб",
            "мышь",
            "слон",
            "кит",
            //2
            "Москва",
            "Санкт-Петербург",
            "Петропавловск-Камчатский",
            "Калининград",
            "Сочи",
            "Симферополь",
            "Краснодар",
            "Екатеринбург",
            //3
            "Пизанская башня",
            "Медный всадник",
            "Эйфелева башня",
            "Кремль",
            "Большой каньон",
            "Ниагарский водопад",
            "Александринская колонна",
            "Большой театр",
            //4
            "Google",
            "Yandex",
            "Youtube",
            "McDonalds",
            "Mercedes",
            "Xiaomi",
            "Apple",
            "Starbucks",
            //5
            "лес",
            "чёрная дыра",
            "майнкрафт",
            "гитара",
            "пианино",
            "роналду",
            "США",
            "шляпа"
        };
        public MainGame()
        {
            InitializeComponent();
        }
        private void MainGame_Load(object sender, EventArgs e)
        {
            btnSure.Visible = false;
            btnSkip.Visible = false;
            btnSkip.Enabled = false;
        }
        private void BtnStart_Click(object sender, EventArgs e)
        {
            this.Text = "Угадай картинку" + " //   Ваше имя:  " + playerName;
            if (choosenThemesIndexes.Contains(4))
            {
                MessageBox.Show("Названия компаний вводяться на английском языке. В противном случае - Вам не засчитает ответ.", "Вы выбрали тему - > Логотипы компаний", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            lblPoints.Text = "Баллы:" + "\r" + points.ToString();
            // BOOL
            //btnSkip.Visible = true;
            btnSure.Visible = true;
            lblWhatIs.Visible = true;
            txtText.Visible = true;
            btnStart.Enabled = false;
            btnSure.Enabled = true;
            pnl1.AutoScroll = true;
            btnIDK.Visible = true;
            //    COLOR
            //lstTries.ForeColor = Color.BlueViolet;
            btnSure.BackColor = Color.White;
            btnStart.BackColor = Color.Gray;
            //    INT
            x = 0; y = 0; points = 50; howManyPics++; X = 0;Y = 0 ;
            indxNow = 0;
            //    METHODS
            randomChoosenPicsIndx2.Clear();
            //gameost1.Play();
            closeImage();
            checkTheRand();
            object ob = (Bitmap)Properties.Resources.ResourceManager.GetObject(listBox2.Items[indxNow].ToString());
            panel1.BackgroundImage = (Bitmap)ob;
            lblPoints.Text = "Баллы:" + "\r" + points.ToString();
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            _Volume += 2;
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                (IntPtr)APPCOMMAND_VOLUME_UP);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            _Volume -= 2;
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
            (IntPtr)APPCOMMAND_VOLUME_DOWN);
        }
        private void btnIDK_Click(object sender, EventArgs e)
        {
            if (points > 10)
            {
                panel1.Controls.Clear();
                points -= 10;
                lblPoints.Text = "Баллы:" + "\r" + points.ToString();
                MessageBox.Show("Правильный ответ : " + namesOfPics[Convert.ToInt32(listBox2.Items[indxNow]) - 1] + "\r" + "Следующая картинка");
                nextPic();
            }
            else if (points <= 10)
            {

                points = 0;
                lblPoints.Text = "Баллы:" + "\r" + points.ToString();
                _Reset("Вы проиграли!");
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
        }

        private void picPodskazka_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Подсказка стоит 3 балла", "Подсказка", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (points > 4)
                {
                    points -= 3;
                    lblPoints.Text = "Баллы:" + "\r" + points.ToString();
                    _rand();
                    p = 0;
                    lie = null;
                    for (int i = 0; i < namesOfPics[Convert.ToInt32(listBox2.Items[indxNow]) - 1].Trim().Length; i++)
                    {
                        if (i == openRand[p])
                        {
                            if (p == openRand.Count - 2)
                            {
                                p = openRand.Count - 3;
                            }
                            else
                            {
                                if(p== openRand.Count - 1)
                                {
                                    p = openRand.Count - 2;
                                }
                            }
                            lie += namesOfPics[Convert.ToInt32(listBox2.Items[indxNow]) - 1].Trim()[i];
                            p++;
                        }
                        else
                        {
                            lie += "*";
                        }
                    }
                    MessageBox.Show(lie, "Подсказка :");
                }
                else
                {
                    MessageBox.Show("У Вас недостаточно баллов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnSkip_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы сможете вернуться к ней позже.", "Вы пропустили картинку", MessageBoxButtons.OK, MessageBoxIcon.Information);
            nextPic();
            Skipped.Add(Convert.ToInt32(listBox2.Items[indxNow]) - 1);
        }

        private void timerVoprosColor_Tick(object sender, EventArgs e)
        {
            if (v == 0)
            {
                picPodskazka.BackColor = Color.White;
                v = 1;
            }
            else
            {
                picPodskazka.BackColor = Color.Yellow;
                v = 0;
            }


        }
        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (Current == 1)
            {
                Current = 2;
                SoundPlayer Music = new SoundPlayer(Properties.Resources.game_ost_2);
                Music.Play();
            }
            else if (Current == 2)
            {
                Current = 1;
                SoundPlayer Music = new SoundPlayer(Properties.Resources.game_ost_1);
                Music.Play();
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Current == 2)
            {
                Current = 1;
                SoundPlayer Music = new SoundPlayer(Properties.Resources.game_ost_1);
                Music.Play();
            }
            else if (Current == 1)
            {
                Current = 2;
                SoundPlayer Music = new SoundPlayer(Properties.Resources.game_ost_2);
                Music.Play();
            }
        }

        private void BtnSure_Click(object sender, EventArgs e)
        {
            if (txtText.Text.Trim().ToLower() == "" || txtText.Text == null)
            {
                Lie();
            }
            else if (txtText.Text.Trim().ToLower() != namesOfPics[Convert.ToInt32(listBox2.Items[indxNow]) - 1].ToLower().Trim())
            {
                Lie();
            }
            else if (txtText.Text.Trim().ToLower() == namesOfPics[Convert.ToInt32(listBox2.Items[indxNow]) - 1].ToLower().Trim())
            {
                this.BackColor = Color.Green;
                panel1.Controls.Clear();
                MessageBox.Show("Правильно!");
                lblCreate(Color.Green);
                this.BackColor = Color.White;
                points += 5;
                txtText.Text = null;
                lblPoints.Text = "Баллы:" + "\r" + points.ToString();
                nextPic();
            }
            if (notCorrectAnswers == 15)
            {
                panel1.Controls.Clear();
                MessageBox.Show("Правильный ответ : " + namesOfPics[Convert.ToInt32(listBox2.Items[indxNow]) - 1] + "\r" + "Следующая картинка");
                nextPic();
            }
            if (notCorrectAnswers == 3)
            {
                picPodskazka.Visible = true;
                timerVoprosColor.Enabled = true;
            }
        }

        private void picMute_Click(object sender, EventArgs e)
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
            (IntPtr)APPCOMMAND_VOLUME_MUTE);
            IsMuted = !IsMuted;
            if (IsMuted == false)
            {
                picMute.Image = Properties.Resources.maxVolume;
            }
            else
            {
                picMute.Image = Properties.Resources.mute;
            }
        }

        void Lie()
        {
            lblCreate(Color.Red);
            if (points == 0)
            {
                _Reset("Вы проиграли!");
            }
            else
            {
                points--;
                this.BackColor = Color.Red;
                panel1.Controls.RemoveAt(rnd.Next(panel1.Controls.Count));
                notCorrectAnswers++;
                MessageBox.Show("Неправильно!");
                this.BackColor = Color.White;
                txtText.Text = null;
                lblPoints.Text = "Баллы:" + "\r" + points.ToString();
            }
        }
        void nextPic()
        {
            lie = null;
            notCorrectAnswers = 0; howManyPics++;
            if (howManyPics != randomChoosenPicsIndx2.Count)
            {
                closeImage();
                switchIm();
            }
            else
            {
                MessageBox.Show("Конец!" + "\r Ваш счет:" + points);
                _Reset("Вы победили!");
            }


            //КОД ДЛЯ КНОПКИ ПРОПУСКА
            

            //else
            //{
            //    IsSkipped = true;
            //    closeImage();
            //    switchIm();
            //}
            //if(Skipped.Count == 0)
            //{
            //    if(howManyPics!= randomChoosenPicsIndx2.Count)
            //    {
            //        closeImage();
            //        switchIm();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Конец!" + "\r Ваш счет:" + points);
            //        _Reset("Вы победили!");
            //    }
            //}
            //else
            //{
            //    if(howManyPics == randomChoosenPicsIndx2.Count)
            //    {
            //        howManyPics -= Skipped.Count - 1;
            //    }
            //}
            timerVoprosColor.Enabled = false;
            picPodskazka.Visible = false;
        }
        void switchIm()
        {
            object ob;
            if (IsSkipped == false)
            {
                indxNow++;
                ob = (Bitmap)Properties.Resources.ResourceManager.GetObject(listBox2.Items[indxNow].ToString());
                panel1.BackgroundImage = (Bitmap)ob;
            }
            if (IsSkipped)
            {
                if (Skip != Skipped.Count - 1)
                {
                    ob = (Bitmap)Properties.Resources.ResourceManager.GetObject(Skipped[Skip].ToString());
                    panel1.BackgroundImage = (Bitmap)ob;
                    howManyPics++;
                    Skip++;
                }
                else
                {
                    IsSkipped = false;
                    MessageBox.Show("Конец!" + "\r Ваш счет:" + points);
                    _Reset("Вы победили!");
                }
            }
        }
        void closeImage()
        {
            panel1.Controls.Clear();
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    PictureBox picClose = new PictureBox();
                    picClose.Image = (Bitmap)Properties.Resources.close;
                    picClose.Location = new Point(x, y);
                    picClose.Size = new Size(100, 100);
                    picClose.SizeMode = PictureBoxSizeMode.StretchImage;
                    picClose.Tag = tagIm + 1;
                    panel1.Controls.Add(picClose);
                    x += 100;
                }
                x = 0;
                y += 100;
            }
            x = 0; y = 0;
            panel1.Controls.RemoveAt(rnd.Next(panel1.Controls.Count - 1));
        }
        void addToFileRes()
        {
            string path = @"resaultsN.txt";
            string path2 = @"resaultsP.txt";
            using (StreamWriter stream = new StreamWriter(path, true))
                stream.WriteLine(playerName);
            using (StreamWriter stream = new StreamWriter(path2, true))
                stream.WriteLine(points);
        }
        void _Reset(string what)
        {
            allResaultsNames.Add(playerName);
            allResaultsPoints.Add(points);
            if (MessageBox.Show("Сыграть еще ?", what, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                addToFileRes();
                Application.Restart();
            }
            else
            {
                addToFileRes();
                MainGame main = new MainGame();
                Itogi itogiFRM = new Itogi();
                this.Hide();
                itogiFRM.ShowDialog();
                main.Dispose();
                itogiFRM.Dispose();
            }

        }
        void _rand()
        {
            openRand.Clear();
            int nameLength = namesOfPics[Convert.ToInt32(listBox2.Items[indxNow]) - 1].ToLower().Trim().Length;
            if (nameLength <= 4)
            {
                for (int i = 1; i <= 1; i++)
                {
                    ForRndLetter();
                }
            }
            else if (nameLength <= 6 && nameLength > 4)
            {
                for (int i = 1; i <= 3; i++)
                {
                    ForRndLetter();
                }
            }
            else if (nameLength > 6 && nameLength <= 8)
            {
                for (int i = 1; i <= 4; i++)
                {
                    ForRndLetter();
                }
            }
            else if (nameLength > 8 && nameLength <= 10)
            {
                for (int i = 1; i <= 5; i++)
                {
                    ForRndLetter();
                }
            }
            else
            {
                for (int i = 1; i <= 7; i++)
                {
                    ForRndLetter();
                }
            }
            for (int i = 0; i <= openRand.Count - 2; i++)
            {
                for (int j = i + 1; j <= openRand.Count - 1; j++)
                {
                    if (openRand[i] > openRand[j])
                    {
                        int a = openRand[i];
                        openRand[i] = openRand[j];
                        openRand[j] = a;
                    }
                }
            }
        }
        void ForRndLetter()
        {
            int a = namesOfPics[Convert.ToInt32(listBox2.Items[indxNow]) - 1].ToLower().Trim().Length - 1;
            _rnd = rnd.Next(0, a);
            while (openRand.Contains(_rnd))
            {
                _rnd = rnd.Next(a);
            }
            openRand.Add(_rnd);
        }
        void lblCreate(Color _color)
        {
            checkforlbl++;
            Label lbl = new Label();
            lbl.Size = new Size(150, 30);
            lbl.Location = new Point(X, Y);
            lbl.ForeColor = _color;
            //lbl.BackColor = Color.Black;
            if (txtText.Text.Trim() == "")
            {               lbl.Text = "Вы ничего не ввели";
            }
            else
            {
                lbl.Text = txtText.Text.Trim();
            }
            if (lbl.Text.Length > 12)
            {
                lbl.Font = new Font("Tobota", 9, FontStyle.Bold);
            }
            else
            {
                lbl.Font = new Font("Tobota", 14, FontStyle.Bold);
            }
            pnl1.Controls.Add(lbl);
           // groupBox1.Controls.Add(lbl);
            //textBox1.Text += checkforlbl.ToString()+"   номер   " +"\r "+ X.ToString() + "  X \r" + Y.ToString() + "   Y    \r      СЛЕД   \r\n";
            Y += 35;
            if (checkforlbl > 15)
            {
                Chekau();
            }
        }
        void Chekau()
        {
                //MessageBox.Show(X.ToString() + "   X \r" + Y.ToString() + "   Y");
        }
        void checkTheRand()
        {

            for (int i = 0; i <= choosenThemesIndexes.Count - 1; i++)
            {
                convertedIndx.Add((choosenThemesIndexes[i] + 1) * 8);
            }
            randomChoosenPicsIndx.Clear();
            randomChoosenPicsIndx2.Clear();
            amountOfRandInLIst = 0;

            s = rnd.Next(convertedIndx[0] - 7, convertedIndx[0]);
            randomChoosenPicsIndx2.Add(s);
            amountOfRandInLIst++;
            for (int i = 0; i <= convertedIndx.Count - 1; i++)
            {
                do
                {
                    s = rnd.Next(convertedIndx[i] - 7, convertedIndx[i] + 1);
                    if (amountOfRandInLIst != 8)
                    {
                        while (randomChoosenPicsIndx2.Contains(s))
                        {
                            s = rnd.Next(convertedIndx[i] - 7, convertedIndx[i] + 1);
                        }
                        randomChoosenPicsIndx2.Add(s);
                        amountOfRandInLIst++;
                    }
                    else
                    {
                        amountOfRandInLIst = 0;
                        break;
                    }
                } while (randomChoosenPicsIndx2.Contains(s));
            }
            for (int i = 0; i < randomChoosenPicsIndx2.Count; i++)
            {
                ABC.Add(randomChoosenPicsIndx2[i].ToString());
            }

            string[] PeremeshivanieRandIndx = (from object item in ABC select item.ToString()).ToArray<string>();

            for(int i = 0;i <= PeremeshivanieRandIndx.Length -1;i++) //(int i = PeremeshivanieRandIndx.Length -1; i > 0; i--)
            {
                int j = rnd.Next(i);
                string a = PeremeshivanieRandIndx[i];
                PeremeshivanieRandIndx[i] = PeremeshivanieRandIndx[j];
                PeremeshivanieRandIndx[j] = a;
            }
            listBox2.DataSource = PeremeshivanieRandIndx;
            int ae = Convert.ToInt32(listBox2.Items[indxNow]);
        }
    }
}
