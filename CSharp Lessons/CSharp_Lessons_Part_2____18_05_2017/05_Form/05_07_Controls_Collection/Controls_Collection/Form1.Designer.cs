namespace Controls_Collection
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MY_menuStrip = new System.Windows.Forms.MenuStrip();
            this.mYmenuStripToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MY_menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(105, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(211, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(21, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(463, 173);
            this.label3.TabIndex = 3;
            // 
            // MY_menuStrip
            // 
            this.MY_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mYmenuStripToolStripMenuItem});
            this.MY_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.MY_menuStrip.Name = "MY_menuStrip";
            this.MY_menuStrip.Size = new System.Drawing.Size(496, 24);
            this.MY_menuStrip.TabIndex = 4;
            this.MY_menuStrip.Text = "MY_menuStrip";
            // 
            // mYmenuStripToolStripMenuItem
            // 
            this.mYmenuStripToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.mYmenuStripToolStripMenuItem.Name = "mYmenuStripToolStripMenuItem";
            this.mYmenuStripToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.mYmenuStripToolStripMenuItem.Text = "MY_menuStrip";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 351);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MY_menuStrip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MY_menuStrip.ResumeLayout(false);
            this.MY_menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip MY_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mYmenuStripToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}

