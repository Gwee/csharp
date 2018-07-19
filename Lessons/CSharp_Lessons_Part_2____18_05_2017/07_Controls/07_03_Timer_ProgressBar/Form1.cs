using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Timer_ProgressBar
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label Label1;
		private System.Windows.Forms.Timer Timer1;
		private System.Windows.Forms.ProgressBar ProgressBar1;
		private System.ComponentModel.IContainer components;

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
			this.components = new System.ComponentModel.Container();
			this.Label1 = new System.Windows.Forms.Label();
			this.Timer1 = new System.Windows.Forms.Timer(this.components);
			this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
			this.SuspendLayout();
			// 
			// Label1
			// 
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(177)));
			this.Label1.Location = new System.Drawing.Point(216, 24);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(64, 32);
			this.Label1.TabIndex = 1;
			// 
			// Timer1
			// 
			this.Timer1.Enabled = true;
			this.Timer1.Interval = 500;
			this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
			// 
			// ProgressBar1
			// 
			this.ProgressBar1.Location = new System.Drawing.Point(0, 96);
			this.ProgressBar1.Name = "ProgressBar1";
			this.ProgressBar1.Size = new System.Drawing.Size(288, 23);
			this.ProgressBar1.Step = 5;
			this.ProgressBar1.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 125);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.ProgressBar1,
																		  this.Label1});
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

		private int t = 0;
		private void Timer1_Tick(object sender, System.EventArgs e)
		{
			t++;
			Label1.Text = t.ToString();
			if (ProgressBar1.Value == ProgressBar1.Maximum )
				ProgressBar1.Value = 0;
			else
				ProgressBar1.PerformStep();
		}
	}
}
