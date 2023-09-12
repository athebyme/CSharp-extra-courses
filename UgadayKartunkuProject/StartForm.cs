using System;
using System.Windows.Forms;

namespace UgadayKartunkuProject
{
    public partial class StartForm : Form
    {
        MainGame _Main = new MainGame();
        public StartForm()
        {
            InitializeComponent();
        }
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            foreach (char a in txtName.Text)
            {
                if (a >= 48 && a <= 57)
                {
                    MessageBox.Show("ОШИБКА!", "Вы ввели недопустимые символы !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (txtName.Text == null || txtName.Text == "")
            {
                MessageBox.Show("Введите пожалуйста своё имя", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (clbTheme.CheckedItems.Count == 0)
            {
                MessageBox.Show("Вы не выбрали темы!", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                Check();
            }
        }
        void Check()
        {
            StartForm _Start = new StartForm();
            _Main.playerName = txtName.Text;
            for (int i = 0; i <= clbTheme.CheckedItems.Count - 1; i++)
            {
                _Main.choosenThemes.Add(clbTheme.CheckedItems[i].ToString());
                _Main.choosenThemesIndexes.Add(clbTheme.CheckedIndices[i]);
            }
            this.Hide();
            _Main.ShowDialog();
            _Start.Dispose();
            _Main.Dispose();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //char num = e.KeyChar;
            //if (num>)
            //{
            //    e.Handled = true;
            //    MessageBox.Show("ОШИБКА!", "Вы ввели недопустимые символы !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
