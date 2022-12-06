namespace Κουλοχέρης
{
    partial class Form2
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
            this.moxlosdown = new System.Windows.Forms.PictureBox();
            this.board = new System.Windows.Forms.PictureBox();
            this.moxlosup = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.slot14 = new System.Windows.Forms.PictureBox();
            this.slot24 = new System.Windows.Forms.PictureBox();
            this.slot34 = new System.Windows.Forms.PictureBox();
            this.slot44 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.moxlosdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.board)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moxlosup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot44)).BeginInit();
            this.SuspendLayout();
            // 
            // moxlosdown
            // 
            this.moxlosdown.BackColor = System.Drawing.SystemColors.Control;
            this.moxlosdown.Location = new System.Drawing.Point(844, 73);
            this.moxlosdown.Name = "moxlosdown";
            this.moxlosdown.Size = new System.Drawing.Size(49, 241);
            this.moxlosdown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moxlosdown.TabIndex = 9;
            this.moxlosdown.TabStop = false;
            // 
            // board
            // 
            this.board.Location = new System.Drawing.Point(12, 332);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(826, 162);
            this.board.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.board.TabIndex = 5;
            this.board.TabStop = false;
            // 
            // moxlosup
            // 
            this.moxlosup.Location = new System.Drawing.Point(844, 34);
            this.moxlosup.Name = "moxlosup";
            this.moxlosup.Size = new System.Drawing.Size(49, 241);
            this.moxlosup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moxlosup.TabIndex = 4;
            this.moxlosup.TabStop = false;
            this.moxlosup.Click += new System.EventHandler(this.moxlosup_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(197, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "Υπόλοιπο :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Στήλες :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(12, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "Φρούτα : ";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "3",
            "4"});
            this.comboBox1.Location = new System.Drawing.Point(202, 373);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(71, 24);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.Text = "3";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "5",
            "6"});
            this.comboBox2.Location = new System.Drawing.Point(203, 411);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(70, 24);
            this.comboBox2.TabIndex = 15;
            this.comboBox2.Text = "5";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(562, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 141);
            this.button1.TabIndex = 16;
            this.button1.Text = "CONFIRM CHANGES";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Black;
            this.radioButton1.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButton1.Location = new System.Drawing.Point(379, 401);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(43, 21);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.Text = "x1";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Black;
            this.radioButton2.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButton2.Location = new System.Drawing.Point(379, 434);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(43, 21);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.Text = "x2";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.Black;
            this.radioButton3.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButton3.Location = new System.Drawing.Point(379, 461);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(43, 21);
            this.radioButton3.TabIndex = 19;
            this.radioButton3.Text = "x3";
            this.radioButton3.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(374, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 26);
            this.label5.TabIndex = 20;
            this.label5.Text = "BET:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(349, 371);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 21;
            // 
            // slot14
            // 
            this.slot14.Location = new System.Drawing.Point(12, 34);
            this.slot14.Name = "slot14";
            this.slot14.Size = new System.Drawing.Size(202, 280);
            this.slot14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slot14.TabIndex = 0;
            this.slot14.TabStop = false;
            // 
            // slot24
            // 
            this.slot24.Location = new System.Drawing.Point(220, 34);
            this.slot24.Name = "slot24";
            this.slot24.Size = new System.Drawing.Size(202, 280);
            this.slot24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slot24.TabIndex = 1;
            this.slot24.TabStop = false;
            // 
            // slot34
            // 
            this.slot34.Location = new System.Drawing.Point(428, 34);
            this.slot34.Name = "slot34";
            this.slot34.Size = new System.Drawing.Size(202, 280);
            this.slot34.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slot34.TabIndex = 2;
            this.slot34.TabStop = false;
            // 
            // slot44
            // 
            this.slot44.Location = new System.Drawing.Point(636, 34);
            this.slot44.Name = "slot44";
            this.slot44.Size = new System.Drawing.Size(202, 280);
            this.slot44.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slot44.TabIndex = 3;
            this.slot44.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 449);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 44);
            this.button2.TabIndex = 22;
            this.button2.Text = "Rules";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 528);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.moxlosdown);
            this.Controls.Add(this.board);
            this.Controls.Add(this.moxlosup);
            this.Controls.Add(this.slot44);
            this.Controls.Add(this.slot34);
            this.Controls.Add(this.slot24);
            this.Controls.Add(this.slot14);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.moxlosdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.board)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moxlosup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot44)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox moxlosup;
        private System.Windows.Forms.PictureBox board;
        private System.Windows.Forms.PictureBox moxlosdown;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox slot14;
        private System.Windows.Forms.PictureBox slot24;
        private System.Windows.Forms.PictureBox slot34;
        private System.Windows.Forms.PictureBox slot44;
        private System.Windows.Forms.Button button2;
    }
}