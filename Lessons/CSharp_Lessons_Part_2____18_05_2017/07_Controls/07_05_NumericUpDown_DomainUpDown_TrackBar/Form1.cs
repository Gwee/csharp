using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace NumericUpDown_DomainUpDown
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.DomainUpDown domainUpDown1;
		private System.Windows.Forms.TrackBar trackBar1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

//		double myOpacity = 1.0;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
//			this.Opacity = myOpacity;
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			domainUpDown1.SelectedIndex = 0;
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
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.SuspendLayout();
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Increment = new System.Decimal(new int[] {
																			 2,
																			 0,
																			 0,
																			 0});
			this.numericUpDown1.Location = new System.Drawing.Point(16, 24);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(48, 20);
			this.numericUpDown1.TabIndex = 0;
			this.numericUpDown1.Value = new System.Decimal(new int[] {
																		 100,
																		 0,
																		 0,
																		 0});
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// domainUpDown1
			// 
			this.domainUpDown1.Items.Add("Full 100%");
			this.domainUpDown1.Items.Add("Half 50%");
			this.domainUpDown1.Items.Add("Empry 10%");
			this.domainUpDown1.Location = new System.Drawing.Point(88, 24);
			this.domainUpDown1.Name = "domainUpDown1";
			this.domainUpDown1.Size = new System.Drawing.Size(96, 20);
			this.domainUpDown1.TabIndex = 1;
			this.domainUpDown1.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
			// 
			// trackBar1
			// 
			this.trackBar1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(128)));
			this.trackBar1.Location = new System.Drawing.Point(208, 24);
			this.trackBar1.Maximum = 50;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.trackBar1.Size = new System.Drawing.Size(42, 232);
			this.trackBar1.TabIndex = 2;
			this.trackBar1.Value = 50;
			this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.SystemColors.HotTrack;
			this.ClientSize = new System.Drawing.Size(280, 273);
			this.Controls.Add(this.trackBar1);
			this.Controls.Add(this.domainUpDown1);
			this.Controls.Add(this.numericUpDown1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
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

		private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
		{
			trackBar1.Value = (int)numericUpDown1.Value / 2;
			this.Opacity = (double)numericUpDown1.Value / 100;
		}

		private void domainUpDown1_SelectedItemChanged(object sender, System.EventArgs e)
		{
			switch(domainUpDown1.SelectedIndex)
			{
				case 0:
					trackBar1.Value = trackBar1.Maximum;
					numericUpDown1.Value = trackBar1.Value * 2;
					this.Opacity = 1;
					break;
				case 1:
					trackBar1.Value = trackBar1.Maximum / 2;
					numericUpDown1.Value = trackBar1.Value * 2;
					this.Opacity = 0.5;
					break;
				case 2:
					trackBar1.Value = trackBar1.Maximum / 10;
					numericUpDown1.Value = trackBar1.Value * 2;
					this.Opacity = 0.1;
					break;
			}
		}

		private void trackBar1_Scroll(object sender, System.EventArgs e)
		{
			numericUpDown1.Value = trackBar1.Value * 2;
			this.Opacity = (double)numericUpDown1.Value / 100;
		}
	}
}
