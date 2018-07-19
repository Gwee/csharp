using System;			// CheckedListBox
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace CheckedListBox
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.CheckedListBox checkedListBox1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
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
			this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// checkedListBox1
			// 
			this.checkedListBox1.Items.AddRange(new object[] {
																 "One",
																 "Two",
																 "Three",
																 "Four",
																 "Five",
																 "Six",
																 "Seven",
																 "Eight",
																 "Nine",
																 "Ten"});
			this.checkedListBox1.Location = new System.Drawing.Point(8, 8);
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new System.Drawing.Size(128, 124);
			this.checkedListBox1.TabIndex = 0;
			this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CheckedListBox1_ItemCheck);
			// 
			// listBox1
			// 
			this.listBox1.Location = new System.Drawing.Point(152, 8);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(120, 121);
			this.listBox1.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(96, 144);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(96, 32);
			this.button1.TabIndex = 2;
			this.button1.Text = "All Checked";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 184);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(248, 40);
			this.label1.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(280, 229);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label1,
																		  this.button1,
																		  this.listBox1,
																		  this.checkedListBox1});
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

		private void CheckedListBox1_ItemCheck(object sender, System.Windows.Forms.ItemCheckEventArgs e)
		{
			string item = 
				checkedListBox1.SelectedItem.ToString();
         	if ( e.NewValue == CheckState.Checked )
				listBox1.Items.Add( item );
			else
				listBox1.Items.Remove( item );
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			label1.Text = "";
			foreach (string i in checkedListBox1.CheckedItems )
			{
				label1.Text += i + " ";
			}
		}
	}
}
