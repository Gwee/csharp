namespace UserControl_and_Form
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
            this.button_ControlToForm = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_FormToControl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_ControlToForm
            // 
            this.button_ControlToForm.Location = new System.Drawing.Point(410, 59);
            this.button_ControlToForm.Name = "button_ControlToForm";
            this.button_ControlToForm.Size = new System.Drawing.Size(104, 53);
            this.button_ControlToForm.TabIndex = 17;
            this.button_ControlToForm.Text = "From CONTROL  To  FORM";
            this.button_ControlToForm.Click += new System.EventHandler(this.button_ControlToForm_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(304, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 20);
            this.textBox1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(304, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 24);
            this.label2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(304, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Put You Name";
            // 
            // button_FormToControl
            // 
            this.button_FormToControl.Location = new System.Drawing.Point(307, 59);
            this.button_FormToControl.Name = "button_FormToControl";
            this.button_FormToControl.Size = new System.Drawing.Size(88, 53);
            this.button_FormToControl.TabIndex = 13;
            this.button_FormToControl.Text = "From FORM  To CONTROL";
            this.button_FormToControl.Click += new System.EventHandler(this.button_FormToControl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 163);
            this.Controls.Add(this.button_ControlToForm);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_FormToControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ControlToForm;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_FormToControl;
    }
}

