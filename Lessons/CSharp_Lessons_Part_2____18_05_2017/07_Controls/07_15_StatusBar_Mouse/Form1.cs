using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace StatusBar_Mouse
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.StatusBar StatusBar1;
		private System.Windows.Forms.StatusBarPanel StatusBarPanel1;
		private System.Windows.Forms.StatusBarPanel StatusBarPanel2;
		private System.Windows.Forms.StatusBarPanel StatusBarPanel3;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		Icon[] myIcon = new Icon [2];

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
	 
			myIcon[0] = new Icon("../../MY_ICO.ico");
			myIcon[1] = new Icon("../../Syndicate.ico");
			StatusBar1.Panels[0].Icon = myIcon[0];
			StatusBar1.Panels[2].Text = System.DateTime.Today.ToLongDateString();
  
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
			this.StatusBar1 = new System.Windows.Forms.StatusBar();
			this.StatusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
			this.StatusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
			this.StatusBarPanel3 = new System.Windows.Forms.StatusBarPanel();
			((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel3)).BeginInit();
			this.SuspendLayout();
			// 
			// StatusBar1
			// 
			this.StatusBar1.Location = new System.Drawing.Point(0, 213);
			this.StatusBar1.Name = "StatusBar1";
			this.StatusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																						  this.StatusBarPanel1,
																						  this.StatusBarPanel2,
																						  this.StatusBarPanel3});
			this.StatusBar1.ShowPanels = true;
			this.StatusBar1.Size = new System.Drawing.Size(392, 40);
			this.StatusBar1.TabIndex = 1;
			this.StatusBar1.Text = "StatusBar1";
			// 
			// StatusBarPanel1
			// 
			this.StatusBarPanel1.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.Raised;
			this.StatusBarPanel1.ToolTipText = "\"Mouse Status\"";
			this.StatusBarPanel1.Width = 140;
			// 
			// StatusBarPanel2
			// 
			this.StatusBarPanel2.ToolTipText = "\"Mouse Coordinates\"";
			this.StatusBarPanel2.Width = 60;
			// 
			// StatusBarPanel3
			// 
			this.StatusBarPanel3.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
			this.StatusBarPanel3.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.Raised;
			this.StatusBarPanel3.ToolTipText = "\"Current Time\"";
			this.StatusBarPanel3.Width = 176;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(392, 253);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.StatusBar1});
			this.Name = "Form1";
			this.Text = "Form1";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
			((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel3)).EndInit();
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

		private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
				StatusBar1.Panels[0].Text = "Left Button Down";
			if (e.Button == MouseButtons.Right) 
				StatusBar1.Panels[0].Text = "Right Button Down";
			StatusBar1.Panels[0].Icon = myIcon[1];
			StatusBar1.Panels[1].Text = e.X.ToString() + " , " + e.Y.ToString();
		}

		private void Form1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			StatusBar1.Panels[0].Text = " ";
			StatusBar1.Panels[0].Icon = myIcon[0];
			StatusBar1.Panels[1].Text = " ";
		}

		private void Form1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
				StatusBar1.Panels[1].Text = e.X.ToString() + " , " + e.Y.ToString();
  		}
	}
}
