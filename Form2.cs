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
    public partial class Form2 : Form
    {
        public static int numberofnight;

        public string SetText1
        {
            get
            {
                return this.tbStart.Text;
            }
            set
            {
                tbStart.Text= value;
            }
        }

        public string SetText2
        {
            get
            {
                return this.tbEnd.Text;
            }
            set
            {
                tbEnd.Text= value;
            }
        }
        public string SetText3
        {
            get
            {
                return this.numericUpDown1.Text;
            }
            set
            {
                numericUpDown1.Text = value;
            }
        }
        public string SetText4
        {
            get
            {
                return this.numericUpDown2.Text;
            }
            set
            {
                numericUpDown2.Text = value;
            }
        }
        



        public Form2()
        {
            InitializeComponent();

            this.numericUpDown1.Maximum = 2;
            this.numericUpDown2.Maximum=2;
            this.numericUpDown1.Minimum = 1;
            this.numericUpDown2.Minimum=0;
        }

        public void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime startDate = monthCalendar1.SelectionStart;
            DateTime endDate= monthCalendar1.SelectionEnd;
            TimeSpan dateDifference= endDate - startDate;

            tbStart.Text =startDate.ToShortDateString();
            tbEnd.Text = endDate.ToShortDateString();
            numberofnight=dateDifference.Days;
            label8.Text="("+numberofnight.ToString()+"박)";

        }

      

        private void button1_Click(object sender, EventArgs e)
        {

            if (numberofnight<=0)
            {
                MessageBox.Show("최소 1박 이상 예약해야 합니다.");
            }
            else
            {
                this.Close();
            }
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            monthCalendar1.SelectionStart = DateTime.Now;
            monthCalendar1.SelectionEnd = DateTime.Now.AddDays(2);
        }
    }
}
