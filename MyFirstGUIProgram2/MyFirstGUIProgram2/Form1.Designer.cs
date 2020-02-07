namespace MyFirstGUIProgram2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.rdbBlack = new System.Windows.Forms.RadioButton();
            this.rdbPink = new System.Windows.Forms.RadioButton();
            this.rdbPurple = new System.Windows.Forms.RadioButton();
            this.rdbOrange = new System.Windows.Forms.RadioButton();
            this.rdbYellow = new System.Windows.Forms.RadioButton();
            this.rdbGreen = new System.Windows.Forms.RadioButton();
            this.rdbBlue = new System.Windows.Forms.RadioButton();
            this.rdbRed = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnGryf = new System.Windows.Forms.Button();
            this.btnHuff = new System.Windows.Forms.Button();
            this.btnSly = new System.Windows.Forms.Button();
            this.btnRave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdb1 = new System.Windows.Forms.RadioButton();
            this.rdb5 = new System.Windows.Forms.RadioButton();
            this.rdb10 = new System.Windows.Forms.RadioButton();
            this.btnWrite = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Write a message";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(412, 258);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn1);
            this.groupBox1.Controls.Add(this.rdbBlack);
            this.groupBox1.Controls.Add(this.rdbPink);
            this.groupBox1.Controls.Add(this.rdbPurple);
            this.groupBox1.Controls.Add(this.rdbOrange);
            this.groupBox1.Controls.Add(this.rdbYellow);
            this.groupBox1.Controls.Add(this.rdbGreen);
            this.groupBox1.Controls.Add(this.rdbBlue);
            this.groupBox1.Controls.Add(this.rdbRed);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 224);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Colors";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(33, 185);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 12;
            this.btn1.Text = "Let\'s Go";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // rdbBlack
            // 
            this.rdbBlack.AutoSize = true;
            this.rdbBlack.Location = new System.Drawing.Point(228, 152);
            this.rdbBlack.Name = "rdbBlack";
            this.rdbBlack.Size = new System.Drawing.Size(52, 17);
            this.rdbBlack.TabIndex = 11;
            this.rdbBlack.TabStop = true;
            this.rdbBlack.Text = "Black";
            this.rdbBlack.UseVisualStyleBackColor = true;
            // 
            // rdbPink
            // 
            this.rdbPink.AutoSize = true;
            this.rdbPink.Location = new System.Drawing.Point(228, 115);
            this.rdbPink.Name = "rdbPink";
            this.rdbPink.Size = new System.Drawing.Size(46, 17);
            this.rdbPink.TabIndex = 10;
            this.rdbPink.TabStop = true;
            this.rdbPink.Text = "Pink";
            this.rdbPink.UseVisualStyleBackColor = true;
            // 
            // rdbPurple
            // 
            this.rdbPurple.AutoSize = true;
            this.rdbPurple.Location = new System.Drawing.Point(228, 77);
            this.rdbPurple.Name = "rdbPurple";
            this.rdbPurple.Size = new System.Drawing.Size(55, 17);
            this.rdbPurple.TabIndex = 9;
            this.rdbPurple.TabStop = true;
            this.rdbPurple.Text = "Purple";
            this.rdbPurple.UseVisualStyleBackColor = true;
            // 
            // rdbOrange
            // 
            this.rdbOrange.AutoSize = true;
            this.rdbOrange.Location = new System.Drawing.Point(228, 39);
            this.rdbOrange.Name = "rdbOrange";
            this.rdbOrange.Size = new System.Drawing.Size(60, 17);
            this.rdbOrange.TabIndex = 8;
            this.rdbOrange.TabStop = true;
            this.rdbOrange.Text = "Orange";
            this.rdbOrange.UseVisualStyleBackColor = true;
            // 
            // rdbYellow
            // 
            this.rdbYellow.AutoSize = true;
            this.rdbYellow.Location = new System.Drawing.Point(33, 152);
            this.rdbYellow.Name = "rdbYellow";
            this.rdbYellow.Size = new System.Drawing.Size(56, 17);
            this.rdbYellow.TabIndex = 7;
            this.rdbYellow.TabStop = true;
            this.rdbYellow.Text = "Yellow";
            this.rdbYellow.UseVisualStyleBackColor = true;
            // 
            // rdbGreen
            // 
            this.rdbGreen.AutoSize = true;
            this.rdbGreen.Location = new System.Drawing.Point(33, 115);
            this.rdbGreen.Name = "rdbGreen";
            this.rdbGreen.Size = new System.Drawing.Size(54, 17);
            this.rdbGreen.TabIndex = 6;
            this.rdbGreen.TabStop = true;
            this.rdbGreen.Text = "Green";
            this.rdbGreen.UseVisualStyleBackColor = true;
            // 
            // rdbBlue
            // 
            this.rdbBlue.AutoSize = true;
            this.rdbBlue.Location = new System.Drawing.Point(33, 77);
            this.rdbBlue.Name = "rdbBlue";
            this.rdbBlue.Size = new System.Drawing.Size(46, 17);
            this.rdbBlue.TabIndex = 5;
            this.rdbBlue.TabStop = true;
            this.rdbBlue.Text = "Blue";
            this.rdbBlue.UseVisualStyleBackColor = true;
            // 
            // rdbRed
            // 
            this.rdbRed.AutoSize = true;
            this.rdbRed.Location = new System.Drawing.Point(33, 39);
            this.rdbRed.Name = "rdbRed";
            this.rdbRed.Size = new System.Drawing.Size(45, 17);
            this.rdbRed.TabIndex = 4;
            this.rdbRed.TabStop = true;
            this.rdbRed.Text = "Red";
            this.rdbRed.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(412, 23);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(376, 203);
            this.textBox2.TabIndex = 3;
            // 
            // btnGryf
            // 
            this.btnGryf.Location = new System.Drawing.Point(6, 19);
            this.btnGryf.Name = "btnGryf";
            this.btnGryf.Size = new System.Drawing.Size(133, 30);
            this.btnGryf.TabIndex = 4;
            this.btnGryf.Text = "Choice 1";
            this.btnGryf.UseVisualStyleBackColor = true;
            this.btnGryf.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnHuff
            // 
            this.btnHuff.Location = new System.Drawing.Point(6, 64);
            this.btnHuff.Name = "btnHuff";
            this.btnHuff.Size = new System.Drawing.Size(133, 30);
            this.btnHuff.TabIndex = 5;
            this.btnHuff.Text = "Choice 3";
            this.btnHuff.UseVisualStyleBackColor = true;
            this.btnHuff.Click += new System.EventHandler(this.btnHuff_Click);
            // 
            // btnSly
            // 
            this.btnSly.Location = new System.Drawing.Point(191, 19);
            this.btnSly.Name = "btnSly";
            this.btnSly.Size = new System.Drawing.Size(133, 30);
            this.btnSly.TabIndex = 6;
            this.btnSly.Text = "Choice 2";
            this.btnSly.UseVisualStyleBackColor = true;
            this.btnSly.Click += new System.EventHandler(this.btnSly_Click);
            // 
            // btnRave
            // 
            this.btnRave.Location = new System.Drawing.Point(191, 64);
            this.btnRave.Name = "btnRave";
            this.btnRave.Size = new System.Drawing.Size(133, 30);
            this.btnRave.TabIndex = 7;
            this.btnRave.Text = "Choice 4";
            this.btnRave.UseVisualStyleBackColor = true;
            this.btnRave.Click += new System.EventHandler(this.btnRave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(713, 343);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGryf);
            this.groupBox2.Controls.Add(this.btnSly);
            this.groupBox2.Controls.Add(this.btnHuff);
            this.groupBox2.Controls.Add(this.btnRave);
            this.groupBox2.Location = new System.Drawing.Point(12, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 100);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "House Placement";
            // 
            // rdb1
            // 
            this.rdb1.AutoSize = true;
            this.rdb1.Location = new System.Drawing.Point(410, 290);
            this.rdb1.Name = "rdb1";
            this.rdb1.Size = new System.Drawing.Size(57, 17);
            this.rdb1.TabIndex = 8;
            this.rdb1.TabStop = true;
            this.rdb1.Text = "1 Time";
            this.rdb1.UseVisualStyleBackColor = true;
            // 
            // rdb5
            // 
            this.rdb5.AutoSize = true;
            this.rdb5.Location = new System.Drawing.Point(501, 290);
            this.rdb5.Name = "rdb5";
            this.rdb5.Size = new System.Drawing.Size(62, 17);
            this.rdb5.TabIndex = 9;
            this.rdb5.TabStop = true;
            this.rdb5.Text = "5 Times";
            this.rdb5.UseVisualStyleBackColor = true;
            // 
            // rdb10
            // 
            this.rdb10.AutoSize = true;
            this.rdb10.Location = new System.Drawing.Point(592, 290);
            this.rdb10.Name = "rdb10";
            this.rdb10.Size = new System.Drawing.Size(68, 17);
            this.rdb10.TabIndex = 10;
            this.rdb10.TabStop = true;
            this.rdb10.Text = "10 Times";
            this.rdb10.UseVisualStyleBackColor = true;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(611, 343);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 13;
            this.btnWrite.Text = "Write Away!";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 378);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.rdb10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.rdb5);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.rdb1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Second Attempt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbBlack;
        private System.Windows.Forms.RadioButton rdbPink;
        private System.Windows.Forms.RadioButton rdbPurple;
        private System.Windows.Forms.RadioButton rdbOrange;
        private System.Windows.Forms.RadioButton rdbYellow;
        private System.Windows.Forms.RadioButton rdbGreen;
        private System.Windows.Forms.RadioButton rdbBlue;
        private System.Windows.Forms.RadioButton rdbRed;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnGryf;
        private System.Windows.Forms.Button btnHuff;
        private System.Windows.Forms.Button btnSly;
        private System.Windows.Forms.Button btnRave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdb1;
        private System.Windows.Forms.RadioButton rdb5;
        private System.Windows.Forms.RadioButton rdb10;
        private System.Windows.Forms.Button btnWrite;
    }
}

