namespace QuackCrypt_DOTNET
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxAES = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.randomize = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.crypt = new System.Windows.Forms.Button();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.rtbAES = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.saveB64 = new System.Windows.Forms.Label();
            this.saveAES = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label11 = new System.Windows.Forms.Label();
            this.delaySelector = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.labelMS = new System.Windows.Forms.Label();
            this.malleableControl1 = new QuackCrypt_DOTNET.MainWindow();
            ((System.ComponentModel.ISupportInitialize)(this.delaySelector)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InfoText;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quack Crypter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InfoText;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(37, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Educational Pwnage Only";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(18, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Select File";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InfoText;
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(15, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select a file...";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(99, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(362, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.InfoText;
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(15, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Output filename >";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox2.Location = new System.Drawing.Point(111, 127);
            this.textBox2.MaxLength = 16;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBoxAES
            // 
            this.textBoxAES.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBoxAES.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAES.ForeColor = System.Drawing.SystemColors.Info;
            this.textBoxAES.Location = new System.Drawing.Point(79, 160);
            this.textBoxAES.MaxLength = 20;
            this.textBoxAES.Name = "textBoxAES";
            this.textBoxAES.ReadOnly = true;
            this.textBoxAES.Size = new System.Drawing.Size(151, 20);
            this.textBoxAES.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.InfoText;
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(15, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "AES Key >";
            // 
            // randomize
            // 
            this.randomize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.randomize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.randomize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.randomize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.randomize.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.randomize.Location = new System.Drawing.Point(236, 160);
            this.randomize.Name = "randomize";
            this.randomize.Size = new System.Drawing.Size(50, 16);
            this.randomize.TabIndex = 9;
            this.randomize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.randomize.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.randomize.UseVisualStyleBackColor = false;
            this.randomize.Click += new System.EventHandler(this.randomizeButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.checkBox1.ForeColor = System.Drawing.Color.Gold;
            this.checkBox1.Location = new System.Drawing.Point(106, 192);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(67, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Disabled";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.InfoText;
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(15, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Delayed Mode >";
            // 
            // crypt
            // 
            this.crypt.Location = new System.Drawing.Point(12, 377);
            this.crypt.Name = "crypt";
            this.crypt.Size = new System.Drawing.Size(138, 61);
            this.crypt.TabIndex = 12;
            this.crypt.Text = "      __\r\n___( o)>\r\n\\ <_. )\r\n `---\'  ";
            this.crypt.UseVisualStyleBackColor = true;
            this.crypt.Click += new System.EventHandler(this.crypt_Click);
            // 
            // rtb
            // 
            this.rtb.BackColor = System.Drawing.SystemColors.Info;
            this.rtb.Location = new System.Drawing.Point(582, 30);
            this.rtb.Name = "rtb";
            this.rtb.ReadOnly = true;
            this.rtb.Size = new System.Drawing.Size(206, 155);
            this.rtb.TabIndex = 14;
            this.rtb.Text = "";
            this.rtb.ZoomFactor = 0.75F;
            // 
            // rtbAES
            // 
            this.rtbAES.BackColor = System.Drawing.SystemColors.Info;
            this.rtbAES.Location = new System.Drawing.Point(582, 210);
            this.rtbAES.Name = "rtbAES";
            this.rtbAES.ReadOnly = true;
            this.rtbAES.Size = new System.Drawing.Size(206, 155);
            this.rtbAES.TabIndex = 15;
            this.rtbAES.Text = "";
            this.rtbAES.ZoomFactor = 0.75F;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.InfoText;
            this.label8.ForeColor = System.Drawing.SystemColors.Info;
            this.label8.Location = new System.Drawing.Point(579, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "File > B64";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.InfoText;
            this.label9.ForeColor = System.Drawing.SystemColors.Info;
            this.label9.Location = new System.Drawing.Point(579, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "B64 > AES";
            // 
            // saveB64
            // 
            this.saveB64.AutoSize = true;
            this.saveB64.BackColor = System.Drawing.SystemColors.InfoText;
            this.saveB64.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveB64.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveB64.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.saveB64.Location = new System.Drawing.Point(729, 14);
            this.saveB64.Name = "saveB64";
            this.saveB64.Size = new System.Drawing.Size(54, 13);
            this.saveB64.TabIndex = 18;
            this.saveB64.Text = "Save B64";
            this.saveB64.Click += new System.EventHandler(this.saveB64_Click);
            // 
            // saveAES
            // 
            this.saveAES.AutoSize = true;
            this.saveAES.BackColor = System.Drawing.SystemColors.InfoText;
            this.saveAES.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveAES.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAES.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.saveAES.Location = new System.Drawing.Point(734, 194);
            this.saveAES.Name = "saveAES";
            this.saveAES.Size = new System.Drawing.Size(56, 13);
            this.saveAES.TabIndex = 19;
            this.saveAES.Text = "Save AES";
            this.saveAES.Click += new System.EventHandler(this.saveAES_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.InfoText;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.ForeColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(12, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Begin Ducking...";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox3.Location = new System.Drawing.Point(604, 399);
            this.textBox3.MaxLength = 16;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(184, 20);
            this.textBox3.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.InfoText;
            this.label10.ForeColor = System.Drawing.SystemColors.Info;
            this.label10.Location = new System.Drawing.Point(530, 401);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Paste URL >";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label11.Enabled = false;
            this.label11.Font = new System.Drawing.Font("Microsoft Yi Baiti", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Location = new System.Drawing.Point(239, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 11);
            this.label11.TabIndex = 22;
            this.label11.Text = "randomize";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // delaySelector
            // 
            this.delaySelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.delaySelector.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.delaySelector.Font = new System.Drawing.Font("Bahnschrift SemiLight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delaySelector.ForeColor = System.Drawing.SystemColors.Info;
            this.delaySelector.Location = new System.Drawing.Point(179, 192);
            this.delaySelector.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.delaySelector.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.delaySelector.Name = "delaySelector";
            this.delaySelector.Size = new System.Drawing.Size(58, 17);
            this.delaySelector.TabIndex = 23;
            this.delaySelector.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.delaySelector.ThousandsSeparator = true;
            this.delaySelector.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.delaySelector.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Black;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(58, 220);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.Text = "select...";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.InfoText;
            this.label12.ForeColor = System.Drawing.SystemColors.Info;
            this.label12.Location = new System.Drawing.Point(15, 223);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Icon >";
            // 
            // labelMS
            // 
            this.labelMS.AutoSize = true;
            this.labelMS.BackColor = System.Drawing.SystemColors.InfoText;
            this.labelMS.ForeColor = System.Drawing.SystemColors.Info;
            this.labelMS.Location = new System.Drawing.Point(238, 195);
            this.labelMS.Name = "labelMS";
            this.labelMS.Size = new System.Drawing.Size(20, 13);
            this.labelMS.TabIndex = 26;
            this.labelMS.Text = "ms";
            this.labelMS.Visible = false;
            // 
            // malleableControl1
            // 
            this.malleableControl1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.malleableControl1.Location = new System.Drawing.Point(778, 355);
            this.malleableControl1.Name = "malleableControl1";
            this.malleableControl1.Size = new System.Drawing.Size(10, 10);
            this.malleableControl1.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuackCrypt_DOTNET.Properties.Resources.How_To_Raise_A_Baby_Duck_scaled_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.malleableControl1);
            this.Controls.Add(this.labelMS);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.delaySelector);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.saveAES);
            this.Controls.Add(this.saveB64);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rtbAES);
            this.Controls.Add(this.rtb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.crypt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.randomize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxAES);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.Text = "Quack Crypter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.delaySelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBoxAES;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button randomize;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button crypt;
        private System.Windows.Forms.RichTextBox rtb;
        private System.Windows.Forms.RichTextBox rtbAES;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label saveB64;
        private System.Windows.Forms.Label saveAES;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown delaySelector;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelMS;
        private MainWindow malleableControl1;
    }
}

