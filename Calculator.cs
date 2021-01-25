﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void HelloLabel_Click(object sender, EventArgs e)
        {

            int number1 = 1;
            int number2 = 2;

            int sum = number1 + number2;

            HelloLabel.Text = sum.ToString();
        }

        private void SumNumbers_Click(object sender, EventArgs e)
        {
            int number1 = 0;
            int number2 = 0;

            if (String.IsNullOrWhiteSpace(Sum1.Text))
            {
                MessageBox.Show("Sum1에 숫자를 입력해주세요");
                return;
            }
            if(int.TryParse(Sum1.Text, out number1) == false)
            {
                MessageBox.Show("Sum1에 문자가 아니라 숫자를 입력해주세요");
                return;
            }

            if (String.IsNullOrWhiteSpace(Sum2.Text))
            {
                MessageBox.Show("Sum2에 숫자를 입력해주세요");
                return;
            }
            if (int.TryParse(Sum2.Text, out number2) == false)
            {
                MessageBox.Show("Sum2에 문자가 아니라 숫자를 입력해주세요");
                return;
            }

            int sum = number1 + number2;
            SumResult.Text = Convert.ToString(sum);

        }

        public int Add(int number1, int number2)
        {
            int sum = number1 + number2;
            return sum;
        }

        public int Sub(int number1, int number2)
        {
            int sub = number1 - number2;
            return sub;
        }
        
    }
}
