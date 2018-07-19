using System;						// TextBox
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TextBox
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label Label1;
		private System.Windows.Forms.Button Button3;
		private System.Windows.Forms.TextBox TextBox2;
		private System.Windows.Forms.Button Button2;
		private System.Windows.Forms.Button Button1;
		private System.Windows.Forms.TextBox TextBox1;
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
			this.Label1 = new System.Windows.Forms.Label();
			this.Button3 = new System.Windows.Forms.Button();
			this.TextBox2 = new System.Windows.Forms.TextBox();
			this.Button2 = new System.Windows.Forms.Button();
			this.Button1 = new System.Windows.Forms.Button();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// Label1
			// 
			this.Label1.Location = new System.Drawing.Point(168, 160);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(96, 24);
			this.Label1.TabIndex = 11;
			// 
			// Button3
			// 
			this.Button3.Location = new System.Drawing.Point(112, 160);
			this.Button3.Name = "Button3";
			this.Button3.Size = new System.Drawing.Size(40, 24);
			this.Button3.TabIndex = 10;
			this.Button3.Text = "OK";
			this.Button3.Click += new System.EventHandler(this.OK_Click);
			// 
			// TextBox2
			// 
			this.TextBox2.Location = new System.Drawing.Point(8, 160);
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.PasswordChar = '*';
			this.TextBox2.Size = new System.Drawing.Size(88, 20);
			this.TextBox2.TabIndex = 9;
			this.TextBox2.Text = "";
			// 
			// Button2
			// 
			this.Button2.Location = new System.Drawing.Point(176, 96);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(64, 32);
			this.Button2.TabIndex = 8;
			this.Button2.Text = "Lower";
			this.Button2.Click += new System.EventHandler(this.Lower_Click);
			// 
			// Button1
			// 
			this.Button1.Location = new System.Drawing.Point(96, 96);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(64, 32);
			this.Button1.TabIndex = 7;
			this.Button1.Text = "Upper";
			this.Button1.Click += new System.EventHandler(this.Upper_Click);
			// 
			// TextBox1
			// 
			this.TextBox1.Location = new System.Drawing.Point(8, 8);
			this.TextBox1.Multiline = true;
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.TextBox1.Size = new System.Drawing.Size(320, 80);
			this.TextBox1.TabIndex = 6;
			this.TextBox1.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(336, 189);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.Label1,
																		  this.Button3,
																		  this.TextBox2,
																		  this.Button2,
																		  this.Button1,
																		  this.TextBox1});
			this.Name = "Form1";
			this.Text = "Form1";
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

		private void Upper_Click(object sender, System.EventArgs e)
		{
			TextBox1.Text = TextBox1.Text.ToUpper();
			TextBox1.ReadOnly = true;
		}

		private void Lower_Click(object sender, System.EventArgs e)
		{
			TextBox1.Text = TextBox1.Text.ToLower();
			TextBox1.ReadOnly = false;
		}

		private void OK_Click(object sender, System.EventArgs e)
		{
			Label1.Text = TextBox2.Text;
		}
	}
}

