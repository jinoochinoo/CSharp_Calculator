﻿
namespace WindowsFormsApp1
{
    partial class Calculator
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.HelloLabel = new System.Windows.Forms.Label();
            this.NumButton1 = new System.Windows.Forms.Button();
            this.NumButton2 = new System.Windows.Forms.Button();
            this.NumScreen = new System.Windows.Forms.Label();
            this.NumPlus = new System.Windows.Forms.Button();
            this.NumButton3 = new System.Windows.Forms.Button();
            this.NumButton4 = new System.Windows.Forms.Button();
            this.NumButton6 = new System.Windows.Forms.Button();
            this.NumButton5 = new System.Windows.Forms.Button();
            this.NumButton8 = new System.Windows.Forms.Button();
            this.NumButton7 = new System.Windows.Forms.Button();
            this.NumButton9 = new System.Windows.Forms.Button();
            this.NumButton0 = new System.Windows.Forms.Button();
            this.NumSub = new System.Windows.Forms.Button();
            this.NumClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HelloLabel
            // 
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HelloLabel.Location = new System.Drawing.Point(34, 22);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(0, 15);
            this.HelloLabel.TabIndex = 0;
            // 
            // NumButton1
            // 
            this.NumButton1.Location = new System.Drawing.Point(113, 272);
            this.NumButton1.Name = "NumButton1";
            this.NumButton1.Size = new System.Drawing.Size(75, 61);
            this.NumButton1.TabIndex = 1;
            this.NumButton1.Text = "1";
            this.NumButton1.UseVisualStyleBackColor = true;
            this.NumButton1.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumButton2
            // 
            this.NumButton2.Location = new System.Drawing.Point(211, 272);
            this.NumButton2.Name = "NumButton2";
            this.NumButton2.Size = new System.Drawing.Size(75, 61);
            this.NumButton2.TabIndex = 2;
            this.NumButton2.Text = "2";
            this.NumButton2.UseVisualStyleBackColor = true;
            this.NumButton2.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumScreen
            // 
            this.NumScreen.BackColor = System.Drawing.SystemColors.Info;
            this.NumScreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NumScreen.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NumScreen.Location = new System.Drawing.Point(110, 22);
            this.NumScreen.Name = "NumScreen";
            this.NumScreen.Size = new System.Drawing.Size(604, 57);
            this.NumScreen.TabIndex = 3;
            this.NumScreen.Text = "0";
            this.NumScreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NumPlus
            // 
            this.NumPlus.Location = new System.Drawing.Point(427, 106);
            this.NumPlus.Name = "NumPlus";
            this.NumPlus.Size = new System.Drawing.Size(287, 62);
            this.NumPlus.TabIndex = 4;
            this.NumPlus.Text = "+";
            this.NumPlus.UseVisualStyleBackColor = true;
            this.NumPlus.Click += new System.EventHandler(this.NumPlus_Click);
            // 
            // NumButton3
            // 
            this.NumButton3.Location = new System.Drawing.Point(314, 272);
            this.NumButton3.Name = "NumButton3";
            this.NumButton3.Size = new System.Drawing.Size(75, 62);
            this.NumButton3.TabIndex = 5;
            this.NumButton3.Text = "3";
            this.NumButton3.UseVisualStyleBackColor = true;
            this.NumButton3.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumButton4
            // 
            this.NumButton4.Location = new System.Drawing.Point(113, 190);
            this.NumButton4.Name = "NumButton4";
            this.NumButton4.Size = new System.Drawing.Size(75, 62);
            this.NumButton4.TabIndex = 6;
            this.NumButton4.Text = "4";
            this.NumButton4.UseVisualStyleBackColor = true;
            this.NumButton4.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumButton6
            // 
            this.NumButton6.Location = new System.Drawing.Point(314, 190);
            this.NumButton6.Name = "NumButton6";
            this.NumButton6.Size = new System.Drawing.Size(75, 62);
            this.NumButton6.TabIndex = 7;
            this.NumButton6.Text = "6";
            this.NumButton6.UseVisualStyleBackColor = true;
            this.NumButton6.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumButton5
            // 
            this.NumButton5.Location = new System.Drawing.Point(211, 190);
            this.NumButton5.Name = "NumButton5";
            this.NumButton5.Size = new System.Drawing.Size(75, 62);
            this.NumButton5.TabIndex = 8;
            this.NumButton5.Text = "5";
            this.NumButton5.UseVisualStyleBackColor = true;
            this.NumButton5.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumButton8
            // 
            this.NumButton8.Location = new System.Drawing.Point(211, 105);
            this.NumButton8.Name = "NumButton8";
            this.NumButton8.Size = new System.Drawing.Size(75, 62);
            this.NumButton8.TabIndex = 9;
            this.NumButton8.Text = "8";
            this.NumButton8.UseVisualStyleBackColor = true;
            this.NumButton8.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumButton7
            // 
            this.NumButton7.Location = new System.Drawing.Point(113, 105);
            this.NumButton7.Name = "NumButton7";
            this.NumButton7.Size = new System.Drawing.Size(75, 62);
            this.NumButton7.TabIndex = 10;
            this.NumButton7.Text = "7";
            this.NumButton7.UseVisualStyleBackColor = true;
            this.NumButton7.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumButton9
            // 
            this.NumButton9.Location = new System.Drawing.Point(314, 106);
            this.NumButton9.Name = "NumButton9";
            this.NumButton9.Size = new System.Drawing.Size(75, 62);
            this.NumButton9.TabIndex = 11;
            this.NumButton9.Text = "9";
            this.NumButton9.UseVisualStyleBackColor = true;
            this.NumButton9.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumButton0
            // 
            this.NumButton0.Location = new System.Drawing.Point(211, 352);
            this.NumButton0.Name = "NumButton0";
            this.NumButton0.Size = new System.Drawing.Size(75, 62);
            this.NumButton0.TabIndex = 12;
            this.NumButton0.Text = "0";
            this.NumButton0.UseVisualStyleBackColor = true;
            this.NumButton0.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumSub
            // 
            this.NumSub.Location = new System.Drawing.Point(427, 190);
            this.NumSub.Name = "NumSub";
            this.NumSub.Size = new System.Drawing.Size(287, 62);
            this.NumSub.TabIndex = 13;
            this.NumSub.Text = "-";
            this.NumSub.UseVisualStyleBackColor = true;
            this.NumSub.Click += new System.EventHandler(this.NumPlus_Click);
            // 
            // NumClear
            // 
            this.NumClear.Location = new System.Drawing.Point(113, 352);
            this.NumClear.Name = "NumClear";
            this.NumClear.Size = new System.Drawing.Size(70, 62);
            this.NumClear.TabIndex = 14;
            this.NumClear.Text = "C";
            this.NumClear.UseVisualStyleBackColor = true;
            this.NumClear.Click += new System.EventHandler(this.NumClear_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 62);
            this.button1.TabIndex = 15;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NumPlus_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NumClear);
            this.Controls.Add(this.NumSub);
            this.Controls.Add(this.NumButton0);
            this.Controls.Add(this.NumButton9);
            this.Controls.Add(this.NumButton7);
            this.Controls.Add(this.NumButton8);
            this.Controls.Add(this.NumButton5);
            this.Controls.Add(this.NumButton6);
            this.Controls.Add(this.NumButton4);
            this.Controls.Add(this.NumButton3);
            this.Controls.Add(this.NumPlus);
            this.Controls.Add(this.NumScreen);
            this.Controls.Add(this.NumButton2);
            this.Controls.Add(this.NumButton1);
            this.Controls.Add(this.HelloLabel);
            this.Name = "Calculator";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.NumPlus_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HelloLabel;
        private System.Windows.Forms.Button NumButton1;
        private System.Windows.Forms.Button NumButton2;
        private System.Windows.Forms.Label NumScreen;
        private System.Windows.Forms.Button NumPlus;
        private System.Windows.Forms.Button NumButton3;
        private System.Windows.Forms.Button NumButton4;
        private System.Windows.Forms.Button NumButton6;
        private System.Windows.Forms.Button NumButton5;
        private System.Windows.Forms.Button NumButton8;
        private System.Windows.Forms.Button NumButton7;
        private System.Windows.Forms.Button NumButton9;
        private System.Windows.Forms.Button NumButton0;
        private System.Windows.Forms.Button NumSub;
        private System.Windows.Forms.Button NumClear;
        private System.Windows.Forms.Button button1;
    }
}

