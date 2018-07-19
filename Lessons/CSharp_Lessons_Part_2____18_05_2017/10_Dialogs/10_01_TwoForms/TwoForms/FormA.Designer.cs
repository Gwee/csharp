namespace TwoForms
{
    partial class FormA
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
            this.button_To_B_Dialog = new System.Windows.Forms.Button();
            this.button_To_B = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_To_B_Dialog
            // 
            this.button_To_B_Dialog.Location = new System.Drawing.Point(100, 12);
            this.button_To_B_Dialog.Name = "button_To_B_Dialog";
            this.button_To_B_Dialog.Size = new System.Drawing.Size(64, 48);
            this.button_To_B_Dialog.TabIndex = 4;
            this.button_To_B_Dialog.Text = "To B (Dialog)";
            this.button_To_B_Dialog.Click += new System.EventHandler(this.button_To_B_Dialog_Click);
            // 
            // button_To_B
            // 
            this.button_To_B.Location = new System.Drawing.Point(12, 12);
            this.button_To_B.Name = "button_To_B";
            this.button_To_B.Size = new System.Drawing.Size(72, 48);
            this.button_To_B.TabIndex = 3;
            this.button_To_B.Text = "To B";
            this.button_To_B.Click += new System.EventHandler(this.button_To_B_Click);
            // 
            // A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(172, 65);
            this.Controls.Add(this.button_To_B_Dialog);
            this.Controls.Add(this.button_To_B);
            this.Name = "A";
            this.Text = "A";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_To_B_Dialog;
        private System.Windows.Forms.Button button_To_B;
    }
}

