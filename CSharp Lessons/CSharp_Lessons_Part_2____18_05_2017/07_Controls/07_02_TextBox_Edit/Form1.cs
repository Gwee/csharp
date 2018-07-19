using System;				// TextBox_Edit
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TextBox_Edit
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox TextBox1;
		private System.Windows.Forms.Button Button_Paste;
		private System.Windows.Forms.Button Button_Undo;
		private System.Windows.Forms.Button Button_Cut;
		private System.Windows.Forms.Button Button_Copy;
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
			this.Button_Paste = new System.Windows.Forms.Button();
			this.Button_Undo = new System.Windows.Forms.Button();
			this.Button_Cut = new System.Windows.Forms.Button();
			this.Button_Copy = new System.Windows.Forms.Button();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// Button_Paste
			// 
			this.Button_Paste.Location = new System.Drawing.Point(100, 220);
			this.Button_Paste.Name = "Button_Paste";
			this.Button_Paste.Size = new System.Drawing.Size(64, 32);
			this.Button_Paste.TabIndex = 9;
			this.Button_Paste.Text = "Paste";
			this.Button_Paste.Click += new System.EventHandler(this.Button_Click);
			// 
			// Button_Undo
			// 
			this.Button_Undo.Location = new System.Drawing.Point(180, 220);
			this.Button_Undo.Name = "Button_Undo";
			this.Button_Undo.Size = new System.Drawing.Size(64, 32);
			this.Button_Undo.TabIndex = 8;
			this.Button_Undo.Text = "Undo";
			this.Button_Undo.Click += new System.EventHandler(this.Button_Click);
			// 
			// Button_Cut
			// 
			this.Button_Cut.Location = new System.Drawing.Point(180, 180);
			this.Button_Cut.Name = "Button_Cut";
			this.Button_Cut.Size = new System.Drawing.Size(64, 32);
			this.Button_Cut.TabIndex = 7;
			this.Button_Cut.Text = "Cut";
			this.Button_Cut.Click += new System.EventHandler(this.Button_Click);
			// 
			// Button_Copy
			// 
			this.Button_Copy.Location = new System.Drawing.Point(100, 180);
			this.Button_Copy.Name = "Button_Copy";
			this.Button_Copy.Size = new System.Drawing.Size(64, 32);
			this.Button_Copy.TabIndex = 6;
			this.Button_Copy.Text = "Copy";
			this.Button_Copy.Click += new System.EventHandler(this.Button_Click);
			// 
			// TextBox1
			// 
			this.TextBox1.Location = new System.Drawing.Point(12, 8);
			this.TextBox1.Multiline = true;
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(320, 160);
			this.TextBox1.TabIndex = 5;
			this.TextBox1.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(344, 261);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.Button_Paste,
																		  this.Button_Undo,
																		  this.Button_Cut,
																		  this.Button_Copy,
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

		private void Button_Click(object sender, System.EventArgs e)
		{
			Button btn = (Button)sender;
			string str = btn.Text;
			switch ( str ) 
			{
				case "Copy" : 
					if (TextBox1.SelectionLength > 0)   
						TextBox1.Copy();
					break;
				case "Cut" : 				
					if (TextBox1.SelectionLength > 0)   
						TextBox1.Cut();
					break;
				case "Paste" : 
					TextBox1.Paste();
					break;
				case "Undo" : 
					TextBox1.Undo();
					break;
			}
		}

	}
}
