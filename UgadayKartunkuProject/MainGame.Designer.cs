namespace UgadayKartunkuProject
{
    partial class MainGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGame));
            this.btnStart = new System.Windows.Forms.Button();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblTries = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.lblWhatIs = new System.Windows.Forms.Label();
            this.btnSure = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMusic = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnIDK = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.picPodskazka = new System.Windows.Forms.PictureBox();
            this.picMute = new System.Windows.Forms.PictureBox();
            this.timerVoprosColor = new System.Windows.Forms.Timer(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPodskazka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMute)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            resources.ApplyResources(this.btnStart, "btnStart");
            this.btnStart.Name = "btnStart";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // lblPoints
            // 
            resources.ApplyResources(this.lblPoints, "lblPoints");
            this.lblPoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblPoints.Name = "lblPoints";
            // 
            // lblTries
            // 
            resources.ApplyResources(this.lblTries, "lblTries");
            this.lblTries.Name = "lblTries";
            // 
            // txtText
            // 
            resources.ApplyResources(this.txtText, "txtText");
            this.txtText.Name = "txtText";
            // 
            // lblWhatIs
            // 
            resources.ApplyResources(this.lblWhatIs, "lblWhatIs");
            this.lblWhatIs.Name = "lblWhatIs";
            // 
            // btnSure
            // 
            resources.ApplyResources(this.btnSure, "btnSure");
            this.btnSure.Name = "btnSure";
            this.btnSure.UseVisualStyleBackColor = true;
            this.btnSure.Click += new System.EventHandler(this.BtnSure_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // lblMusic
            // 
            resources.ApplyResources(this.lblMusic, "lblMusic");
            this.lblMusic.Name = "lblMusic";
            // 
            // btnPlus
            // 
            resources.ApplyResources(this.btnPlus, "btnPlus");
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            resources.ApplyResources(this.btnMinus, "btnMinus");
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // timer
            // 
            this.timer.Interval = 10;
            // 
            // btnNext
            // 
            resources.ApplyResources(this.btnNext, "btnNext");
            this.btnNext.Name = "btnNext";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            resources.ApplyResources(this.btnPrev, "btnPrev");
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnIDK
            // 
            resources.ApplyResources(this.btnIDK, "btnIDK");
            this.btnIDK.Name = "btnIDK";
            this.btnIDK.UseVisualStyleBackColor = true;
            this.btnIDK.Click += new System.EventHandler(this.btnIDK_Click);
            // 
            // btnSkip
            // 
            resources.ApplyResources(this.btnSkip, "btnSkip");
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // picPodskazka
            // 
            this.picPodskazka.Image = global::UgadayKartunkuProject.Properties.Resources.vopros;
            resources.ApplyResources(this.picPodskazka, "picPodskazka");
            this.picPodskazka.Name = "picPodskazka";
            this.picPodskazka.TabStop = false;
            this.picPodskazka.Click += new System.EventHandler(this.picPodskazka_Click);
            // 
            // picMute
            // 
            this.picMute.BackColor = System.Drawing.SystemColors.Control;
            this.picMute.Image = global::UgadayKartunkuProject.Properties.Resources.maxVolume;
            resources.ApplyResources(this.picMute, "picMute");
            this.picMute.Name = "picMute";
            this.picMute.TabStop = false;
            this.picMute.Click += new System.EventHandler(this.picMute_Click);
            // 
            // timerVoprosColor
            // 
            this.timerVoprosColor.Interval = 500;
            this.timerVoprosColor.Tick += new System.EventHandler(this.timerVoprosColor_Tick);
            // 
            // btnStop
            // 
            resources.ApplyResources(this.btnStop, "btnStop");
            this.btnStop.Name = "btnStop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // pnl1
            // 
            this.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.pnl1, "pnl1");
            this.pnl1.Name = "pnl1";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            resources.ApplyResources(this.listBox2, "listBox2");
            this.listBox2.Name = "listBox2";
            // 
            // MainGame
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.picPodskazka);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnIDK);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.picMute);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.lblMusic);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSure);
            this.Controls.Add(this.lblWhatIs);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.lblTries);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.btnStart);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainGame";
            this.Load += new System.EventHandler(this.MainGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPodskazka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblTries;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label lblWhatIs;
        private System.Windows.Forms.Button btnSure;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMusic;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.PictureBox picMute;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnIDK;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.PictureBox picPodskazka;
        private System.Windows.Forms.Timer timerVoprosColor;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.ListBox listBox2;
    }
}

