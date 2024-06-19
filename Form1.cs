using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WF127
{
    public partial class Form1 : Form
    {
        public string SetText1
        {
            get
            {
                return this.label33.Text;
            }
            set
            {
                label33.Text= value;
            }
        }

        public Form1()
        {
            InitializeComponent();
            InitializeTextBoxHint();

            this.numericUpDown1.Maximum = 2;
            this.numericUpDown1.Minimum = 0;

        }
        private void InitializeTextBoxHint()
        {
            textBox1.Text = "요청사항을 입력하세요";
            textBox1.ForeColor = SystemColors.GrayText; // 연한 색상
        }

        private void button1_Click(object sender, EventArgs e)
        {//날짜,인원
            this.Hide();
            Form2 form2 = new Form2();            
            form2.ShowDialog();
            this.Show();
            label25.Text= form2.SetText1.ToString();
            label27.Text=form2.SetText2.ToString();
            label28.Text=form2.SetText3.ToString() + "명";
            label29.Text=form2.SetText4.ToString() + "명";
        }



        private void button2_Click(object sender, EventArgs e)
        {//객실
            this.Hide();
            Form3 form3 = new Form3();
            string roomvalue = "";
            string pricevalue = "";

            if (form3.ShowDialog() == DialogResult.OK)
            {
                roomvalue = form3.Roomvalue;
                label5.Text=roomvalue.ToString();

                pricevalue = form3.Pricevalue;
                label6.Text=pricevalue.ToString()+"원";

                string numericPart = new string(pricevalue.Where(char.IsDigit).ToArray());

                int num1;
                int num2 = Form2.numberofnight;


                if (int.TryParse(numericPart, out num1))
                {
                    label30.Text=(num1*num2).ToString("N0")+"원";

                }
                else
                {
                    label30.Text="오류";
                }
                this.Show();
            }

        }

        private void 선택ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 인원ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void 날짜ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        public void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {


            UpdateLabel32();

        }

        private void UpdateLabel32()
        {
            label32.Text="0원";
            if (numericUpDown1.Value==0)
                label32.Text="0원";
            else if (numericUpDown1.Value==1)
                label32.Text="45,000원";
            else if (numericUpDown1.Value==2)
                label32.Text="90,000원";
            else if (numericUpDown1.Value==3)
                label32.Text="135,000원";
            else if (numericUpDown1.Value==4)
                label32.Text="180,000원";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            UpdateLabel35();

        }

        private void UpdateLabel35()
        {
            label35.Text="0원";

            if (checkBox1.Checked)
                label35.Text="60,500원";
        }



        private void button3_Click(object sender, EventArgs e)
        {
            if (label25.Text=="-"||label27.Text=="-"||label28.Text=="-"||label29.Text=="-")
            {
                MessageBox.Show("날짜, 인원을 선택해주세요.");
            }
            else if (label5.Text=="-"||label6.Text=="-")
            {
                MessageBox.Show("객실을 선택해주세요.");
            }
            else
            { 
                this.Hide();
                Form4 form4 = new Form4();
                form4.ShowDialog();                
                //this.Close();                
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "요청사항을 입력하세요")
            {
                textBox1.Text = "";
                textBox1.ForeColor = SystemColors.WindowText; // 실제 텍스트 색상
            }
        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        public void button4_Click(object sender, EventArgs e)
        {
            string lb32txt = label32.Text;
            string num1 = new string(lb32txt.Where(char.IsDigit).ToArray());

            string lb35txt = label35.Text;
            string num2 = new string(lb35txt.Where(char.IsDigit).ToArray());

            string lb30txt = label30.Text;
            string num3 = new string(lb30txt.Where(char.IsDigit).ToArray());

            int num32,num35,num30;


            if (int.TryParse(num1, out num32)&&
                int.TryParse(num2,out num35)&&
                int.TryParse(num3, out num30))
            {//옵션전부o
                int result = num32+num35+num30;
                label33.Text= result.ToString("N0")+"원";
            }

            else if(int.TryParse(num1, out num32)&&
                int.TryParse(num3, out num30))
            {//엑스트라베드x
                int result = num32+num30;
                label33.Text= result.ToString("N0")+"원";
            }

            else if(int.TryParse(num2, out num35)&&
                int.TryParse(num3, out num30))
            {//조식x 
                int result = num35+num30;
                label33.Text= result.ToString("N0")+"원";
            }
            else if(int.TryParse(num3,out num30))
            {//옵션x
                int result = num30;
                label33.Text= result.ToString("N0")+"원";
            }
            else
            {
                label33.Text="오류";
            }
        }
    }
}
