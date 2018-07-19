using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace RadioButton_CheckButton_Panel_GroupBox
{
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox GroupBox1;
		private System.Windows.Forms.CheckBox CheckBox1;
		private System.Windows.Forms.CheckBox CheckBox2;
		private System.Windows.Forms.Panel Panel1;
		private System.Windows.Forms.RadioButton RadioButton2;
		private System.Windows.Forms.RadioButton RadioButton1;
	
		private System.ComponentModel.Container components = null;

		private bool RB1, RB2, CB1, CB2;

		public Form1()
		{
			 RB1 =  RB2 =  CB1 = CB2 = false;

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
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.CheckBox1 = new System.Windows.Forms.CheckBox();
			this.CheckBox2 = new System.Windows.Forms.CheckBox();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.RadioButton2 = new System.Windows.Forms.RadioButton();
			this.RadioButton1 = new System.Windows.Forms.RadioButton();
			this.GroupBox1.SuspendLayout();
			this.Panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// GroupBox1
			// 
			this.GroupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.CheckBox1,
																					this.CheckBox2});
			this.GroupBox1.Location = new System.Drawing.Point(8, 114);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(136, 78);
			this.GroupBox1.TabIndex = 6;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "CheckButtons";
			// 
			// CheckBox1
			// 
			this.CheckBox1.Location = new System.Drawing.Point(24, 16);
			this.CheckBox1.Name = "CheckBox1";
			this.CheckBox1.Size = new System.Drawing.Size(80, 24);
			this.CheckBox1.TabIndex = 2;
			this.CheckBox1.Text = "Three";
			this.CheckBox1.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
			// 
			// CheckBox2
			// 
			this.CheckBox2.Location = new System.Drawing.Point(24, 48);
			this.CheckBox2.Name = "CheckBox2";
			this.CheckBox2.Size = new System.Drawing.Size(80, 24);
			this.CheckBox2.TabIndex = 3;
			this.CheckBox2.Text = "Foure";
			this.CheckBox2.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
			// 
			// Panel1
			// 
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.RadioButton2,
																				 this.RadioButton1});
			this.Panel1.Location = new System.Drawing.Point(8, 8);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(136, 80);
			this.Panel1.TabIndex = 5;
			// 
			// RadioButton2
			// 
			this.RadioButton2.Location = new System.Drawing.Point(32, 48);
			this.RadioButton2.Name = "RadioButton2";
			this.RadioButton2.Size = new System.Drawing.Size(72, 16);
			this.RadioButton2.TabIndex = 1;
			this.RadioButton2.Text = "Two";
			this.RadioButton2.Click += new System.EventHandler(this.RadioButton_Click);
			// 
			// RadioButton1
			// 
			this.RadioButton1.Location = new System.Drawing.Point(32, 24);
			this.RadioButton1.Name = "RadioButton1";
			this.RadioButton1.Size = new System.Drawing.Size(80, 16);
			this.RadioButton1.TabIndex = 0;
			this.RadioButton1.Text = "One";
			this.RadioButton1.Click += new System.EventHandler(this.RadioButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(152, 197);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.GroupBox1,
																		  this.Panel1});
			this.Name = "Form1";
			this.Text = "Form1";
			this.GroupBox1.ResumeLayout(false);
			this.Panel1.ResumeLayout(false);
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

		private void RadioButton_Click(object sender, System.EventArgs e)
		{
			if ( RB1 == false && RB2 == false )
			{
				if ( Equals(sender, RadioButton1))
					RB1 = ! RB1 ;
				else 
					RB2 = ! RB2;
			}
			else 
			{
				RB1 = ! RB1;
				RB2 = ! RB2;
			}
			Message();
		}

		private void CheckBox_CheckedChanged(object sender, System.EventArgs e)
		{
			if (Equals(sender, CheckBox1)) 
				CB1 = ! CB1;
			if (Equals(sender, CheckBox2)) 
				CB2 = ! CB2;
			Message();
		}

		private void Message()
		{
			string str = "";	
			if ( RB1 ) str += "One ";
			if ( RB2 ) str += "Two ";
			if ( CB1 ) str += "Three ";
			if ( CB2 ) str += "Foure ";
			MessageBox.Show(str + " clicked");
		}
	}
}
