using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace HelpProvider
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.HelpProvider helpProvider1;
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
			this.button1 = new System.Windows.Forms.Button();
			this.helpProvider1 = new System.Windows.Forms.HelpProvider();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.helpProvider1.SetHelpKeyword(this.button1, "");
			this.helpProvider1.SetHelpNavigator(this.button1, System.Windows.Forms.HelpNavigator.Find);
			this.helpProvider1.SetHelpString(this.button1, "");
			this.button1.Location = new System.Drawing.Point(24, 56);
			this.button1.Name = "button1";
			this.helpProvider1.SetShowHelp(this.button1, true);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			// 
			// helpProvider1
			// 
			this.helpProvider1.HelpNamespace = "../../readme.html";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button1});
			this.HelpButton = true;
			this.helpProvider1.SetHelpString(this, "Click me!");
			this.Name = "Form1";
			this.helpProvider1.SetShowHelp(this, true);
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
	}
}