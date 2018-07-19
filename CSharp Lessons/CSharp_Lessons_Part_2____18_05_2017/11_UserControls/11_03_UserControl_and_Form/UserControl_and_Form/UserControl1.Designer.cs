namespace UserControl_and_Form
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserControl_ControlToForm = new System.Windows.Forms.Button();
            this.UserControl_FormToControl = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserControl_ControlToForm
            // 
            this.UserControl_ControlToForm.Location = new System.Drawing.Point(6, 60);
            this.UserControl_ControlToForm.Name = "UserControl_ControlToForm";
            this.UserControl_ControlToForm.Size = new System.Drawing.Size(117, 45);
            this.UserControl_ControlToForm.TabIndex = 20;
            this.UserControl_ControlToForm.Text = "From CONTROL  To  FORM";
            this.UserControl_ControlToForm.Click += new System.EventHandler(this.UserControl_ControlToForm_Click);
            // 
            // UserControl_FormToControl
            // 
            this.UserControl_FormToControl.Location = new System.Drawing.Point(129, 60);
            this.UserControl_FormToControl.Name = "UserControl_FormToControl";
            this.UserControl_FormToControl.Size = new System.Drawing.Size(109, 45);
            this.UserControl_FormToControl.TabIndex = 19;
            this.UserControl_FormToControl.Text = "From  FORM    To CONTROL";
            this.UserControl_FormToControl.Click += new System.EventHandler(this.UserControl_FormToControl_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 20);
            this.textBox1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(9, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 24);
            this.label2.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Put You Name";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.UserControl_ControlToForm);
            this.Controls.Add(this.UserControl_FormToControl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(252, 147);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UserControl_ControlToForm;
        private System.Windows.Forms.Button UserControl_FormToControl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
