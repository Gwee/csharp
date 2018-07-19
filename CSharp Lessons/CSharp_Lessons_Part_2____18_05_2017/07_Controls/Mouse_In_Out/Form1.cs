using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Mouse_In_Out
{
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		int myX, myY;

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
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(177)));
			this.label1.Location = new System.Drawing.Point(0, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(248, 48);
			this.label1.TabIndex = 0;
			this.label1.MouseEnter += new System.EventHandler(this.myMouseEnter);
			this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
			this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(248, 273);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label1});
			this.Name = "Form1";
			this.Text = "Form1";
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
			this.MouseEnter += new System.EventHandler(this.myMouseEnter);
			this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
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

		private void myMouseEnter(object sender, System.EventArgs e)
		{
			label1.Text = "IN";
		}

		private void label1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			myX = e.X + label1.Location.X;
			myY = e.Y + label1.Location.Y;
			//			label1.Text = myX.ToString() + "  " + myY.ToString();
		}

		private void Form1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			myX = e.X;
			myY = e.Y;
			//			label1.Text = myX.ToString() + "  " + myY.ToString();
		}

		private void Form1_MouseLeave(object sender, System.EventArgs e)
		{
			if ( myX >= label1.Location.X && myX < label1.Location.X + label1.Width
				&& myY >= label1.Location.Y && myY < label1.Location.Y + label1.Height)
				return;
			label1.Text = "OUT";
		}

		private void label1_MouseLeave(object sender, System.EventArgs e)
		{
			if ( myX > 5 && myX < this.Width - 10 
				&& myY > 5 && myY < this.Height - 10 )
				return;
			label1.Text = "OUT";
		}
	}
}
