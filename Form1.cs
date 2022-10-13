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
        static float 계산심도 = 0;
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
            label5.Text = "";
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
            계산심도 = 0;
            label5.Text = "";
        }

        private void Plusbt_Click(object sender, EventArgs e)
        {
            if (계산심도 == 3) return;
            else 계산심도++;
            label1.Text += "+";
            라벨한칸올리기();
        }

        private void Multbt_Click(object sender, EventArgs e)
        {
            if (계산심도 == 3) return;
            else 계산심도++;
            label1.Text += "×";
            라벨한칸올리기();
        }

        private void Minubt_Click(object sender, EventArgs e)
        {
            if (계산심도 == 3) return;
            else 계산심도++;
            label1.Text += "-";
            라벨한칸올리기();
        }

        private void Divibt_Click(object sender, EventArgs e)
        {
            if (계산심도 == 3) return;
            else 계산심도++;
            label1.Text += "÷";
            라벨한칸올리기();
        }

        private void Enterbt_Click(object sender, EventArgs e)
        {
            if (계산심도 == 0) return;
            if (label1.Text.Length < 1) return;
            float 변수1 = 0; float 변수2 = 0;
            float 변수3 = 0; float 변수4 = 0;
            string 연산기호1 = " "; string 연산기호2 = " "; string 연산기호3 = " ";
            if (label4.Text.Length <= 1) { 변수1 = 0; 연산기호1 = "+"; }
            else
            {
                float.TryParse(label4.Text.Substring(0, label4.Text.Length - 1), out 변수1);
                연산기호1 = label4.Text.Substring(label4.Text.Length-2,1);
            }
            if (label3.Text.Length <= 1) { 변수2 = 0; 연산기호2 = "+"; }
            else
            {
                float.TryParse(label3.Text.Substring(0, label3.Text.Length - 1), out 변수2);
                연산기호2 = label4.Text.Substring(label3.Text.Length - 2, 1);
            }
            if (label2.Text.Length <= 1) { 변수3 = 0; 연산기호3 = "+"; }
            else
            {
                float.TryParse(label2.Text.Substring(0, label2.Text.Length - 1), out 변수3);
                연산기호3 = label2.Text.Substring(label2.Text.Length-1, 1);
            }
            float.TryParse(label1.Text, out 변수4);

            변수2 = 연산기능(변수1, 변수2, 연산기호1);
            변수3 = 연산기능(변수2, 변수3, 연산기호2);
            변수4 = 연산기능(변수3, 변수4, 연산기호3);
            
            label4.Text = ""; label3.Text = ""; label2.Text = "";
            label1.Text = 변수4.ToString();
            계산심도 = 0;
            label5.Text = "";
        }
        void 계산심도경고() 
        {
            if (계산심도 == 3) label5.Text = "더 이상 연산을 추가할 수 없습니다.";
            else label5.Text = "";
        }
        private void Plusbt_MouseEnter(object sender, EventArgs e)
        {
            계산심도경고();
        }
        float 연산기능(float x, float y, string op) 
        {
            switch (op)
            {
                case "+":
                    y = x + y;
                    break;
                case "-":
                    y = x - y;
                    break;
                case "×":
                    y = x * y;
                    break;
                case "÷":
                    y = x / y;
                    break;
                case "^" :
                    y = (float)Math.Pow(x, y);
                    break;
                default: break;
            }
            return y;
        }
        private void expobt_Click(object sender, EventArgs e)
        {
            if (계산심도 == 3) return;
            else 계산심도++;
            label1.Text += "^";
            라벨한칸올리기();
        }

        private void rootbt_Click(object sender, EventArgs e)
        {
            label1.Text = Math.Sqrt(double.Parse(label1.Text)).ToString();
        }
    }
}
