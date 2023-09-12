namespace _13_Domino
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstDate = new System.Windows.Forms.ListBox();
            this.lstRand = new System.Windows.Forms.ListBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnRand = new System.Windows.Forms.Button();
            this.btnDate = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(10, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 128);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSalmon;
            this.panel2.Controls.Add(this.btnDate);
            this.panel2.Controls.Add(this.btnRand);
            this.panel2.Controls.Add(this.lstDate);
            this.panel2.Controls.Add(this.lstRand);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.txt6);
            this.panel2.Controls.Add(this.txt5);
            this.panel2.Controls.Add(this.txt4);
            this.panel2.Controls.Add(this.txt3);
            this.panel2.Controls.Add(this.lbl2);
            this.panel2.Controls.Add(this.lbl1);
            this.panel2.Controls.Add(this.lbl6);
            this.panel2.Controls.Add(this.lbl4);
            this.panel2.Controls.Add(this.lbl3);
            this.panel2.Controls.Add(this.lbl5);
            this.panel2.Controls.Add(this.btnCalc);
            this.panel2.Location = new System.Drawing.Point(285, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(449, 400);
            this.panel2.TabIndex = 3;
            // 
            // lstDate
            // 
            this.lstDate.FormattingEnabled = true;
            this.lstDate.Location = new System.Drawing.Point(169, 251);
            this.lstDate.Name = "lstDate";
            this.lstDate.Size = new System.Drawing.Size(263, 147);
            this.lstDate.TabIndex = 17;
            // 
            // lstRand
            // 
            this.lstRand.FormattingEnabled = true;
            this.lstRand.Location = new System.Drawing.Point(6, 251);
            this.lstRand.Name = "lstRand";
            this.lstRand.Size = new System.Drawing.Size(112, 147);
            this.lstRand.TabIndex = 16;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd MMMM yyyy, dddd";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(232, 40);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd MMMM yyyy, dddd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(232, 14);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // txt6
            // 
            this.txt6.Location = new System.Drawing.Point(300, 187);
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(100, 20);
            this.txt6.TabIndex = 13;
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(300, 161);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(100, 20);
            this.txt5.TabIndex = 12;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(300, 136);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(100, 20);
            this.txt4.TabIndex = 11;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(300, 112);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(100, 20);
            this.txt3.TabIndex = 10;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(18, 49);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(72, 13);
            this.lbl2.TabIndex = 9;
            this.lbl2.Text = "Вторая Дата";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(18, 20);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(74, 13);
            this.lbl1.TabIndex = 8;
            this.lbl1.Text = "Первая Дата";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(3, 191);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(105, 13);
            this.lbl6.TabIndex = 7;
            this.lbl6.Text = "Какая дата больше";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(3, 143);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(160, 13);
            this.lbl4.TabIndex = 6;
            this.lbl4.Text = "Прибавить к 1ой дате 30 дней";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(3, 119);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(85, 13);
            this.lbl3.TabIndex = 5;
            this.lbl3.Text = "Разница в днях";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(3, 168);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(162, 13);
            this.lbl5.TabIndex = 5;
            this.lbl5.Text = "Прибавить к 1ой дате 1 месяц";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(3, 75);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(443, 26);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Вычислить";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // btnRand
            // 
            this.btnRand.Location = new System.Drawing.Point(21, 219);
            this.btnRand.Name = "btnRand";
            this.btnRand.Size = new System.Drawing.Size(87, 27);
            this.btnRand.TabIndex = 18;
            this.btnRand.Text = "Rand";
            this.btnRand.UseVisualStyleBackColor = true;
            this.btnRand.Click += new System.EventHandler(this.BtnRand_Click);
            // 
            // btnDate
            // 
            this.btnDate.Location = new System.Drawing.Point(179, 219);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(237, 25);
            this.btnDate.TabIndex = 19;
            this.btnDate.Text = "Date";
            this.btnDate.UseVisualStyleBackColor = true;
            this.btnDate.Click += new System.EventHandler(this.BtnDate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.ListBox lstDate;
        private System.Windows.Forms.ListBox lstRand;
        private System.Windows.Forms.Button btnDate;
        private System.Windows.Forms.Button btnRand;
    }
}

