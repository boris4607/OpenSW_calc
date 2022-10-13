
namespace 간단한계산기_20162881
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Plusbt = new System.Windows.Forms.Button();
            this.Minubt = new System.Windows.Forms.Button();
            this.Multbt = new System.Windows.Forms.Button();
            this.Divibt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.영 = new System.Windows.Forms.Button();
            this.일 = new System.Windows.Forms.Button();
            this.이 = new System.Windows.Forms.Button();
            this.삼 = new System.Windows.Forms.Button();
            this.사 = new System.Windows.Forms.Button();
            this.오 = new System.Windows.Forms.Button();
            this.육 = new System.Windows.Forms.Button();
            this.칠 = new System.Windows.Forms.Button();
            this.팔 = new System.Windows.Forms.Button();
            this.구 = new System.Windows.Forms.Button();
            this.점 = new System.Windows.Forms.Button();
            this.Enterbt = new System.Windows.Forms.Button();
            this.Delbt = new System.Windows.Forms.Button();
            this.DelAllbt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(83, 149);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(257, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "000,000,000,000";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Plusbt
            // 
            this.Plusbt.Location = new System.Drawing.Point(239, 270);
            this.Plusbt.Name = "Plusbt";
            this.Plusbt.Size = new System.Drawing.Size(50, 50);
            this.Plusbt.TabIndex = 1;
            this.Plusbt.Text = "+";
            this.Plusbt.UseVisualStyleBackColor = true;
            this.Plusbt.Click += new System.EventHandler(this.Plusbt_Click);
            // 
            // Minubt
            // 
            this.Minubt.Location = new System.Drawing.Point(239, 326);
            this.Minubt.Name = "Minubt";
            this.Minubt.Size = new System.Drawing.Size(50, 50);
            this.Minubt.TabIndex = 2;
            this.Minubt.Text = "-";
            this.Minubt.UseVisualStyleBackColor = true;
            this.Minubt.Click += new System.EventHandler(this.Minubt_Click);
            // 
            // Multbt
            // 
            this.Multbt.Location = new System.Drawing.Point(295, 270);
            this.Multbt.Name = "Multbt";
            this.Multbt.Size = new System.Drawing.Size(50, 50);
            this.Multbt.TabIndex = 3;
            this.Multbt.Text = "×";
            this.Multbt.UseVisualStyleBackColor = true;
            this.Multbt.Click += new System.EventHandler(this.Multbt_Click);
            // 
            // Divibt
            // 
            this.Divibt.Location = new System.Drawing.Point(295, 326);
            this.Divibt.Name = "Divibt";
            this.Divibt.Size = new System.Drawing.Size(50, 50);
            this.Divibt.TabIndex = 4;
            this.Divibt.Text = "÷";
            this.Divibt.UseVisualStyleBackColor = true;
            this.Divibt.Click += new System.EventHandler(this.Divibt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 187);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // 영
            // 
            this.영.Location = new System.Drawing.Point(12, 427);
            this.영.Name = "영";
            this.영.Size = new System.Drawing.Size(65, 65);
            this.영.TabIndex = 6;
            this.영.Text = "0";
            this.영.UseVisualStyleBackColor = true;
            this.영.Click += new System.EventHandler(this.영_Click);
            // 
            // 일
            // 
            this.일.Location = new System.Drawing.Point(12, 356);
            this.일.Name = "일";
            this.일.Size = new System.Drawing.Size(65, 65);
            this.일.TabIndex = 7;
            this.일.Text = "1";
            this.일.UseVisualStyleBackColor = true;
            this.일.Click += new System.EventHandler(this.일_Click);
            // 
            // 이
            // 
            this.이.Location = new System.Drawing.Point(83, 356);
            this.이.Name = "이";
            this.이.Size = new System.Drawing.Size(65, 65);
            this.이.TabIndex = 8;
            this.이.Text = "2";
            this.이.UseVisualStyleBackColor = true;
            this.이.Click += new System.EventHandler(this.이_Click);
            // 
            // 삼
            // 
            this.삼.Location = new System.Drawing.Point(154, 356);
            this.삼.Name = "삼";
            this.삼.Size = new System.Drawing.Size(65, 65);
            this.삼.TabIndex = 9;
            this.삼.Text = "3";
            this.삼.UseVisualStyleBackColor = true;
            this.삼.Click += new System.EventHandler(this.삼_Click);
            // 
            // 사
            // 
            this.사.Location = new System.Drawing.Point(12, 285);
            this.사.Name = "사";
            this.사.Size = new System.Drawing.Size(65, 65);
            this.사.TabIndex = 10;
            this.사.Text = "4";
            this.사.UseVisualStyleBackColor = true;
            this.사.Click += new System.EventHandler(this.사_Click);
            // 
            // 오
            // 
            this.오.Location = new System.Drawing.Point(83, 285);
            this.오.Name = "오";
            this.오.Size = new System.Drawing.Size(65, 65);
            this.오.TabIndex = 11;
            this.오.Text = "5";
            this.오.UseVisualStyleBackColor = true;
            this.오.Click += new System.EventHandler(this.오_Click);
            // 
            // 육
            // 
            this.육.Location = new System.Drawing.Point(154, 285);
            this.육.Name = "육";
            this.육.Size = new System.Drawing.Size(65, 65);
            this.육.TabIndex = 12;
            this.육.Text = "6";
            this.육.UseVisualStyleBackColor = true;
            this.육.Click += new System.EventHandler(this.육_Click);
            // 
            // 칠
            // 
            this.칠.Location = new System.Drawing.Point(12, 214);
            this.칠.Name = "칠";
            this.칠.Size = new System.Drawing.Size(65, 65);
            this.칠.TabIndex = 13;
            this.칠.Text = "7";
            this.칠.UseVisualStyleBackColor = true;
            this.칠.Click += new System.EventHandler(this.칠_Click);
            // 
            // 팔
            // 
            this.팔.Location = new System.Drawing.Point(83, 214);
            this.팔.Name = "팔";
            this.팔.Size = new System.Drawing.Size(65, 65);
            this.팔.TabIndex = 14;
            this.팔.Text = "8";
            this.팔.UseVisualStyleBackColor = true;
            this.팔.Click += new System.EventHandler(this.팔_Click);
            // 
            // 구
            // 
            this.구.Location = new System.Drawing.Point(154, 214);
            this.구.Name = "구";
            this.구.Size = new System.Drawing.Size(65, 65);
            this.구.TabIndex = 15;
            this.구.Text = "9";
            this.구.UseVisualStyleBackColor = true;
            this.구.Click += new System.EventHandler(this.구_Click);
            // 
            // 점
            // 
            this.점.Location = new System.Drawing.Point(83, 427);
            this.점.Name = "점";
            this.점.Size = new System.Drawing.Size(65, 65);
            this.점.TabIndex = 16;
            this.점.Text = ".";
            this.점.UseVisualStyleBackColor = true;
            this.점.Click += new System.EventHandler(this.점_Click);
            // 
            // Enterbt
            // 
            this.Enterbt.Location = new System.Drawing.Point(154, 427);
            this.Enterbt.Name = "Enterbt";
            this.Enterbt.Size = new System.Drawing.Size(65, 65);
            this.Enterbt.TabIndex = 17;
            this.Enterbt.Text = "Enter";
            this.Enterbt.UseVisualStyleBackColor = true;
            this.Enterbt.Click += new System.EventHandler(this.Enterbt_Click);
            // 
            // Delbt
            // 
            this.Delbt.Location = new System.Drawing.Point(239, 214);
            this.Delbt.Name = "Delbt";
            this.Delbt.Size = new System.Drawing.Size(50, 50);
            this.Delbt.TabIndex = 18;
            this.Delbt.Text = "C";
            this.Delbt.UseVisualStyleBackColor = true;
            this.Delbt.Click += new System.EventHandler(this.Delbt_Click);
            // 
            // DelAllbt
            // 
            this.DelAllbt.Location = new System.Drawing.Point(295, 214);
            this.DelAllbt.Name = "DelAllbt";
            this.DelAllbt.Size = new System.Drawing.Size(50, 50);
            this.DelAllbt.TabIndex = 19;
            this.DelAllbt.Text = "EC";
            this.DelAllbt.UseVisualStyleBackColor = true;
            this.DelAllbt.Click += new System.EventHandler(this.DelAllbt_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(83, 104);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(257, 45);
            this.label2.TabIndex = 20;
            this.label2.Text = "000,000,000,000";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(83, 59);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(257, 45);
            this.label3.TabIndex = 21;
            this.label3.Text = "000,000,000,000";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(83, 14);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(257, 45);
            this.label4.TabIndex = 22;
            this.label4.Text = "000,000,000,000";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 38);
            this.button1.TabIndex = 23;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(356, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DelAllbt);
            this.Controls.Add(this.Delbt);
            this.Controls.Add(this.Enterbt);
            this.Controls.Add(this.점);
            this.Controls.Add(this.구);
            this.Controls.Add(this.팔);
            this.Controls.Add(this.칠);
            this.Controls.Add(this.육);
            this.Controls.Add(this.오);
            this.Controls.Add(this.사);
            this.Controls.Add(this.삼);
            this.Controls.Add(this.이);
            this.Controls.Add(this.일);
            this.Controls.Add(this.영);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Divibt);
            this.Controls.Add(this.Multbt);
            this.Controls.Add(this.Minubt);
            this.Controls.Add(this.Plusbt);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "간단한 계산기";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Plusbt;
        private System.Windows.Forms.Button Minubt;
        private System.Windows.Forms.Button Multbt;
        private System.Windows.Forms.Button Divibt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button 영;
        private System.Windows.Forms.Button 일;
        private System.Windows.Forms.Button 이;
        private System.Windows.Forms.Button 삼;
        private System.Windows.Forms.Button 사;
        private System.Windows.Forms.Button 오;
        private System.Windows.Forms.Button 육;
        private System.Windows.Forms.Button 칠;
        private System.Windows.Forms.Button 팔;
        private System.Windows.Forms.Button 구;
        private System.Windows.Forms.Button 점;
        private System.Windows.Forms.Button Enterbt;
        private System.Windows.Forms.Button Delbt;
        private System.Windows.Forms.Button DelAllbt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

