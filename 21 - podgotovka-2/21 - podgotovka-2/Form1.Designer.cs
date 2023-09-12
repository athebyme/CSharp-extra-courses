namespace _21___podgotovka_2
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
            this.components = new System.ComponentModel.Container();
            this.btnList = new System.Windows.Forms.Button();
            this.lblList = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.btnCombo = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lstToys = new System.Windows.Forms.ListBox();
            this.btnToy = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtToy = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnl1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(12, 12);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(95, 46);
            this.btnList.TabIndex = 0;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(135, 29);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(19, 13);
            this.lblList.TabIndex = 1;
            this.lblList.Text = "list";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 64);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 51);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // cmb1
            // 
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Location = new System.Drawing.Point(379, 21);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(121, 21);
            this.cmb1.TabIndex = 4;
            // 
            // btnCombo
            // 
            this.btnCombo.Location = new System.Drawing.Point(543, 21);
            this.btnCombo.Name = "btnCombo";
            this.btnCombo.Size = new System.Drawing.Size(75, 37);
            this.btnCombo.TabIndex = 5;
            this.btnCombo.Text = "Add to the CMB";
            this.btnCombo.UseVisualStyleBackColor = true;
            this.btnCombo.Click += new System.EventHandler(this.BtnCombo_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(543, 64);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 38);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // lstToys
            // 
            this.lstToys.FormattingEnabled = true;
            this.lstToys.Items.AddRange(new object[] {
            "car",
            "che",
            "lod",
            "pir",
            "tel"});
            this.lstToys.Location = new System.Drawing.Point(21, 147);
            this.lstToys.Name = "lstToys";
            this.lstToys.Size = new System.Drawing.Size(75, 121);
            this.lstToys.TabIndex = 7;
            this.lstToys.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LstToys_MouseDoubleClick);
            // 
            // btnToy
            // 
            this.btnToy.Location = new System.Drawing.Point(112, 194);
            this.btnToy.Name = "btnToy";
            this.btnToy.Size = new System.Drawing.Size(75, 23);
            this.btnToy.TabIndex = 8;
            this.btnToy.Text = "Toy";
            this.btnToy.UseVisualStyleBackColor = true;
            this.btnToy.Click += new System.EventHandler(this.BtnToy_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(242, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // txtToy
            // 
            this.txtToy.Location = new System.Drawing.Point(102, 156);
            this.txtToy.Name = "txtToy";
            this.txtToy.Size = new System.Drawing.Size(102, 20);
            this.txtToy.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // pnl1
            // 
            this.pnl1.Location = new System.Drawing.Point(451, 155);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(286, 254);
            this.pnl1.TabIndex = 11;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(112, 223);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.txtToy);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnToy);
            this.Controls.Add(this.lstToys);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnCombo);
            this.Controls.Add(this.cmb1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.btnList);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmb1;
        private System.Windows.Forms.Button btnCombo;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ListBox lstToys;
        private System.Windows.Forms.Button btnToy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtToy;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Button btnClear;
    }
}

