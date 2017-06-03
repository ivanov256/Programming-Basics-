﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BGNtoEURConvertor
{
    public partial class FormConvert : Form
    {
        public FormConvert()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Convert();
        }

        private void numericUpDownAmount_ValueChanged(object sender, EventArgs e)
        {
            Convert();
        }

        private void numericUpDownAmount_KeyUp(object sender, KeyEventArgs e)
        {
            Convert();
        }
        private void Convert()
        {
            decimal amountBGN = this.numericUpDownAmount.Value;
            decimal amountEUR = amountBGN / 1.95583m;
            this.labelResult.Text =
                amountBGN + " BGN" + " = " + Math.Round(amountEUR, 2) + " EUR";

        }
    }
}
