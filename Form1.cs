using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 간단한계산기_20162881
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void 라벨한칸올리기()
        {
            label4.Text = label3.Text;
            label3.Text = label2.Text;
            label2.Text = label1.Text;
            label1.Text = "0";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "0";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
        }

        private void 영_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0") label1.Text = "0";
            else label1.Text += "0";
        }

        private void 일_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0") label1.Text = "1";
            else label1.Text += "1";
        }

        private void 이_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0") label1.Text = "2";
            else label1.Text += "2";
        }

        private void 삼_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0") label1.Text = "3";
            else label1.Text += "3";
        }

        private void 사_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0") label1.Text = "4";
            else label1.Text += "4";
        }

        private void 오_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0") label1.Text = "5";
            else label1.Text += "5";
        }

        private void 육_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0") label1.Text = "6";
            else label1.Text += "6";
        }

        private void 칠_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0") label1.Text = "7";
            else label1.Text += "7";
        }

        private void 팔_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0") label1.Text = "8";
            else label1.Text += "8";
        }

        private void 구_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0") label1.Text = "9";
            else label1.Text += "9";
        }

        private void 점_Click(object sender, EventArgs e)
        {
            if (label1.Text.Contains('.')) return;
            else if (label1.Text == "0") label1.Text = "0.";
            else label1.Text += ".";
        }

        private void Delbt_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length == 1) label1.Text = "0";
            else label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);
        }

        private void DelAllbt_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
        }

        private void Plusbt_Click(object sender, EventArgs e)
        {
            label1.Text += "+";
            라벨한칸올리기();
        }

        private void Multbt_Click(object sender, EventArgs e)
        {
            label1.Text += "×";
            라벨한칸올리기();
        }

        private void Minubt_Click(object sender, EventArgs e)
        {
            label1.Text += "-";
            라벨한칸올리기();
        }

        private void Divibt_Click(object sender, EventArgs e)
        {
            label1.Text += "÷";
            라벨한칸올리기();
        }

        private void Enterbt_Click(object sender, EventArgs e)
        {
            //연산
        }
    }
}
