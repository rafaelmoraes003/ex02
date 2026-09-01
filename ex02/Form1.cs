using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex02
{
    public partial class Form1 : Form
    {

        int c = 0;

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            String image;

            if(c % 2 == 0)
            {
                pictureBox1.BackgroundImage = Image.FromFile("cara.jpg");
                image = "cara";

            }
            else
            {
                pictureBox1.BackgroundImage = Image.FromFile("coroa.jpg");
                image = "coroa";

            }

            c += 1;

            Random random = new Random();


            if(c < 101)
            {
                timer1.Interval += random.Next(10);
            } else
            {
                timer1.Interval += random.Next(400, 501);
            }




            if (timer1.Interval >= 1500)
            {
                timer1.Stop();

                bool isCara = radioButton1.Checked;
                bool isCoroa = radioButton2.Checked;

                bool success = (image == "cara" && isCara) || (image == "coroa" && isCoroa);

                MessageBox.Show(success ? "você ganhou" : "você perdeu");

                c = 0;
                timer1.Interval = 1;
                return;

            }
        }
    }
}
