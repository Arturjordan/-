﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox4.Text = "Лаб. раб. №1. Ст. гр. 7А62 Иванов А.А.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            double z = Convert.ToDouble(textBox3.Text);
            double result = Math.Abs(Math.Pow(x, (y / x)) - Math.Pow(Math.Sqrt(y / x), 3)) + (y - x) * ((Math.Cos(y) - (z / (y - x))) / 1 + Math.Pow((y - x), 2));
            textBox4.Text += Environment.NewLine + $"X = {textBox1.Text}"+ Environment.NewLine + $"Y = { textBox2.Text}"+ Environment.NewLine + $"Z = { textBox3.Text}"+ Environment.NewLine + $"Результат W = { result}";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
