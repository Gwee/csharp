using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TabControl
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TabControl TabControl1;
		private System.Windows.Forms.TabPage TabPage1;
		private System.Windows.Forms.Button Button1;
		private System.Windows.Forms.TextBox TextBox3;
		private System.Windows.Forms.TextBox TextBox2;
		private System.Windows.Forms.TextBox TextBox1;
		private System.Windows.Forms.Label Label3;
		private System.Windows.Forms.Label Label2;
		private System.Windows.Forms.Label Label1;
		private System.Windows.Forms.TabPage TabPage2;
		private System.Windows.Forms.RadioButton RadioButton2;
		private System.Windows.Forms.RadioButton RadioButton1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.TabControl1 = new System.Windows.Forms.TabControl();
			this.TabPage1 = new System.Windows.Forms.TabPage();
			this.Button1 = new System.Windows.Forms.Button();
			this.TextBox3 = new System.Windows.Forms.TextBox();
			this.TextBox2 = new System.Windows.Forms.TextBox();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.TabPage2 = new System.Windows.Forms.TabPage();
			this.RadioButton2 = new System.Windows.Forms.RadioButton();
			this.RadioButton1 = new System.Windows.Forms.RadioButton();
			this.TabControl1.SuspendLayout();
			this.TabPage1.SuspendLayout();
			this.TabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// TabControl1
			// 
			this.TabControl1.Controls.Add(this.TabPage1);
			this.TabControl1.Controls.Add(this.TabPage2);
			this.TabControl1.Location = new System.Drawing.Point(0, 8);
			this.TabControl1.Name = "TabControl1";
			this.TabControl1.SelectedIndex = 0;
			this.TabControl1.Size = new System.Drawing.Size(184, 208);
			this.TabControl1.TabIndex = 1;
			// 
			// TabPage1
			// 
			this.TabPage1.Controls.Add(this.Button1);
			this.TabPage1.Controls.Add(this.TextBox3);
			this.TabPage1.Controls.Add(this.TextBox2);
			this.TabPage1.Controls.Add(this.TextBox1);
			this.TabPage1.Controls.Add(this.Label3);
			this.TabPage1.Controls.Add(this.Label2);
			this.TabPage1.Controls.Add(this.Label1);
			this.TabPage1.Location = new System.Drawing.Point(4, 22);
			this.TabPage1.Name = "TabPage1";
			this.TabPage1.Size = new System.Drawing.Size(176, 182);
			this.TabPage1.TabIndex = 0;
			this.TabPage1.Text = "Statements";
			// 
			// Button1
			// 
			this.Button1.Location = new System.Drawing.Point(80, 128);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(56, 32);
			this.Button1.TabIndex = 6;
			this.Button1.Text = "OK";
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// TextBox3
			// 
			this.TextBox3.Location = new System.Drawing.Point(56, 80);
			this.TextBox3.Name = "TextBox3";
			this.TextBox3.Size = new System.Drawing.Size(80, 20);
			this.TextBox3.TabIndex = 5;
			this.TextBox3.Text = "";
			// 
			// TextBox2
			// 
			this.TextBox2.Location = new System.Drawing.Point(56, 48);
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.Size = new System.Drawing.Size(80, 20);
			this.TextBox2.TabIndex = 4;
			this.TextBox2.Text = "0";
			// 
			// TextBox1
			// 
			this.TextBox1.Location = new System.Drawing.Point(56, 16);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(80, 20);
			this.TextBox1.TabIndex = 3;
			this.TextBox1.Text = "0";
			// 
			// Label3
			// 
			this.Label3.Location = new System.Drawing.Point(8, 80);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(32, 23);
			this.Label3.TabIndex = 2;
			this.Label3.Text = "c";
			// 
			// Label2
			// 
			this.Label2.Location = new System.Drawing.Point(8, 48);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(32, 23);
			this.Label2.TabIndex = 1;
			this.Label2.Text = "b";
			// 
			// Label1
			// 
			this.Label1.Location = new System.Drawing.Point(8, 16);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(32, 23);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "a";
			// 
			// TabPage2
			// 
			this.TabPage2.Controls.Add(this.RadioButton2);
			this.TabPage2.Controls.Add(this.RadioButton1);
			this.TabPage2.Location = new System.Drawing.Point(4, 22);
			this.TabPage2.Name = "TabPage2";
			this.TabPage2.Size = new System.Drawing.Size(176, 182);
			this.TabPage2.TabIndex = 1;
			this.TabPage2.Text = "Action";
			this.TabPage2.Visible = false;
			// 
			// RadioButton2
			// 
			this.RadioButton2.Location = new System.Drawing.Point(80, 64);
			this.RadioButton2.Name = "RadioButton2";
			this.RadioButton2.Size = new System.Drawing.Size(80, 16);
			this.RadioButton2.TabIndex = 1;
			this.RadioButton2.Text = "Minus";
			// 
			// RadioButton1
			// 
			this.RadioButton1.Checked = true;
			this.RadioButton1.Location = new System.Drawing.Point(80, 40);
			this.RadioButton1.Name = "RadioButton1";
			this.RadioButton1.Size = new System.Drawing.Size(88, 16);
			this.RadioButton1.TabIndex = 0;
			this.RadioButton1.TabStop = true;
			this.RadioButton1.Text = "Plus";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(192, 221);
			this.Controls.Add(this.TabControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.TabControl1.ResumeLayout(false);
			this.TabPage1.ResumeLayout(false);
			this.TabPage2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Button1_Click(object sender, System.EventArgs e)
		{
			int a = Int32.Parse(TextBox1.Text);
			int b = Int32.Parse(TextBox2.Text);
			int c;
			if (RadioButton1.Checked)
				c = a + b;
			else
				c = a - b;
			TextBox3.Text = c.ToString();
		}
	}
}
