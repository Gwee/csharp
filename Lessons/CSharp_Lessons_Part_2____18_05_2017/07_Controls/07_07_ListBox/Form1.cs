using System;				// ListBox
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ListBox
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label Label5;
		private System.Windows.Forms.Label Label4;
		private System.Windows.Forms.Label Label3;
		private System.Windows.Forms.Label Label2;
		private System.Windows.Forms.Label Label1;
		private System.Windows.Forms.ListBox ListBox1;
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

			string[] arrStr = {"One", "Two", "Three", "Foure", "Five", "Six", "Seven", "Eight", "Nine", "Ten"};
			foreach ( string i in arrStr  )
				ListBox1.Items.Add(i);
			ListBox1.SetSelected(5, true);

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
			this.Label5 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.ListBox1 = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// Label5
			// 
			this.Label5.Location = new System.Drawing.Point(392, 176);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(72, 32);
			this.Label5.TabIndex = 11;
			this.Label5.Text = "Click outside  Controls";
			// 
			// Label4
			// 
			this.Label4.Location = new System.Drawing.Point(392, 64);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(48, 24);
			this.Label4.TabIndex = 10;
			this.Label4.Text = "Label4";
			// 
			// Label3
			// 
			this.Label3.Location = new System.Drawing.Point(392, 8);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(80, 16);
			this.Label3.TabIndex = 9;
			this.Label3.Text = "Label3";
			// 
			// Label2
			// 
			this.Label2.Location = new System.Drawing.Point(320, 64);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(56, 24);
			this.Label2.TabIndex = 8;
			this.Label2.Text = "Index";
			// 
			// Label1
			// 
			this.Label1.Location = new System.Drawing.Point(320, 8);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(56, 16);
			this.Label1.TabIndex = 7;
			this.Label1.Text = "Element";
			// 
			// ListBox1
			// 
			this.ListBox1.Location = new System.Drawing.Point(8, 8);
			this.ListBox1.MultiColumn = true;
			this.ListBox1.Name = "ListBox1";
			this.ListBox1.Size = new System.Drawing.Size(304, 199);
			this.ListBox1.TabIndex = 6;
			this.ListBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(480, 213);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.Label5,
																		  this.Label4,
																		  this.Label3,
																		  this.Label2,
																		  this.Label1,
																		  this.ListBox1});
			this.Name = "Form1";
			this.Text = "Form1";
			this.Click += new System.EventHandler(this.Form1_Click);
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

		private void ListBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			Label3.Text = ListBox1.SelectedItem.ToString();
			Label4.Text = ListBox1.SelectedIndex.ToString();
		}

		private void Form1_Click(object sender, System.EventArgs e)
		{
			ListBox1.BeginUpdate();
			for ( int i = 0; i < 10000; i ++ )
				ListBox1.Items.Add("Line " + i.ToString());
            ListBox1.EndUpdate();
		}
	}
}
