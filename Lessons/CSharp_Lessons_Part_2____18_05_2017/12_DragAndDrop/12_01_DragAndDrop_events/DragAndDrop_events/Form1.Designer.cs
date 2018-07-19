namespace DragAndDrop_events
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
            this.Label_1 = new System.Windows.Forms.Label();
            this.Label_2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label_1
            // 
            this.Label_1.AllowDrop = true;
            this.Label_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Label_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Label_1.Location = new System.Drawing.Point(34, 9);
            this.Label_1.Name = "Label_1";
            this.Label_1.Size = new System.Drawing.Size(100, 112);
            this.Label_1.TabIndex = 0;
            this.Label_1.Text = "A";
            this.Label_1.DragOver += new System.Windows.Forms.DragEventHandler(this.all_DragOver);
            this.Label_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.Label_1.DragLeave += new System.EventHandler(this.all_DragLeave);
            this.Label_1.DragEnter += new System.Windows.Forms.DragEventHandler(this.all_DragEnter);
            // 
            // Label_2
            // 
            this.Label_2.AllowDrop = true;
            this.Label_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Label_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Label_2.Location = new System.Drawing.Point(202, 9);
            this.Label_2.Name = "Label_2";
            this.Label_2.Size = new System.Drawing.Size(100, 112);
            this.Label_2.TabIndex = 1;
            this.Label_2.Text = "B";
            this.Label_2.DragOver += new System.Windows.Forms.DragEventHandler(this.all_DragOver);
            this.Label_2.DragDrop += new System.Windows.Forms.DragEventHandler(this.label2_DragDrop);
            this.Label_2.DragLeave += new System.EventHandler(this.all_DragLeave);
            this.Label_2.DragEnter += new System.Windows.Forms.DragEventHandler(this.all_DragEnter);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 227);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(282, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 69);
            this.label4.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 379);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Label_2);
            this.Controls.Add(this.Label_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label_1;
        private System.Windows.Forms.Label Label_2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

