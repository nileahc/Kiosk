using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF127
{

    public partial class Form3 : Form
    {
        public string Roomvalue
        {
            get; private set;
        }

        public string Pricevalue
        {
            get; private set;
        }

        //인원에 따른 선택 제한 걸고싶어, 인원 5명일때 선택을 못한다던가 그런거

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {
            Roomvalue =label11.Text;
            Pricevalue = label18.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Roomvalue=label19.Text;
            Pricevalue = label33.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Roomvalue=label1.Text;
            Pricevalue = label6.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Roomvalue=label20.Text;
            Pricevalue = label34.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Roomvalue=label35.Text;
            Pricevalue = label49.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Roomvalue=label36.Text;
            Pricevalue = label50.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
