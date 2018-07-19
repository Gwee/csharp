using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace LinkLabel
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label Label1;
		private System.Windows.Forms.LinkLabel LinkLabel1;
		private System.Windows.Forms.LinkLabel LinkLabel2;
		private System.Windows.Forms.LinkLabel LinkLabel3;

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

		LinkLabel3.Links.Add(0, 15, "www.addisonwesley.com");
        LinkLabel3.Links.Add(21, 24, "www.wrox.com");

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
			this.LinkLabel3 = new System.Windows.Forms.LinkLabel();
			this.LinkLabel2 = new System.Windows.Forms.LinkLabel();
			this.Label1 = new System.Windows.Forms.Label();
			this.LinkLabel1 = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// LinkLabel3
			// 
			this.LinkLabel3.ActiveLinkColor = System.Drawing.Color.Red;
			this.LinkLabel3.LinkColor = System.Drawing.Color.Blue;
			this.LinkLabel3.Location = new System.Drawing.Point(8, 88);
			this.LinkLabel3.Name = "LinkLabel3";
			this.LinkLabel3.Size = new System.Drawing.Size(176, 23);
			this.LinkLabel3.TabIndex = 8;
			this.LinkLabel3.TabStop = true;
			this.LinkLabel3.Text = "Addison Wesley   or   WROX";
			this.LinkLabel3.VisitedLinkColor = System.Drawing.Color.Red;
			this.LinkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel3_LinkClicked);
			// 
			// LinkLabel2
			// 
			this.LinkLabel2.ActiveLinkColor = System.Drawing.Color.Red;
			this.LinkLabel2.Location = new System.Drawing.Point(64, 16);
			this.LinkLabel2.Name = "LinkLabel2";
			this.LinkLabel2.Size = new System.Drawing.Size(32, 16);
			this.LinkLabel2.TabIndex = 7;
			this.LinkLabel2.TabStop = true;
			this.LinkLabel2.Text = "Java";
			this.LinkLabel2.VisitedLinkColor = System.Drawing.Color.Red;
			this.LinkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel2_LinkClicked);
			// 
			// Label1
			// 
			this.Label1.Location = new System.Drawing.Point(40, 16);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(16, 23);
			this.Label1.TabIndex = 6;
			this.Label1.Text = "or";
			// 
			// LinkLabel1
			// 
			this.LinkLabel1.ActiveLinkColor = System.Drawing.Color.Red;
			this.LinkLabel1.DisabledLinkColor = System.Drawing.Color.DimGray;
			this.LinkLabel1.LinkColor = System.Drawing.Color.Blue;
			this.LinkLabel1.Location = new System.Drawing.Point(8, 16);
			this.LinkLabel1.Name = "LinkLabel1";
			this.LinkLabel1.Size = new System.Drawing.Size(32, 24);
			this.LinkLabel1.TabIndex = 5;
			this.LinkLabel1.TabStop = true;
			this.LinkLabel1.Text = ".NET";
			this.LinkLabel1.VisitedLinkColor = System.Drawing.Color.Red;
			this.LinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 133);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.LinkLabel3,
																		  this.LinkLabel2,
																		  this.Label1,
																		  this.LinkLabel1});
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

		private void LinkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			LinkLabel1.LinkVisited = true;
			System.Diagnostics.Process.Start("www.microsoft.com");
		}

		private void LinkLabel2_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			LinkLabel2.LinkVisited = true;
			System.Diagnostics.Process.Start("IExplore", "www.sun.com");
 		}

		private void LinkLabel3_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			LinkLabel3.LinkVisited = true;
			System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
 		}
	}
}
