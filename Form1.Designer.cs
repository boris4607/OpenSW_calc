
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(231, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "000,000,000,000";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Plusbt
            // 
            this.Plusbt.Location = new System.Drawing.Point(386, 92);
            this.Plusbt.Name = "Plusbt";
            this.Plusbt.Size = new System.Drawing.Size(50, 50);
            this.Plusbt.TabIndex = 1;
            this.Plusbt.Text = "+";
            this.Plusbt.UseVisualStyleBackColor = true;
            this.Plusbt.Click += new System.EventHandler(this.button1_Click);
            // 
            // Minubt
            // 
            this.Minubt.Location = new System.Drawing.Point(442, 92);
            this.Minubt.Name = "Minubt";
            this.Minubt.Size = new System.Drawing.Size(50, 50);
            this.Minubt.TabIndex = 2;
            this.Minubt.Text = "-";
            this.Minubt.UseVisualStyleBackColor = true;
            // 
            // Multbt
            // 
            this.Multbt.Location = new System.Drawing.Point(386, 148);
            this.Multbt.Name = "Multbt";
            this.Multbt.Size = new System.Drawing.Size(50, 50);
            this.Multbt.TabIndex = 3;
            this.Multbt.Text = "×";
            this.Multbt.UseVisualStyleBackColor = true;
            // 
            // Divibt
            // 
            this.Divibt.Location = new System.Drawing.Point(442, 148);
            this.Divibt.Name = "Divibt";
            this.Divibt.Size = new System.Drawing.Size(50, 50);
            this.Divibt.TabIndex = 4;
            this.Divibt.Text = "÷";
            this.Divibt.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 58);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // 영
            // 
            this.영.Location = new System.Drawing.Point(12, 305);
            this.영.Name = "영";
            this.영.Size = new System.Drawing.Size(65, 65);
            this.영.TabIndex = 6;
            this.영.Text = "0";
            this.영.UseVisualStyleBackColor = true;
            // 
            // 일
            // 
            this.일.Location = new System.Drawing.Point(12, 234);
            this.일.Name = "일";
            this.일.Size = new System.Drawing.Size(65, 65);
            this.일.TabIndex = 7;
            this.일.Text = "1";
            this.일.UseVisualStyleBackColor = true;
            // 
            // 이
            // 
            this.이.Location = new System.Drawing.Point(83, 234);
            this.이.Name = "이";
            this.이.Size = new System.Drawing.Size(65, 65);
            this.이.TabIndex = 8;
            this.이.Text = "2";
            this.이.UseVisualStyleBackColor = true;
            // 
            // 삼
            // 
            this.삼.Location = new System.Drawing.Point(154, 234);
            this.삼.Name = "삼";
            this.삼.Size = new System.Drawing.Size(65, 65);
            this.삼.TabIndex = 9;
            this.삼.Text = "3";
            this.삼.UseVisualStyleBackColor = true;
            // 
            // 사
            // 
            this.사.Location = new System.Drawing.Point(12, 163);
            this.사.Name = "사";
            this.사.Size = new System.Drawing.Size(65, 65);
            this.사.TabIndex = 10;
            this.사.Text = "4";
            this.사.UseVisualStyleBackColor = true;
            // 
            // 오
            // 
            this.오.Location = new System.Drawing.Point(83, 163);
            this.오.Name = "오";
            this.오.Size = new System.Drawing.Size(65, 65);
            this.오.TabIndex = 11;
            this.오.Text = "5";
            this.오.UseVisualStyleBackColor = true;
            // 
            // 육
            // 
            this.육.Location = new System.Drawing.Point(154, 163);
            this.육.Name = "육";
            this.육.Size = new System.Drawing.Size(65, 65);
            this.육.TabIndex = 12;
            this.육.Text = "6";
            this.육.UseVisualStyleBackColor = true;
            // 
            // 칠
            // 
            this.칠.Location = new System.Drawing.Point(12, 92);
            this.칠.Name = "칠";
            this.칠.Size = new System.Drawing.Size(65, 65);
            this.칠.TabIndex = 13;
            this.칠.Text = "7";
            this.칠.UseVisualStyleBackColor = true;
            // 
            // 팔
            // 
            this.팔.Location = new System.Drawing.Point(83, 92);
            this.팔.Name = "팔";
            this.팔.Size = new System.Drawing.Size(65, 65);
            this.팔.TabIndex = 14;
            this.팔.Text = "8";
            this.팔.UseVisualStyleBackColor = true;
            // 
            // 구
            // 
            this.구.Location = new System.Drawing.Point(154, 92);
            this.구.Name = "구";
            this.구.Size = new System.Drawing.Size(65, 65);
            this.구.TabIndex = 15;
            this.구.Text = "9";
            this.구.UseVisualStyleBackColor = true;
            // 
            // 점
            // 
            this.점.Location = new System.Drawing.Point(154, 305);
            this.점.Name = "점";
            this.점.Size = new System.Drawing.Size(65, 65);
            this.점.TabIndex = 16;
            this.점.Text = ".";
            this.점.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(504, 554);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

