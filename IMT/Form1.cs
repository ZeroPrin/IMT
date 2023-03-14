using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMT
{
    public partial class Form1 : Form
    {
        bool gender = false;
        public Form1()
        {
            InitializeComponent();
            pictureBox3.Image = Image.FromFile("C:\\Users\\Home\\Documents\\VS 2022\\IMT\\IMT\\Resources\\2f.png");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BorderStyle != BorderStyle.Fixed3D) 
            {
                pictureBox1.BorderStyle = BorderStyle.Fixed3D;
                pictureBox2.BorderStyle = BorderStyle.None;
                gender = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.BorderStyle != BorderStyle.Fixed3D)
            {
                pictureBox2.BorderStyle = BorderStyle.Fixed3D;
                pictureBox1.BorderStyle = BorderStyle.None;
                gender = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int height = Convert.ToInt32(textBox1.Text);
                int weight = Convert.ToInt32(textBox2.Text);

                double imt = weight/Math.Pow(((double)height/100),2);
                label2.Text = "ИМТ = " + Math.Round(imt,1).ToString();

                if (imt < 18.5)
                {
                    trackBar1.Value = 2;
                    if (gender)
                        pictureBox3.Image = Image.FromFile("C:\\Users\\Home\\Documents\\VS 2022\\IMT\\IMT\\Resources\\1m.png");
                    else
                        pictureBox3.Image = Image.FromFile("C:\\Users\\Home\\Documents\\VS 2022\\IMT\\IMT\\Resources\\1f.png");

                }
                else if (imt < 25)
                {
                    trackBar1.Value = 5;
                    if (gender)
                        pictureBox3.Image = Image.FromFile("C:\\Users\\Home\\Documents\\VS 2022\\IMT\\IMT\\Resources\\2m.png");
                    else
                        pictureBox3.Image = Image.FromFile("C:\\Users\\Home\\Documents\\VS 2022\\IMT\\IMT\\Resources\\2f.png");
                }
                else if (imt < 30)
                {
                    trackBar1.Value = 8;
                    if (gender)
                        pictureBox3.Image = Image.FromFile("C:\\Users\\Home\\Documents\\VS 2022\\IMT\\IMT\\Resources\\3m.png");
                    else
                        pictureBox3.Image = Image.FromFile("C:\\Users\\Home\\Documents\\VS 2022\\IMT\\IMT\\Resources\\3f.png");
                }
                else
                {
                    trackBar1.Value = 11;
                    if (gender)
                        pictureBox3.Image = Image.FromFile("C:\\Users\\Home\\Documents\\VS 2022\\IMT\\IMT\\Resources\\4m.png");
                    else
                        pictureBox3.Image = Image.FromFile("C:\\Users\\Home\\Documents\\VS 2022\\IMT\\IMT\\Resources\\4f.png");
                }
            }
            catch 
            {
                MessageBox.Show("Введите правильные данные");
            }
            
            
        }
    }
}
