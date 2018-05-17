using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace res
{
    public partial class Form1 : Form
    {
        string questions;
        string answers;
        public Form1()
        {
            InitializeComponent();
            button1.Focus(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            questions = textBox1.Text;
            textBox1.Hide();
        }

        private void textBox2_DoubleClick(object sender, EventArgs e)
        {
            answers = textBox2.Text;
            textBox2.Hide();
            label1.Text = "Кондауров Антон Сергеевич, для Вас тестирование завершено. " +
                    "Вы ответили на " + questions + " вопрсов. Ваш результат равен:  " + answers + ",00";
        }
    }
}