using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace train
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        MyTrain train;

        public Form1()
        {
            InitializeComponent();
            graphics = panel1.CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
            if (Convert.ToInt32(textBox1.Text) < 0 || Convert.ToInt32(textBox2.Text) < 0 || Convert.ToInt32(textBox3.Text) <= 0)
            {
                MessageBox.Show("введите положительные значения", "ошибка");
                return;
            }
            MyCircle Circle = new MyCircle(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
            Circle.Draw(graphics);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Refresh();

            if (Convert.ToInt32(textBox4.Text) < 0 || Convert.ToInt32(textBox5.Text) < 0 || Convert.ToInt32(textBox6.Text) <= 0 || Convert.ToInt32(textBox7.Text) <= 0)
            {
                MessageBox.Show("введите положительные значения", "ошибка");

                return;
            }

            MyRectangle Rectangle = new MyRectangle(Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox7.Text));
            Rectangle.Draw(graphics);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Refresh();

            if (Convert.ToInt32(textBox8.Text) < 0 || Convert.ToInt32(textBox9.Text) < 0 || Convert.ToInt32(textBox10.Text) <= 0 || Convert.ToInt32(textBox11.Text) <= 0)
            {
                MessageBox.Show("введите положительные значения", "ошибка");

                return;
            }

            train = new MyTrain(Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox9.Text), Convert.ToInt32(textBox10.Text), Convert.ToInt32(textBox11.Text));
            train.Draw(graphics);
        }

        private void button4_Click(object sender, EventArgs e)
        {
                label15.Text = train.Weight_Count().ToString();
        }
    }
}
