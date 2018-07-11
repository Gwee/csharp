namespace solution1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.leftTextBox = new System.Windows.Forms.TextBox();
            this.RightTextBox = new System.Windows.Forms.TextBox();
            this.OperatorTextBox = new System.Windows.Forms.TextBox();
            this.resultTestBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.devideButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonPoint = new System.Windows.Forms.Button();
            this.button00 = new System.Windows.Forms.Button();
            this.resultButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // leftTextBox
            // 
            this.leftTextBox.Location = new System.Drawing.Point(27, 32);
            this.leftTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.leftTextBox.Name = "leftTextBox";
            this.leftTextBox.Size = new System.Drawing.Size(136, 26);
            this.leftTextBox.TabIndex = 0;
            this.leftTextBox.Click += new System.EventHandler(this.TextBoxClick);
            // 
            // RightTextBox
            // 
            this.RightTextBox.Location = new System.Drawing.Point(248, 32);
            this.RightTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RightTextBox.Name = "RightTextBox";
            this.RightTextBox.Size = new System.Drawing.Size(144, 26);
            this.RightTextBox.TabIndex = 1;
            this.RightTextBox.Click += new System.EventHandler(this.TextBoxClick);
            // 
            // OperatorTextBox
            // 
            this.OperatorTextBox.Location = new System.Drawing.Point(191, 32);
            this.OperatorTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OperatorTextBox.Name = "OperatorTextBox";
            this.OperatorTextBox.Size = new System.Drawing.Size(34, 26);
            this.OperatorTextBox.TabIndex = 2;
            // 
            // resultTestBox
            // 
            this.resultTestBox.Location = new System.Drawing.Point(32, 84);
            this.resultTestBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resultTestBox.Name = "resultTestBox";
            this.resultTestBox.Size = new System.Drawing.Size(360, 26);
            this.resultTestBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 394);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.DigitClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(123, 394);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.DigitClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(214, 394);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 29);
            this.button3.TabIndex = 6;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.DigitClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(32, 336);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 29);
            this.button4.TabIndex = 7;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.DigitClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(123, 336);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 29);
            this.button5.TabIndex = 8;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.DigitClick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(207, 336);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 31);
            this.button6.TabIndex = 9;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.DigitClick);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(32, 268);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(84, 29);
            this.button7.TabIndex = 10;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.DigitClick);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(123, 268);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(84, 29);
            this.button8.TabIndex = 11;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.DigitClick);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(214, 268);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(84, 29);
            this.button9.TabIndex = 12;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.DigitClick);
            // 
            // devideButton
            // 
            this.devideButton.Location = new System.Drawing.Point(32, 208);
            this.devideButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.devideButton.Name = "devideButton";
            this.devideButton.Size = new System.Drawing.Size(84, 29);
            this.devideButton.TabIndex = 13;
            this.devideButton.Text = "/";
            this.devideButton.UseVisualStyleBackColor = true;
            this.devideButton.Click += new System.EventHandler(this.OperatorClick);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Location = new System.Drawing.Point(123, 208);
            this.multiplyButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(84, 29);
            this.multiplyButton.TabIndex = 14;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.OperatorClick);
            // 
            // minusButton
            // 
            this.minusButton.Location = new System.Drawing.Point(214, 208);
            this.minusButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(78, 29);
            this.minusButton.TabIndex = 15;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.OperatorClick);
            // 
            // plusButton
            // 
            this.plusButton.Location = new System.Drawing.Point(299, 208);
            this.plusButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(69, 29);
            this.plusButton.TabIndex = 16;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.OperatorClick);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(33, 452);
            this.button0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(83, 35);
            this.button0.TabIndex = 17;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.DigitClick);
            // 
            // buttonPoint
            // 
            this.buttonPoint.Location = new System.Drawing.Point(214, 452);
            this.buttonPoint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPoint.Name = "buttonPoint";
            this.buttonPoint.Size = new System.Drawing.Size(84, 35);
            this.buttonPoint.TabIndex = 18;
            this.buttonPoint.Text = ".";
            this.buttonPoint.UseVisualStyleBackColor = true;
            this.buttonPoint.Click += new System.EventHandler(this.DigitClick);
            // 
            // button00
            // 
            this.button00.Location = new System.Drawing.Point(123, 452);
            this.button00.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button00.Name = "button00";
            this.button00.Size = new System.Drawing.Size(84, 34);
            this.button00.TabIndex = 19;
            this.button00.Text = "00";
            this.button00.UseVisualStyleBackColor = true;
            this.button00.Click += new System.EventHandler(this.DigitClick);
            // 
            // resultButton
            // 
            this.resultButton.Location = new System.Drawing.Point(305, 268);
            this.resultButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(54, 219);
            this.resultButton.TabIndex = 20;
            this.resultButton.Text = "=";
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.ResultClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 506);
            this.Controls.Add(this.resultButton);
            this.Controls.Add(this.button00);
            this.Controls.Add(this.buttonPoint);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.devideButton);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultTestBox);
            this.Controls.Add(this.OperatorTextBox);
            this.Controls.Add(this.RightTextBox);
            this.Controls.Add(this.leftTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox leftTextBox;
        private System.Windows.Forms.TextBox RightTextBox;
        private System.Windows.Forms.TextBox OperatorTextBox;
        private System.Windows.Forms.TextBox resultTestBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button devideButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonPoint;
        private System.Windows.Forms.Button button00;
        private System.Windows.Forms.Button resultButton;
    }
}

