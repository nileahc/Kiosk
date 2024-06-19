using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WF127
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            InitializeTextBoxHint();
        }
        //객실,날짜,인원,요금 연동 못함



        private void InitializeTextBoxHint()
        {
            textBox1.Text = "이름을 입력하세요";
            textBox1.ForeColor = SystemColors.GrayText; // 연한 색상

            textBox2.Text = "example@google.com";
            textBox2.ForeColor = SystemColors.GrayText;

            textBox3.Text = "연락처를 입력하세요";
            textBox3.ForeColor = SystemColors.GrayText;

            textBox4.Text = "0000-0000-0000-0000";
            textBox4.ForeColor = SystemColors.GrayText;

            textBox5.Text = "MM/YY";
            textBox5.ForeColor = SystemColors.GrayText;

            textBox6.Text= "CVC번호 뒤 3자리";
            textBox6.ForeColor = SystemColors.GrayText;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "이름을 입력하세요")
            {
                textBox1.Text = "";
                textBox1.ForeColor = SystemColors.WindowText; // 실제 텍스트 색상
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {


        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "example@google.com")
            {
                textBox2.Text = "";
                textBox2.ForeColor = SystemColors.WindowText;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "연락처를 입력하세요")
            {
                textBox3.Text = "";
                textBox3.ForeColor = SystemColors.WindowText;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "0000-0000-0000-0000")
            {
                textBox4.Text = "";
                textBox4.ForeColor = SystemColors.WindowText;
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "MM/YY")
            {
                textBox5.Text = "";
                textBox5.ForeColor = SystemColors.WindowText;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text)||string.IsNullOrEmpty(textBox2.Text)||string.IsNullOrEmpty(textBox3.Text)||string.IsNullOrEmpty(textBox4.Text)||string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("필수 항목 중 빈 값이 있습니다.");
            }
            else if (radioButton1.Checked==false&&radioButton2.Checked==false)
            {
                MessageBox.Show("방문수단을 선택해주세요.");
            }
            else if (comboBox1.SelectedItem==null)
            {
                MessageBox.Show("카드 종류를 선택해주세요.");
            }

            else if (checkBox1.Checked==false||checkBox2.Checked==false||checkBox3.Checked==false)
            {
                MessageBox.Show("동의 여부를 확인해주세요.");
            }


            else
            {

                DialogResult result = MessageBox.Show("결제하시겠습니까?", "결제", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("결제가 완료되었습니다.");
                    this.Close();
                    Form1 form1 = new Form1();
                    form1.Show();
                }
                else if (result == DialogResult.No)
                {
                    // "아니요"를 선택한 경우에 수행할 작업
                }
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "CVC번호 뒤 3자리")
            {
                textBox6.Text = "";
                textBox6.ForeColor = SystemColors.WindowText;
            }
        }
    }
}
