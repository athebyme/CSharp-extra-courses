namespace UgadayKartunkuProject
{
    partial class StartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStartGame = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.clbTheme = new System.Windows.Forms.CheckedListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblChooseThemes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStartGame
            // 
            this.btnStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStartGame.Location = new System.Drawing.Point(21, 71);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(75, 23);
            this.btnStartGame.TabIndex = 0;
            this.btnStartGame.Text = "Начать !";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(18, 6);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(81, 16);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Ваше имя:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(9, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 4;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // clbTheme
            // 
            this.clbTheme.FormattingEnabled = true;
            this.clbTheme.HorizontalScrollbar = true;
            this.clbTheme.Items.AddRange(new object[] {
            "Электроника",
            "Жиовтные",
            "Города России",
            "Достопримечательности",
            "Логотипы компаний",
            "Другое"});
            this.clbTheme.Location = new System.Drawing.Point(127, 23);
            this.clbTheme.Name = "clbTheme";
            this.clbTheme.Size = new System.Drawing.Size(134, 109);
            this.clbTheme.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(21, 100);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblChooseThemes
            // 
            this.lblChooseThemes.AutoSize = true;
            this.lblChooseThemes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChooseThemes.Location = new System.Drawing.Point(133, 6);
            this.lblChooseThemes.Name = "lblChooseThemes";
            this.lblChooseThemes.Size = new System.Drawing.Size(122, 16);
            this.lblChooseThemes.TabIndex = 7;
            this.lblChooseThemes.Text = "Выберите темы";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 135);
            this.Controls.Add(this.lblChooseThemes);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.clbTheme);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnStartGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.CheckedListBox clbTheme;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblChooseThemes;
    }
}